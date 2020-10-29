namespace HangFire_MicroUI_Service.Web.ViewModels
{
    using HangFire_MicroUI_Service.Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class JobListViewModel
    {
        public List<Hash> Jobs { get; set; }

        public string JobId { get; set; }
    }
}
