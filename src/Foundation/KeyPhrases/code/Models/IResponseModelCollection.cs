using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctaCore.Foundation.KeyPhrases.Models
{
    public interface IResponseModelCollection<out TModel> : IEnumerable<TModel> 
        where TModel : IResponseModel
    {
    }
}