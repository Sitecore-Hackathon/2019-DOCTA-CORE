using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Pipelines;

namespace DoctaCore.Foundation.KeyPhrases
{
    public abstract class BaseResponseHandler<TResponseModelCollection, TResponseModel, TPipelineArgs> : IHandleResponse<TResponseModelCollection, TResponseModel>
        where TPipelineArgs : PipelineArgs
    {
        public virtual void DoHandleResponse(TResponseModelCollection collection)
        {
            var args = GetArgs(collection);
            CorePipeline.Run("handleKeyPhrasesResponse", args);
        }

        public abstract TPipelineArgs GetArgs(TResponseModelCollection collection);
    }
}