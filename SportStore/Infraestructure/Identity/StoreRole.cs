using Microsoft.AspNet.Identity.EntityFramework;

namespace SportStore.Infraestructure.Identity
{
    public class StoreRole : IdentityRole
    {
        public StoreRole() : base() { }

        public StoreRole(string name) : base(name) { }
    }
}