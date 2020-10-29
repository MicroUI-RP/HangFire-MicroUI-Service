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
    using HangFire_MicroUI_Service.Web.ViewModels;
    using HangFire_MicroUI_Service.Model.Models;
    using Microsoft.AspNetCore.Cors;

    [EnableCors("_myAllowSpecificOrigins")]
    public class HangFireMicroUIController : Controller
    {
        private readonly IHashService hashService;

        public HangFireMicroUIController(IHashService hashService)
        {
            this.hashService = hashService;
        }

        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult GetJobs()
        {
            JobListViewModel jobListViewModel = new JobListViewModel
            {
                Jobs = hashService.GetAllJobs()
            };

            return PartialView(jobListViewModel);
        }

        [HttpPost]
        [EnableCors("_myAllowSpecificOrigins")]
        public JsonResult UpdateJobDetails(Hash hash)
        {
            if (hash != null &&
                !string.IsNullOrEmpty(hash.Key))
            {
                hashService.UpdateHash(hash);
            }

            return Json("");
        }
    }
}
