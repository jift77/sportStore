using SportStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SportStore.Controllers
{
    public class ProductsController : ApiController
    {
        private IRepository Repository { get; set; }

        public ProductsController()
        {
            Repository = new ProductRepository();
        }

        public IEnumerable<Product> GetProducts() {
            return Repository.Products;
        }

        public IHttpActionResult GetProduct(int id) {
            Product product = Repository.Products.Where(p => p.Id == id).FirstOrDefault();
            return product == null ? (IHttpActionResult)BadRequest("No product found") : Ok(product);
        }

        public async Task PostProduct(Product product) {
            await Repository.SaveProductAsync(product);
        }

        [Authorize(Roles = "Administrators")]
        public async Task DeleteProduct(int id)
        {
            await Repository.DeleteProductAsync(id);
        }
    }
}
