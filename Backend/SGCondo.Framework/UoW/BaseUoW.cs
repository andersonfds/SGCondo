using SGCondo.Framework.DataContext;
using System;

namespace SGCondo.Framework.UoW
{
    public abstract class BaseUoW : IDisposable
    {
        protected readonly IDbContext Context;

        public BaseUoW(IDbContext context)
        {
            Context = context;
        }

        public void Dispose() => Context?.Dispose();

        public int SaveChanges() => Context.SaveChanges();
    }
}
