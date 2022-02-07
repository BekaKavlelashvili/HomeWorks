using Microsoft.AspNetCore.Mvc;

namespace Homework_13_exercise1.Controllers
{
    public class HttpStatusCodeResult : ActionResult
    {
        private object unauthorized;
        private string v;
        public HttpStatusCodeResult(object unauthorized, string v)
        {
            this.unauthorized = unauthorized;
            this.v = v;
        }
    }
}
