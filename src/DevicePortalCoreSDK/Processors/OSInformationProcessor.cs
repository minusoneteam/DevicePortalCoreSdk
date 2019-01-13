using DevicePortalCoreSDK.Constants;
using DevicePortalCoreSDK.Models.OSInformation;
using DevicePortalCoreSDK.Models.Requests;
using System;
using System.Net;
using System.Net.Http;

namespace DevicePortalCoreSDK.Processors
{
    /// <summary>
    /// Processor class that handles Operating System related request.
    /// </summary>
    public class OSInformationProcessor : BaseProcessor
    {
        #region Public Methods

        /// <summary>
        /// Gets the remote device's machine name.
        /// </summary>
        public MachineNameInformation GetMachineName()
        {
            RequestModel requestModel = new RequestModel()
            {
                Body = null,
                Credentials = Credentials,
                Method = HttpMethod.Get,
                SerializerSettings = SerializerSettings,
                Uri = new Uri(DevicePortalUrl + RequestPaths.OSInformationGetMachineName)
            };

            return new Request<MachineNameInformation>(requestModel).Execute();
        }

        /// <summary>
        /// Gets the operating system information from the remote device.
        /// </summary>
        public OperatingSystemInformation GetOSInformation()
        {
            RequestModel requestModel = new RequestModel()
            {
                Body = null,
                Credentials = Credentials,
                Method = HttpMethod.Get,
                SerializerSettings = SerializerSettings,
                Uri = new Uri(DevicePortalUrl + RequestPaths.OSInformationGetOSInformation)
            };

            return new Request<OperatingSystemInformation>(requestModel).Execute();
        }

        /// <summary>
        /// Gets the device family information from the remote device.
        /// </summary>
        public DeviceFamilyInformation GetDeviceFamily()
        {
            RequestModel requestModel = new RequestModel()
            {
                Body = null,
                Credentials = Credentials,
                Method = HttpMethod.Get,
                SerializerSettings = SerializerSettings,
                Uri = new Uri(DevicePortalUrl + RequestPaths.OSInformationGetDeviceFamily)
            };

            return new Request<DeviceFamilyInformation>(requestModel).Execute();
        }

        /// <summary>
        /// Sets a new machine name to the device.
        /// </summary>
        public MachineNameInformation SetMachineName(string machineName)
        {
            RequestModel requestModel = new RequestModel()
            {
                Body = null,
                Credentials = Credentials,
                Method = HttpMethod.Get,
                SerializerSettings = SerializerSettings,
                Uri = new Uri(DevicePortalUrl +
                    string.Format(RequestPaths.OSInformationPostMachineName, machineName))
            };

            return new Request<MachineNameInformation>(requestModel).Execute();
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
        public OSInformationProcessor(string devicePortalUrl, NetworkCredential credentials) :
            base(devicePortalUrl, credentials)
        { }

        #endregion Constructor
    }
}
