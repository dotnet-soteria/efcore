using System;

namespace Soteria.EntityFrameworkCore.Abstractions.Resolvers
{
	public class DefaultIdentifierNamesResolver : IIdentifierNamesResolver
	{
		public string ResolveName(string entityName, string schema, Type clrType)
		{
			throw new NotImplementedException();
		}
	}
}
