using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Foundation.KeyPhrases.Models;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.ContentSearch.Security;
using Sitecore.Data.Items;

namespace DoctaCore.Foundation.KeyPhrases
{
    /// <summary>
    /// Default implementation of IItemRetriever that uses the content search API to retrieve descendants of the start node.
    /// </summary>
    public class DefaultItemRetriever : IItemRetriever
    {
        public IEnumerable<Item> GetItems(Item startItem)
        {
            // If a null start item is used, simply return an empty list
            if (startItem == null)
            {
                return new List<Item>();
            }

            var items = new List<Item> {startItem};
            var indexable = new SitecoreIndexableItem(startItem);
            using (var searchContext = ContentSearchManager.GetIndex(indexable)
                .CreateSearchContext(SearchSecurityOptions.DisableSecurityCheck))
            {
                // Filter the search by the start item language and only return results that are the latest version.
                var results = searchContext.GetQueryable<ExtendedSearchResultItem>()
                    .Where(x => x.Paths.Contains(startItem.ID) && x.Language == startItem.Language.Name && x.LatestVersion).GetResults().ToList();
                if (results.Any())
                {
                    items.AddRange(results.Select(x => x.Document.GetItem()));
                }

            }

            return items;
        }
    }
}