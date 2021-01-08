using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Podcastrz.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }
    }
}