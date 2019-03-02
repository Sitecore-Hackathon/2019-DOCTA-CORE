﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Foundation.Rules;

namespace DoctaCore.Feature.ContentScoring.Rules
{
    public class ContentScoringRuleContext : RuleContext<ContentScoringRuleArgs>
    {
        public ContentScoringRuleContext(ContentScoringRuleArgs args) : base(args)
        {
        }
    }
}