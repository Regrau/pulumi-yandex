// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseConfigKafkaTopicSettingsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("saslMechanism")]
        public Input<string>? SaslMechanism { get; set; }

        [Input("saslPassword")]
        public Input<string>? SaslPassword { get; set; }

        [Input("saslUsername")]
        public Input<string>? SaslUsername { get; set; }

        [Input("securityProtocol")]
        public Input<string>? SecurityProtocol { get; set; }

        public MdbClickhouseClusterClickhouseConfigKafkaTopicSettingsGetArgs()
        {
        }
        public static new MdbClickhouseClusterClickhouseConfigKafkaTopicSettingsGetArgs Empty => new MdbClickhouseClusterClickhouseConfigKafkaTopicSettingsGetArgs();
    }
}
