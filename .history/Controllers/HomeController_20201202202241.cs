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
                Firstname ="bob",
                Lastname="wilber",
                Age="25",
                
            };

            return View("Index", someUser);
        }

        [HttpGet]
        [Route("numbers")]
        public IActionResult Numbers()
        {
            List<int> numberList = new List<int>(){1,2,3};
            return View("Numbers",numberList);   
        } 
    }
}