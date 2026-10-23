
using Microsoft.AspNetCore.Mvc;

namespace Day2_NongAnhThu.Controllers
{
    public class Hello_World : Controller
    {
        public IActionResult Welcome(string name, int numTimes = 3)
        {
            ViewData["numTimes"] = numTimes;
            return View();
        }
    }
}
