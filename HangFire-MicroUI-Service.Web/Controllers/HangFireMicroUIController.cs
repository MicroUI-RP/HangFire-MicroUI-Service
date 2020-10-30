namespace HangFire_MicroUI_Service.Web.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
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
            var result = new { error = false, msg = "Success" };

            if (hash != null &&
                !string.IsNullOrEmpty(hash.Key))
            {
                try
                {
                    hashService.UpdateHash(hash);
                }
                catch (Exception e)
                {
                    result = new { error = true, msg = e.Message };
                }
            }

            return Json(result);
        }
    }
}
