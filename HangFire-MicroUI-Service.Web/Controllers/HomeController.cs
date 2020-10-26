namespace HangFire_MicroUI_Service.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using HangFire_MicroUI_Service.Web.Models;
    using HangFire_MicroUI_Service.DomainService.HashService;

    public class HomeController : Controller
    {
        private readonly IHashService hashService;

        public HomeController(IHashService hashService)
        {
            this.hashService = hashService;
        }

        public IActionResult GetJobs()
        {
            var jobs = hashService.GetAllJobs();
            return View();
        }

    }
}
