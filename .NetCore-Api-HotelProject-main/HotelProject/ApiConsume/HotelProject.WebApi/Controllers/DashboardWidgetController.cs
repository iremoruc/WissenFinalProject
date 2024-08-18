using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IGuestService _guestService;
        private readonly IWorkLocationService _workLocationService;

        public DashboardWidgetController(IStaffService staffService, IBookingService bookingService, IGuestService guestService, IWorkLocationService workLocationService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _guestService = guestService;
            _workLocationService = workLocationService;
        }
        [HttpGet("StaffCount")]
        public IActionResult StaffCount() 
        {
            var value =_staffService.TGetStaffCount();
            return Ok(value);
        }
        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            var value = _bookingService.TGetBookingCount();
            return Ok(value);
        }
        [HttpGet("GuestCount")]
        public IActionResult GuestCount()
        {
            var value = _guestService.TGetGuestCount();
            return Ok(value);
        }
        [HttpGet("WorkLocationCount")]
        public IActionResult WorkLocationCount()
        {
            var value = _workLocationService.TGetWorkLocationCount();
            return Ok(value);
        }

    }
}
