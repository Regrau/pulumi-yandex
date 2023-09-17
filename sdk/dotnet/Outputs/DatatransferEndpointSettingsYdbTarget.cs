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
    public sealed class DatatransferEndpointSettingsYdbTarget
    {
        /// <summary>
        /// How to clean collections when activating the transfer. One of "DISABLED", "DROP" or "TRUNCATE".
        /// </summary>
        public readonly string? CleanupPolicy;
        /// <summary>
        /// Name of the database to transfer.
        /// </summary>
        public readonly string? Database;
        public readonly string? Instance;
        /// <summary>
        /// Path to the field.
        /// </summary>
        public readonly string? Path;
        public readonly string? SaKeyContent;
        /// <summary>
        /// List of security groups that the transfer associated with this endpoint should use.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroups;
        public readonly string? ServiceAccountId;
        /// <summary>
        /// Identifier of the Yandex Cloud VPC subnetwork to user for accessing the database. If omitted, the server has to be accessible via Internet.
        /// </summary>
        public readonly string? SubnetId;

        [OutputConstructor]
        private DatatransferEndpointSettingsYdbTarget(
            string? cleanupPolicy,

            string? database,

            string? instance,

            string? path,

            string? saKeyContent,

            ImmutableArray<string> securityGroups,

            string? serviceAccountId,

            string? subnetId)
        {
            CleanupPolicy = cleanupPolicy;
            Database = database;
            Instance = instance;
            Path = path;
            SaKeyContent = saKeyContent;
            SecurityGroups = securityGroups;
            ServiceAccountId = serviceAccountId;
            SubnetId = subnetId;
        }
    }
}
