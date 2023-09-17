// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetCdnResourceOptionsArgs : global::Pulumi.InvokeArgs
    {
        [Input("allowedHttpMethods", required: true)]
        private List<string>? _allowedHttpMethods;

        /// <summary>
        /// HTTP methods for your CDN content. By default the following methods are allowed: GET, HEAD, POST, PUT, PATCH, DELETE, OPTIONS. In case some methods are not allowed to the user, they will get the 405 (Method Not Allowed) response. If the method is not supported, the user gets the 501 (Not Implemented) response.
        /// </summary>
        public List<string> AllowedHttpMethods
        {
            get => _allowedHttpMethods ?? (_allowedHttpMethods = new List<string>());
            set => _allowedHttpMethods = value;
        }

        /// <summary>
        /// set up a cache period for the end-users browser. Content will be cached due to origin settings. If there are no cache settings on your origin, the content will not be cached. The list of HTTP response codes that can be cached in browsers: 200, 201, 204, 206, 301, 302, 303, 304, 307, 308. Other response codes will not be cached. The default value is 4 days.
        /// </summary>
        [Input("browserCacheSettings", required: true)]
        public int BrowserCacheSettings { get; set; }

        [Input("cacheHttpHeaders", required: true)]
        private List<string>? _cacheHttpHeaders;

        /// <summary>
        /// list HTTP headers that must be included in responses to clients.
        /// </summary>
        public List<string> CacheHttpHeaders
        {
            get => _cacheHttpHeaders ?? (_cacheHttpHeaders = new List<string>());
            set => _cacheHttpHeaders = value;
        }

        [Input("cors", required: true)]
        private List<string>? _cors;

        /// <summary>
        /// parameter that lets browsers get access to selected resources from a domain different to a domain from which the request is received.
        /// </summary>
        public List<string> Cors
        {
            get => _cors ?? (_cors = new List<string>());
            set => _cors = value;
        }

        /// <summary>
        /// custom value for the Host header. Your server must be able to process requests with the chosen header.
        /// </summary>
        [Input("customHostHeader", required: true)]
        public string CustomHostHeader { get; set; } = null!;

        /// <summary>
        /// wildcard additional CNAME. If a resource has a wildcard additional CNAME, you can use your own certificate for content delivery via HTTPS. Read-only.
        /// </summary>
        [Input("customServerName", required: true)]
        public string CustomServerName { get; set; } = null!;

        /// <summary>
        /// setup a cache status.
        /// </summary>
        [Input("disableCache", required: true)]
        public bool DisableCache { get; set; }

        /// <summary>
        /// disabling proxy force ranges.
        /// </summary>
        [Input("disableProxyForceRanges", required: true)]
        public bool DisableProxyForceRanges { get; set; }

        /// <summary>
        /// content will be cached according to origin cache settings. The value applies for a response with codes 200, 201, 204, 206, 301, 302, 303, 304, 307, 308 if an origin server does not have caching HTTP headers. Responses with other codes will not be cached.
        /// </summary>
        [Input("edgeCacheSettings", required: true)]
        public int EdgeCacheSettings { get; set; }

        /// <summary>
        /// option helps you to reduce the bandwidth between origin and CDN servers. Also, content delivery speed becomes higher because of reducing the time for compressing files in a CDN.
        /// </summary>
        [Input("fetchedCompressed", required: true)]
        public bool FetchedCompressed { get; set; }

        /// <summary>
        /// choose the Forward Host header option if is important to send in the request to the Origin the same Host header as was sent in the request to CDN server.
        /// </summary>
        [Input("forwardHostHeader", required: true)]
        public bool ForwardHostHeader { get; set; }

        /// <summary>
        /// GZip compression at CDN servers reduces file size by 70% and can be as high as 90%.
        /// </summary>
        [Input("gzipOn", required: true)]
        public bool GzipOn { get; set; }

        /// <summary>
        /// set for ignoring cookie.
        /// </summary>
        [Input("ignoreCookie", required: true)]
        public bool IgnoreCookie { get; set; }

        /// <summary>
        /// files with different query parameters are cached as objects with the same key regardless of the parameter value. selected by default.
        /// </summary>
        [Input("ignoreQueryParams", required: true)]
        public bool IgnoreQueryParams { get; set; }

        /// <summary>
        /// allows caching for GET, HEAD and POST requests.
        /// </summary>
        [Input("proxyCacheMethodsSet", required: true)]
        public bool ProxyCacheMethodsSet { get; set; }

        [Input("queryParamsBlacklists", required: true)]
        private List<string>? _queryParamsBlacklists;

        /// <summary>
        /// files with the specified query parameters are cached as objects with the same key, files with other parameters are cached as objects with different keys.
        /// </summary>
        public List<string> QueryParamsBlacklists
        {
            get => _queryParamsBlacklists ?? (_queryParamsBlacklists = new List<string>());
            set => _queryParamsBlacklists = value;
        }

        [Input("queryParamsWhitelists", required: true)]
        private List<string>? _queryParamsWhitelists;

        /// <summary>
        /// files with the specified query parameters are cached as objects with different keys, files with other parameters are cached as objects with the same key.
        /// </summary>
        public List<string> QueryParamsWhitelists
        {
            get => _queryParamsWhitelists ?? (_queryParamsWhitelists = new List<string>());
            set => _queryParamsWhitelists = value;
        }

        /// <summary>
        /// set up a redirect from HTTPS to HTTP.
        /// </summary>
        [Input("redirectHttpToHttps", required: true)]
        public bool RedirectHttpToHttps { get; set; }

        /// <summary>
        /// set up a redirect from HTTP to HTTPS.
        /// </summary>
        [Input("redirectHttpsToHttp", required: true)]
        public bool RedirectHttpsToHttp { get; set; }

        /// <summary>
        /// files larger than 10 MB will be requested and cached in parts (no larger than 10 MB each part). It reduces time to first byte. The origin must support HTTP Range requests.
        /// </summary>
        [Input("slice", required: true)]
        public bool Slice { get; set; }

        [Input("staticRequestHeaders", required: true)]
        private Dictionary<string, string>? _staticRequestHeaders;

        /// <summary>
        /// set up custom headers that CDN servers send in requests to origins.
        /// </summary>
        public Dictionary<string, string> StaticRequestHeaders
        {
            get => _staticRequestHeaders ?? (_staticRequestHeaders = new Dictionary<string, string>());
            set => _staticRequestHeaders = value;
        }

        [Input("staticResponseHeaders", required: true)]
        private Dictionary<string, string>? _staticResponseHeaders;
        public Dictionary<string, string> StaticResponseHeaders
        {
            get => _staticResponseHeaders ?? (_staticResponseHeaders = new Dictionary<string, string>());
            set => _staticResponseHeaders = value;
        }

        public GetCdnResourceOptionsArgs()
        {
        }
        public static new GetCdnResourceOptionsArgs Empty => new GetCdnResourceOptionsArgs();
    }
}
