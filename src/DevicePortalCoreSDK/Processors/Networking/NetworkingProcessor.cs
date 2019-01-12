using DevicePortalCoreSDK.Models.Networking;
using DevicePortalCoreSDK.Models.Requests;
using DevicePortalCoreSDK.Processors.Networking.Contracts;
using System;
using System.Net;
using System.Net.Http;

namespace DevicePortalCoreSDK.Processors.Networking
{
    /// <summary>
    /// Processor class that handles networking related request.
    /// </summary>
    public class NetworkingProcessor : BaseProcessor, INetworkingConfiguration, IIPv4Configuration
    {
        #region INetworkingConfiguration implementation

        /// <summary>
        /// Network configuration requests.
        /// </summary>
        public INetworkingConfiguration Configuration { get { return this; } }

        /// <summary>
        /// The device's network configuration functions.
        /// </summary>
        NetworkConfiguration INetworkingConfiguration.Get()
        {
            RequestModel requestModel = new RequestModel()
            {
                Body = null,
                Credentials = Credentials,
                Method = HttpMethod.Get,
                SerializerSettings = SerializerSettings,
                Uri = new Uri("api/networking/ipv4config"),
            };

            return new Request<NetworkConfiguration>(requestModel).Execute();
        }

        #endregion INetworkingConfiguration implementation

        #region IPv4Configuration implementation

        /// <summary>
        /// IPv4 configuration requests.
        /// </summary>
        public IIPv4Configuration IPv4Configuration { get { return this; } }

        /// <summary>
        /// The device's ipv4 configuration functions.
        /// </summary>
        void IIPv4Configuration.Put(IPv4AdapterConfiguration configuration)
        {
            RequestModel requestModel = new RequestModel()
            {
                Body = configuration,
                Credentials = Credentials,
                Method = HttpMethod.Get,
                SerializerSettings = SerializerSettings,
                Uri = new Uri("api/networking/ipv4config"),
            };

            new Request<string>(requestModel).Execute();
        }

        #endregion IPv4Configuration implementation

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkingProcessor"/> class.
        /// </summary>
        /// <param name="devicePortalUrl">
        /// The device portal url. E.g. if the manager is used from an application within the 
        /// windows iot, the address will be localhost. And if it is on a raspberry pi, then the
        /// default address and port should be "http://localhost:8080/". The slash at the end is
        /// optional and automatically concatenated if missing.
        /// </param>
        /// <param name="credentials">The credentials that will be used by the processor.</param>
        public NetworkingProcessor(string devicePortalUrl, NetworkCredential credentials) :
            base(devicePortalUrl, credentials)
        { }

        #endregion Constructor
    }
}
