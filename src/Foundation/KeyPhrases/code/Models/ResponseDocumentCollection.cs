using System.Collections.Generic;

namespace DoctaCore.Foundation.KeyPhrases.Models
{
    public class ResponseDocumentCollection
    {
        public List<ResponseDocument> Documents { get; set; }
        public List<string> Error { get; set; }
    }
}