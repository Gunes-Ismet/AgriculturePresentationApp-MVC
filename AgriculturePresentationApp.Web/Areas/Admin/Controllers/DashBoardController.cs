﻿using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
