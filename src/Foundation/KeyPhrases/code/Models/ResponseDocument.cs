using System.Collections.Generic;

namespace DoctaCore.Foundation.KeyPhrases.Models
{
    public class ResponseDocument
    {
        public string Id { get; set; }
        public IEnumerable<string> KeyPhrases { get; set; }
    }
}