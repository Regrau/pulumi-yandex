// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbElasticSearchClusterConfigDataNodeResourcesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("diskSize", required: true)]
        public Input<int> DiskSize { get; set; } = null!;

        [Input("diskTypeId", required: true)]
        public Input<string> DiskTypeId { get; set; } = null!;

        [Input("resourcePresetId", required: true)]
        public Input<string> ResourcePresetId { get; set; } = null!;

        public MdbElasticSearchClusterConfigDataNodeResourcesGetArgs()
        {
        }
        public static new MdbElasticSearchClusterConfigDataNodeResourcesGetArgs Empty => new MdbElasticSearchClusterConfigDataNodeResourcesGetArgs();
    }
}
