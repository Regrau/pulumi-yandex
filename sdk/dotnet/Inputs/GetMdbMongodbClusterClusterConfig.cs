// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterClusterConfigArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Access policy to MongoDB cluster. The structure is documented below.
        /// </summary>
        [Input("access", required: true)]
        public Inputs.GetMdbMongodbClusterClusterConfigAccessArgs Access { get; set; } = null!;

        /// <summary>
        /// Time to start the daily backup, in the UTC timezone. The structure is documented below.
        /// </summary>
        [Input("backupWindowStart", required: true)]
        public Inputs.GetMdbMongodbClusterClusterConfigBackupWindowStartArgs BackupWindowStart { get; set; } = null!;

        /// <summary>
        /// Feature compatibility version of MongoDB.
        /// </summary>
        [Input("featureCompatibilityVersion", required: true)]
        public string FeatureCompatibilityVersion { get; set; } = null!;

        /// <summary>
        /// (Optional) Configuration of the mongod service. The structure is documented below.
        /// </summary>
        [Input("mongod", required: true)]
        public Inputs.GetMdbMongodbClusterClusterConfigMongodArgs Mongod { get; set; } = null!;

        /// <summary>
        /// Version of MongoDB (either 5.0, 5.0-enterprise, 4.4, 4.4-enterprise, 4.2, 4.0 or 3.6).
        /// </summary>
        [Input("version")]
        public string? Version { get; set; }

        public GetMdbMongodbClusterClusterConfigArgs()
        {
        }
        public static new GetMdbMongodbClusterClusterConfigArgs Empty => new GetMdbMongodbClusterClusterConfigArgs();
    }
}
