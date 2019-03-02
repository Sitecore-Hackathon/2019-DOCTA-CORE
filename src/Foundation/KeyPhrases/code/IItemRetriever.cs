using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;

namespace DoctaCore.Foundation.KeyPhrases
{
    public interface IItemRetriever
    {
        IEnumerable<Item> GetItems();
    }
}