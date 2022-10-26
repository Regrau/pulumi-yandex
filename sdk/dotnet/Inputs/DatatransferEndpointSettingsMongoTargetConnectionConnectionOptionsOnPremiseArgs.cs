// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseArgs : global::Pulumi.ResourceArgs
    {
        [Input("hosts")]
        private InputList<string>? _hosts;

        /// <summary>
        /// Host names of the replica set.
        /// </summary>
        public InputList<string> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<string>());
            set => _hosts = value;
        }

        /// <summary>
        /// TCP Port number.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// Replica set name.
        /// </summary>
        [Input("replicaSet")]
        public Input<string>? ReplicaSet { get; set; }

        /// <summary>
        /// TLS settings for the server connection. Empty implies plaintext connection. The structure is documented below.
        /// </summary>
        [Input("tlsMode")]
        public Input<Inputs.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsModeArgs>? TlsMode { get; set; }

        public DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseArgs()
        {
        }
        public static new DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseArgs Empty => new DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseArgs();
    }
}
