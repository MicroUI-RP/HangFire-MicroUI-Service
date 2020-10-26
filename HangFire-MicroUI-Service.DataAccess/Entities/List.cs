using System;
using System.Collections.Generic;

namespace HangFire_MicroUI_Service.DataAccess.Entities
{
    public partial class List
    {
        public long Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
