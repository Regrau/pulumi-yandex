// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbBackendGroupStreamBackendTlsArgs : global::Pulumi.ResourceArgs
    {
        [Input("sni")]
        public Input<string>? Sni { get; set; }

        [Input("validationContext")]
        public Input<Inputs.AlbBackendGroupStreamBackendTlsValidationContextArgs>? ValidationContext { get; set; }

        public AlbBackendGroupStreamBackendTlsArgs()
        {
        }
        public static new AlbBackendGroupStreamBackendTlsArgs Empty => new AlbBackendGroupStreamBackendTlsArgs();
    }
}