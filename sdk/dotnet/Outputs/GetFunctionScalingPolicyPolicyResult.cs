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
    public sealed class GetFunctionScalingPolicyPolicyResult
    {
        public readonly string Tag;
        public readonly int? ZoneInstancesLimit;
        public readonly int? ZoneRequestsLimit;

        [OutputConstructor]
        private GetFunctionScalingPolicyPolicyResult(
            string tag,

            int? zoneInstancesLimit,

            int? zoneRequestsLimit)
        {
            Tag = tag;
            ZoneInstancesLimit = zoneInstancesLimit;
            ZoneRequestsLimit = zoneRequestsLimit;
        }
    }
}