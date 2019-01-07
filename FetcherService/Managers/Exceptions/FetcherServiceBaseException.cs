namespace PodcastApp.FetcherService.Managers.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public abstract class FetcherServiceBaseException : Exception
    {
        public FetcherServiceBaseException()
        {
        }

        public FetcherServiceBaseException(string message) : base(message)
        {
        }

        public FetcherServiceBaseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FetcherServiceBaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}