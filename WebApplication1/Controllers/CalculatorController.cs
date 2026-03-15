using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult index(int a, int b)
        {
            return Content($"{a} + {b} = {a + b}");
        }
    }
}
