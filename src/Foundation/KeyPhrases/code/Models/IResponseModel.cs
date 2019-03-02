using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctaCore.Foundation.KeyPhrases.Models
{
    public interface IResponseModel
    {
        string ItemId { get; set; }
        IEnumerable<string> KeyPhrases { get; set; }
    }
}
