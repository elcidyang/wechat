using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace WeChat.EntityFramework.Repositories
{
    public abstract class WeChatRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<WeChatDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected WeChatRepositoryBase(IDbContextProvider<WeChatDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class WeChatRepositoryBase<TEntity> : WeChatRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected WeChatRepositoryBase(IDbContextProvider<WeChatDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
