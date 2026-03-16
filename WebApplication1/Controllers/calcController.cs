using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class calcController : Controller
    {
        public IActionResult index(int a, int b, string c)
        {
            if (c == "+" || c == null)
                return Content($"{a} + {b} = {a + b}");
            else if (c == "-")
                return Content($"{a} - {b} = {a - b}");
            else if (c == "*")
                return Content($"{a} * {b} = {a * b}");
            else
                return Content("Неверная операция");
        }
    }
}
