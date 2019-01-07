namespace PodcastApp.FetcherService.Managers.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public abstract class FetcherServiceBusinessException : Exception
    {
        public FetcherServiceBusinessException()
        {
        }

        public FetcherServiceBusinessException(string message) : base(message)
        {
        }

        public FetcherServiceBusinessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FetcherServiceBusinessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}