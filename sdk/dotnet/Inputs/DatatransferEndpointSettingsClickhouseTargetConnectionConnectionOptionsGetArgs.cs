// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("database")]
        public Input<string>? Database { get; set; }

        [Input("mdbClusterId")]
        public Input<string>? MdbClusterId { get; set; }

        [Input("onPremise")]
        public Input<Inputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremiseGetArgs>? OnPremise { get; set; }

        [Input("password")]
        public Input<Inputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsPasswordGetArgs>? Password { get; set; }

        [Input("user")]
        public Input<string>? User { get; set; }

        public DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsGetArgs Empty => new DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsGetArgs();
    }
}