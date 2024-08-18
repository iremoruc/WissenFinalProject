using System;

namespace HotelProject.WebUI.Dtos.ReservationDto.Requests
{
    public class UpdateReservationRequest
    {
        public int BookingId { get; set; }
        public string Status { get; set; }
    }
}
