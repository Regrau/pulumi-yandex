// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsMysqlTargetArgs : global::Pulumi.ResourceArgs
    {
        [Input("connection")]
        public Input<Inputs.DatatransferEndpointSettingsMysqlTargetConnectionArgs>? Connection { get; set; }

        [Input("database")]
        public Input<string>? Database { get; set; }

        [Input("password")]
        public Input<Inputs.DatatransferEndpointSettingsMysqlTargetPasswordArgs>? Password { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        [Input("skipConstraintChecks")]
        public Input<bool>? SkipConstraintChecks { get; set; }

        [Input("sqlMode")]
        public Input<string>? SqlMode { get; set; }

        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        [Input("user")]
        public Input<string>? User { get; set; }

        public DatatransferEndpointSettingsMysqlTargetArgs()
        {
        }
        public static new DatatransferEndpointSettingsMysqlTargetArgs Empty => new DatatransferEndpointSettingsMysqlTargetArgs();
    }
}
