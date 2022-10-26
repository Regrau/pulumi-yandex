// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsPostgresTargetArgs : global::Pulumi.ResourceArgs
    {
        [Input("connection")]
        public Input<Inputs.DatatransferEndpointSettingsPostgresTargetConnectionArgs>? Connection { get; set; }

        [Input("database")]
        public Input<string>? Database { get; set; }

        [Input("password")]
        public Input<Inputs.DatatransferEndpointSettingsPostgresTargetPasswordArgs>? Password { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        [Input("user")]
        public Input<string>? User { get; set; }

        public DatatransferEndpointSettingsPostgresTargetArgs()
        {
        }
        public static new DatatransferEndpointSettingsPostgresTargetArgs Empty => new DatatransferEndpointSettingsPostgresTargetArgs();
    }
}
