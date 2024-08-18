using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.MessageSubjectCategoryDto.Requests
{
    public class UpdateMessageSubjectCategoryRequest
    {
        public int MessageSubjectCategoryId { get; set; }
        public string Name { get; set; }
    }
}
