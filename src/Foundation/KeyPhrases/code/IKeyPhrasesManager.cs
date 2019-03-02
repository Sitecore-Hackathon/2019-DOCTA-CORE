using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data.Items;

namespace DoctaCore.Foundation.KeyPhrases
{
    public interface IKeyPhrasesManager
    {
        void Execute(Item startItem);
    }
}
