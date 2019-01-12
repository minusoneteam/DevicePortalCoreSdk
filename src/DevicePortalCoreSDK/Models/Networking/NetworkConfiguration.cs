using DevicePortalCoreSDK.Models.Networking.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DevicePortalCoreSDK.Models.Networking
{
    /// <summary>
    /// Network Configuration class that holds a list of <see cref="AdapterConfiguration"/> 
    /// populated by data found on the device.
    /// </summary>
    public class NetworkConfiguration : Collection<AdapterConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public NetworkConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="list">The list that is wrapped by the new collection.</param>
        public NetworkConfiguration(IList<AdapterConfiguration> list) : base(list) { }
    }
}
