// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseConfigKafkaArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// SASL mechanism used in kafka authentication.
        /// </summary>
        [Input("saslMechanism")]
        public Input<string>? SaslMechanism { get; set; }

        [Input("saslPassword")]
        private Input<string>? _saslPassword;

        /// <summary>
        /// User password on kafka server.
        /// </summary>
        public Input<string>? SaslPassword
        {
            get => _saslPassword;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _saslPassword = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Username on kafka server.
        /// </summary>
        [Input("saslUsername")]
        public Input<string>? SaslUsername { get; set; }

        /// <summary>
        /// Security protocol used to connect to kafka server.
        /// </summary>
        [Input("securityProtocol")]
        public Input<string>? SecurityProtocol { get; set; }

        public MdbClickhouseClusterClickhouseConfigKafkaArgs()
        {
        }
        public static new MdbClickhouseClusterClickhouseConfigKafkaArgs Empty => new MdbClickhouseClusterClickhouseConfigKafkaArgs();
    }
}
