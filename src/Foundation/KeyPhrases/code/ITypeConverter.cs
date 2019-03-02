using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctaCore.Foundation.KeyPhrases
{
    public interface ITypeConverter<in TIn, out TOut>
    {
        TOut Convert(TIn obj);
    }
}