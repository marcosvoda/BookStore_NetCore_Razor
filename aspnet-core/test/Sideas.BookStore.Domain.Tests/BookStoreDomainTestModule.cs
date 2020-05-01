using Sideas.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Sideas.BookStore
{
    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}