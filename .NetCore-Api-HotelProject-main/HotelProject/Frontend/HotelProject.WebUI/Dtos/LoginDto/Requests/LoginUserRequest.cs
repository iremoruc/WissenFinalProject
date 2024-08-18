using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto.Requests
{
    public class LoginUserRequest
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Adı Giriniz")]
        public string Password { get; set; }
    }
}
