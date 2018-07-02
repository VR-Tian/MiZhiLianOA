using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace VR.Tian.EntityFramework.Repositories
{
    public abstract class TianRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TianDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TianRepositoryBase(IDbContextProvider<TianDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TianRepositoryBase<TEntity> : TianRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TianRepositoryBase(IDbContextProvider<TianDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
