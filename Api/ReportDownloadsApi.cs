/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
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
    public interface IReportDownloadsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Download a report
        /// </summary>
        /// <remarks>
        /// Download a report using the unique report name and date. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns></returns>
        void DownloadReport (DateTime? reportDate, string reportName, string organizationId = null);

        /// <summary>
        /// Download a report
        /// </summary>
        /// <remarks>
        /// Download a report using the unique report name and date. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DownloadReportWithHttpInfo (DateTime? reportDate, string reportName, string organizationId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Download a report
        /// </summary>
        /// <remarks>
        /// Download a report using the unique report name and date. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DownloadReportAsync (DateTime? reportDate, string reportName, string organizationId = null);

        /// <summary>
        /// Download a report
        /// </summary>
        /// <remarks>
        /// Download a report using the unique report name and date. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DownloadReportAsyncWithHttpInfo (DateTime? reportDate, string reportName, string organizationId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReportDownloadsApi : IReportDownloadsApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDownloadsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportDownloadsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ReportDownloadsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReportDownloadsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            this.Configuration.ApiClient.Configuration = this.Configuration;
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
        /// Download a report Download a report using the unique report name and date. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns></returns>
        public void DownloadReport (DateTime? reportDate, string reportName, string organizationId = null)
        {
             DownloadReportWithHttpInfo(reportDate, reportName, organizationId);
        }

        /// <summary>
        /// Download a report Download a report using the unique report name and date. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DownloadReportWithHttpInfo (DateTime? reportDate, string reportName, string organizationId = null)
        {
            // verify the required parameter 'reportDate' is set
            if (reportDate == null)
                throw new ApiException(400, "Missing required parameter 'reportDate' when calling ReportDownloadsApi->DownloadReport");
            // verify the required parameter 'reportName' is set
            if (reportName == null)
                throw new ApiException(400, "Missing required parameter 'reportName' when calling ReportDownloadsApi->DownloadReport");

            var localVarPath = $"/reporting/v3/report-downloads";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "text/csv"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            if (reportDate != null) localVarQueryParams.Add("reportDate", Configuration.ApiClient.ParameterToString(reportDate.Value.ToString("yyyy-MM-dd"))); // query parameter
            if (reportName != null) localVarQueryParams.Add("reportName", Configuration.ApiClient.ParameterToString(reportName)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DownloadReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                localVarResponse.Content);
        }

        /// <summary>
        /// Download a report Download a report using the unique report name and date. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DownloadReportAsync (DateTime? reportDate, string reportName, string organizationId = null)
        {
             await DownloadReportAsyncWithHttpInfo(reportDate, reportName, organizationId);

        }

        /// <summary>
        /// Download a report Download a report using the unique report name and date. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DownloadReportAsyncWithHttpInfo (DateTime? reportDate, string reportName, string organizationId = null)
        {
            // verify the required parameter 'reportDate' is set
            if (reportDate == null)
                throw new ApiException(400, "Missing required parameter 'reportDate' when calling ReportDownloadsApi->DownloadReport");
            // verify the required parameter 'reportName' is set
            if (reportName == null)
                throw new ApiException(400, "Missing required parameter 'reportName' when calling ReportDownloadsApi->DownloadReport");

            var localVarPath = $"/reporting/v3/report-downloads";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "text/csv"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            if (reportDate != null) localVarQueryParams.Add("reportDate", Configuration.ApiClient.ParameterToString(reportDate.Value.ToString("yyyy-MM-dd"))); // query parameter
            if (reportName != null) localVarQueryParams.Add("reportName", Configuration.ApiClient.ParameterToString(reportName)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DownloadReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                localVarResponse.Content);
        }

    }
}
