using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Foundation.KeyPhrases.Models;
using DoctaCore.Foundation.KeyPhrases.Pipelines.HandleKeyPhrasesResponse;
using Sitecore.Pipelines;

namespace DoctaCore.Feature.KeyPhraseExtraction.Pipelines.HandleKeyPhrasesResponse
{
    public class HandleKeyPhrasesResponsePipelineArgs : PipelineArgs, IHandleKeyPhrasesResponsePipelineArgs<ResponseDocumentCollection, ResponseDocument>
    {
        public ResponseDocumentCollection Collection { get; set; }
    }
}