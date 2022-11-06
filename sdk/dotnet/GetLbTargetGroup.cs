// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetLbTargetGroup
    {
        /// <summary>
        /// Get information about a Yandex Load Balancer target group. For more information, see
        /// [Yandex.Cloud Load Balancer](https://cloud.yandex.com/docs/load-balancer/quickstart).
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var foo = Yandex.GetLbTargetGroup.Invoke(new()
        ///     {
        ///         TargetGroupId = "my-target-group-id",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// This data source is used to define [Load Balancer Target Groups] that can be used by other resources.
        /// </summary>
        public static Task<GetLbTargetGroupResult> InvokeAsync(GetLbTargetGroupArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetLbTargetGroupResult>("yandex:index/getLbTargetGroup:getLbTargetGroup", args ?? new GetLbTargetGroupArgs(), options.WithDefaults());

        /// <summary>
        /// Get information about a Yandex Load Balancer target group. For more information, see
        /// [Yandex.Cloud Load Balancer](https://cloud.yandex.com/docs/load-balancer/quickstart).
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var foo = Yandex.GetLbTargetGroup.Invoke(new()
        ///     {
        ///         TargetGroupId = "my-target-group-id",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// This data source is used to define [Load Balancer Target Groups] that can be used by other resources.
        /// </summary>
        public static Output<GetLbTargetGroupResult> Invoke(GetLbTargetGroupInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetLbTargetGroupResult>("yandex:index/getLbTargetGroup:getLbTargetGroup", args ?? new GetLbTargetGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetLbTargetGroupArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public string? FolderId { get; set; }

        /// <summary>
        /// - Name of the Target Group.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Target Group ID.
        /// </summary>
        [Input("targetGroupId")]
        public string? TargetGroupId { get; set; }

        public GetLbTargetGroupArgs()
        {
        }
        public static new GetLbTargetGroupArgs Empty => new GetLbTargetGroupArgs();
    }

    public sealed class GetLbTargetGroupInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// - Name of the Target Group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Target Group ID.
        /// </summary>
        [Input("targetGroupId")]
        public Input<string>? TargetGroupId { get; set; }

        public GetLbTargetGroupInvokeArgs()
        {
        }
        public static new GetLbTargetGroupInvokeArgs Empty => new GetLbTargetGroupInvokeArgs();
    }


    [OutputType]
    public sealed class GetLbTargetGroupResult
    {
        /// <summary>
        /// Creation timestamp of this target group.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// Description of the target group.
        /// </summary>
        public readonly string Description;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Labels to assign to this target group.
        /// * `target.0.address` - IP address of the target.
        /// * `target.0.subnet_id` - ID of the subnet that targets are connected to.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly string TargetGroupId;
        public readonly ImmutableArray<Outputs.GetLbTargetGroupTargetResult> Targets;

        [OutputConstructor]
        private GetLbTargetGroupResult(
            string createdAt,

            string description,

            string folderId,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            string targetGroupId,

            ImmutableArray<Outputs.GetLbTargetGroupTargetResult> targets)
        {
            CreatedAt = createdAt;
            Description = description;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            Name = name;
            TargetGroupId = targetGroupId;
            Targets = targets;
        }
    }
}
