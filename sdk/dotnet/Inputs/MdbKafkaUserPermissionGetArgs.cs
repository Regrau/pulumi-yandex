// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbKafkaUserPermissionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The role type to grant to the topic.
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        /// <summary>
        /// The name of the topic that the permission grants access to.
        /// </summary>
        [Input("topicName", required: true)]
        public Input<string> TopicName { get; set; } = null!;

        public MdbKafkaUserPermissionGetArgs()
        {
        }
        public static new MdbKafkaUserPermissionGetArgs Empty => new MdbKafkaUserPermissionGetArgs();
    }
}
