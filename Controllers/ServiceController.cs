using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    public class ServiceController : Controller
    {
        FinanceDbContext db=new();

        [Route("/hizmetler")]
        public IActionResult Index(int? id)
        {
            ViewBag.MenuIndex = 2;
            ViewBag.ServiceIndex = id;
            return View(db.Services.ToList());
        }
    }
}
