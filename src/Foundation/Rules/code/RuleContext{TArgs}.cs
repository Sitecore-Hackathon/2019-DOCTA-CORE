using Sitecore.Rules;

namespace DoctaCore.Foundation.Rules
{
	public class RuleContext<TArgs> : RuleContext, IRuleContext<TArgs>
		where TArgs : class
	{
		public RuleContext(TArgs args)
		{
			this.Args = args;
		}

		/// <summary>
		/// Gets the args.
		/// </summary>
		public TArgs Args { get; }
	}
}