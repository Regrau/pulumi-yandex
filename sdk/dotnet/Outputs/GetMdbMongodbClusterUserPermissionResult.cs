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
    public sealed class GetMdbMongodbClusterUserPermissionResult
    {
        /// <summary>
        /// The name of the database that the permission grants access to.
        /// </summary>
        public readonly string? DatabaseName;
        /// <summary>
        /// (Optional) List of strings. The roles of the user in this database. For more information see [the official documentation](https://cloud.yandex.com/docs/managed-mongodb/concepts/users-and-roles).
        /// </summary>
        public readonly ImmutableArray<string> Roles;

        [OutputConstructor]
        private GetMdbMongodbClusterUserPermissionResult(
            string? databaseName,

            ImmutableArray<string> roles)
        {
            DatabaseName = databaseName;
            Roles = roles;
        }
    }
}
