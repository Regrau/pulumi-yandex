// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterClusterConfigMongodStorageWiredTigerInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("blockCompressor")]
        public Input<string>? BlockCompressor { get; set; }

        [Input("cacheSizeGb")]
        public Input<double>? CacheSizeGb { get; set; }

        public GetMdbMongodbClusterClusterConfigMongodStorageWiredTigerInputArgs()
        {
        }
        public static new GetMdbMongodbClusterClusterConfigMongodStorageWiredTigerInputArgs Empty => new GetMdbMongodbClusterClusterConfigMongodStorageWiredTigerInputArgs();
    }
}