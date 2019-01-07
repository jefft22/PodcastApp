namespace ConsoleTest
{
    using System;
    using System.Threading.Tasks;
    using PodcastApp.FetcherService;
    using PodcastApp.FetcherService.Managers.Models;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting test...");

            Console.WriteLine("Enter search query: ");
            var query = Console.ReadLine();

            var domainFacade = new DomainFacade();
            var search = new RequestPodcastSearch() { Query = query };
            var results = domainFacade.FindPodcasts(search).GetAwaiter().GetResult();

            Console.WriteLine($"Got {results.Results.Count} results.");
            foreach(var result in results.Results)
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($"Title: {result.Title} - {result.Description}");
                Console.WriteLine($"Url: {result.Url}");
            }

            Console.WriteLine("Which number do you want to get episodes for?");
            var selectedPodcast = Console.ReadLine();
            var selected = Int32.Parse(selectedPodcast);

            var episodeRequest = new RequestPodcastEpisodes()
            {
                Url = results.Results[selected - 1].Url
            };

            Console.WriteLine("Searching for episodes...");
            var episodeResults = domainFacade.GetEpisodes(episodeRequest).GetAwaiter().GetResult();
            Console.WriteLine("Done.");



            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}