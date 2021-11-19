using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHomeApiFix.Models
{
    public class DeviceInfoDTO
    {
        public int Area_id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; }
        public Dictionary<string, string> Properities { get; set; }
    }
}