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
    public sealed class DatatransferEndpointSettingsMongoSourceConnectionConnectionOptions
    {
        /// <summary>
        /// Name of the database associated with the credentials.
        /// </summary>
        public readonly string? AuthSource;
        /// <summary>
        /// Identifier of the Managed ClickHouse cluster.
        /// </summary>
        public readonly string? MdbClusterId;
        /// <summary>
        /// Connection settings of the on-premise ClickHouse server.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsOnPremise? OnPremise;
        /// <summary>
        /// Password for the database access. This is a block with a single field named `raw` which should contain the password.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsPassword? Password;
        /// <summary>
        /// User for database access.
        /// </summary>
        public readonly string? User;

        [OutputConstructor]
        private DatatransferEndpointSettingsMongoSourceConnectionConnectionOptions(
            string? authSource,

            string? mdbClusterId,

            Outputs.DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsOnPremise? onPremise,

            Outputs.DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsPassword? password,

            string? user)
        {
            AuthSource = authSource;
            MdbClusterId = mdbClusterId;
            OnPremise = onPremise;
            Password = password;
            User = user;
        }
    }
}
