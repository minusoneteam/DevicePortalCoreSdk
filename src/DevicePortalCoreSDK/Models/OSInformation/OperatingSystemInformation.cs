using Newtonsoft.Json;

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
        [JsonProperty("ComputerName")]
        public string ComputerName { get; set; }

        /// <summary>
        /// The language of the operating system.
        /// </summary>
        [JsonProperty("Language")]
        public string Language { get; set; }

        /// <summary>
        /// The edition of the operating system.
        /// </summary>
        [JsonProperty("OsEdition")]
        public string Edition { get; set; }

        /// <summary>
        /// The edition id of the operating system.
        /// </summary>
        [JsonProperty("OsEditionId")]
        public string EditionId { get; set; }

        /// <summary>
        /// The version of the operating system.
        /// </summary>
        [JsonProperty("OsVersion")]
        public string Version { get; set; }

        /// <summary>
        /// The platform of the operating system.
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform { get; set; }
    }
}
