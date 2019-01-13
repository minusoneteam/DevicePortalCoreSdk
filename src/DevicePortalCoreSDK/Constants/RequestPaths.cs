namespace DevicePortalCoreSDK.Constants
{
    /// <summary>
    /// Class that holds constant values about the request paths.
    /// </summary>
    public static class RequestPaths
    {
        #region OS Information

        /// <summary>
        /// Api path for getting the machine name.
        /// </summary>
        public const string OSInformationGetMachineName = "api/os/machinename";

        /// <summary>
        /// Api path for getting operating system's information.
        /// </summary>
        public const string OSInformationGetOSInformation = "api/os/info";

        /// <summary>
        /// Api path for getting the device family.
        /// </summary>
        public const string OSInformationGetDeviceFamily = "api/os/devicefamily";

        /// <summary>
        /// Api path for posting the machine name.
        /// </summary>
        public const string OSInformationPostMachineName = "api/os/machinename?name={0}";

        #endregion OS Information

        #region Remote Control Paths

        /// <summary>
        /// Api path for restarting the device.
        /// </summary>
        public const string RemoteControlPostRestart = "api/control/restart";

        /// <summary>
        /// Api path for shutting down the device.
        /// </summary>
        public const string RemoteControlPostShutdown = "api/control/shutdown";

        #endregion Remote Control Paths

        #region Networking Paths

        /// <summary>
        /// Api path for getting the current ip configuration of the device.
        /// </summary>
        public const string NetworkingGetCurrentIPConfiguration = "api/networking/ipconfig";

        /// <summary>
        /// Api path for setting the ipv4 configuration of the device.
        /// </summary>
        public const string NetworkingSetAStaticIpAddress = "api/networking/ipv4config";

        #endregion Networking Paths
    }
}
