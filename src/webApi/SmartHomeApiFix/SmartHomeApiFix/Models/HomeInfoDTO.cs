using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHomeApiFix.Models
{
    public class HomeInfoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public IList<AreaSimpleDTO> Areas { get; set; }
    }
}