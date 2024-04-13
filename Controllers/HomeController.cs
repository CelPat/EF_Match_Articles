using ASWWW_lab2_gr4_nohttps.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASWWW_lab1_gr4_nohttps.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Home";

            var articles = _dbContext.Articles!.ToList(); // var articles = Repository.articles;
            return View(articles);
        }
    }
}
