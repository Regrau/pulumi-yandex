// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbPostgresqlClusterRestoreGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("backupId", required: true)]
        public Input<string> BackupId { get; set; } = null!;

        [Input("time")]
        public Input<string>? Time { get; set; }

        [Input("timeInclusive")]
        public Input<bool>? TimeInclusive { get; set; }

        public MdbPostgresqlClusterRestoreGetArgs()
        {
        }
        public static new MdbPostgresqlClusterRestoreGetArgs Empty => new MdbPostgresqlClusterRestoreGetArgs();
    }
}
