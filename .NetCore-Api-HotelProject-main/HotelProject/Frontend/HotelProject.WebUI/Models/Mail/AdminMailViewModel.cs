namespace HotelProject.WebUI.Models.Mail
{
    public class AdminMailViewModel
    {
        public string SenderNameSurname { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverNameSurname { get; set; }
        public string ReceiverMail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
