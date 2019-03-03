using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctaCore.Feature.ContentScoring.Pipelines.ScoreContent;
using DoctaCore.Foundation.KeyPhrases.Models;
using DoctaCore.Foundation.KeyPhrases.Pipelines.HandleKeyPhrasesResponse;
using Sitecore.Abstractions;
using Sitecore.Data;
using Sitecore.Diagnostics;
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


        public void Process(HandleKeyPhrasesResponsePipelineArgs args)
        {
            if (args?.Collection?.Documents == null)
            {
                Log.Warn($"ScoreContentWithKeyPhrases skipped due to a null argument", this);
                return;
            }

            var database = _factory.GetDatabase("master"); // TODO: move this to config and inject

            foreach (var model in args.Collection.Documents)
            {
                if (!ID.TryParse(model.Id, out var id))
                {
                    continue;
                }

                var scoreContentArgs = new ScoreContentPipelineArgs()
                {
                    Item = database.GetItem(id),
                    KeyPhrases = model.KeyPhrases
                };
                CorePipeline.Run("scoreContent", scoreContentArgs); // TODO: move this to config and inject
            }
        }
    }
}
