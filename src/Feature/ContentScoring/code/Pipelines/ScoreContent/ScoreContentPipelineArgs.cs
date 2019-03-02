using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Pipelines;

namespace DoctaCore.Feature.ContentScoring.Pipelines.ScoreContent
{
    public class ScoreContentPipelineArgs : PipelineArgs
    {
        public Item Item { get; set; }
        public IEnumerable<string> KeyPhrases { get; set; }
    }
}