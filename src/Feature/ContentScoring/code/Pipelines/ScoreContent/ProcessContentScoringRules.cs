using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Feature.ContentScoring.Rules;
using DoctaCore.Foundation.Rules;
using Sitecore.Data;
using Sitecore.Diagnostics;

namespace DoctaCore.Feature.ContentScoring.Pipelines.ScoreContent
{
    public class ProcessContentScoringRules
    {
        public static readonly string RuleFolder = Sitecore.Configuration.Settings.GetSetting("DoctaCore.Feature.ContentScoring.RuleFolder");

        public void Process(ScoreContentPipelineArgs args)
        {
            Assert.IsNotNull(args.Item, "args.Item != null");
            Assert.IsNotNull(args.KeyPhrases, "args.KeyPhrases != null");

            if (!ID.TryParse(RuleFolder, out var ruleFolderId))
            {
                Log.Error($"DoctaCore.Feature.ContentScoring.RuleFolder setting value must be a valid Sitecore ID", this);
                return;
            }

            var context = new ContentScoringRuleContext(args.KeyPhrases)
            {
                Item = args.Item
            };

            RuleManager.RunRules(context, ruleFolderId);
        }
    }
}