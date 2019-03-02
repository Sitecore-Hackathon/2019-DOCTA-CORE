using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Feature.KeyPhraseExtraction.Models;
using DoctaCore.Feature.KeyPhraseExtraction.Shell.Framework.Commands;
using DoctaCore.Foundation.KeyPhrases;
using Newtonsoft.Json;

namespace DoctaCore.Feature.KeyPhraseExtraction
{
    public class ResponseDocumentTypeConverter : ITypeConverter<string, ResponseDocumentCollection>
    {
        public ResponseDocumentCollection Convert(string obj)
        {
            var response = JsonConvert.DeserializeObject<ResponseDocumentCollection>(obj);

            return response;
        }
    }
}