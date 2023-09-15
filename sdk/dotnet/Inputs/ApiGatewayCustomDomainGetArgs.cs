// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ApiGatewayCustomDomainGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("certificateId", required: true)]
        public Input<string> CertificateId { get; set; } = null!;

        [Input("domainId")]
        public Input<string>? DomainId { get; set; }

        [Input("fqdn", required: true)]
        public Input<string> Fqdn { get; set; } = null!;

        public ApiGatewayCustomDomainGetArgs()
        {
        }
        public static new ApiGatewayCustomDomainGetArgs Empty => new ApiGatewayCustomDomainGetArgs();
    }
}