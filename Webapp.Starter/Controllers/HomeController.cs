using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webapp.Starter.Data.Entities;
using Webapp.Starter.Data.Repository;
using Webapp.Starter.Models;

namespace Webapp.Starter.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericRepository<Article> articleRepository;
        public HomeController(IGenericRepository<Article> _articleRepository)
        {
            articleRepository = _articleRepository;
        }
        public IActionResult Index()
        {
            var articles = articleRepository.Get(filter: null, orderBy: x => x.OrderByDescending(a => a.ArticleId), includeProperties: "");
            return View(articles);
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
