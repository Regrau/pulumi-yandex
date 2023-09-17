// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsKafkaTargetConnectionOnPremiseGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("brokerUrls")]
        private InputList<string>? _brokerUrls;

        /// <summary>
        /// List of Kafka broker URLs.
        /// </summary>
        public InputList<string> BrokerUrls
        {
            get => _brokerUrls ?? (_brokerUrls = new InputList<string>());
            set => _brokerUrls = value;
        }

        /// <summary>
        /// Identifier of the Yandex Cloud VPC subnetwork to user for accessing the database. If omitted, the server has to be accessible via Internet.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// TLS settings for the server connection. Empty implies plaintext connection. The structure is documented below.
        /// </summary>
        [Input("tlsMode")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaTargetConnectionOnPremiseTlsModeGetArgs>? TlsMode { get; set; }

        public DatatransferEndpointSettingsKafkaTargetConnectionOnPremiseGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsKafkaTargetConnectionOnPremiseGetArgs Empty => new DatatransferEndpointSettingsKafkaTargetConnectionOnPremiseGetArgs();
    }
}
