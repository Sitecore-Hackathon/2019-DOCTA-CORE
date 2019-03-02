using System;
using Newtonsoft.Json;

namespace DoctaCore.Foundation.KeyPhrases.Models
{
    public class RequestDocument
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}