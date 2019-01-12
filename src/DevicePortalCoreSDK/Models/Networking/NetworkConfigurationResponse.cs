using DevicePortalCoreSDK.Models.Networking.Components;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DevicePortalCoreSDK.Models.Networking
{
    /// <summary>
    /// Internal class used for deserializing response body.
    /// </summary>
    internal class NetworkConfigurationResponse
    {
        /// <summary>
        /// The adapters of the network configuration.
        /// </summary>
        [JsonProperty("Adapters")]
        internal IEnumerable<AdapterConfiguration> Adapters { get; set; }
    }
}
