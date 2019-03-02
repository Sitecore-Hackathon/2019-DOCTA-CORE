using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctaCore.Foundation.KeyPhrases
{
    public interface IHandleResponse<in TResponseModelCollection, TResponseModel>
        where TResponseModelCollection : IEnumerable<TResponseModel>
    {
        void DoHandleResponse(TResponseModelCollection collection);
    }
}
