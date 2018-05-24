using TngocShop.Data.Infrastructure;
using TngocShop.Model.Models;

namespace TngocShop.Data.Respositories
{
    public interface ITagRepository
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}