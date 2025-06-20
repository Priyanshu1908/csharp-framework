namespace csharp_framework.lib.model
{
    /// <summary>
    /// Api test class
    /// </summary>
    public class Api
    {

        /// <summary>
        /// API Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// API Request
        /// </summary>
        public string RequestUrl { get; set; }

        /// <summary>
        /// API Response
        /// </summary>
        public string ResponseCode { get; set; }

        /// <summary>
        /// API Client
        /// </summary>
        public string Client {  get; set; }

        /// <summary>
        /// Response Headers
        /// </summary>
        public string ResponseHeaders { get; set; }

        /// <summary>
        /// Response Content
        /// </summary>
        public string ResponseContent { get; set; }

        /// <summary>
        /// Response Status
        /// </summary>
        public string ResponseStatus { get; set; }

        /// <summary>
        /// Request Method
        /// </summary>
        public string RequestMethod { get; set; }
    }
}
