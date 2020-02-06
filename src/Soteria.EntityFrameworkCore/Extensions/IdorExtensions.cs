using Microsoft.EntityFrameworkCore;
using Soteria.EntityFrameworkCore.Abstractions.Options;
using Soteria.EntityFrameworkCore.Modules;

namespace Soteria.EntityFrameworkCore.Extensions
{
	/// <summary>
	/// Contains a collection of static method for protection against Insecure Direct Object Reference.
	/// </summary>
	public static class IdorExtensions
	{
		/// <summary>
		/// Protects against Insecure Direct Object Reference by hiding the entity's identifier from the CLR.
		/// </summary>
		/// <param name="builder">Model builder from database context</param>
		/// <param name="options">IDOR configuration options</param>
		/// <returns>Model builder for database context.</returns>
		public static ModelBuilder AddInsecureDirectObjectReferenceProtection(this ModelBuilder builder, IdorOptions? options = null)
		{
			options ??= new IdorOptions();

			var module = new IdorModule(builder, options);
			module.Build();

			return builder;
		}
	}
}
