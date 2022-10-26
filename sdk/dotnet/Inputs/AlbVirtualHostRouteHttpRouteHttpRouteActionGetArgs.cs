// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbVirtualHostRouteHttpRouteHttpRouteActionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If set, will automatically rewrite host.
        /// </summary>
        [Input("autoHostRewrite")]
        public Input<bool>? AutoHostRewrite { get; set; }

        /// <summary>
        /// Backend group to route requests.
        /// </summary>
        [Input("backendGroupId", required: true)]
        public Input<string> BackendGroupId { get; set; } = null!;

        /// <summary>
        /// Host rewrite specifier.
        /// </summary>
        [Input("hostRewrite")]
        public Input<string>? HostRewrite { get; set; }

        /// <summary>
        /// Specifies the idle timeout (time without any data transfer for the active request) for the
        /// route. It is useful for streaming scenarios - one should set idle_timeout to something meaningful and max_timeout
        /// to the maximum time the stream is allowed to be alive. If not specified, there is no
        /// per-route idle timeout.
        /// </summary>
        [Input("idleTimeout")]
        public Input<string>? IdleTimeout { get; set; }

        /// <summary>
        /// If not empty, matched path prefix will be replaced by this value.
        /// </summary>
        [Input("prefixRewrite")]
        public Input<string>? PrefixRewrite { get; set; }

        /// <summary>
        /// Specifies the request timeout (overall time request processing is allowed to take) for the 
        /// route. If not set, default is 60 seconds.
        /// </summary>
        [Input("timeout")]
        public Input<string>? Timeout { get; set; }

        [Input("upgradeTypes")]
        private InputList<string>? _upgradeTypes;

        /// <summary>
        /// List of upgrade types. Only specified upgrade types will be allowed. For example, 
        /// "websocket".
        /// </summary>
        public InputList<string> UpgradeTypes
        {
            get => _upgradeTypes ?? (_upgradeTypes = new InputList<string>());
            set => _upgradeTypes = value;
        }

        public AlbVirtualHostRouteHttpRouteHttpRouteActionGetArgs()
        {
        }
        public static new AlbVirtualHostRouteHttpRouteHttpRouteActionGetArgs Empty => new AlbVirtualHostRouteHttpRouteHttpRouteActionGetArgs();
    }
}
