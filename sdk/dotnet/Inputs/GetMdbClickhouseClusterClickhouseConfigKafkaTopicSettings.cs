// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterClickhouseConfigKafkaTopicSettingsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// SASL mechanism used in kafka authentication.
        /// </summary>
        [Input("saslMechanism")]
        public string? SaslMechanism { get; set; }

        [Input("saslPassword")]
        private string? _saslPassword;

        /// <summary>
        /// User password on kafka server.
        /// </summary>
        public string? SaslPassword
        {
            get => _saslPassword;
            set => _saslPassword = value;
        }

        /// <summary>
        /// Username on kafka server.
        /// </summary>
        [Input("saslUsername")]
        public string? SaslUsername { get; set; }

        /// <summary>
        /// Security protocol used to connect to kafka server.
        /// </summary>
        [Input("securityProtocol")]
        public string? SecurityProtocol { get; set; }

        public GetMdbClickhouseClusterClickhouseConfigKafkaTopicSettingsArgs()
        {
        }
        public static new GetMdbClickhouseClusterClickhouseConfigKafkaTopicSettingsArgs Empty => new GetMdbClickhouseClusterClickhouseConfigKafkaTopicSettingsArgs();
    }
}
