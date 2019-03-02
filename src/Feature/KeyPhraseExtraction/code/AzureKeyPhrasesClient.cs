using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using DoctaCore.Feature.KeyPhraseExtraction.Pipelines.HandleKeyPhrasesResponse;
using DoctaCore.Feature.KeyPhraseExtraction.Shell.Framework.Commands;
using DoctaCore.Foundation.KeyPhrases;
using Newtonsoft.Json;
using Sitecore.Diagnostics;

namespace DoctaCore.Feature.KeyPhraseExtraction
{
    public class AzureKeyPhrasesClient : IRequestKeyPhrases
    {
        public async Task<string> GetResponse(string data)
        {
            Log.Info(data, "Axure Sending");

            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "bb1e672daac7491091c4aabf272d2ab8");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var uri = "https://westus.api.cognitive.microsoft.com/text/analytics/v2.0/keyPhrases?" + queryString;

            var byteData = Encoding.UTF8.GetBytes(data);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(uri, content);
                var resultString = await response.Content.ReadAsStringAsync();

                return resultString;
            }
        }
    }
}