using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Feature.KeyPhraseExtraction.Models;
using DoctaCore.Feature.KeyPhraseExtraction.Pipelines.HandleKeyPhrasesResponse;
using DoctaCore.Foundation.KeyPhrases;

namespace DoctaCore.Feature.KeyPhraseExtraction
{
    public class AzureKeyPhraseResponseHandler : BaseResponseHandler<ResponseDocumentCollection, ResponseDocument, HandleKeyPhrasesResponsePipelineArgs>
    {
        public override HandleKeyPhrasesResponsePipelineArgs GetArgs(ResponseDocumentCollection collection)
        {
            return new HandleKeyPhrasesResponsePipelineArgs()
            {
                DocumentCollection = collection
            };
        }
    }
}