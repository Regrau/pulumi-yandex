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
    public sealed class MdbMysqlClusterUser
    {
        /// <summary>
        /// Authentication plugin. Allowed values: `MYSQL_NATIVE_PASSWORD`, `CACHING_SHA2_PASSWORD`, `SHA256_PASSWORD` (for version 5.7 `MYSQL_NATIVE_PASSWORD`, `SHA256_PASSWORD`)
        /// </summary>
        public readonly string? AuthenticationPlugin;
        /// <summary>
        /// User's connection limits. The structure is documented below.
        /// If the attribute is not specified there will be no changes.
        /// </summary>
        public readonly Outputs.MdbMysqlClusterUserConnectionLimits? ConnectionLimits;
        /// <summary>
        /// List user's global permissions     
        /// Allowed permissions:  `REPLICATION_CLIENT`, `REPLICATION_SLAVE`, `PROCESS` for clear list use empty list.
        /// If the attribute is not specified there will be no changes.
        /// </summary>
        public readonly ImmutableArray<string> GlobalPermissions;
        /// <summary>
        /// Host state name. It should be set for all hosts or unset for all hosts. This field can be used by another host, to select which host will be its replication source. Please refer to `replication_source_name` parameter.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The password of the user.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// Set of permissions granted to the user. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.MdbMysqlClusterUserPermission> Permissions;

        [OutputConstructor]
        private MdbMysqlClusterUser(
            string? authenticationPlugin,

            Outputs.MdbMysqlClusterUserConnectionLimits? connectionLimits,

            ImmutableArray<string> globalPermissions,

            string name,

            string password,

            ImmutableArray<Outputs.MdbMysqlClusterUserPermission> permissions)
        {
            AuthenticationPlugin = authenticationPlugin;
            ConnectionLimits = connectionLimits;
            GlobalPermissions = globalPermissions;
            Name = name;
            Password = password;
            Permissions = permissions;
        }
    }
}
