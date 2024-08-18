namespace HotelProject.WebUI.Dtos.SocialMediaFollowerDtos.Response
{
    public class DisplayLinkedInFollowersResponse
    {

        public Data data { get; set; }


        public class Data
        {

            public int followers_count { get; set; }

        }

    }
}
