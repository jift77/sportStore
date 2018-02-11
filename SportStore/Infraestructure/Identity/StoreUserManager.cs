using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SportStore.Infraestructure.Identity
{
    internal class StoreUserManager
    {
        private UserStore<StoreUser> userStore;

        public StoreUserManager(UserStore<StoreUser> userStore)
        {
            this.userStore = userStore;
        }

        internal StoreUser FindByName(string userName)
        {
            throw new NotImplementedException();
        }

        internal void Create(StoreUser storeUser, string passWord)
        {
            throw new NotImplementedException();
        }

        internal bool IsInRole(string id, string roleName)
        {
            throw new NotImplementedException();
        }

        internal void AddToRole(string id, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}