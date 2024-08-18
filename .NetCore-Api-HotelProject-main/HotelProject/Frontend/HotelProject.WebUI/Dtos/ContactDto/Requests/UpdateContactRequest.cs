using System;

namespace HotelProject.WebUI.Dtos.ContactDto.Requests
{
    public class UpdateContactRequest
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
