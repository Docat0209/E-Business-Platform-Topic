using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace SmartHomeApiFix.Models
{
    public class AreaInfoDTO
    {
        public int Id { get; set; }
        public int Home_id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public DataTable Devices { get; set; }
    }
}