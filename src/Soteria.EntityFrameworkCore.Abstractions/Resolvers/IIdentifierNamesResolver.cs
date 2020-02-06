using System;

namespace Soteria.EntityFrameworkCore.Abstractions.Resolvers
{
	public interface IIdentifierNamesResolver
	{
		string ResolveName(string entityName, string schema, Type clrType);
	}
}
