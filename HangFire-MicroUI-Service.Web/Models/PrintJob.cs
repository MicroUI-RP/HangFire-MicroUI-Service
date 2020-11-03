namespace HangFire_MicroUI_Service.Web.Models
{
    using System;
    using System.Diagnostics;
    using Hangfire;

    [LogEverything]
    public class PrintJob : IPrintJob
    {
        [Queue("alpha")]
        [LogEverything]
        public void Print()
        {
            Debug.WriteLine($"Job 2");
        }
    }
}
