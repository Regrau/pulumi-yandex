// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetFunctionTrigger
    {
        public static Task<GetFunctionTriggerResult> InvokeAsync(GetFunctionTriggerArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFunctionTriggerResult>("yandex:index/getFunctionTrigger:getFunctionTrigger", args ?? new GetFunctionTriggerArgs(), options.WithDefaults());

        public static Output<GetFunctionTriggerResult> Invoke(GetFunctionTriggerInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetFunctionTriggerResult>("yandex:index/getFunctionTrigger:getFunctionTrigger", args ?? new GetFunctionTriggerInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetFunctionTriggerArgs : global::Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("triggerId")]
        public string? TriggerId { get; set; }

        public GetFunctionTriggerArgs()
        {
        }
        public static new GetFunctionTriggerArgs Empty => new GetFunctionTriggerArgs();
    }

    public sealed class GetFunctionTriggerInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("triggerId")]
        public Input<string>? TriggerId { get; set; }

        public GetFunctionTriggerInvokeArgs()
        {
        }
        public static new GetFunctionTriggerInvokeArgs Empty => new GetFunctionTriggerInvokeArgs();
    }


    [OutputType]
    public sealed class GetFunctionTriggerResult
    {
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly ImmutableArray<Outputs.GetFunctionTriggerDlqResult> Dlqs;
        public readonly string? FolderId;
        public readonly ImmutableArray<Outputs.GetFunctionTriggerFunctionResult> Functions;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetFunctionTriggerIotResult> Iots;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly ImmutableArray<Outputs.GetFunctionTriggerLogGroupResult> LogGroups;
        public readonly ImmutableArray<Outputs.GetFunctionTriggerLoggingResult> Loggings;
        public readonly ImmutableArray<Outputs.GetFunctionTriggerMessageQueueResult> MessageQueues;
        public readonly string? Name;
        public readonly ImmutableArray<Outputs.GetFunctionTriggerObjectStorageResult> ObjectStorages;
        public readonly ImmutableArray<Outputs.GetFunctionTriggerTimerResult> Timers;
        public readonly string? TriggerId;

        [OutputConstructor]
        private GetFunctionTriggerResult(
            string createdAt,

            string description,

            ImmutableArray<Outputs.GetFunctionTriggerDlqResult> dlqs,

            string? folderId,

            ImmutableArray<Outputs.GetFunctionTriggerFunctionResult> functions,

            string id,

            ImmutableArray<Outputs.GetFunctionTriggerIotResult> iots,

            ImmutableDictionary<string, string> labels,

            ImmutableArray<Outputs.GetFunctionTriggerLogGroupResult> logGroups,

            ImmutableArray<Outputs.GetFunctionTriggerLoggingResult> loggings,

            ImmutableArray<Outputs.GetFunctionTriggerMessageQueueResult> messageQueues,

            string? name,

            ImmutableArray<Outputs.GetFunctionTriggerObjectStorageResult> objectStorages,

            ImmutableArray<Outputs.GetFunctionTriggerTimerResult> timers,

            string? triggerId)
        {
            CreatedAt = createdAt;
            Description = description;
            Dlqs = dlqs;
            FolderId = folderId;
            Functions = functions;
            Id = id;
            Iots = iots;
            Labels = labels;
            LogGroups = logGroups;
            Loggings = loggings;
            MessageQueues = messageQueues;
            Name = name;
            ObjectStorages = objectStorages;
            Timers = timers;
            TriggerId = triggerId;
        }
    }
}