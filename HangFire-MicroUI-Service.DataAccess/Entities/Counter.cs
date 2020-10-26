using System;
using System.Collections.Generic;

namespace HangFire_MicroUI_Service.DataAccess.Entities
{
    public partial class Counter
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
