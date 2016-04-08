using DemoStore.Infrastructure;
using DemoStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStore.Services
{
    public class ProductServices
    {
        private ProductRepository _productRepo;

        public ProductServices(ProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public ICollection<ProductDTO> GetProductList()
        {
            return (from p in _productRepo.List()
                    select new ProductDTO
                    {
                        Name = p.Name,
                        ImageUrl = p.ImageUrl,
                        Description = p.Description,
                        Price = p.Price,
                        ProductNumber = p.ProductNumber

                    }).ToList();
        }
    }
}
