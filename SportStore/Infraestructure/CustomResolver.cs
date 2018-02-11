using SportStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;

namespace SportStore.Infraestructure
{
    public class CustomResolver : IDependencyResolver, IDependencyScope
    {
        public IDependencyScope BeginScope() => (this);

        public void Dispose() { }

        public object GetService(Type serviceType) => ( serviceType == typeof(IRepository) ? new ProductRepository() : null );

        public IEnumerable<object> GetServices(Type serviceType) => ( Enumerable.Empty<object>() );
    }
}