using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blogg.Models;

namespace Blogg.Controllers
{
    public class HomeController : Controller
    {
        private readonly BaseDbContext _context;
        public HomeController(BaseDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            BaseViewModel viewModel = new BaseViewModel();
            viewModel.Posts = _context.Posts;
            return View(viewModel);
           
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
