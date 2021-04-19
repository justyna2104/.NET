using DependencyInjection.Data;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProductContext _context;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, ProductContext context)
        {
            _logger = logger;
            _context = context;

        }


        public IList<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _context.Product.ToList();
        }
    }
}
