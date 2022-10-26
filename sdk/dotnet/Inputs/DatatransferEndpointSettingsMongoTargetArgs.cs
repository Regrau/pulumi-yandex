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
        [Input("cleanupPolicy")]
        public Input<string>? CleanupPolicy { get; set; }

        [Input("connection")]
        public Input<Inputs.DatatransferEndpointSettingsMongoTargetConnectionArgs>? Connection { get; set; }

        [Input("database")]
        public Input<string>? Database { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public DatatransferEndpointSettingsMongoTargetArgs()
        {
        }
        public static new DatatransferEndpointSettingsMongoTargetArgs Empty => new DatatransferEndpointSettingsMongoTargetArgs();
    }
}
