using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace myWebApp.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /Home/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Home/Welcome/ 

        public IActionResult Welcome()
        {
            return View("Index");
        }
    }
}