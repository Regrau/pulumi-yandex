// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbPostgresqlClusterConfigPoolerConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("poolDiscard")]
        public Input<bool>? PoolDiscard { get; set; }

        [Input("poolingMode")]
        public Input<string>? PoolingMode { get; set; }

        public MdbPostgresqlClusterConfigPoolerConfigGetArgs()
        {
        }
        public static new MdbPostgresqlClusterConfigPoolerConfigGetArgs Empty => new MdbPostgresqlClusterConfigPoolerConfigGetArgs();
    }
}
