// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("metricName", required: true)]
        public Input<string> MetricName { get; set; } = null!;

        [Input("metricType", required: true)]
        public Input<string> MetricType { get; set; } = null!;

        [Input("ruleType", required: true)]
        public Input<string> RuleType { get; set; } = null!;

        [Input("service")]
        public Input<string>? Service { get; set; }

        [Input("target", required: true)]
        public Input<double> Target { get; set; } = null!;

        public ComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleGetArgs()
        {
        }
        public static new ComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleGetArgs Empty => new ComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleGetArgs();
    }
}
