using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.WorkLocationDto.Requests
{
    public class CreateWorkLocationRequest
    {
        public string WorkLocationName { get; set; }
        public string WorkLocationCity { get; set; }
    }
}
