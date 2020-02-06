using Microsoft.EntityFrameworkCore;
using Soteria.EntityFrameworkCore.Abstractions;
using System;
using System.Linq;

namespace Soteria.EntityFrameworkCore.Modules
{
	internal class IdorModule : BaseModule
	{
		private static readonly Type interceptorType = typeof(IIdorInterceptor);

		public IdorModule(ModelBuilder builder) 
			: base(builder)
		{

		}

		public override void Build()
		{
			_ = Builder.Model.GetEntityTypes().Where(e => interceptorType.IsAssignableFrom(e.ClrType))
				.Select(e =>
				{
					var entity = Builder.Entity(e.ClrType);
					_ = entity.Property("Id"); // TODO - Make configurable

					return e;
				});
		}
	}
}
