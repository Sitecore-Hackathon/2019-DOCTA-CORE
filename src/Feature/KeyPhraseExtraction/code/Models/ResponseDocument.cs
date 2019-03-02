using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctaCore.Feature.KeyPhraseExtraction.Models
{
    public class ResponseDocument
    {
        public string Id { get; set; }
        public IEnumerable<string> KeyPhrases { get; set; }
    }
}