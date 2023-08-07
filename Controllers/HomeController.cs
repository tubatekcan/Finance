using FinanceApp.Common;
using FinanceApp.Models;
using FinanceApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    public class HomeController : Controller
    {
        FinanceDbContext db = new();
        public IActionResult Index()
        {
            ViewBag.MenuIndex = 0;
            IndexVM indexVM = new IndexVM { 
                Slides=db.Slides,
                Services=db.Services
            };
            return View(indexVM);
        }

        [Route("/Hakkimizda")]
        public IActionResult AboutUs()
        {
            ViewBag.MenuIndex = 1;
            return View();  
        }
   
        [Route("/iletisim")]
        public IActionResult Contact()
        {
            ViewBag.MenuIndex = 3;
            return View();
        }

        [Route("/iletisim"),HttpPost]
        public IActionResult Contact(string name,string email,string subject,string message)
        {
            db.Contacts.Add(new Contact {Email=email,FullName=name,Message=message,Subject=subject,Ipno=HttpContext.Connection.RemoteIpAddress.ToString(),RecDate=DateTime.Now });
            db.SaveChanges();

            GeneralTools.MailGoder(email,subject,"Sayın "+name+";</br>Mailiniz tarafımıza ulaşmış olup, en kısa sürede sizlere dönüş sağlayacağız, gönderdiğiniz mesaj:"+message);
            return View();
        }
    }
}
