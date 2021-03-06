﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Foundation.KeyPhrases.Pipelines.HandleKeyPhrasesResponse;
using Sitecore.Abstractions;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.SecurityModel;

namespace DoctaCore.Feature.KeyPhraseExtraction.Pipelines.HandleKeyPhrasesResponse
{
    /// <summary>
    /// Note that this processor is being used as a temporary workaround to save some time on our POC. Eventually
    /// this data is intended to be stored in a custom database or custom table of the master database
    /// </summary>
    public class UpdateItemsWithKeyPhrases
    {
        private BaseFactory _factory { get; }

        public UpdateItemsWithKeyPhrases(BaseFactory factory)
        {
            _factory = factory;
        }

        public void Process(HandleKeyPhrasesResponsePipelineArgs args)
        {
            if (args?.Collection?.Documents == null)
            {
                Log.Warn($"UpdateItemsWithKeyPhrases skipped due to a null argument", this);
                return;
            }

            using (new BulkUpdateContext())
            {
                foreach (var document in args.Collection.Documents)
                {
                    // ReSharper disable once InconsistentNaming
                    var masterDB = _factory.GetDatabase("master"); // TODO: move to config and inject
                    var item = masterDB.GetItem(new ID(document.Id));

                    using (new SecurityDisabler())
                    using (new EditContext(item))
                    {
                        item["Key Phrases"] = string.Join(",", document.KeyPhrases); // TODO: move field name to config and inject
                    }
                }
            }
        }
    }
}