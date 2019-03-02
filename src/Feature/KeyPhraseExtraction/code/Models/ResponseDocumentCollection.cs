using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Foundation.KeyPhrases.Models;

namespace DoctaCore.Feature.KeyPhraseExtraction.Models
{
    public class ResponseDocumentCollection : List<ResponseDocument>, IResponseModelCollection<ResponseDocument>
    {
        public List<string> Error { get; set; }
    }
}