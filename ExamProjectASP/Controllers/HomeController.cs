﻿using ExamProjectASP.Entities;
using ExamProjectASP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace ExamProjectASP.Controllers
{
    [Authorize(Roles = "Admin")]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private UserManager<CustomIdentityUser> _userManager;
        private IHttpContextAccessor _accessor;
        private CustomIdentityDbContext _db;
        public HomeController(ILogger<HomeController> logger, UserManager<CustomIdentityUser> userManager, IHttpContextAccessor accessor, CustomIdentityDbContext db)
        {
            _logger = logger;
            _userManager = userManager;
            _accessor = accessor;
            _db = db;
        }

        public async Task<IActionResult> Index()
		{
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ViewBag.User = user;
			return View();
		}


        public IActionResult Notifications()
        {
            return View();
        }

        public IActionResult Messages()
        {
            return View();
        }


        public IActionResult Friends()
        {
            return View();
        }

        public IActionResult Groups()
        {
            return View();
        }


        public IActionResult Favorite()
        {
            return View();
        }


        public IActionResult Events()
        {
            return View();
        }


        public IActionResult Birthday()
        {
            return View();
        }


        public IActionResult Video()
        {
            return View();
        }


        public IActionResult Weather()
        {
            return View();
        }


        public IActionResult Marketplace()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }


        public IActionResult Settings()
        {
            return View();
        }

        [HttpGet($"home/live-chat")]
        public IActionResult LiveChat()
        {
            return View("live-chat");
        }


        [HttpGet($"home/forgot-password")]
        public IActionResult ForgotPassword()
        {
            return View("forgot-password");
        }


        [HttpGet($"home/my-profile")]
        public IActionResult MyProfile()
        {
            return View("my-profile");
        }


        [HttpGet($"home/help-and-support")]
        public IActionResult HelpAndSupport()
        {
            return View("help-and-support");
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
	}
}