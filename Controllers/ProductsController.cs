using Microsoft.AspNetCore.Mvc;
using SpotsPro.Models;

namespace SpotsPro.Controllers
{
   
    public class ProductsController : Controller
    {
        [Route("products")]
        public IActionResult List()
        {
            var products = new List<Product>
        {
           new Product { ProductID = 1, ProductCode = "LPT100", Name = "Laptop", YearlyPrice = 899.99m, ReleaseDate = new DateTime(2022, 6, 15) },
            new Product { ProductID = 2, ProductCode = "SPH200", Name = "Smartphone", YearlyPrice = 699.99m, ReleaseDate = new DateTime(2022, 7, 20) },
            new Product { ProductID = 3, ProductCode = "CAM300", Name = "Digital Camera", YearlyPrice = 449.99m, ReleaseDate = new DateTime(2022, 8, 10) },
            new Product { ProductID = 4, ProductCode = "HDV400", Name = "4K TV", YearlyPrice = 1499.99m, ReleaseDate = new DateTime(2022, 9, 5) },
            new Product { ProductID = 5, ProductCode = "HDS500", Name = "Soundbar", YearlyPrice = 299.99m, ReleaseDate = new DateTime(2022, 10, 18) }
        };
            return View(products);
        }
    }
}
