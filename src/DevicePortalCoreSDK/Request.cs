using DevicePortalCoreSDK.Models.Requests;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DevicePortalCoreSDK
{
    /// <summary>
    /// Class that handles request to the device portal.
    /// </summary> 
    public class Request<TResponseBody>
    {
        /// <summary>
        /// The request model that build the class.
        /// </summary>
        public RequestModel RequestModel { get; private set; }

        /// <summary>
        /// Sends the request.
        /// </summary>
        /// <returns>The response body deserialized.</returns>
        public TResponseBody Execute()
        {
            HttpResponseMessage responseMessage;

            string requestBody =
                JsonConvert.SerializeObject(RequestModel.Body, RequestModel.SerializerSettings);

            HttpRequestMessage requestMessage = new HttpRequestMessage()
            {
                Content = RequestModel.Method == HttpMethod.Get ?
                    null : new StringContent(requestBody, Encoding.UTF8),
                Method = RequestModel.Method,
                RequestUri = RequestModel.Uri
            };

            HttpClientHandler handler = new HttpClientHandler()
            {
                Credentials = RequestModel.Credentials
            };

            using (HttpClient client = new HttpClient(handler))
            {
                Task<HttpResponseMessage> requestTask = client.SendAsync(requestMessage);
                requestTask.Wait();
                responseMessage = requestTask.Result;
            }

            string responseContent = responseMessage.Content.ReadAsStringAsync().Result;

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new HttpRequestException(responseContent);
            }

            return JsonConvert.DeserializeObject<TResponseBody>(
                responseContent, RequestModel.SerializerSettings);
        }

        /// <summary>
        /// Default class constructor that initializes a new instance of the class.
        /// </summary>
        /// <param name="requestModel">The request model.</param>
        public Request(RequestModel requestModel)
        {
            RequestModel = requestModel;
        }
    }
}
