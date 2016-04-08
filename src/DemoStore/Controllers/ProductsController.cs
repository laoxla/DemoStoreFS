using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DemoStore.Services;
using DemoStore.Services.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoStore.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private ProductServices _productServ;

        public ProductsController(ProductServices productServ)
        {
            _productServ = productServ;
        }

        // GET: api/values
        [HttpGet]
        public ICollection<ProductDTO> GetProducts()
        {
            return _productServ.GetProductList().ToList();
        }

       
    }
}
