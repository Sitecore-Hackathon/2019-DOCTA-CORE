using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctaCore.Foundation.KeyPhrases.Models;

namespace DoctaCore.Foundation.KeyPhrases.Pipelines.HandleKeyPhrasesResponse
{
    public interface IHandleKeyPhrasesResponsePipelineArgs<TModelCollection, TModel> 
        where TModel : IResponseModel
    {
        TModelCollection Collection { get; set; }
    }
}