// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterZookeeperResourcesArgs : global::Pulumi.ResourceArgs
    {
        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        [Input("diskTypeId")]
        public Input<string>? DiskTypeId { get; set; }

        [Input("resourcePresetId")]
        public Input<string>? ResourcePresetId { get; set; }

        public MdbClickhouseClusterZookeeperResourcesArgs()
        {
        }
        public static new MdbClickhouseClusterZookeeperResourcesArgs Empty => new MdbClickhouseClusterZookeeperResourcesArgs();
    }
}
