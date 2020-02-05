using Microsoft.EntityFrameworkCore;

namespace Soteria.EntityFrameworkCore.Modules
{
	internal abstract class BaseModule
	{
		public BaseModule(ModelBuilder builder)
		{
			Builder = builder;
		}

		protected ModelBuilder Builder { get; }

		public abstract void Initialize();
	}
}
