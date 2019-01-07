namespace PodcastApp.FetcherService.Managers.Models
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class RequestPodcastEpisodes
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}