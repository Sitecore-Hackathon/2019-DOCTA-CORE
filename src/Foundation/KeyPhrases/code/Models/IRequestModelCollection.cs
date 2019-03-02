using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctaCore.Foundation.KeyPhrases.Models
{
    public interface IRequestModelCollection
    {
        List<IRequestModel> Documents { get; set; }
    }
}
