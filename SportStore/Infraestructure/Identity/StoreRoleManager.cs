using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SportStore.Infraestructure.Identity
{
    internal class StoreRoleManager
    {
        private RoleStore<StoreRole> roleStore;

        public StoreRoleManager(RoleStore<StoreRole> roleStore)
        {
            this.roleStore = roleStore;
        }

        internal bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        internal void Create(StoreRole storeRole)
        {
            throw new NotImplementedException();
        }
    }
}