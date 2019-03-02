using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data.Items;

namespace DoctaCore.Foundation.KeyPhrases
{
    public interface IKeyPhrasesManager<TRequestModelCollection, TRequestModel, TResponseModelCollection, TResponseModel>
        where TRequestModelCollection : IEnumerable<TRequestModel>
        where TResponseModelCollection : IEnumerable<TResponseModel>
    {
        void Execute(Item startItem);
    }
}
