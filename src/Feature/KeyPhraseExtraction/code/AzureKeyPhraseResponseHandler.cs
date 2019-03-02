using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Feature.KeyPhraseExtraction.Pipelines.HandleKeyPhrasesResponse;
using DoctaCore.Foundation.KeyPhrases;
using DoctaCore.Foundation.KeyPhrases.Models;
using DoctaCore.Foundation.KeyPhrases.Pipelines.HandleKeyPhrasesResponse;

namespace DoctaCore.Feature.KeyPhraseExtraction
{
    public class AzureKeyPhraseResponseHandler : BaseResponseHandler<ResponseDocumentCollection, ResponseDocument, HandleKeyPhrasesResponsePipelineArgs>
    {
        public override HandleKeyPhrasesResponsePipelineArgs GetArgs(ResponseDocumentCollection collection)
        {
            return new HandleKeyPhrasesResponsePipelineArgs()
            {
                Collection = collection
            };
        }
    }
}