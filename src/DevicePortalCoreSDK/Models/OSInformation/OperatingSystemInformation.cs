namespace DevicePortalCoreSDK.Models.OSInformation
{
    /// <summary>
    /// Model class with operating system information of a device.
    /// </summary>
    public class OperatingSystemInformation
    {
        /// <summary>
        /// The computer name.
        /// </summary>
        public string ComputerName { get; set; }

        /// <summary>
        /// The edition of the operating system.
        /// </summary>
        public string OsEdition { get; set; }

        /// <summary>
        /// The edition id of the operating system.
        /// </summary>
        public string OsEditionId { get; set; }

        /// <summary>
        /// The version of the operating system.
        /// </summary>
        public string OsVersion { get; set; }

        /// <summary>
        /// The platform of the device.
        /// </summary>
        public string Platform { get; set; }
    }
}
