// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class YdbDatabaseServerlessServerlessDatabaseGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("enableThrottlingRcuLimit")]
        public Input<bool>? EnableThrottlingRcuLimit { get; set; }

        [Input("provisionedRcuLimit")]
        public Input<int>? ProvisionedRcuLimit { get; set; }

        [Input("storageSizeLimit")]
        public Input<int>? StorageSizeLimit { get; set; }

        [Input("throttlingRcuLimit")]
        public Input<int>? ThrottlingRcuLimit { get; set; }

        public YdbDatabaseServerlessServerlessDatabaseGetArgs()
        {
        }
        public static new YdbDatabaseServerlessServerlessDatabaseGetArgs Empty => new YdbDatabaseServerlessServerlessDatabaseGetArgs();
    }
}
