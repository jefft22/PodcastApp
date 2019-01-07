namespace PodcastApp.FetcherService.Managers.Models.Gpodder
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    internal sealed class GpodderPodcastSummary
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("subscribers")]
        public int Subscribers { get; set; }

        [JsonProperty("subscribers_last_week")]
        public int SubscribersLastWeek { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("scaled_logo_url")]
        public string ScaledLogoUrl { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("mygpo_link")]
        public string MyGpoLink { get; set; }
    }
}