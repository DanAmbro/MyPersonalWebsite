﻿using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Models;
using System.Diagnostics;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Innerpage()
        {
            return View();
        }

        public IActionResult Contact() 
        {
            return View(); 
        }

        public IActionResult Portfoliodetails()
        {
            return View();
        }
    }
}