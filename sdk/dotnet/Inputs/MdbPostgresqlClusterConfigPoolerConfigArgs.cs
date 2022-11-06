// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbPostgresqlClusterConfigPoolerConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Setting `pool_discard` [parameter in Odyssey](https://github.com/yandex/odyssey/blob/master/documentation/configuration.md#pool_discard-yesno).
        /// </summary>
        [Input("poolDiscard")]
        public Input<bool>? PoolDiscard { get; set; }

        /// <summary>
        /// Mode that the connection pooler is working in. See descriptions of all modes in the [documentation for Odyssey](https://github.com/yandex/odyssey/blob/master/documentation/configuration.md#pool-string.
        /// </summary>
        [Input("poolingMode")]
        public Input<string>? PoolingMode { get; set; }

        public MdbPostgresqlClusterConfigPoolerConfigArgs()
        {
        }
        public static new MdbPostgresqlClusterConfigPoolerConfigArgs Empty => new MdbPostgresqlClusterConfigPoolerConfigArgs();
    }
}
