﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers
{
    public class HomeController : Controller
    {
        public List<User> GenerateUsers()
        {
            return new List<User>()
            {
                new User(){ FirstName="Moose", LastName="Phillips"},
                new User(){ FirstName="Ricky", LastName="Thames"},
                new User(){ FirstName="Sally", LastName="McSally"},
                new User(){ FirstName="Barb", LastName="Reardan"},
            };
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string stringModel = "My message is here, this is a simple string that I am using as a model";

            return View("Index", stringModel);
        }
        [HttpGet("numbers")]
        public IActionResult Number()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 6, -13, 100, -2 };
            return View(numbers);
        }
        [HttpGet("users")]
        public IActionResult AllUsers()
        {
            var users = GenerateUsers();
            return View(users);
        }
        [HttpGet("user")]
        public IActionResult OneUser()
        {
            var rand = new Random();
            var users = GenerateUsers();

            // grab random user (could just create one, grab first, etc...)
            var user = users[rand.Next(users.Count)];
            return View(user);
        }
    }
}