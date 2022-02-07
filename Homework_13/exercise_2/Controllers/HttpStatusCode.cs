using Microsoft.AspNetCore.Mvc;

namespace exercise_2.Controllers
{
    public class HttpStatusCode : ActionResult
    {
        private object unauthorized;
        private string v;
        public HttpStatusCode(object unauthorized, string v)
        {
            this.unauthorized = unauthorized;
            this.v = v;
        }
    }
}
