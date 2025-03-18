using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorDemo.Models;
using RazorDemo.Pages.Service;

namespace RazorDemo.Pages.Products
{
    public class ProductIndexModel : PageModel
    {
        private readonly ProductService _productService;

        public ProductIndexModel(ProductService productservice)
        {
            this._productService = productservice;
        }

        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _productService.GetAll();
        }
    }
}
