using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Feature.KeyPhraseExtraction.Models;
using DoctaCore.Foundation.KeyPhrases;

namespace DoctaCore.Feature.KeyPhraseExtraction
{
    public class ResponseDocumentTypeConverter : ITypeConverter<string, ResponseDocument>
    {
        public ResponseDocument Convert(string obj)
        {
            throw new NotImplementedException();
        }
    }
}