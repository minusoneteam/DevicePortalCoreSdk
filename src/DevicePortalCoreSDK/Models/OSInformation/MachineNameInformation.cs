using Newtonsoft.Json;

namespace DevicePortalCoreSDK.Models.OSInformation
{
    /// <summary>
    /// Model class with information about the machine name.
    /// </summary>
    public class MachineNameInformation
    {
        /// <summary>
        /// The name of the computer.
        /// </summary>
        [JsonProperty("ComputerName")]
        public string ComputerName { get; set; }
    }
}
