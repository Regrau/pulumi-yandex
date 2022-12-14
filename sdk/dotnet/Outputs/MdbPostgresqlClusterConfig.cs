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
    public sealed class MdbPostgresqlClusterConfig
    {
        public readonly Outputs.MdbPostgresqlClusterConfigAccess? Access;
        public readonly bool? Autofailover;
        public readonly int? BackupRetainPeriodDays;
        public readonly Outputs.MdbPostgresqlClusterConfigBackupWindowStart? BackupWindowStart;
        public readonly Outputs.MdbPostgresqlClusterConfigPerformanceDiagnostics? PerformanceDiagnostics;
        public readonly Outputs.MdbPostgresqlClusterConfigPoolerConfig? PoolerConfig;
        public readonly ImmutableDictionary<string, string>? PostgresqlConfig;
        public readonly Outputs.MdbPostgresqlClusterConfigResources Resources;
        public readonly string Version;

        [OutputConstructor]
        private MdbPostgresqlClusterConfig(
            Outputs.MdbPostgresqlClusterConfigAccess? access,

            bool? autofailover,

            int? backupRetainPeriodDays,

            Outputs.MdbPostgresqlClusterConfigBackupWindowStart? backupWindowStart,

            Outputs.MdbPostgresqlClusterConfigPerformanceDiagnostics? performanceDiagnostics,

            Outputs.MdbPostgresqlClusterConfigPoolerConfig? poolerConfig,

            ImmutableDictionary<string, string>? postgresqlConfig,

            Outputs.MdbPostgresqlClusterConfigResources resources,

            string version)
        {
            Access = access;
            Autofailover = autofailover;
            BackupRetainPeriodDays = backupRetainPeriodDays;
            BackupWindowStart = backupWindowStart;
            PerformanceDiagnostics = performanceDiagnostics;
            PoolerConfig = poolerConfig;
            PostgresqlConfig = postgresqlConfig;
            Resources = resources;
            Version = version;
        }
    }
}
