﻿namespace HangFire_MicroUI_Service.DomainService.HashService
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HangFire_MicroUI_Service.DataAccess.Entities;
    using Dm = HangFire_MicroUI_Service.Model.Models;

    public class HashService : IHashService
    {
        #region Member Veriables

        private readonly HangFirePoCContext hangFirePoCContext;

        #endregion Member Veriables

        #region Constructors

        public HashService()
        {
            this.hangFirePoCContext = new HangFirePoCContext();
        }

        #endregion Constructors

        #region Public Methods

        public List<Dm.Hash> GetAllJobs()
        {
            var jobs = new List<Dm.Hash>();

            jobs = hangFirePoCContext.Hash
                   .Select(k=> new Dm.Hash
                   {
                        Key = k.Key,
                   })
                   .Distinct()
                   .ToList();

            return jobs;
        }

        #endregion Public Methods
    }
}