// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class GetCmCertificateChallengeResult
    {
        public readonly string CreatedAt;
        public readonly string DnsName;
        public readonly string DnsType;
        public readonly string DnsValue;
        public readonly string Domain;
        public readonly string HttpContent;
        public readonly string HttpUrl;
        public readonly string Message;
        public readonly string Type;
        public readonly string UpdatedAt;

        [OutputConstructor]
        private GetCmCertificateChallengeResult(
            string createdAt,

            string dnsName,

            string dnsType,

            string dnsValue,

            string domain,

            string httpContent,

            string httpUrl,

            string message,

            string type,

            string updatedAt)
        {
            CreatedAt = createdAt;
            DnsName = dnsName;
            DnsType = dnsType;
            DnsValue = dnsValue;
            Domain = domain;
            HttpContent = httpContent;
            HttpUrl = httpUrl;
            Message = message;
            Type = type;
            UpdatedAt = updatedAt;
        }
    }
}
