namespace PodcastApp.FetcherService.Managers.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public sealed class FetcherServiceMissingQueryException : FetcherServiceBusinessException
    {
        public FetcherServiceMissingQueryException()
        {
        }

        public FetcherServiceMissingQueryException(string message) : base(message)
        {
        }

        public FetcherServiceMissingQueryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public FetcherServiceMissingQueryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}