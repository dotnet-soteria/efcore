using System;

namespace Soteria.EntityFrameworkCore.Abstractions.Resolvers
{
	/// <summary>
	/// Property name resolver for identifier columns.
	/// </summary>
	public interface IIdentifierNamesResolver
	{
		/// <summary>
		/// Resolves property names when given an entity name, schema and its respective CLR type.
		/// </summary>
		/// <param name="entityName">Entity's name</param>
		/// <param name="schema">Entity's schema</param>
		/// <param name="clrType">CLR type of entity</param>
		/// <returns>Property name</returns>
		string ResolveName(string entityName, string schema, Type clrType);
	}
}
