using DevicePortalCoreSDK.Attributes.Networking;

namespace DevicePortalCoreSDK.Enumerations.Networking
{
    /// <summary>
    /// Enumeration with values for determining the type of a network adapter.
    /// </summary>
    public enum AdapterType
    {
        /// <summary>
        /// Unknown type adapter.
        /// </summary>
        [AdapterTypeValue("Unknown")]
        Unknown,

        /// <summary>
        /// Ethernet adapter.
        /// </summary>
        [AdapterTypeValue("Ethernet")]
        Ethernet,

        /// <summary>
        /// IEEE 802.11 adapter. 
        /// </summary>
        [AdapterTypeValue("IEEE 802.11")]
        IEEE80211
    }
}
