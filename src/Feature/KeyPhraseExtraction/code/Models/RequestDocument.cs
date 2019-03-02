using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctaCore.Feature.KeyPhraseExtraction.Models
{
    public class RequestDocument
    {
        public Guid Id { get; set; }
        public string Language { get; set; }
        public string Text { get; set; }
    }
}