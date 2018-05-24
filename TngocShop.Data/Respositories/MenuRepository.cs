using TngocShop.Data.Infrastructure;
using TngocShop.Model.Models;

namespace TngocShop.Data.Respositories
{
    public interface IMenuRepository
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}