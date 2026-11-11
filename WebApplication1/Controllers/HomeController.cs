using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
        [Route("/shop/{id}/{query}")]
        [Route("/{id}/{query}")]
        public IActionResult Shop(Search search)
        {
            return Content($"id:{search.id},query:{search.query}");

        }

    }

    
}
