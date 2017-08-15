using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Soulcalibur.EntityFramework.Repositories
{
    public abstract class SoulcaliburRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SoulcaliburDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SoulcaliburRepositoryBase(IDbContextProvider<SoulcaliburDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SoulcaliburRepositoryBase<TEntity> : SoulcaliburRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SoulcaliburRepositoryBase(IDbContextProvider<SoulcaliburDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
