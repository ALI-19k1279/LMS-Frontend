﻿using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
