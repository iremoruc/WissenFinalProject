namespace HotelProject.WebUI.Dtos.GuestDto.Requests
{
    public class UpdateGuestRequest
    {
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}
