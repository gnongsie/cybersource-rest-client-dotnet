/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICreditApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Process a Credit
        /// </summary>
        /// <remarks>
        /// POST to the credit resource to credit funds to a specified credit card.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCreditRequest"></param>
        /// <returns>InlineResponse2014</returns>
        InlineResponse2014 CreateCredit (CreateCreditRequest createCreditRequest);

        /// <summary>
        /// Process a Credit
        /// </summary>
        /// <remarks>
        /// POST to the credit resource to credit funds to a specified credit card.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCreditRequest"></param>
        /// <returns>ApiResponse of InlineResponse2014</returns>
        ApiResponse<InlineResponse2014> CreateCreditWithHttpInfo (CreateCreditRequest createCreditRequest);
        /// <summary>
        /// Retrieve a Credit
        /// </summary>
        /// <remarks>
        /// Include the credit ID in the GET request to return details of the credit.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The credit ID returned from a previous stand-alone credit request. </param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 GetCredit (string id);

        /// <summary>
        /// Retrieve a Credit
        /// </summary>
        /// <remarks>
        /// Include the credit ID in the GET request to return details of the credit.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The credit ID returned from a previous stand-alone credit request. </param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        ApiResponse<InlineResponse2006> GetCreditWithHttpInfo (string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Process a Credit
        /// </summary>
        /// <remarks>
        /// POST to the credit resource to credit funds to a specified credit card.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCreditRequest"></param>
        /// <returns>Task of InlineResponse2014</returns>
        System.Threading.Tasks.Task<InlineResponse2014> CreateCreditAsync (CreateCreditRequest createCreditRequest);

        /// <summary>
        /// Process a Credit
        /// </summary>
        /// <remarks>
        /// POST to the credit resource to credit funds to a specified credit card.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCreditRequest"></param>
        /// <returns>Task of ApiResponse (InlineResponse2014)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2014>> CreateCreditAsyncWithHttpInfo (CreateCreditRequest createCreditRequest);
        /// <summary>
        /// Retrieve a Credit
        /// </summary>
        /// <remarks>
        /// Include the credit ID in the GET request to return details of the credit.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The credit ID returned from a previous stand-alone credit request. </param>
        /// <returns>Task of InlineResponse2006</returns>
        System.Threading.Tasks.Task<InlineResponse2006> GetCreditAsync (string id);

        /// <summary>
        /// Retrieve a Credit
        /// </summary>
        /// <remarks>
        /// Include the credit ID in the GET request to return details of the credit.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The credit ID returned from a previous stand-alone credit request. </param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> GetCreditAsyncWithHttpInfo (string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CreditApi : ICreditApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CreditApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CreditApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CyberSource.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Process a Credit POST to the credit resource to credit funds to a specified credit card.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCreditRequest"></param>
        /// <returns>InlineResponse2014</returns>
        public InlineResponse2014 CreateCredit (CreateCreditRequest createCreditRequest)
        {
             ApiResponse<InlineResponse2014> localVarResponse = CreateCreditWithHttpInfo(createCreditRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process a Credit POST to the credit resource to credit funds to a specified credit card.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCreditRequest"></param>
        /// <returns>ApiResponse of InlineResponse2014</returns>
        public ApiResponse< InlineResponse2014 > CreateCreditWithHttpInfo (CreateCreditRequest createCreditRequest)
        {
            // verify the required parameter 'createCreditRequest' is set
            if (createCreditRequest == null)
                throw new ApiException(400, "Missing required parameter 'createCreditRequest' when calling CreditApi->CreateCredit");

            var localVarPath = "/pts/v2/credits/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                ////"application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createCreditRequest != null && createCreditRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createCreditRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createCreditRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCredit", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2014>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2014) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2014)));
        }

        /// <summary>
        /// Process a Credit POST to the credit resource to credit funds to a specified credit card.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCreditRequest"></param>
        /// <returns>Task of InlineResponse2014</returns>
        public async System.Threading.Tasks.Task<InlineResponse2014> CreateCreditAsync (CreateCreditRequest createCreditRequest)
        {
             ApiResponse<InlineResponse2014> localVarResponse = await CreateCreditAsyncWithHttpInfo(createCreditRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Process a Credit POST to the credit resource to credit funds to a specified credit card.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCreditRequest"></param>
        /// <returns>Task of ApiResponse (InlineResponse2014)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2014>> CreateCreditAsyncWithHttpInfo (CreateCreditRequest createCreditRequest)
        {
            // verify the required parameter 'createCreditRequest' is set
            if (createCreditRequest == null)
                throw new ApiException(400, "Missing required parameter 'createCreditRequest' when calling CreditApi->CreateCredit");

            var localVarPath = "/pts/v2/credits/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                ////"application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createCreditRequest != null && createCreditRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createCreditRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createCreditRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCredit", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2014>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2014) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2014)));
        }

        /// <summary>
        /// Retrieve a Credit Include the credit ID in the GET request to return details of the credit.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The credit ID returned from a previous stand-alone credit request. </param>
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 GetCredit (string id)
        {
             ApiResponse<InlineResponse2006> localVarResponse = GetCreditWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a Credit Include the credit ID in the GET request to return details of the credit.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The credit ID returned from a previous stand-alone credit request. </param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        public ApiResponse< InlineResponse2006 > GetCreditWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CreditApi->GetCredit");

            var localVarPath = "/pts/v2/credits/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                ////"application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCredit", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
        }

        /// <summary>
        /// Retrieve a Credit Include the credit ID in the GET request to return details of the credit.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The credit ID returned from a previous stand-alone credit request. </param>
        /// <returns>Task of InlineResponse2006</returns>
        public async System.Threading.Tasks.Task<InlineResponse2006> GetCreditAsync (string id)
        {
             ApiResponse<InlineResponse2006> localVarResponse = await GetCreditAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a Credit Include the credit ID in the GET request to return details of the credit.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The credit ID returned from a previous stand-alone credit request. </param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> GetCreditAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CreditApi->GetCredit");

            var localVarPath = "/pts/v2/credits/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                ////"application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCredit", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
        }

    }
}
