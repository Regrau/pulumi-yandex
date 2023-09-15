// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetApiGatewayCustomDomainArgs : global::Pulumi.InvokeArgs
    {
        [Input("certificateId", required: true)]
        public string CertificateId { get; set; } = null!;

        [Input("domainId", required: true)]
        public string DomainId { get; set; } = null!;

        [Input("fqdn", required: true)]
        public string Fqdn { get; set; } = null!;

        public GetApiGatewayCustomDomainArgs()
        {
        }
        public static new GetApiGatewayCustomDomainArgs Empty => new GetApiGatewayCustomDomainArgs();
    }
}