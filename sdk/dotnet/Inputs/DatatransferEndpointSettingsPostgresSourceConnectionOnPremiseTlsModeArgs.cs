// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeArgs : global::Pulumi.ResourceArgs
    {
        [Input("disabled")]
        public Input<Inputs.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeDisabledArgs>? Disabled { get; set; }

        [Input("enabled")]
        public Input<Inputs.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeEnabledArgs>? Enabled { get; set; }

        public DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeArgs()
        {
        }
        public static new DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeArgs Empty => new DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeArgs();
    }
}
