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
    public sealed class GetMdbMysqlUserPermissionResult
    {
        /// <summary>
        /// The name of the database that the permission grants access to.
        /// </summary>
        public readonly string DatabaseName;
        /// <summary>
        /// List user's roles in the database.
        /// Allowed roles: `ALL`,`ALTER`,`ALTER_ROUTINE`,`CREATE`,`CREATE_ROUTINE`,`CREATE_TEMPORARY_TABLES`,
        /// `CREATE_VIEW`,`DELETE`,`DROP`,`EVENT`,`EXECUTE`,`INDEX`,`INSERT`,`LOCK_TABLES`,`SELECT`,`SHOW_VIEW`,`TRIGGER`,`UPDATE`.
        /// </summary>
        public readonly ImmutableArray<string> Roles;

        [OutputConstructor]
        private GetMdbMysqlUserPermissionResult(
            string databaseName,

            ImmutableArray<string> roles)
        {
            DatabaseName = databaseName;
            Roles = roles;
        }
    }
}