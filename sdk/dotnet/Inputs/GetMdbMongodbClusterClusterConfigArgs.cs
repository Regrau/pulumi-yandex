// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterClusterConfigInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Access policy to MongoDB cluster. The structure is documented below.
        /// </summary>
        [Input("access", required: true)]
        public Input<Inputs.GetMdbMongodbClusterClusterConfigAccessInputArgs> Access { get; set; } = null!;

        [Input("backupRetainPeriodDays", required: true)]
        public Input<int> BackupRetainPeriodDays { get; set; } = null!;

        /// <summary>
        /// Time to start the daily backup, in the UTC timezone. The structure is documented below.
        /// </summary>
        [Input("backupWindowStart", required: true)]
        public Input<Inputs.GetMdbMongodbClusterClusterConfigBackupWindowStartInputArgs> BackupWindowStart { get; set; } = null!;

        /// <summary>
        /// Feature compatibility version of MongoDB.
        /// </summary>
        [Input("featureCompatibilityVersion", required: true)]
        public Input<string> FeatureCompatibilityVersion { get; set; } = null!;

        [Input("mongocfg", required: true)]
        public Input<Inputs.GetMdbMongodbClusterClusterConfigMongocfgInputArgs> Mongocfg { get; set; } = null!;

        /// <summary>
        /// (Optional) Configuration of the mongod service. The structure is documented below.
        /// </summary>
        [Input("mongod", required: true)]
        public Input<Inputs.GetMdbMongodbClusterClusterConfigMongodInputArgs> Mongod { get; set; } = null!;

        [Input("mongos", required: true)]
        public Input<Inputs.GetMdbMongodbClusterClusterConfigMongosInputArgs> Mongos { get; set; } = null!;

        [Input("performanceDiagnostics", required: true)]
        public Input<Inputs.GetMdbMongodbClusterClusterConfigPerformanceDiagnosticsInputArgs> PerformanceDiagnostics { get; set; } = null!;

        /// <summary>
        /// Version of MongoDB (either 6.0, 6.0-enterprise, 5.0, 5.0-enterprise, 4.4, 4.4-enterprise, 4.2).
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public GetMdbMongodbClusterClusterConfigInputArgs()
        {
        }
        public static new GetMdbMongodbClusterClusterConfigInputArgs Empty => new GetMdbMongodbClusterClusterConfigInputArgs();
    }
}
