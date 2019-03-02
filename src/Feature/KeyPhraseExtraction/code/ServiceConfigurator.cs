using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Feature.KeyPhraseExtraction.Models;
using DoctaCore.Foundation.KeyPhrases;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace DoctaCore.Feature.KeyPhraseExtraction
{
    public class ServiceConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IHandleResponse<DocumentCollection, Document>,AzureKeyPhraseResponseHandler>();

        }
    }
}