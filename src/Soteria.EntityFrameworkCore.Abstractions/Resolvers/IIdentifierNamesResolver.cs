using System;

namespace Soteria.EntityFrameworkCore.Abstractions.Resolvers
{
	public interface IIdentifierNamesResolver
	{
		string ResolveName(string entityName, Type clrType);
	}
}
