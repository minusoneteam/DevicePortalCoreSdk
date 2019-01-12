using System.Net;

namespace DevicePortalCoreSDK.Models.Networking.Components
{
    /// <summary>
    /// Class that holds a pair of IPAddress and Network Mask.
    /// </summary>
    public class IPAddressMaskPair
    {
        /// <summary>
        /// The ip address.
        /// </summary>
        public IPAddress IPAddress { get; set; }

        /// <summary>
        /// The network mask.
        /// </summary>
        public IPAddress Mask { get; set; }

        /// <summary>
        /// Initializes a new instance of the class with the given properties.
        /// </summary>
        /// <param name="ipaddress">The ip address.</param>
        /// <param name="mask">The network mask.</param>
        public IPAddressMaskPair(IPAddress ipaddress, IPAddress mask)
        {
            IPAddress = ipaddress;
            Mask = mask;
        }

        /// <summary>
        /// Initializes a new instance of the class with empty properties.
        /// </summary>
        public IPAddressMaskPair() { }
    }
}
