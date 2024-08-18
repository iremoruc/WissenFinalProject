using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class MessageSubjectCategory
    {
        public int MessageSubjectCategoryId { get; set; }
        public string Name { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
