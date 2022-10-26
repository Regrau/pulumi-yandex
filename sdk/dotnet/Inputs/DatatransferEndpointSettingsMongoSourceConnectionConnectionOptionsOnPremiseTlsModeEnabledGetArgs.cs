// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsOnPremiseTlsModeEnabledGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// X.509 certificate of the certificate authority which issued the server's certificate, in PEM format. If empty, the server's certificate must be signed by a well-known CA.
        /// </summary>
        [Input("caCertificate")]
        public Input<string>? CaCertificate { get; set; }

        public DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsOnPremiseTlsModeEnabledGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsOnPremiseTlsModeEnabledGetArgs Empty => new DatatransferEndpointSettingsMongoSourceConnectionConnectionOptionsOnPremiseTlsModeEnabledGetArgs();
    }
}
