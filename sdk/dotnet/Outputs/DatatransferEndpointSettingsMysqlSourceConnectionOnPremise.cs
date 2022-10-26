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
    public sealed class DatatransferEndpointSettingsMysqlSourceConnectionOnPremise
    {
        public readonly ImmutableArray<string> Hosts;
        public readonly int? Port;
        public readonly string? SubnetId;
        public readonly Outputs.DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseTlsMode? TlsMode;

        [OutputConstructor]
        private DatatransferEndpointSettingsMysqlSourceConnectionOnPremise(
            ImmutableArray<string> hosts,

            int? port,

            string? subnetId,

            Outputs.DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseTlsMode? tlsMode)
        {
            Hosts = hosts;
            Port = port;
            SubnetId = subnetId;
            TlsMode = tlsMode;
        }
    }
}
