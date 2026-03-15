using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StartController : Controller
    {
        public IActionResult hello()
        {
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;
            string greeting;
            if (hour >= 0 && hour < 6)
            {
                greeting = "Доброй ночи";
            }
            else if (hour >= 6 && hour < 12)
            {
                greeting = "Доброе утро";
            }
            else if (hour >= 12 && hour < 18)
            {
                greeting = "Добрый день";
            }
            else // hour >= 18 && hour < 24
            {
                greeting = "Добрый вечер";
            }
            Console.WriteLine(greeting);
            return Content(greeting);
        }
    }
}
