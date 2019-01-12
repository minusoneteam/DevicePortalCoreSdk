using DevicePortalCoreSDK.Attributes.Networking;
using DevicePortalCoreSDK.Enumerations.Networking;
using System.Linq;
using System.Reflection;

namespace DevicePortalCoreSDK.Enumerations
{
    /// <summary>
    /// Class with extension methods for enumerations.
    /// </summary>
    public static class EnumerationExtensions
    {
        /// <summary>
        /// Gets the adapter's type string representation.
        /// </summary>
        public static string GetAdapterValue(this AdapterType adapterType)
        {
            MemberInfo memberInfo = typeof(AdapterType)
                                    .GetMember(adapterType.ToString())
                                    .FirstOrDefault();

            string adapterValue = string.Empty;
            if (memberInfo != null)
            {
                AdapterTypeValueAttribute attribute =
                    memberInfo.GetCustomAttribute<AdapterTypeValueAttribute>();
                adapterValue = attribute?.Value;
            }
            return adapterValue;
        }

        /// <summary>
        /// Converts a string to it's matching <see cref="AdapterType"/> by searching through the
        /// adapter types' values.
        /// </summary>
        public static AdapterType ParseToAdapterType(this string adapterValue)
        {
            AdapterType adapterType = AdapterType.Unknown;

            foreach (FieldInfo field in typeof(AdapterType).GetFields())
            {
                AdapterTypeValueAttribute attribute =
                    field.GetCustomAttribute<AdapterTypeValueAttribute>();

                if (attribute != null && attribute.Value == adapterValue)
                {
                    adapterType = (AdapterType)field.GetValue(null);
                }
            }

            return adapterType;
        }
    }
}
