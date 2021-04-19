using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages
{
    public class LoadedFromFileModel : PageModel
    {
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public LoadedFromFileModel(JsonFileProductService productService) {

            ProductService = productService;
        }
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
