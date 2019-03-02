using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Feature.KeyPhraseExtraction.Models;
using DoctaCore.Feature.KeyPhraseExtraction.Shell.Framework.Commands;
using DoctaCore.Foundation.KeyPhrases;
using DoctaCore.Foundation.KeyPhrases.Models;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.ContentSearch.Security;
using Sitecore.Data.Items;

namespace DoctaCore.Feature.KeyPhraseExtraction
{
    public class RequestDocumentTypeConverter : ITypeConverter<IEnumerable<Item>, RequestDocumentCollection>
    {
        public RequestDocumentCollection Convert(IEnumerable<Item> obj)
        {
            var results = new RequestDocumentCollection();
            foreach (var item in obj)
            {
                var indexable = new SitecoreIndexableItem(item);
                using (var searchContext = ContentSearchManager.GetIndex(indexable)
                        .CreateSearchContext(SearchSecurityOptions.DisableSecurityCheck))
                {
                    var searchResult = searchContext.GetQueryable<ExtendedSearchResultItem>()
                        .Where(x => x.ItemId == item.ID && x.Language == item.Language.Name && x.LatestVersion).GetResults().FirstOrDefault();
                    if (searchResult != null && searchResult.Document != null && !string.IsNullOrWhiteSpace(searchResult.Document.Content))
                    {
                        var document = new RequestDocument();
                        document.Text = searchResult.Document.Content;
                        document.ItemId = item.ID.Guid;
                        document.Language = item.Language.Name;

                        results.Add(document);
                    }
                }
            }

            return results;
        }
    }
}