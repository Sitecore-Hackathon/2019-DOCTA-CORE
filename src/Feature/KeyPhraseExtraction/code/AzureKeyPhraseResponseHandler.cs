using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Feature.KeyPhraseExtraction.Models;
using DoctaCore.Feature.KeyPhraseExtraction.Pipelines.HandleKeyPhrasesResponse;
using DoctaCore.Foundation.KeyPhrases;

namespace DoctaCore.Feature.KeyPhraseExtraction
{
    public class AzureKeyPhraseResponseHandler : BaseResponseHandler<DocumentCollection, Document, HandleKeyPhrasesResponsePipelineArgs>
    {
        public override HandleKeyPhrasesResponsePipelineArgs GetArgs(DocumentCollection collection)
        {
            return new HandleKeyPhrasesResponsePipelineArgs()
            {
                DocumentCollection = collection
            };
        }
    }
}