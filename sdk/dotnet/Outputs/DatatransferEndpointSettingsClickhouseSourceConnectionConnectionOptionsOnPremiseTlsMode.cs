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
    public sealed class DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseTlsMode
    {
        public readonly Outputs.DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseTlsModeDisabled? Disabled;
        public readonly Outputs.DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseTlsModeEnabled? Enabled;

        [OutputConstructor]
        private DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseTlsMode(
            Outputs.DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseTlsModeDisabled? disabled,

            Outputs.DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseTlsModeEnabled? enabled)
        {
            Disabled = disabled;
            Enabled = enabled;
        }
    }
}