using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/welcome'>" +
                "<input type='text' name='name' />" +
                "<select name='greeting'>" +
                "<option value='Hello'>English</option>" +
                "<option value='Hola'>Spanish</option>" +
                "<option value='Bonjour'>French</option>" +
                "<option value='Hallo'>German</option>" +
                "<option value='Ciao'>Italian</option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        // GET: /<controller>/welcome?name=value or GET: /<controller>/welcome/name
        // POST: /<controller>/welcome
        [HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
        public IActionResult Welcome(string greeting, string name = "World")
        {
            return Content("<h1>" + greeting + ", "  + name + "!</h1>", "text/html");
        }
    }
}
