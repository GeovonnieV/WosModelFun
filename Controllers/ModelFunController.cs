using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WosModelFun.Models;
using System;
using System.Collections.Generic;

namespace WosModelFun.Controllers
{
    public class ModelFunController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ModelString someMessage = new ModelString()
            {
                Message = "This is a message from the controller"
            };

            string Hello = "ello mate";

            return View("Index", Hello);
        }

        [HttpGet("Numbers")]
        public IActionResult Numbers()
        {
            int[] Numerals = { 1, 2, 3, 10, 43, 5 };

            return View("Numbers", Numerals);
        }

        [HttpGet("Users")]
        public IActionResult Users()
        {
            User someUser = new User()
            {
                FirstName = "Chad",
                LastName = "Chaderson"
            };

            User anotherUser = new User()
                {
                    FirstName = "Scarllet",
                    LastName = "Johanson"
                };


            List <User> viewModel = new List<User>()
                {
                    someUser, anotherUser
                };

                return View("Users", viewModel);

        }

        [HttpGet("User")]
        public IActionResult User()
            {
                 User anotherUser = new User()
                {
                    FirstName = "Scarllet",
                    LastName = "Johanson"
                };

                return View("User", anotherUser);
            }

    }

}