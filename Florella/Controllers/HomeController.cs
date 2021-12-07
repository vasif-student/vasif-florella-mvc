using Florella.Data;
using Florella.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florella.Controllers
{
    public class HomeController : Controller
    {

        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var about = _context.About.FirstOrDefault();
            var aboutvideo = _context.AboutVideo.FirstOrDefault();
            return View(new HomeViewModel { About = about, AboutVideo = aboutvideo});
        }
    }
}
