using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Foundation.KeyPhrases.Models;

namespace DoctaCore.Feature.KeyPhraseExtraction.Models
{
    public class ResponseDocument : IResponseModel
    {
        public string ItemId { get; set; }
        public IEnumerable<string> KeyPhrases { get; set; }
    }
}