using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Foundation.Rules.Actions;
using Sitecore.Diagnostics;
using Sitecore.Rules;

namespace DoctaCore.Feature.ContentScoring.Rules.Actions
{
    public class MapKeyPhraseToProfileKey<TRuleContext> : BaseRuleAction<TRuleContext> where TRuleContext : ContentScoringRuleContext
    {
        public string Phrase { get; set; }
        public string ProfileKey { get; set; }
        public string Points { get; set; }

        protected override void ApplyRule(TRuleContext ruleContext)
        {
            Assert.IsNotNull(ruleContext.Item, "ruleContext.Item != null");

            Assert.IsNotNullOrEmpty(Phrase, "Phrase != null && Phrase != string.Empty");
            Assert.IsNotNullOrEmpty(ProfileKey, "ProfileKey != null && ProfileKey != string.Empty");
            Assert.IsNotNullOrEmpty(Points, "Points != null && Points != string.Empty");

            if (!ruleContext.Args.Contains(Phrase, StringComparer.InvariantCultureIgnoreCase))
            {
                Log.Debug($"Phrase \"{Phrase}\" did not match any of the key phrases. Skipping mapping.", this);
                return;
            }

            if (!int.TryParse(Points, out var parsedPoints))
            {
                Log.Error($"Points value {Points} must be a valid number. Rule execution terminating for item {ruleContext.Item}", this);
                return;
            }

            ScoreContent(ProfileKey, parsedPoints);
        }

        protected virtual void ScoreContent(string profileKey, int points)
        {
            throw new NotImplementedException();
        }
    }
}