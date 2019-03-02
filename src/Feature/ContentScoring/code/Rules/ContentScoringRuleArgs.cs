using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctaCore.Feature.ContentScoring.Rules
{
    public class ContentScoringRuleArgs
    {
        public IEnumerable<string> KeyPhrases { get; set; }
        public Dictionary<string, Dictionary<string, int>> ProfileKeyScores { get; set; }
    }
}