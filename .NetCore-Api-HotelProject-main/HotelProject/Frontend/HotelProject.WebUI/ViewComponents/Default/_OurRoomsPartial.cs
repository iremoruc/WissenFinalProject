using HotelProject.WebUI.Dtos.AboutDto.Responses;
using HotelProject.WebUI.Dtos.RoomDto.Responses;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _OurRoomsPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _OurRoomsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5000/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<DisplayRoomResponse>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
