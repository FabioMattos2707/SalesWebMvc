using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Data;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private SalesWebMvcContext _context;
        public SellersController(SalesWebMvcContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            return View(_context.Seller.ToList());
        }
    }
}
