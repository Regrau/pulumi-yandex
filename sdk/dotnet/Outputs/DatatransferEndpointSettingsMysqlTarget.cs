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
    public sealed class DatatransferEndpointSettingsMysqlTarget
    {
        /// <summary>
        /// Connection settings. The structure is documented below.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsMysqlTargetConnection? Connection;
        /// <summary>
        /// Name of the database to transfer.
        /// </summary>
        public readonly string? Database;
        /// <summary>
        /// Password for the database access. This is a block with a single field named `raw` which should contain the password.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsMysqlTargetPassword? Password;
        /// <summary>
        /// List of security groups that the transfer associated with this endpoint should use.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroups;
        /// <summary>
        /// When true, disables foreign key checks. See [foreign_key_checks](https://dev.mysql.com/doc/refman/5.7/en/server-system-variables.html#sysvar_foreign_key_checks). False by default.
        /// </summary>
        public readonly bool? SkipConstraintChecks;
        /// <summary>
        /// [sql_mode](https://dev.mysql.com/doc/refman/5.7/en/sql-mode.html) to use when interacting with the server. Defaults to "NO_AUTO_VALUE_ON_ZERO,NO_DIR_IN_CREATE,NO_ENGINE_SUBSTITUTION".
        /// </summary>
        public readonly string? SqlMode;
        /// <summary>
        /// Timezone to use for parsing timestamps for saving source timezones. Accepts values from IANA timezone database. Default: local timezone.
        /// </summary>
        public readonly string? Timezone;
        /// <summary>
        /// User for the database access.
        /// </summary>
        public readonly string? User;

        [OutputConstructor]
        private DatatransferEndpointSettingsMysqlTarget(
            Outputs.DatatransferEndpointSettingsMysqlTargetConnection? connection,

            string? database,

            Outputs.DatatransferEndpointSettingsMysqlTargetPassword? password,

            ImmutableArray<string> securityGroups,

            bool? skipConstraintChecks,

            string? sqlMode,

            string? timezone,

            string? user)
        {
            Connection = connection;
            Database = database;
            Password = password;
            SecurityGroups = securityGroups;
            SkipConstraintChecks = skipConstraintChecks;
            SqlMode = sqlMode;
            Timezone = timezone;
            User = user;
        }
    }
}
