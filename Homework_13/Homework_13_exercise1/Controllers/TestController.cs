using Microsoft.AspNetCore.Mvc;

namespace Homework_13_exercise1.Controllers
{
    public class TestController : Controller
    {
        [Route("/commschool", Name = "Commschool")]
        public IActionResult Commschool()
        {
            return Redirect("https://commschool.ge/");
        }
        [Route("/content")]
        public IActionResult Content(int id)
        {
            var x = id;
            return Content("application/json");
        }
    }
}
