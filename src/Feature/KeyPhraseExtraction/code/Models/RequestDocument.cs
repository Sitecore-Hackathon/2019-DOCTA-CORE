using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Foundation.KeyPhrases.Models;
using Newtonsoft.Json;

namespace DoctaCore.Feature.KeyPhraseExtraction.Models
{
    public class RequestDocument : IRequestModel
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}