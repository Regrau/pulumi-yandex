// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterUserPermissionArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the database that the permission grants access to.
        /// </summary>
        [Input("databaseName")]
        public string? DatabaseName { get; set; }

        public GetMdbClickhouseClusterUserPermissionArgs()
        {
        }
        public static new GetMdbClickhouseClusterUserPermissionArgs Empty => new GetMdbClickhouseClusterUserPermissionArgs();
    }
}
