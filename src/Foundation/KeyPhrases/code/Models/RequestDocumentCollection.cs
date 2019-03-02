using System.Collections.Generic;
using Newtonsoft.Json;

namespace DoctaCore.Foundation.KeyPhrases.Models
{
    public class RequestDocumentCollection
    {
        [JsonProperty("documents")]
        public List<RequestDocument> Documents { get; set; }
    }
}