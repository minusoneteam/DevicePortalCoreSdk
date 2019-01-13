using DevicePortalCoreSDK.Constants;
using DevicePortalCoreSDK.Models.Networking;
using DevicePortalCoreSDK.Models.Requests;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace DevicePortalCoreSDK.Processors
{
    /// <summary>
    /// Processor class that handles networking related request.
    /// </summary>
    public class NetworkingProcessor : BaseProcessor
    {
        #region Public Methods

        /// <summary>
        /// Gets the device's network configuration.
        /// </summary>
        public NetworkConfiguration GetConfiguration()
        {
            RequestModel requestModel = new RequestModel()
            {
                Body = null,
                Credentials = Credentials,
                Method = HttpMethod.Get,
                SerializerSettings = SerializerSettings,
                Uri = new Uri(DevicePortalUrl + RequestPaths.NetworkingGetCurrentIPConfiguration)
            };

            NetworkConfigurationResponse response =
                new Request<NetworkConfigurationResponse>(requestModel).Execute();

            return new NetworkConfiguration(response.Adapters.ToList());
        }

        /// <summary>
        /// Updates the device's ipv4 configuration.
        /// </summary>
        public void PutConfiguration(IPv4AdapterConfiguration configuration)
        {
            RequestModel requestModel = new RequestModel()
            {
                Body = configuration,
                Credentials = Credentials,
                Method = HttpMethod.Put,
                SerializerSettings = SerializerSettings,
                Uri = new Uri(DevicePortalUrl + RequestPaths.NetworkingSetAStaticIpAddress)
            };

            new Request<string>(requestModel).Execute();
        }

        #endregion Public Methods

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
