namespace DevicePortalCoreSDK.Models.Networking.Components
{
    /// <summary>
    /// Model that holds information related to an adapter's Dynamic Host Configuration Protocol.
    /// </summary>
    public class DHCP
    {
        /// <summary>
        /// Number of leases expired.
        /// </summary>
        public int LeaseExpires { get; set; }

        /// <summary>
        /// Number of leases obtained.
        /// </summary>
        public int LeaseObtained { get; set; }

        /// <summary>
        /// The address of the DHCP.
        /// </summary>
        public IPAddressMaskPair Address { get; set; }
    }
}
