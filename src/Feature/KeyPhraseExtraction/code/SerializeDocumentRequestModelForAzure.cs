using System.Text;
using System.Web.Script.Serialization;
using DoctaCore.Feature.KeyPhraseExtraction.Models;
using DoctaCore.Foundation.KeyPhrases;

namespace DoctaCore.Feature.KeyPhraseExtraction
{
    public class SerializeDocumentRequestModelForAzure : ITypeConverter<RequestDocumentCollection, string>
    {
        public string Convert(RequestDocumentCollection obj)
        {
            var serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(obj);

            return json;
        }
    }
}