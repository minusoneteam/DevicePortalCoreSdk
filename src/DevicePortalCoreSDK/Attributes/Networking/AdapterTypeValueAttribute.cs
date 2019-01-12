using System;

namespace DevicePortalCoreSDK.Attributes.Networking
{
    /// <summary>
    /// Attribute that holds a string representation for the actual value of an adapter.
    /// </summary>
    public class AdapterTypeValueAttribute : Attribute
    {
        /// <summary>
        /// The value of the adapter.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Default class constructor that initializes an instance of the current object.
        /// </summary>
        /// <param name="value"></param>
        public AdapterTypeValueAttribute(string value)
        {
            Value = value;
        }
    }
}
