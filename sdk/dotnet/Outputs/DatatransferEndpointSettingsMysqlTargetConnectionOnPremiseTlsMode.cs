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
    public sealed class DatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsMode
    {
        /// <summary>
        /// Empty block designating that the connection is not secured, i.e. plaintext connection.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsModeDisabled? Disabled;
        /// <summary>
        /// If this attribute is not an empty block, then TLS is used for the server connection. The structure is documented below.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsModeEnabled? Enabled;

        [OutputConstructor]
        private DatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsMode(
            Outputs.DatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsModeDisabled? disabled,

            Outputs.DatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsModeEnabled? enabled)
        {
            Disabled = disabled;
            Enabled = enabled;
        }
    }
}
