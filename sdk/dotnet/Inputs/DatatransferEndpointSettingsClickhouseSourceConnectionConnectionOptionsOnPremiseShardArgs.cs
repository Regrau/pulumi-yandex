// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseShardArgs : global::Pulumi.ResourceArgs
    {
        [Input("hosts")]
        private InputList<string>? _hosts;

        /// <summary>
        /// List of ClickHouse server host names.
        /// </summary>
        public InputList<string> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<string>());
            set => _hosts = value;
        }

        /// <summary>
        /// Arbitrary shard name. This name may be used in `sharding` block to specify custom sharding rules.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseShardArgs()
        {
        }
        public static new DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseShardArgs Empty => new DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseShardArgs();
    }
}
