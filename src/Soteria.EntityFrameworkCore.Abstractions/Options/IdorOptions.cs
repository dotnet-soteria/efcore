using Soteria.EntityFrameworkCore.Abstractions.Resolvers;

namespace Soteria.EntityFrameworkCore.Abstractions.Options
{
	/// <summary>
	/// Configuration options for Insecure Direct Object Reference (IDOR) protection module.
	/// </summary>
	public class IdorOptions
	{
		/// <summary>
		/// Property name resolver for hidden identifier columns.
		/// </summary>
		public IIdentifierNamesResolver IdentifierNamesResolver { get; set; } = new DefaultIdentifierNamesResolver();
	}
}
