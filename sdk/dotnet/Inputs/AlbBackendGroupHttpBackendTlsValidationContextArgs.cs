// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbBackendGroupHttpBackendTlsValidationContextArgs : global::Pulumi.ResourceArgs
    {
        [Input("trustedCaBytes")]
        public Input<string>? TrustedCaBytes { get; set; }

        [Input("trustedCaId")]
        public Input<string>? TrustedCaId { get; set; }

        public AlbBackendGroupHttpBackendTlsValidationContextArgs()
        {
        }
        public static new AlbBackendGroupHttpBackendTlsValidationContextArgs Empty => new AlbBackendGroupHttpBackendTlsValidationContextArgs();
    }
}
