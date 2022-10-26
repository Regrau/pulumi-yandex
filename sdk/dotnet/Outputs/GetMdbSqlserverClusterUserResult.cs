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
    public sealed class GetMdbSqlserverClusterUserResult
    {
        public readonly string Name;
        public readonly string Password;
        public readonly ImmutableArray<Outputs.GetMdbSqlserverClusterUserPermissionResult> Permissions;

        [OutputConstructor]
        private GetMdbSqlserverClusterUserResult(
            string name,

            string password,

            ImmutableArray<Outputs.GetMdbSqlserverClusterUserPermissionResult> permissions)
        {
            Name = name;
            Password = password;
            Permissions = permissions;
        }
    }
}
