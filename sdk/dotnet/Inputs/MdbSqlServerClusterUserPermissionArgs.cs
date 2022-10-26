// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbSqlServerClusterUserPermissionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the database that the permission grants access to.
        /// </summary>
        [Input("databaseName", required: true)]
        public Input<string> DatabaseName { get; set; } = null!;

        [Input("roles")]
        private InputList<string>? _roles;

        /// <summary>
        /// List user's roles in the database.
        /// Allowed roles: `OWNER`, `SECURITYADMIN`, `ACCESSADMIN`, `BACKUPOPERATOR`, `DDLADMIN`, `DATAWRITER`, `DATAREADER`, `DENYDATAWRITER`, `DENYDATAREADER`.
        /// </summary>
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        public MdbSqlServerClusterUserPermissionArgs()
        {
        }
        public static new MdbSqlServerClusterUserPermissionArgs Empty => new MdbSqlServerClusterUserPermissionArgs();
    }
}
