// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetFunctionScalingPolicyPolicyArgs : global::Pulumi.InvokeArgs
    {
        [Input("tag", required: true)]
        public string Tag { get; set; } = null!;

        [Input("zoneInstancesLimit")]
        public int? ZoneInstancesLimit { get; set; }

        [Input("zoneRequestsLimit")]
        public int? ZoneRequestsLimit { get; set; }

        public GetFunctionScalingPolicyPolicyArgs()
        {
        }
        public static new GetFunctionScalingPolicyPolicyArgs Empty => new GetFunctionScalingPolicyPolicyArgs();
    }
}
