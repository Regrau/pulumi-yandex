// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsClickhouseTargetConnectionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Connection options. The structure is documented below.
        /// </summary>
        [Input("connectionOptions")]
        public Input<Inputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsArgs>? ConnectionOptions { get; set; }

        public DatatransferEndpointSettingsClickhouseTargetConnectionArgs()
        {
        }
        public static new DatatransferEndpointSettingsClickhouseTargetConnectionArgs Empty => new DatatransferEndpointSettingsClickhouseTargetConnectionArgs();
    }
}
