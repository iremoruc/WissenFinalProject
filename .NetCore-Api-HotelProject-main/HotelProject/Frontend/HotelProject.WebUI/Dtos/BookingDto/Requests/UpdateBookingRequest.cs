using System;

namespace HotelProject.WebUI.Dtos.BookingDto.Requests
{
    public class UpdateBookingRequest
    {
        public int BookingId { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string AdultCount { get; set; }
        public string ChildCount { get; set; }
        public string RoomCount { get; set; }
        public string SpecialReuest { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
