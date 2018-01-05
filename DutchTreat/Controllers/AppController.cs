using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using DutchTreat.ViewModels;
using DutchTreat.Services;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService){
            _mailService = mailService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid){
              
                _mailService.SendMessage("test@test.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                //send the email
                //Insert Service here to send email
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            else {
                //Show the errors
            }
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
