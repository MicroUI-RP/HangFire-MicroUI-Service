namespace HangFire_MicroUI_Service.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Hash
    {
        public string Key { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
