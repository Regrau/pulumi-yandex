// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsKafkaTargetSerializerArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Empty block. Select data serialization format automatically.
        /// </summary>
        [Input("serializerAuto")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaTargetSerializerSerializerAutoArgs>? SerializerAuto { get; set; }

        /// <summary>
        /// Serialize data in json format. The structure is documented below.
        /// </summary>
        [Input("serializerDebezium")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaTargetSerializerSerializerDebeziumArgs>? SerializerDebezium { get; set; }

        /// <summary>
        /// Empty block. Serialize data in json format.
        /// </summary>
        [Input("serializerJson")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaTargetSerializerSerializerJsonArgs>? SerializerJson { get; set; }

        public DatatransferEndpointSettingsKafkaTargetSerializerArgs()
        {
        }
        public static new DatatransferEndpointSettingsKafkaTargetSerializerArgs Empty => new DatatransferEndpointSettingsKafkaTargetSerializerArgs();
    }
}
