using DevicePortalCoreSDK.Models.Networking;

namespace DevicePortalCoreSDK.Processors.Networking.Contracts
{
    /// <summary>
    /// Contract interface that contains functions for device's ipv4 network configuration.
    /// </summary>
    public interface IIPv4Configuration
    {
        /// <summary>
        /// Sends a configuration request for an IPv4 adapter.
        /// </summary>
        /// <param name="request">The model that contains all the new configuration settings.</param>
        void Put(IPv4AdapterConfiguration request);
    }
}
