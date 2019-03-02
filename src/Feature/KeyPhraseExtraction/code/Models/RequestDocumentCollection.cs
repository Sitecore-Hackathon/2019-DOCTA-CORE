using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Foundation.KeyPhrases.Models;
using Newtonsoft.Json;

namespace DoctaCore.Feature.KeyPhraseExtraction.Models
{
    public class RequestDocumentCollection : IRequestModelCollection
    {
        [JsonProperty("documents")]
        public List<IRequestModel> Documents { get; set; }
    }
}