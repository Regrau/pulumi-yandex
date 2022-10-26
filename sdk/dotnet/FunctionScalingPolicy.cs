// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    /// <summary>
    /// Allows management of [Yandex Cloud Function Scaling Policies](https://cloud.yandex.com/docs/functions/)
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Yandex = Pulumi.Yandex;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var myScalingPolicy = new Yandex.FunctionScalingPolicy("myScalingPolicy", new()
    ///     {
    ///         FunctionId = "are1samplefunction11",
    ///         Policies = new[]
    ///         {
    ///             new Yandex.Inputs.FunctionScalingPolicyPolicyArgs
    ///             {
    ///                 Tag = "$latest",
    ///                 ZoneInstancesLimit = 3,
    ///                 ZoneRequestsLimit = 100,
    ///             },
    ///             new Yandex.Inputs.FunctionScalingPolicyPolicyArgs
    ///             {
    ///                 Tag = "my_tag",
    ///                 ZoneInstancesLimit = 4,
    ///                 ZoneRequestsLimit = 150,
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/functionScalingPolicy:FunctionScalingPolicy")]
    public partial class FunctionScalingPolicy : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Yandex Cloud Function id used to define function
        /// </summary>
        [Output("functionId")]
        public Output<string> FunctionId { get; private set; } = null!;

        /// <summary>
        /// list definition for Yandex Cloud Function scaling policies
        /// * `policy.#` - number of Yandex Cloud Function scaling policies
        /// * `policy.{num}.tag` - Yandex.Cloud Function version tag for Yandex Cloud Function scaling policy
        /// * `policy.{num}.zone_instances_limit` - max number of instances in one zone for Yandex.Cloud Function with tag
        /// * `policy.{num}.zone_requests_limit` - max number of requests in one zone for Yandex.Cloud Function with tag
        /// </summary>
        [Output("policies")]
        public Output<ImmutableArray<Outputs.FunctionScalingPolicyPolicy>> Policies { get; private set; } = null!;


        /// <summary>
        /// Create a FunctionScalingPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FunctionScalingPolicy(string name, FunctionScalingPolicyArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/functionScalingPolicy:FunctionScalingPolicy", name, args ?? new FunctionScalingPolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FunctionScalingPolicy(string name, Input<string> id, FunctionScalingPolicyState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/functionScalingPolicy:FunctionScalingPolicy", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/regrau/pulumi-yandex/releases",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing FunctionScalingPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FunctionScalingPolicy Get(string name, Input<string> id, FunctionScalingPolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new FunctionScalingPolicy(name, id, state, options);
        }
    }

    public sealed class FunctionScalingPolicyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Yandex Cloud Function id used to define function
        /// </summary>
        [Input("functionId", required: true)]
        public Input<string> FunctionId { get; set; } = null!;

        [Input("policies")]
        private InputList<Inputs.FunctionScalingPolicyPolicyArgs>? _policies;

        /// <summary>
        /// list definition for Yandex Cloud Function scaling policies
        /// * `policy.#` - number of Yandex Cloud Function scaling policies
        /// * `policy.{num}.tag` - Yandex.Cloud Function version tag for Yandex Cloud Function scaling policy
        /// * `policy.{num}.zone_instances_limit` - max number of instances in one zone for Yandex.Cloud Function with tag
        /// * `policy.{num}.zone_requests_limit` - max number of requests in one zone for Yandex.Cloud Function with tag
        /// </summary>
        public InputList<Inputs.FunctionScalingPolicyPolicyArgs> Policies
        {
            get => _policies ?? (_policies = new InputList<Inputs.FunctionScalingPolicyPolicyArgs>());
            set => _policies = value;
        }

        public FunctionScalingPolicyArgs()
        {
        }
        public static new FunctionScalingPolicyArgs Empty => new FunctionScalingPolicyArgs();
    }

    public sealed class FunctionScalingPolicyState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Yandex Cloud Function id used to define function
        /// </summary>
        [Input("functionId")]
        public Input<string>? FunctionId { get; set; }

        [Input("policies")]
        private InputList<Inputs.FunctionScalingPolicyPolicyGetArgs>? _policies;

        /// <summary>
        /// list definition for Yandex Cloud Function scaling policies
        /// * `policy.#` - number of Yandex Cloud Function scaling policies
        /// * `policy.{num}.tag` - Yandex.Cloud Function version tag for Yandex Cloud Function scaling policy
        /// * `policy.{num}.zone_instances_limit` - max number of instances in one zone for Yandex.Cloud Function with tag
        /// * `policy.{num}.zone_requests_limit` - max number of requests in one zone for Yandex.Cloud Function with tag
        /// </summary>
        public InputList<Inputs.FunctionScalingPolicyPolicyGetArgs> Policies
        {
            get => _policies ?? (_policies = new InputList<Inputs.FunctionScalingPolicyPolicyGetArgs>());
            set => _policies = value;
        }

        public FunctionScalingPolicyState()
        {
        }
        public static new FunctionScalingPolicyState Empty => new FunctionScalingPolicyState();
    }
}
