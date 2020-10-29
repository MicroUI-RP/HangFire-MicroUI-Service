namespace HangFire_MicroUI_Service.DomainService.HashService
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using HangFire_MicroUI_Service.Model.Models;
    
    public interface IHashService 
    {
        List<Hash> GetAllJobs();

        void UpdateHash(Hash hash);
    }
}
