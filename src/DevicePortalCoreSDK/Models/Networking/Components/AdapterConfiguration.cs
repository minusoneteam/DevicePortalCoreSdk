using DevicePortalCoreSDK.Enumerations.Networking;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace DevicePortalCoreSDK.Models.Networking.Components
{
    /// <summary>
    /// Model that holds information on how an adapter is configured.
    /// </summary>
    public class AdapterConfiguration
    {
        /// <summary>
        /// Bool indicating if dynamic DNS is enabled or not.
        /// </summary>
        public bool DDNSEnabled { get; set; }

        /// <summary>
        /// The description of the adapter.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The physical address of the adapter (MAC Address).
        /// </summary>
        public PhysicalAddress HardwareAddress { get; set; }

        /// <summary>
        /// The index of the adapter on the device.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// The name of the adapter.
        /// </summary>
        public Guid Name { get; set; }

        /// <summary>
        /// The type of the adapter.
        /// </summary>
        public AdapterType Type { get; set; }

        /// <summary>
        /// The DHCP configuration of the adapter.
        /// </summary>
        public DHCP DHCP { get; set; }

        /// <summary>
        /// The Windows Internet Name Service configuration of the adapter.
        /// </summary>
        public WINS WINS { get; set; }

        /// <summary>
        /// The configured Gateways of the adapter with their masks.
        /// </summary>
        public IEnumerable<IPAddressMaskPair> Gateways { get; set; }

        /// <summary>
        /// The configured IP Addresses of the adapter with their masks.
        /// </summary>
        public IEnumerable<IPAddressMaskPair> IpAddresses { get; set; }

        /// <summary>
        /// The configured DNS Addresses of the adapter.
        /// </summary>
        public IEnumerable<IPAddress> DnsAddresses { get; set; }
    }
}
