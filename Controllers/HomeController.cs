//-----------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Kofax Inc.">
//     Copyright (c) Kofax Inc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Kofax.QATestTask.Controllers
{
    using System;
    using System.Diagnostics;

    using Kofax.QATestTask.Models;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(DateTime birthDate)
        {
            if (birthDate == DateTime.MinValue)
            {
                return RedirectToAction("Error");
            }

            return View(new CalculateModel(birthDate));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
