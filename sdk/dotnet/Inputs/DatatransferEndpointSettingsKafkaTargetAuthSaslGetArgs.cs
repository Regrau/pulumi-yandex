// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsKafkaTargetAuthSaslGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("mechanism")]
        public Input<string>? Mechanism { get; set; }

        /// <summary>
        /// Password for the database access. This is a block with a single field named `raw` which should contain the password.
        /// </summary>
        [Input("password")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaTargetAuthSaslPasswordGetArgs>? Password { get; set; }

        /// <summary>
        /// User for the database access.
        /// </summary>
        [Input("user")]
        public Input<string>? User { get; set; }

        public DatatransferEndpointSettingsKafkaTargetAuthSaslGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsKafkaTargetAuthSaslGetArgs Empty => new DatatransferEndpointSettingsKafkaTargetAuthSaslGetArgs();
    }
}
