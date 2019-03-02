

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.ContentSearch.Security;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.SecurityModel;
using Sitecore.Shell.Framework.Commands;
using Sitecore.StringExtensions;

namespace DoctaCore.Feature.KeyPhraseExtraction.Shell.Framework.Commands
{
    /// <summary>
    /// Ribbon command that send the indexed content for the current item to ML
    /// and saves the returned key phrases in Key Phrases field
    /// </summary>
    public class GetKeyPhrases : Command
    {
        public override void Execute(CommandContext context)
        {
            Sitecore.Context.ClientPage.ClientResponse.Alert("Testing my button");
            var contextItem = context.Items.FirstOrDefault();

            var inputDocumentList = new InputDocumentsList
            {
                Documents = new List<InputDocument>()
            };

            var inputDocumentsList = CreateInputDocumentList(contextItem, inputDocumentList);

            Task<HttpResponseMessage> task =
                Task.Run<HttpResponseMessage>(async () => await ExecuteRequest(inputDocumentsList));
        }

        private InputDocumentsList CreateInputDocumentList(Item contextItem, InputDocumentsList inputDocumentsList)
        {
            foreach (Item contextItemChild in contextItem.Children)
            {
                if (contextItemChild.HasChildren)
                {
                    CreateInputDocumentList(contextItemChild, inputDocumentsList);
                }
                else
                {
                    inputDocumentsList = AddItemToDocumentList(contextItemChild, inputDocumentsList);
                    return inputDocumentsList;
                }
            }

            inputDocumentsList = AddItemToDocumentList(contextItem, inputDocumentsList);
            return inputDocumentsList;
        }

        private InputDocumentsList AddItemToDocumentList(Item contextItem, InputDocumentsList inputDocumentsList)
        {
            using (IProviderSearchContext searchContext = ContentSearchManager.GetIndex("sitecore_master_index")
                .CreateSearchContext(SearchSecurityOptions.DisableSecurityCheck))
            {
                var resultItem = searchContext.GetQueryable<SearchResultItem>()
                    .Where(x => x.ItemId == contextItem.ID).GetResults();

                if (resultItem.Hits.Any())
                {
                    var text = resultItem.Hits.First().Document.Content;
                    if (!text.IsNullOrEmpty())
                    {
                        inputDocumentsList.Documents.Add(new InputDocument
                        {
                            Language = contextItem.Language.Name,
                            Id = contextItem.ID.ToShortID().ToString(),
                            Text = text
                        });
                        return inputDocumentsList;
                    }
                }
            }

            return inputDocumentsList;
        }

        static async Task<HttpResponseMessage> ExecuteRequest(InputDocumentsList inputDocumetsList)
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "bb1e672daac7491091c4aabf272d2ab8");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var uri = "https://westus.api.cognitive.microsoft.com/text/analytics/v2.0/keyPhrases?" + queryString;

            HttpResponseMessage response;
            //var sample = new {documents= new []{new {language = "en", id = "1", text = "Hello world. This is some input text that I love."}}};

            // Request body
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            byte[] byteData = Encoding.UTF8.GetBytes(serializer.Serialize(inputDocumetsList));

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);

                var keyPhrasesStream = response.Content.ReadAsStringAsync();
                var keyPhrasesJson = JsonConvert.DeserializeObject<DocumentList>(keyPhrasesStream.Result);
                Log.Info(keyPhrasesStream.Result, keyPhrasesStream);
                UpdateItemsWithKeyPhrases(keyPhrasesJson);
                return response;
            }
        }

        private static void UpdateItemsWithKeyPhrases(DocumentList documentList)
        {
            if (documentList != null && documentList.Documents.Any())
            {
                foreach (var documentListDocument in documentList.Documents)
                {
                    Sitecore.Data.Database masterDB = Sitecore.Configuration.Factory.GetDatabase("master");
                    Sitecore.Data.Items.Item item = masterDB.GetItem(new ID(documentListDocument.Id));
                    using (new SecurityDisabler())
                    {
                        using (new EditContext(item))
                        {
                            item["Key Phrases"] = string.Join(",",documentListDocument.KeyPhrases);
                        }
                    }
                }
            }
        }
    }

    public class InputDocumentsList
    {
        public List<InputDocument> Documents { get; set; }
    }

    public class InputDocument
    {
        public string Language { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
    }

    [Serializable]
    public class DocumentList
    {
        public List<Document> Documents { get; set; }
        public List<string> Error { get; set; }
    }

    [Serializable]
    public class Document
    {
        public string Id { get; set; }
        public List<string> KeyPhrases { get; set; }
    }
}