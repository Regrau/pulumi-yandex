// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsMongoSourceConnectionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("connectionOptions")]
        public Input<Inputs.DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsGetArgs>? ConnectionOptions { get; set; }

        public DatatransferEndpointSettingsMongoSourceConnectionGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsMongoSourceConnectionGetArgs Empty => new DatatransferEndpointSettingsMongoSourceConnectionGetArgs();
    }
}
