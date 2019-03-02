using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctaCore.Feature.ContentScoring.Pipelines.ScoreContent;
using DoctaCore.Foundation.KeyPhrases.Models;
using DoctaCore.Foundation.KeyPhrases.Pipelines.HandleKeyPhrasesResponse;
using Sitecore.Abstractions;
using Sitecore.Pipelines;

namespace DoctaCore.Feature.ContentScoring.Pipelines.HandleKeyPhrasesResponse
{
    public class ScoreContentWithKeyPhrases
    {
        private BaseFactory _factory { get; }

        public ScoreContentWithKeyPhrases(BaseFactory factory)
        {
            _factory = factory;
        }


        public void Process(
            IHandleKeyPhrasesResponsePipelineArgs<ResponseDocumentCollection, ResponseDocument> args)
        {
            var database = _factory.GetDatabase("master"); // TODO: move this to config and inject

            foreach (var model in args.Collection.Documents)
            {
                var scoreContentArgs = new ScoreContentPipelineArgs()
                {
                    Item = database.GetItem(model.ItemId),
                    KeyPhrases = model.KeyPhrases
                };
                CorePipeline.Run("scoreContent", scoreContentArgs); // TODO: move this to config and inject
            }
        }
    }
}
