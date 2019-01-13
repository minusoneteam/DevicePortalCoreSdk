using DevicePortalCoreSDK.Constants;
using DevicePortalCoreSDK.Models.Requests;
using System;
using System.Net;
using System.Net.Http;

namespace DevicePortalCoreSDK.Processors
{
    /// <summary>
    /// Processor class that handles remote control related request.
    /// </summary>
    public class RemoteControlProcessor : BaseProcessor
    {
        #region Public Methods

        /// <summary>
        /// Sends a restart request to the remote device.
        /// </summary>
        public void Restart()
        {
            RequestModel requestModel = new RequestModel()
            {
                Body = null,
                Credentials = Credentials,
                Method = HttpMethod.Post,
                SerializerSettings = SerializerSettings,
                Uri = new Uri(DevicePortalUrl + RequestPaths.RemoteControlPostRestart)
            };

            new Request<string>(requestModel).Execute();
        }

        /// <summary>
        /// Sends a shutdown request to the remote device.
        /// </summary>
        public void Shutdown()
        {
            RequestModel requestModel = new RequestModel()
            {
                Body = null,
                Credentials = Credentials,
                Method = HttpMethod.Post,
                SerializerSettings = SerializerSettings,
                Uri = new Uri(DevicePortalUrl + RequestPaths.RemoteControlPostShutdown)
            };

            new Request<string>(requestModel).Execute();
        }

        #endregion Public Methods

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteControlProcessor"/> class.
        /// </summary>
        /// <param name="devicePortalUrl">
        /// The device portal url. E.g. if the manager is used from an application within the 
        /// windows iot, the address will be localhost. And if it is on a raspberry pi, then the
        /// default address and port should be "http://localhost:8080/". The slash at the end is
        /// optional and automatically concatenated if missing.
        /// </param>
        /// <param name="credentials">The credentials that will be used by the processor.</param>
        public RemoteControlProcessor(string devicePortalUrl, NetworkCredential credentials) :
            base(devicePortalUrl, credentials)
        { }

        #endregion Constructor
    }
}
