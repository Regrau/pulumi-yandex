// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsArgs : global::Pulumi.ResourceArgs
    {
        [Input("authSource")]
        public Input<string>? AuthSource { get; set; }

        [Input("mdbClusterId")]
        public Input<string>? MdbClusterId { get; set; }

        [Input("onPremise")]
        public Input<Inputs.DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsOnPremiseArgs>? OnPremise { get; set; }

        [Input("password")]
        public Input<Inputs.DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsPasswordArgs>? Password { get; set; }

        [Input("user")]
        public Input<string>? User { get; set; }

        public DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsArgs()
        {
        }
        public static new DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsArgs Empty => new DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsArgs();
    }
}
