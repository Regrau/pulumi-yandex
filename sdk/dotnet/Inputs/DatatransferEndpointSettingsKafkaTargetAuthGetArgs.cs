// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsKafkaTargetAuthGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Connection without authentication data.
        /// </summary>
        [Input("noAuth")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaTargetAuthNoAuthGetArgs>? NoAuth { get; set; }

        /// <summary>
        /// Authentication using sasl.
        /// </summary>
        [Input("sasl")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaTargetAuthSaslGetArgs>? Sasl { get; set; }

        public DatatransferEndpointSettingsKafkaTargetAuthGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsKafkaTargetAuthGetArgs Empty => new DatatransferEndpointSettingsKafkaTargetAuthGetArgs();
    }
}
