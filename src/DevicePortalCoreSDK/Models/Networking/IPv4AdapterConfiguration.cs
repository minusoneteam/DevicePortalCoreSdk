using System;
using System.Net;

namespace DevicePortalCoreSDK.Models.Networking
{
    /// <summary>
    /// Configuration model used for configuring an IPv4 adapter. 
    /// </summary>
    public class IPv4AdapterConfiguration
    {
        /// <summary>
        /// The name of the adapter.
        /// </summary>
        public Guid Name { get; set; }

        /// <summary>
        /// The IPAddress to set.
        /// </summary>
        public IPAddress IPAddress { get; set; }

        /// <summary>
        /// The SubnetMask to set.
        /// </summary>
        public IPAddress SubnetMask { get; set; }

        /// <summary>
        /// The Default Gateway to set.
        /// </summary>
        public IPAddress DefaultGateway { get; set; }

        /// <summary>
        /// The Primary DNS to set.
        /// </summary>
        public IPAddress PrimaryDNS { get; set; }

        /// <summary>
        /// The Secondary DNS to set.
        /// </summary>
        public IPAddress SecondaryDNS { get; set; }
    }
}
