// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsOnPremiseTlsModeEnabledGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("caCertificate")]
        public Input<string>? CaCertificate { get; set; }

        public DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsOnPremiseTlsModeEnabledGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsOnPremiseTlsModeEnabledGetArgs Empty => new DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsOnPremiseTlsModeEnabledGetArgs();
    }
}
