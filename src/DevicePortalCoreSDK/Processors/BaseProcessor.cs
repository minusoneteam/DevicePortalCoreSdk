using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Reflection;

namespace DevicePortalCoreSDK.Processors
{
    /// <summary>
    /// Parent class for all processors.
    /// </summary>
    public class BaseProcessor
    {
        #region Properties

        /// <summary>
        /// The additional custom serialization settings of the class, used in requests.
        /// </summary>
        protected JsonSerializerSettings SerializerSettings { get; private set; }

        /// <summary>
        /// The device portal url used in each individual api request controller.
        /// </summary>
        protected string DevicePortalUrl { get; private set; }

        /// <summary>
        /// The authorization headers used in every request.
        /// </summary>
        protected NetworkCredential Credentials { get; private set; }

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseProcessor"/> class and builds the
        /// <see cref="SerializerSettings"/> field.
        /// </summary>
        /// <param name="devicePortalUrl">
        /// The device portal url. E.g. if the manager is used from an application within the 
        /// windows iot, the address will be localhost. And if it is on a raspberry pi, then the
        /// default address and port should be "http://localhost:8080/". The slash at the end is
        /// optional and automatically concatenated if missing.
        /// </param>
        /// <param name="credentials">The credentials that will be used by the processor.</param>
        public BaseProcessor(string devicePortalUrl, NetworkCredential credentials)
        {
            DevicePortalUrl = devicePortalUrl;
            Credentials = credentials;

            //Dynamically get all serializer settings that have processor type the derived class.
            SerializerSettings = new JsonSerializerSettings();

            Assembly currentAssembly = AppDomain.CurrentDomain.GetAssemblies()
                   .Where(a => a.FullName.Contains("DevicePortalCoreSDK"))
                   .Single();

            foreach (Type type in currentAssembly.GetTypes())
            {
                FieldInfo processorTypeField = type
                    .GetField("ProcessorType", BindingFlags.Public | BindingFlags.Static);

                if (type.BaseType == typeof(JsonConverter) && processorTypeField != null &&
                    (Type)processorTypeField.GetValue(null) == this.GetType())
                {
                    SerializerSettings.Converters.Add((JsonConverter)Activator.CreateInstance(type));
                }
            }

            SerializerSettings.Formatting = Formatting.Indented;
        }

        #endregion Constructor
    }
}
