using DoctaCore.Foundation.KeyPhrases.Models;
using Sitecore.Pipelines;

namespace DoctaCore.Foundation.KeyPhrases.Pipelines.HandleKeyPhrasesResponse
{
    public class HandleKeyPhrasesResponsePipelineArgs : PipelineArgs
    {
        public ResponseDocumentCollection Collection { get; set; }
    }
}