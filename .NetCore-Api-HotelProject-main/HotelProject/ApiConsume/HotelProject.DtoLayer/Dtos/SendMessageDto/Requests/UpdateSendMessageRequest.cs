using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.SendMessageDto.Requests
{
    public class UpdateSendMessageRequest
    {
        public int SendMessageId { get; set; }
        public string SenderNameSurname { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverNameSurname { get; set; }
        public string ReceiverMail { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
