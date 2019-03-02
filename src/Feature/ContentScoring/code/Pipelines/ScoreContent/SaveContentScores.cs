using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.SecurityModel;

namespace DoctaCore.Feature.ContentScoring.Pipelines.ScoreContent
{
    public class SaveContentScores
    {
        public void Process(ScoreContentPipelineArgs args)
        {
            Assert.IsNotNull(args.Item, "args.Item != null");
            
            Assert.IsNotNull(args.ProfileKeyScores, "args.ProfileKeyScores != null");

            var profileKeyElements = string.Join(
                string.Empty, 
                args.ProfileKeyScores
                    .Select(profileEntry =>
                    {
                        var profileItem = args.Item.Database.GetItem(profileEntry.Key);
                        var profileKeys = string.Join(
                            string.Empty,
                            profileEntry.Value
                                .Select(profileKeyEntry => $"<key name=\"{profileKeyEntry.Key}\" value=\"{profileKeyEntry.Value}\" />"));
                        return
                            $"<profile id=\"{profileItem.ID.Guid.ToString().ToLowerInvariant()}\" name=\"{profileItem.Name}\">{profileKeys}</profile>";
                    }));

            var trackingFieldValue = $"<tracking>{profileKeyElements}</tracking>";

            using (new SecurityDisabler())
            using (new EditContext(args.Item))
            {
                args.Item["__Tracking"] = trackingFieldValue;
            }
        }
    }
}