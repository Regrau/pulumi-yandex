// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class VpcSecurityGroupEgressArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the security group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("fromPort")]
        public Input<int>? FromPort { get; set; }

        /// <summary>
        /// Id of the rule.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels to assign to this security group.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("predefinedTarget")]
        public Input<string>? PredefinedTarget { get; set; }

        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        [Input("securityGroupId")]
        public Input<string>? SecurityGroupId { get; set; }

        [Input("toPort")]
        public Input<int>? ToPort { get; set; }

        [Input("v4CidrBlocks")]
        private InputList<string>? _v4CidrBlocks;
        public InputList<string> V4CidrBlocks
        {
            get => _v4CidrBlocks ?? (_v4CidrBlocks = new InputList<string>());
            set => _v4CidrBlocks = value;
        }

        [Input("v6CidrBlocks")]
        private InputList<string>? _v6CidrBlocks;
        public InputList<string> V6CidrBlocks
        {
            get => _v6CidrBlocks ?? (_v6CidrBlocks = new InputList<string>());
            set => _v6CidrBlocks = value;
        }

        public VpcSecurityGroupEgressArgs()
        {
        }
        public static new VpcSecurityGroupEgressArgs Empty => new VpcSecurityGroupEgressArgs();
    }
}
