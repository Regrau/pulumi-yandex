// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterFormatSchemaInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the ClickHouse cluster.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Type of maintenance window. Can be either `ANYTIME` or `WEEKLY`. A day and hour of window need to be specified with weekly window.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Model file URL. You can only use models stored in Yandex Object Storage.
        /// </summary>
        [Input("uri")]
        public Input<string>? Uri { get; set; }

        public GetMdbClickhouseClusterFormatSchemaInputArgs()
        {
        }
        public static new GetMdbClickhouseClusterFormatSchemaInputArgs Empty => new GetMdbClickhouseClusterFormatSchemaInputArgs();
    }
}
