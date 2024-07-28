using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello world from action method";
        }

        public string hello()
        {
            return "Hello world from another";
        }
    }
}
