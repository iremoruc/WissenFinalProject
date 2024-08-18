using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto.Requests
{
    public class CreateServiceRequest
    {
        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }
        
        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(200, ErrorMessage = "Sistem başlığı en fazla 200 karakter olmalıdır")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet açıklaması giriniz")]
        [StringLength(500, ErrorMessage = "Sistem başlığı en fazla 500 karakter olmalıdır")]
        public string Description { get; set; }
    }
}
