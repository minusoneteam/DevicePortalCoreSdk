using DevicePortalCoreSDK.Models.Networking;

namespace DevicePortalCoreSDK.Processors.Networking.Contracts
{
    /// <summary>
    /// Contract interface that contains functions for device's network configuration.
    /// </summary>
    public interface INetworkingConfiguration
    {
        /// <summary>
        /// Gets the network's configuration from the device for all available adapters.
        /// </summary>
        /// <returns>
        /// A new instance of <see cref="NetworkConfiguration"/> populated with all available 
        /// adapters that were found on the device.
        /// </returns>
        NetworkConfiguration Get();
    }
}
