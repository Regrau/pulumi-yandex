// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbSqlServerClusterDatabaseGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public MdbSqlServerClusterDatabaseGetArgs()
        {
        }
        public static new MdbSqlServerClusterDatabaseGetArgs Empty => new MdbSqlServerClusterDatabaseGetArgs();
    }
}
