using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctaCore.Foundation.KeyPhrases.Models
{
    public interface IResponseModelCollection
    {
        List<IResponseModel> Documents { get; set; }
        List<string> Error { get; set; }
    }
}