// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbKafkaClusterUserArgs : global::Pulumi.ResourceArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        [Input("permissions")]
        private InputList<Inputs.MdbKafkaClusterUserPermissionArgs>? _permissions;
        public InputList<Inputs.MdbKafkaClusterUserPermissionArgs> Permissions
        {
            get => _permissions ?? (_permissions = new InputList<Inputs.MdbKafkaClusterUserPermissionArgs>());
            set => _permissions = value;
        }

        public MdbKafkaClusterUserArgs()
        {
        }
        public static new MdbKafkaClusterUserArgs Empty => new MdbKafkaClusterUserArgs();
    }
}
