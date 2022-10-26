// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetComputeInstancePlacementPolicyHostAffinityRuleArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Affinity label or one of reserved values - `yc.hostId`, `yc.hostGroupId`.
        /// </summary>
        [Input("key", required: true)]
        public string Key { get; set; } = null!;

        /// <summary>
        /// Affinity action. The only value supported is `IN`.
        /// </summary>
        [Input("op", required: true)]
        public string Op { get; set; } = null!;

        [Input("values", required: true)]
        private List<string>? _values;
        public List<string> Values
        {
            get => _values ?? (_values = new List<string>());
            set => _values = value;
        }

        public GetComputeInstancePlacementPolicyHostAffinityRuleArgs()
        {
        }
        public static new GetComputeInstancePlacementPolicyHostAffinityRuleArgs Empty => new GetComputeInstancePlacementPolicyHostAffinityRuleArgs();
    }
}
