﻿using Microsoft.AspNetCore.Mvc;

namespace ProMedia.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
