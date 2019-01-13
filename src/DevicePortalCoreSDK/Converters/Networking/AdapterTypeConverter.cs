using DevicePortalCoreSDK.Enumerations;
using DevicePortalCoreSDK.Enumerations.Networking;
using DevicePortalCoreSDK.Processors;
using Newtonsoft.Json;
using System;

namespace DevicePortalCoreSDK.Converters.Networking
{
    /// <summary>
    /// Converter class for explicit implementation for converting objects to and from json files.
    /// </summary>
    public class AdapterTypeConverter : JsonConverter
    {
        /// <summary>
        /// The type of Processor that uses this converter.
        /// </summary>
        public static Type ProcessorType = typeof(NetworkingProcessor);

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// True if this instance can convert the specified object type; otherwise, false.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(AdapterType);
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The Newtonsoft.Json.JsonReader to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns></returns>
        public override object ReadJson(
            JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return ((string)reader.Value).ParseToAdapterType();
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The Newtonsoft.Json.JsonWriter to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((AdapterType)value).GetAdapterValue());
        }
    }
}
