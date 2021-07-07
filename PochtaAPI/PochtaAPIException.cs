using System;
using System.Runtime.Serialization;

namespace PochtaAPI
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
    public class PochtaAPIException : Exception
    {
        internal PochtaAPIException() { }

        internal PochtaAPIException(string message) : base(message) { }

        internal PochtaAPIException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        ///
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected PochtaAPIException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}