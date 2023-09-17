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
    public sealed class MdbKafkaUserPermission
    {
        /// <summary>
        /// The role type to grant to the topic.
        /// </summary>
        public readonly string Role;
        /// <summary>
        /// The name of the topic that the permission grants access to.
        /// </summary>
        public readonly string TopicName;

        [OutputConstructor]
        private MdbKafkaUserPermission(
            string role,

            string topicName)
        {
            Role = role;
            TopicName = topicName;
        }
    }
}
