using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace SportStore.Infraestructure.Identity
{
    public class StoreIdentityDbContext : IdentityDbContext<StoreUser>
    {
        public StoreIdentityDbContext() : base("SportStoreIdentityDb") {
            Database.SetInitializer<StoreIdentityDbContext>(new StoreIdentityDbInitalizer());
        }

        public static StoreIdentityDbContext Create()
        {
            return new StoreIdentityDbContext();
        }
    }
}