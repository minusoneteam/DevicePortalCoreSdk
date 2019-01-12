namespace DevicePortalCoreSDK.Models.Networking.Components
{
    /// <summary>
    /// Model for Windows Internet Name Service configuration.
    /// </summary>
    public class WINS
    {
        /// <summary>
        /// Primary configuration.
        /// </summary>
        public IPAddressMaskPair Primary { get; set; }

        /// <summary>
        /// Secondary configuration.
        /// </summary>
        public IPAddressMaskPair Secondary { get; set; }
    }
}
