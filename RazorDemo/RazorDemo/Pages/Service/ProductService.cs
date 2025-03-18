using RazorDemo.Models;

namespace RazorDemo.Pages.Service
{
    public class ProductService
    {
        private static List<Product> products = new List<Product>
     {
         new Product { Id = 1, Name = "Product 1", Price = 10.0m },
         new Product { Id = 2, Name = "Product 2", Price = 20.0m },
         new Product { Id = 3, Name = "Product 3", Price = 30.0m },
     };

        public List<Product> GetAll()
        {
            // Return the list of all products
            return products;
        }
    }
}
