namespace PodcastApp.FetcherService.Managers.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public abstract class FetcherServiceTechnicalException : Exception
    {
        public FetcherServiceTechnicalException()
        {
        }

        public FetcherServiceTechnicalException(string message) : base(message)
        {
        }

        public FetcherServiceTechnicalException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FetcherServiceTechnicalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}