using DevicePortalCoreSDK.Processors;
using System.Net;

namespace DevicePortalCoreSDK
{
    /// <summary>
    /// Class used for managing requests on the device portal api of a windows iot operating system.
    /// </summary>
    public class DevicePortalProcessor
    {
        #region Processors 

        /// <summary>
        /// Gets the networking processor that contains request methods related to networking.
        /// </summary>
        public NetworkingProcessor Networking { get; set; }

        /// <summary>
        /// Gets the networking processor that contains request methods related to networking.
        /// </summary>
        public RemoteControlProcessor RemoteControl { get; set; }

        /// <summary>
        /// Gets the Operating System Information processor that contains request methods related
        /// to the operating system of the device.
        /// </summary>
        public OSInformationProcessor OSInformation { get; set; }

        #endregion Processors 

        #region Constructors

        /// <summary>
        /// Creates an instance of the class and stores the device portal url that will be used
        /// by all device portal request methods.
        /// </summary>
        /// <param name="devicePortalUrl">
        /// The device portal url. E.g. if the manager is used from an application within the 
        /// windows iot, the address will be localhost. And if it is on a raspberry pi, then the
        /// default address and port should be "http://localhost:8080/". The slash at the end is
        /// optional and automatically concatenated if missing.
        /// </param>
        /// <param name="username">Username with authority on the device portal.</param>
        /// <param name="password">The password of the user.</param>
        public DevicePortalProcessor(string devicePortalUrl, string username, string password) :
            this(devicePortalUrl, new NetworkCredential(username, password))
        { }

        /// <summary>
        /// Creates an instance of the class and stores the device portal url that will be used
        /// by all device portal request methods.
        /// </summary>
        /// <param name="devicePortalUrl">
        /// The device portal url. E.g. if the manager is used from an application within the 
        /// windows iot, the address will be localhost. And if it is on a raspberry pi, then the
        /// default address and port should be "http://localhost:8080/". The slash at the end is
        /// optional and automatically concatenated if missing.
        /// </param>
        /// <param name="credentials">The credentials that will be used by the processor.</param>
        public DevicePortalProcessor(string devicePortalUrl, NetworkCredential credentials)
        {
            devicePortalUrl = devicePortalUrl.Substring(devicePortalUrl.Length - 1, 1) == "/" ?
                devicePortalUrl :
                devicePortalUrl + "/";

            Networking = new NetworkingProcessor(devicePortalUrl, credentials);
            RemoteControl = new RemoteControlProcessor(devicePortalUrl, credentials);
            OSInformation = new OSInformationProcessor(devicePortalUrl, credentials);
        }

        #endregion Constructors
    }
}
