﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using validateForm.Models;

namespace validateForm.Controllers
{
    public class HomeController : Controller
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /) local host 5000
        //this will look for a file name called Index
        public IActionResult Index()
        {
            User someUser = new User()
            {
                //make premade fields for testing purposes 
                Firstname ="bobby",
                Lastname="wilber",
                Age=25,
                Email="bla@gmail.com",
                Password="pie"
            };

            return View("Index", someUser);
        }
        //upon success reroute to success page
        [HttpPost]
        [Route("user/create")]
        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            //this is here so that the code will actually compile
            return View("Success");
        }



        
    }
}