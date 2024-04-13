using Microsoft.AspNetCore.Mvc;
using ASWWW_lab2_gr4_nohttps.Models;

namespace ASWWW_lab1_gr4_nohttps.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ArticleController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index(int id) 
        {
            var article = _dbContext.Articles.FirstOrDefault(x => x.Id == id); //Repository.Articles.ToList()[id];
            if(article != null) { 
                return View(article);
            }
            return View("Error");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Article article)
        {
            if(ModelState.IsValid)
            {
                _dbContext.Articles.Add(article); // Repository.AddArticle(article)
                _dbContext.SaveChanges();
                return View("Added", article);
            }
            return View("Error");
        }
    }
}
