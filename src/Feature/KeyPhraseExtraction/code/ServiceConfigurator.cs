using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Feature.KeyPhraseExtraction.Models;
using DoctaCore.Foundation.KeyPhrases;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Data.Items;
using Sitecore.DependencyInjection;

namespace DoctaCore.Feature.KeyPhraseExtraction
{
    public class ServiceConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IHandleResponse<ResponseDocumentCollection, ResponseDocument>,AzureKeyPhraseResponseHandler>();
            serviceCollection.AddSingleton<ITypeConverter<IEnumerable<Item>, RequestDocumentCollection>, RequestDocumentTypeConverter>();
            serviceCollection.AddSingleton<ITypeConverter<RequestDocumentCollection, string>, SerializeDocumentRequestModelForAzure>();
            serviceCollection.AddSingleton<ITypeConverter<string, ResponseDocumentCollection>, ResponseDocumentTypeConverter>();
            serviceCollection.AddSingleton<IRequestKeyPhrases, AzureKeyPhrasesClient>();
            serviceCollection.AddSingleton<IKeyPhrasesManager, KeyPhrasesManager<RequestDocumentCollection, RequestDocument, ResponseDocumentCollection, ResponseDocument>>();
        }
    }
}