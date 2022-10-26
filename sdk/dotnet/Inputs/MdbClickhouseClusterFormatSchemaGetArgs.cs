// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterFormatSchemaGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Graphite rollup configuration name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Type of maintenance window. Can be either `ANYTIME` or `WEEKLY`. A day and hour of window need to be specified with weekly window.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Model file URL. You can only use models stored in Yandex Object Storage.
        /// </summary>
        [Input("uri", required: true)]
        public Input<string> Uri { get; set; } = null!;

        public MdbClickhouseClusterFormatSchemaGetArgs()
        {
        }
        public static new MdbClickhouseClusterFormatSchemaGetArgs Empty => new MdbClickhouseClusterFormatSchemaGetArgs();
    }
}
