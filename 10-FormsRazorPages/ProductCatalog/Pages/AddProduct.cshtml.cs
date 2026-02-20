using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductCatalog.Pages
{
    public class AddProductModel : PageModel
    {

        private static List<Product> _products = new List<Product>();

        public List<Product> ProductList => _products;

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public decimal Price { get; set; }

        public bool IsSubmitted { get; set; } = false;
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                _products.Add(new Product(Name, Price));
                IsSubmitted = true;
            }
        }
    }
}
