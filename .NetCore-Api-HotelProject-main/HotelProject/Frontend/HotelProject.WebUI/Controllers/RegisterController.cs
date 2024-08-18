using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDto.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateUserRequest createUserRequest)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = createUserRequest.Name,
                Email = createUserRequest.Mail,
                Surname = createUserRequest.Surname,
                UserName = createUserRequest.Username
                //WorkLocationId=1

            };
            var result = await _userManager.CreateAsync(appUser, createUserRequest.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
