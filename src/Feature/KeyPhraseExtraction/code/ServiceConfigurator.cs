using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Foundation.KeyPhrases;
using DoctaCore.Foundation.KeyPhrases.Models;
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