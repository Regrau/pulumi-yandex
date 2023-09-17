// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsKafkaSourceGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Authentication data.
        /// </summary>
        [Input("auth")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaSourceAuthGetArgs>? Auth { get; set; }

        /// <summary>
        /// Connection settings. The structure is documented below.
        /// </summary>
        [Input("connection")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaSourceConnectionGetArgs>? Connection { get; set; }

        /// <summary>
        /// Data parsing parameters. If not set, the source messages are read in raw.
        /// </summary>
        [Input("parser")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaSourceParserGetArgs>? Parser { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;

        /// <summary>
        /// List of security groups that the transfer associated with this endpoint should use.
        /// </summary>
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        /// <summary>
        /// Full source topic name.
        /// </summary>
        [Input("topicName")]
        public Input<string>? TopicName { get; set; }

        /// <summary>
        /// Transform data with a custom Cloud Function.
        /// </summary>
        [Input("transformer")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaSourceTransformerGetArgs>? Transformer { get; set; }

        public DatatransferEndpointSettingsKafkaSourceGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsKafkaSourceGetArgs Empty => new DatatransferEndpointSettingsKafkaSourceGetArgs();
    }
}
