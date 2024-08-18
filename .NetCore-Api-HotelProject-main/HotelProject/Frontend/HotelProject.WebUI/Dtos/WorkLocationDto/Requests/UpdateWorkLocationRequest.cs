using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.WorkLocationDto.Requests
{
    public class UpdateWorkLocationRequest
    {
        public int WorkLocationId { get; set; }
        public string WorkLocationName { get; set; }
        public string WorkLocationCity { get; set; }
    }
}
