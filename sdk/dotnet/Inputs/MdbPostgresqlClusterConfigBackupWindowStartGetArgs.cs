// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbPostgresqlClusterConfigBackupWindowStartGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("hours")]
        public Input<int>? Hours { get; set; }

        [Input("minutes")]
        public Input<int>? Minutes { get; set; }

        public MdbPostgresqlClusterConfigBackupWindowStartGetArgs()
        {
        }
        public static new MdbPostgresqlClusterConfigBackupWindowStartGetArgs Empty => new MdbPostgresqlClusterConfigBackupWindowStartGetArgs();
    }
}
