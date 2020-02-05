using System;

namespace Soteria.EntityFrameworkCore.Abstractions
{
	/// <summary>
	/// Prevents Insecure Direct Object Reference (IDOR) from occurring whilst retaining the inherent indexing benefits from sequential identifiers.
	/// </summary>
	/// <remarks>
	/// IDOR occurs when a application exposes a reference to an internal implementation object. Using this way, it reveals the real identifier and format/pattern used of the element in the storage backend side.
	/// <a href="https://owasp.org/www-project-cheat-sheets/cheatsheets/Insecure_Direct_Object_Reference_Prevention_Cheat_Sheet.html">Read more</a>
	/// </remarks>
	public interface IIdorInterceptor
	{
		/// <summary>
		/// Unique IDOR-safe identifier.
		/// </summary>
		Guid Id { get; set; }
	}
}
