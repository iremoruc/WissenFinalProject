using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using HotelProject.WebUI.Dtos.SocialMediaFollowerDtos.Response;

namespace HotelProject.WebUI.ViewComponents.AdminDashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Instagram
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/ahmeteminozturkk"),
                Headers =
    {
        { "X-RapidAPI-Key", "d92334bb4emshba1bae2177c8375p199b4djsn39ce36e099b3" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                DisplayInstagramFollowersResponse displayInstagramFollowersResponse = JsonConvert.DeserializeObject<DisplayInstagramFollowersResponse>(body);
                ViewBag.InstagramFollowers = displayInstagramFollowersResponse.followers;
                ViewBag.InstagramFollowing = displayInstagramFollowersResponse.following;
            }

            
            //Twitter
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=murattyucedag"),
                Headers =
    {
        { "X-RapidAPI-Key", "d92334bb4emshba1bae2177c8375p199b4djsn39ce36e099b3" },
        { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                DisplayTwitterFollowersResponse displayTwitterFollowersResponse = JsonConvert.DeserializeObject<DisplayTwitterFollowersResponse>(body2);
                ViewBag.TwitterFollowers = displayTwitterFollowersResponse.data.user_info.followers_count;
                ViewBag.TwitterFollowing = displayTwitterFollowersResponse.data.user_info.friends_count;
            }


            //LinkedIn
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fahmeteminozturk%2F"),
                Headers =
    {
        { "X-RapidAPI-Key", "d92334bb4emshba1bae2177c8375p199b4djsn39ce36e099b3" },
        { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                DisplayLinkedInFollowersResponse displayLinkedInFollowersResponse = JsonConvert.DeserializeObject<DisplayLinkedInFollowersResponse>(body3);
                ViewBag.LinkedInFollowers = displayLinkedInFollowersResponse.data.followers_count;
            }

            return View();
        }
    }
}
