using Microsoft.EntityFrameworkCore;
using Soteria.EntityFrameworkCore.Abstractions.Entities;
using Soteria.EntityFrameworkCore.Abstractions.Options;
using Soteria.EntityFrameworkCore.Abstractions.Resolvers;
using System;
using System.Linq;

namespace Soteria.EntityFrameworkCore.Modules
{
	internal class IdorModule : BaseModule
	{
		private static readonly Type interceptorType = typeof(IIdorInterceptor);
		private readonly IdorOptions options;

		public IdorModule(ModelBuilder builder, IdorOptions options)
			: base(builder)
		{
			this.options = options;
		}

		public override void Build()
		{
			_ = Builder.Model.GetEntityTypes().Where(e => interceptorType.IsAssignableFrom(e.ClrType))
				.Select(e =>
				{
					var entity = Builder.Entity(e.ClrType);
					var resolver = options?.IdentifierNamesResolver ?? new DefaultIdentifierNamesResolver();
					var table = e.GetTableName();
					var schema = e.GetSchema();
					var identifier = resolver.ResolveName(table, schema, e.ClrType);

					_ = entity.Property(identifier);

					return e;
				});
		}
	}
}
