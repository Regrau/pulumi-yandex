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
    public sealed class DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsMode
    {
        public readonly Outputs.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsModeDisabled? Disabled;
        public readonly Outputs.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsModeEnabled? Enabled;

        [OutputConstructor]
        private DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsMode(
            Outputs.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsModeDisabled? disabled,

            Outputs.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsModeEnabled? enabled)
        {
            Disabled = disabled;
            Enabled = enabled;
        }
    }
}