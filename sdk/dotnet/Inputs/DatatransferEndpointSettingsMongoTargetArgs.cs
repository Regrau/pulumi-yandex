// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsMongoTargetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// How to clean collections when activating the transfer. One of "DISABLED", "DROP" or "TRUNCATE".
        /// </summary>
        [Input("cleanupPolicy")]
        public Input<string>? CleanupPolicy { get; set; }

        /// <summary>
        /// Connection settings. The structure is documented below.
        /// </summary>
        [Input("connection")]
        public Input<Inputs.DatatransferEndpointSettingsMongoTargetConnectionArgs>? Connection { get; set; }

        /// <summary>
        /// Name of the database to transfer.
        /// </summary>
        [Input("database")]
        public Input<string>? Database { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;

        /// <summary>
        /// List of security groups that the transfer associated with this endpoint should use.
        /// </summary>
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        /// <summary>
        /// Identifier of the Yandex Cloud VPC subnetwork to user for accessing the database. If omitted, the server has to be accessible via Internet.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public DatatransferEndpointSettingsMongoTargetArgs()
        {
        }
        public static new DatatransferEndpointSettingsMongoTargetArgs Empty => new DatatransferEndpointSettingsMongoTargetArgs();
    }
}
