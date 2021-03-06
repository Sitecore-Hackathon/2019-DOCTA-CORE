﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Sitecore.Data.Items;

namespace DoctaCore.Foundation.KeyPhrases
{
    public class KeyPhrasesManager<TRequestModelCollection, TRequestModel, TResponseModelCollection, TResponseModel> : IKeyPhrasesManager
    {
        protected IItemRetriever ItemRetriever { get; set; }
        protected ITypeConverter<IEnumerable<Item>, TRequestModelCollection> RequestParser { get; set; }
        protected ITypeConverter<TRequestModelCollection, string> RequestModelCollectionSerializer { get; set; }
        protected IRequestKeyPhrases KeyPhrasesRequester { get; set; }
        protected ITypeConverter<string, TResponseModelCollection> ResponseParser { get; set; }
        protected IHandleResponse<TResponseModelCollection, TResponseModel> ResponseHandler { get; set; }

        public KeyPhrasesManager(
            IItemRetriever itemRetriever, 
            ITypeConverter<IEnumerable<Item>, TRequestModelCollection> requestParser,
            ITypeConverter<TRequestModelCollection, string> requestModelCollectionSerializer,
            IRequestKeyPhrases keyPhrasesRequester,
            ITypeConverter<string, TResponseModelCollection> responseParser,
            IHandleResponse<TResponseModelCollection, TResponseModel> responseHandler)
        {
            ItemRetriever = itemRetriever;
            RequestParser = requestParser;
            RequestModelCollectionSerializer = requestModelCollectionSerializer;
            KeyPhrasesRequester = keyPhrasesRequester;
            ResponseParser = responseParser;
            ResponseHandler = responseHandler;
        }

        public void Execute(Item startItem)
        {
            // get items
            var items = ItemRetriever.GetItems(startItem);
            // items -> request models
            var requestModelCollection = RequestParser.Convert(items);
            // serialize request models
            var requestData = RequestModelCollectionSerializer.Convert(requestModelCollection);
            // execute request & get response
            Task<string> task =
                Task.Run(async () => await KeyPhrasesRequester.GetResponse(requestData));
            //var responseData = KeyPhrasesRequester.GetResponse(requestData);
            // parse response
            var responseModelCollection = ResponseParser.Convert(task.Result);
            // handle parsed response
            ResponseHandler.DoHandleResponse(responseModelCollection);
        }
    }
}