using System.Linq;
using System.Threading.Tasks;
using DoctaCore.Foundation.KeyPhrases;
using DoctaCore.Foundation.KeyPhrases.Models;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.Shell.Framework.Commands;

namespace DoctaCore.Feature.KeyPhraseExtraction.Shell.Framework.Commands
{
    /// <summary>
    /// Ribbon command that send the indexed content for the current item to ML
    /// and saves the returned key phrases in Key Phrases field
    /// </summary>
    public class GetKeyPhrases : Command
    {
        public override void Execute(CommandContext context)
        {
            var manager = ServiceLocator.ServiceProvider.GetService<IKeyPhrasesManager>();
            var contextItem = context.Items.FirstOrDefault();

            manager.Execute(contextItem);
        }

    }
}