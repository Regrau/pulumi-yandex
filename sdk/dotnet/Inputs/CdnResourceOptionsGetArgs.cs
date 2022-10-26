// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class CdnResourceOptionsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowedHttpMethods")]
        private InputList<string>? _allowedHttpMethods;
        public InputList<string> AllowedHttpMethods
        {
            get => _allowedHttpMethods ?? (_allowedHttpMethods = new InputList<string>());
            set => _allowedHttpMethods = value;
        }

        [Input("browserCacheSettings")]
        public Input<int>? BrowserCacheSettings { get; set; }

        [Input("cacheHttpHeaders")]
        private InputList<string>? _cacheHttpHeaders;
        public InputList<string> CacheHttpHeaders
        {
            get => _cacheHttpHeaders ?? (_cacheHttpHeaders = new InputList<string>());
            set => _cacheHttpHeaders = value;
        }

        [Input("cors")]
        private InputList<string>? _cors;
        public InputList<string> Cors
        {
            get => _cors ?? (_cors = new InputList<string>());
            set => _cors = value;
        }

        [Input("customHostHeader")]
        public Input<string>? CustomHostHeader { get; set; }

        [Input("customServerName")]
        public Input<string>? CustomServerName { get; set; }

        [Input("disableCache")]
        public Input<bool>? DisableCache { get; set; }

        [Input("disableProxyForceRanges")]
        public Input<bool>? DisableProxyForceRanges { get; set; }

        [Input("edgeCacheSettings")]
        public Input<int>? EdgeCacheSettings { get; set; }

        [Input("fetchedCompressed")]
        public Input<bool>? FetchedCompressed { get; set; }

        [Input("forwardHostHeader")]
        public Input<bool>? ForwardHostHeader { get; set; }

        [Input("gzipOn")]
        public Input<bool>? GzipOn { get; set; }

        [Input("ignoreCookie")]
        public Input<bool>? IgnoreCookie { get; set; }

        [Input("ignoreQueryParams")]
        public Input<bool>? IgnoreQueryParams { get; set; }

        [Input("proxyCacheMethodsSet")]
        public Input<bool>? ProxyCacheMethodsSet { get; set; }

        [Input("queryParamsBlacklists")]
        private InputList<string>? _queryParamsBlacklists;
        public InputList<string> QueryParamsBlacklists
        {
            get => _queryParamsBlacklists ?? (_queryParamsBlacklists = new InputList<string>());
            set => _queryParamsBlacklists = value;
        }

        [Input("queryParamsWhitelists")]
        private InputList<string>? _queryParamsWhitelists;
        public InputList<string> QueryParamsWhitelists
        {
            get => _queryParamsWhitelists ?? (_queryParamsWhitelists = new InputList<string>());
            set => _queryParamsWhitelists = value;
        }

        [Input("redirectHttpToHttps")]
        public Input<bool>? RedirectHttpToHttps { get; set; }

        [Input("redirectHttpsToHttp")]
        public Input<bool>? RedirectHttpsToHttp { get; set; }

        [Input("slice")]
        public Input<bool>? Slice { get; set; }

        [Input("staticRequestHeaders")]
        private InputList<string>? _staticRequestHeaders;
        public InputList<string> StaticRequestHeaders
        {
            get => _staticRequestHeaders ?? (_staticRequestHeaders = new InputList<string>());
            set => _staticRequestHeaders = value;
        }

        [Input("staticResponseHeaders")]
        private InputMap<string>? _staticResponseHeaders;
        public InputMap<string> StaticResponseHeaders
        {
            get => _staticResponseHeaders ?? (_staticResponseHeaders = new InputMap<string>());
            set => _staticResponseHeaders = value;
        }

        public CdnResourceOptionsGetArgs()
        {
        }
        public static new CdnResourceOptionsGetArgs Empty => new CdnResourceOptionsGetArgs();
    }
}
