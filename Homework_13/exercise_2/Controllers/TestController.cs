using Microsoft.AspNetCore.Mvc;

namespace exercise_2.Controllers
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
