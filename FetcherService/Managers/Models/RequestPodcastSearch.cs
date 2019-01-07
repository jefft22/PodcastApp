namespace PodcastApp.FetcherService.Managers.Models
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class RequestPodcastSearch
    {
        [JsonProperty("query")]
        public string Query { get; set; }
    }
}