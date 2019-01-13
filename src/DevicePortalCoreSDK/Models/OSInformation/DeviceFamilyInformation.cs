using Newtonsoft.Json;

namespace DevicePortalCoreSDK.Models.OSInformation
{
    /// <summary>
    /// Model class with information about the device family.
    /// </summary>
    public class DeviceFamilyInformation
    {
        /// <summary>
        /// The device type.
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType { get; set; }
    }
}
