using System;
using System.Collections.Generic;

namespace HangFire_MicroUI_Service.DataAccess.Entities
{
    public partial class Server
    {
        public string Id { get; set; }
        public string Data { get; set; }
        public DateTime LastHeartbeat { get; set; }
    }
}
