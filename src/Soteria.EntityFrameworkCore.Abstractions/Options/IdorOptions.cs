using Soteria.EntityFrameworkCore.Abstractions.Resolvers;

namespace Soteria.EntityFrameworkCore.Abstractions.Options
{
	public class IdorOptions
	{
		public IIdentifierNamesResolver IdentifierNamesResolver { get; set; } = new DefaultIdentifierNamesResolver();
	}
}
