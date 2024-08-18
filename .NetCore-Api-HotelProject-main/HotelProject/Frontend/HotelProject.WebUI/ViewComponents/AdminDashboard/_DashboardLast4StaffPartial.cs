using HotelProject.WebUI.Dtos.StaffDto.Responses;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.AdminDashboard
{
    public class _DashboardLast4StaffPartial : ViewComponent
    {
        public readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast4StaffPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5000/api/Staff/Last4Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<DisplayStaffResponse>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
