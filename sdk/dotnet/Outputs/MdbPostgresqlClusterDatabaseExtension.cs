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
    public sealed class MdbPostgresqlClusterDatabaseExtension
    {
        /// <summary>
        /// Host state name. It should be set for all hosts or unset for all hosts. This field can be used by another host, to select which host will be its replication source. Please see `replication_source_name` parameter.
        /// Also, this field is used to select which host will be selected as a master host. Please see `host_master_name` parameter.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Version of the PostgreSQL cluster. (allowed versions are: 10, 10-1c, 11, 11-1c, 12, 12-1c, 13, 13-1c, 14, 14-1c)
        /// </summary>
        public readonly string? Version;

        [OutputConstructor]
        private MdbPostgresqlClusterDatabaseExtension(
            string name,

            string? version)
        {
            Name = name;
            Version = version;
        }
    }
}