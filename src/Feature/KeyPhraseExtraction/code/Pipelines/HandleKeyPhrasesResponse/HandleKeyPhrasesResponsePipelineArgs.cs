using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Feature.KeyPhraseExtraction.Models;
using Sitecore.Pipelines;

namespace DoctaCore.Feature.KeyPhraseExtraction.Pipelines.HandleKeyPhrasesResponse
{
    public class HandleKeyPhrasesResponsePipelineArgs : PipelineArgs
    {
        public DocumentCollection DocumentCollection { get; set; }
    }
}