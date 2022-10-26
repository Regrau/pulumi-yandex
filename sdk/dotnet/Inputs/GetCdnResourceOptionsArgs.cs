// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetCdnResourceOptionsInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowedHttpMethods", required: true)]
        private InputList<string>? _allowedHttpMethods;
        public InputList<string> AllowedHttpMethods
        {
            get => _allowedHttpMethods ?? (_allowedHttpMethods = new InputList<string>());
            set => _allowedHttpMethods = value;
        }

        [Input("browserCacheSettings", required: true)]
        public Input<int> BrowserCacheSettings { get; set; } = null!;

        [Input("cacheHttpHeaders", required: true)]
        private InputList<string>? _cacheHttpHeaders;
        public InputList<string> CacheHttpHeaders
        {
            get => _cacheHttpHeaders ?? (_cacheHttpHeaders = new InputList<string>());
            set => _cacheHttpHeaders = value;
        }

        [Input("cors", required: true)]
        private InputList<string>? _cors;
        public InputList<string> Cors
        {
            get => _cors ?? (_cors = new InputList<string>());
            set => _cors = value;
        }

        [Input("customHostHeader", required: true)]
        public Input<string> CustomHostHeader { get; set; } = null!;

        [Input("customServerName", required: true)]
        public Input<string> CustomServerName { get; set; } = null!;

        [Input("disableCache", required: true)]
        public Input<bool> DisableCache { get; set; } = null!;

        [Input("disableProxyForceRanges", required: true)]
        public Input<bool> DisableProxyForceRanges { get; set; } = null!;

        [Input("edgeCacheSettings", required: true)]
        public Input<int> EdgeCacheSettings { get; set; } = null!;

        [Input("fetchedCompressed", required: true)]
        public Input<bool> FetchedCompressed { get; set; } = null!;

        [Input("forwardHostHeader", required: true)]
        public Input<bool> ForwardHostHeader { get; set; } = null!;

        [Input("gzipOn", required: true)]
        public Input<bool> GzipOn { get; set; } = null!;

        [Input("ignoreCookie", required: true)]
        public Input<bool> IgnoreCookie { get; set; } = null!;

        [Input("ignoreQueryParams", required: true)]
        public Input<bool> IgnoreQueryParams { get; set; } = null!;

        [Input("proxyCacheMethodsSet", required: true)]
        public Input<bool> ProxyCacheMethodsSet { get; set; } = null!;

        [Input("queryParamsBlacklists", required: true)]
        private InputList<string>? _queryParamsBlacklists;
        public InputList<string> QueryParamsBlacklists
        {
            get => _queryParamsBlacklists ?? (_queryParamsBlacklists = new InputList<string>());
            set => _queryParamsBlacklists = value;
        }

        [Input("queryParamsWhitelists", required: true)]
        private InputList<string>? _queryParamsWhitelists;
        public InputList<string> QueryParamsWhitelists
        {
            get => _queryParamsWhitelists ?? (_queryParamsWhitelists = new InputList<string>());
            set => _queryParamsWhitelists = value;
        }

        [Input("redirectHttpToHttps", required: true)]
        public Input<bool> RedirectHttpToHttps { get; set; } = null!;

        [Input("redirectHttpsToHttp", required: true)]
        public Input<bool> RedirectHttpsToHttp { get; set; } = null!;

        [Input("slice", required: true)]
        public Input<bool> Slice { get; set; } = null!;

        [Input("staticRequestHeaders", required: true)]
        private InputList<string>? _staticRequestHeaders;
        public InputList<string> StaticRequestHeaders
        {
            get => _staticRequestHeaders ?? (_staticRequestHeaders = new InputList<string>());
            set => _staticRequestHeaders = value;
        }

        [Input("staticResponseHeaders", required: true)]
        private InputMap<string>? _staticResponseHeaders;
        public InputMap<string> StaticResponseHeaders
        {
            get => _staticResponseHeaders ?? (_staticResponseHeaders = new InputMap<string>());
            set => _staticResponseHeaders = value;
        }

        public GetCdnResourceOptionsInputArgs()
        {
        }
        public static new GetCdnResourceOptionsInputArgs Empty => new GetCdnResourceOptionsInputArgs();
    }
}
