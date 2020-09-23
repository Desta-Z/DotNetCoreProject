using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OVERS.Models;
namespace OVERS.Controllers
{
    public class CustomerRegistrationController : Controller
    {
        private readonly CustomerDB cd; 
        public CustomerRegistrationController(CustomerDB _cd)
        {
            cd = _cd;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Customer c)
        {
            cd.Add(c);
            cd.SaveChanges();
            ViewBag.message = "Data has been succesfully stored";
            return View();
                       
        }
        [HttpGet]
        public IActionResult ShowCustomers()
        {
            return View();
        }
        public IActionResult ShowCustomers()
        {
            
            return View();
        }
       
      
    }
}
