using Homework_13_exercise1.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Homework_13_exercise1.Controllers
{
    public class TestController : Controller
    {


        [HttpPost]
        [Route("/contact", Name = "Contact")]
        public IActionResult Index(PersonModel person)
        {
            var path = @"C:\Users\Beka\source\repos\Homework_13\Homework_13_exercise1\Data.json";
            string firstName = person.FirstName;
            string lastName = person.LastName;
            string doctor = person.Doctor;
            int time = person.Time;
            return View();
            JObject o = JObject.Parse(@"{ 'FirstName :' { firstName} ,'LastName :' { lastName},'Doctor:' { doctor}, 'Time :' { time} }");
        }
        [Route("/commschool", Name = "Commschool")]
        public IActionResult Commschool()
        {
            return Json(new { Name = "Some", ID = 1 });
            //return Redirect("https://commschool.ge/");
        }
        [Route("/content")]
        public IActionResult Content(int id)
        {
            var x = id;
            return Content("application/json");
        }
    }
}
