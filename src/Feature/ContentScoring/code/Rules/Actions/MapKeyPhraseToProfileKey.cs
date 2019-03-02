using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Foundation.Rules.Actions;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Sitecore.Analytics.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Exceptions;
using Sitecore.Rules;

namespace DoctaCore.Feature.ContentScoring.Rules.Actions
{
    public class MapKeyPhraseToProfileKey<TRuleContext> : BaseRuleAction<TRuleContext> where TRuleContext : ContentScoringRuleContext
    {
        public string Phrase { get; set; }
        public string ProfileKeyId { get; set; }
        public string ProfileId { get; set; }
        public string Points { get; set; }

        protected override void ApplyRule(TRuleContext ruleContext)
        {
            Assert.IsNotNull(ruleContext.Item, "ruleContext.Item != null");

            Assert.IsNotNullOrEmpty(Phrase, "Phrase != null && Phrase != string.Empty");
            Assert.IsNotNullOrEmpty(ProfileKeyId, "ProfileKeyId != null && ProfileKeyId != string.Empty");
            Assert.IsNotNullOrEmpty(Points, "Points != null && Points != string.Empty");

            if (!ruleContext.Args.KeyPhrases.Contains(Phrase, StringComparer.InvariantCultureIgnoreCase))
            {
                Log.Debug($"Phrase \"{Phrase}\" did not match any of the key phrases. Skipping mapping.", this);
                return;
            }

            if (!int.TryParse(Points, out var parsedPoints))
            {
                Log.Error($"Points value {Points} must be a valid number. Rule execution terminating for item {ruleContext.Item.ID}", this);
                return;
            }

            if (!Guid.TryParse(ProfileId, out var parsedProfileItemId))
            {
                Log.Error($"The specified profile item ID must be a valid guid format. Rule execution terminating for item {ruleContext.Item.ID}", this);
                return;
            }

            if (ruleContext.Args.ProfileKeyScores.ContainsKey(ProfileId))
            {
                var profileKeys = ruleContext.Args.ProfileKeyScores[ProfileId];
                if (profileKeys.ContainsKey(ProfileKeyId))
                {
                    profileKeys[ProfileKeyId] += parsedPoints;
                    ruleContext.Args.ProfileKeyScores[ProfileId] = profileKeys;
                }
                else
                {
                    ruleContext.Args.ProfileKeyScores[ProfileId].Add(ProfileKeyId, parsedPoints);
                }
            }
            else
            {
                var profileKeys = new Dictionary<string, int> { { ProfileKeyId, parsedPoints } };
                ruleContext.Args.ProfileKeyScores.Add(ProfileId, profileKeys);
            }
        }
    }
}