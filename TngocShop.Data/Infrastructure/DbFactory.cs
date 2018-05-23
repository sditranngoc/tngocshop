namespace TngocShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TngocShopDbContext dbContext;

        public TngocShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TngocShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}