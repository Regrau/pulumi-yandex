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
    public sealed class GetComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleResult
    {
        public readonly string FolderId;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string MetricName;
        public readonly string MetricType;
        public readonly string RuleType;
        public readonly string Service;
        public readonly double Target;

        [OutputConstructor]
        private GetComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleResult(
            string folderId,

            ImmutableDictionary<string, string> labels,

            string metricName,

            string metricType,

            string ruleType,

            string service,

            double target)
        {
            FolderId = folderId;
            Labels = labels;
            MetricName = metricName;
            MetricType = metricType;
            RuleType = ruleType;
            Service = service;
            Target = target;
        }
    }
}
