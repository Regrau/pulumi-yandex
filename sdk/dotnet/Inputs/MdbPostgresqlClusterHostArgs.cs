// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbPostgresqlClusterHostArgs : global::Pulumi.ResourceArgs
    {
        [Input("assignPublicIp")]
        public Input<bool>? AssignPublicIp { get; set; }

        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("priority")]
        public Input<int>? Priority { get; set; }

        [Input("replicationSource")]
        public Input<string>? ReplicationSource { get; set; }

        [Input("replicationSourceName")]
        public Input<string>? ReplicationSourceName { get; set; }

        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public MdbPostgresqlClusterHostArgs()
        {
        }
        public static new MdbPostgresqlClusterHostArgs Empty => new MdbPostgresqlClusterHostArgs();
    }
}
