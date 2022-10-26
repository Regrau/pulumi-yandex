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
    public sealed class GetMdbMongodbClusterClusterConfigResult
    {
        /// <summary>
        /// Access policy to MongoDB cluster. The structure is documented below.
        /// </summary>
        public readonly Outputs.GetMdbMongodbClusterClusterConfigAccessResult Access;
        /// <summary>
        /// Time to start the daily backup, in the UTC timezone. The structure is documented below.
        /// </summary>
        public readonly Outputs.GetMdbMongodbClusterClusterConfigBackupWindowStartResult BackupWindowStart;
        /// <summary>
        /// Feature compatibility version of MongoDB.
        /// </summary>
        public readonly string FeatureCompatibilityVersion;
        /// <summary>
        /// (Optional) Configuration of the mongod service. The structure is documented below.
        /// </summary>
        public readonly Outputs.GetMdbMongodbClusterClusterConfigMongodResult Mongod;
        /// <summary>
        /// Version of MongoDB (either 5.0, 5.0-enterprise, 4.4, 4.4-enterprise, 4.2, 4.0 or 3.6).
        /// </summary>
        public readonly string? Version;

        [OutputConstructor]
        private GetMdbMongodbClusterClusterConfigResult(
            Outputs.GetMdbMongodbClusterClusterConfigAccessResult access,

            Outputs.GetMdbMongodbClusterClusterConfigBackupWindowStartResult backupWindowStart,

            string featureCompatibilityVersion,

            Outputs.GetMdbMongodbClusterClusterConfigMongodResult mongod,

            string? version)
        {
            Access = access;
            BackupWindowStart = backupWindowStart;
            FeatureCompatibilityVersion = featureCompatibilityVersion;
            Mongod = mongod;
            Version = version;
        }
    }
}
