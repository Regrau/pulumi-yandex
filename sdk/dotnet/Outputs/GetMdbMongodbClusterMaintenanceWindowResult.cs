// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class GetMdbMongodbClusterMaintenanceWindowResult
    {
        public readonly string? Day;
        public readonly int? Hour;
        public readonly string? Type;

        [OutputConstructor]
        private GetMdbMongodbClusterMaintenanceWindowResult(
            string? day,

            int? hour,

            string? type)
        {
            Day = day;
            Hour = hour;
            Type = type;
        }
    }
}
