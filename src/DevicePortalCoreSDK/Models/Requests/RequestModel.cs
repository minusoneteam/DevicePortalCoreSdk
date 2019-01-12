using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;

namespace DevicePortalCoreSDK.Models.Requests
{
    /// <summary>
    /// Model class that describes a request.
    /// </summary>
    public class RequestModel
    {
        /// <summary>
        /// The Uri address of the request.
        /// </summary>
        public Uri Uri { get; set; }

        /// <summary>
        /// The method of the request.
        /// </summary>
        public HttpMethod Method { get; set; }

        /// <summary>
        /// The body of the request.
        /// </summary>
        public object Body { get; set; }

        /// <summary>
        /// The credentials that will be used to authorize the request.
        /// </summary>
        public NetworkCredential Credentials { get; set; }

        /// <summary>
        /// Additional custom serialization settings that will be used when serializing the request
        /// and deserializing the response.
        /// </summary>
        public JsonSerializerSettings SerializerSettings { get; set; }
    }
}
