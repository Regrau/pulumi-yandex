// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsClickhouseTargetAltNameGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("fromName")]
        public Input<string>? FromName { get; set; }

        [Input("toName")]
        public Input<string>? ToName { get; set; }

        public DatatransferEndpointSettingsClickhouseTargetAltNameGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsClickhouseTargetAltNameGetArgs Empty => new DatatransferEndpointSettingsClickhouseTargetAltNameGetArgs();
    }
}
