// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterUserPermissionArgs : global::Pulumi.InvokeArgs
    {
        [Input("databaseName")]
        public string? DatabaseName { get; set; }

        [Input("roles")]
        private List<string>? _roles;
        public List<string> Roles
        {
            get => _roles ?? (_roles = new List<string>());
            set => _roles = value;
        }

        public GetMdbMongodbClusterUserPermissionArgs()
        {
        }
        public static new GetMdbMongodbClusterUserPermissionArgs Empty => new GetMdbMongodbClusterUserPermissionArgs();
    }
}
