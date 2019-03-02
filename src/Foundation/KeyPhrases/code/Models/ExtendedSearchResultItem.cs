using System.Collections.Generic;
using System.Runtime.Serialization;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Data.Items;

namespace DoctaCore.Foundation.KeyPhrases.Models
{
    /// <summary>
    ///  Model to extend the SearchResultItem to provide additional functionality
    /// </summary>
    public class ExtendedSearchResultItem : SearchResultItem
    {
        /// <summary>
        /// Returns a boolean that can be used to return only the latest content from the master DB
        /// </summary>
        [IndexField("_latestversion")]
        [DataMember]
        public virtual bool LatestVersion { get; set; }
    }
}