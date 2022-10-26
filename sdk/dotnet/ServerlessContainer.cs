// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/serverlessContainer:ServerlessContainer")]
    public partial class ServerlessContainer : global::Pulumi.CustomResource
    {
        [Output("concurrency")]
        public Output<int?> Concurrency { get; private set; } = null!;

        [Output("coreFraction")]
        public Output<int> CoreFraction { get; private set; } = null!;

        [Output("cores")]
        public Output<int?> Cores { get; private set; } = null!;

        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("executionTimeout")]
        public Output<string> ExecutionTimeout { get; private set; } = null!;

        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        [Output("image")]
        public Output<Outputs.ServerlessContainerImage> Image { get; private set; } = null!;

        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// Container memory in megabytes, should be aligned to 128
        /// </summary>
        [Output("memory")]
        public Output<int> Memory { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("revisionId")]
        public Output<string> RevisionId { get; private set; } = null!;

        [Output("secrets")]
        public Output<ImmutableArray<Outputs.ServerlessContainerSecret>> Secrets { get; private set; } = null!;

        [Output("serviceAccountId")]
        public Output<string?> ServiceAccountId { get; private set; } = null!;

        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a ServerlessContainer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServerlessContainer(string name, ServerlessContainerArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/serverlessContainer:ServerlessContainer", name, args ?? new ServerlessContainerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServerlessContainer(string name, Input<string> id, ServerlessContainerState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/serverlessContainer:ServerlessContainer", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ServerlessContainer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServerlessContainer Get(string name, Input<string> id, ServerlessContainerState? state = null, CustomResourceOptions? options = null)
        {
            return new ServerlessContainer(name, id, state, options);
        }
    }

    public sealed class ServerlessContainerArgs : global::Pulumi.ResourceArgs
    {
        [Input("concurrency")]
        public Input<int>? Concurrency { get; set; }

        [Input("coreFraction")]
        public Input<int>? CoreFraction { get; set; }

        [Input("cores")]
        public Input<int>? Cores { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("executionTimeout")]
        public Input<string>? ExecutionTimeout { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("image", required: true)]
        public Input<Inputs.ServerlessContainerImageArgs> Image { get; set; } = null!;

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Container memory in megabytes, should be aligned to 128
        /// </summary>
        [Input("memory", required: true)]
        public Input<int> Memory { get; set; } = null!;

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("secrets")]
        private InputList<Inputs.ServerlessContainerSecretArgs>? _secrets;
        public InputList<Inputs.ServerlessContainerSecretArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.ServerlessContainerSecretArgs>());
            set => _secrets = value;
        }

        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        public ServerlessContainerArgs()
        {
        }
        public static new ServerlessContainerArgs Empty => new ServerlessContainerArgs();
    }

    public sealed class ServerlessContainerState : global::Pulumi.ResourceArgs
    {
        [Input("concurrency")]
        public Input<int>? Concurrency { get; set; }

        [Input("coreFraction")]
        public Input<int>? CoreFraction { get; set; }

        [Input("cores")]
        public Input<int>? Cores { get; set; }

        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("executionTimeout")]
        public Input<string>? ExecutionTimeout { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("image")]
        public Input<Inputs.ServerlessContainerImageGetArgs>? Image { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Container memory in megabytes, should be aligned to 128
        /// </summary>
        [Input("memory")]
        public Input<int>? Memory { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("revisionId")]
        public Input<string>? RevisionId { get; set; }

        [Input("secrets")]
        private InputList<Inputs.ServerlessContainerSecretGetArgs>? _secrets;
        public InputList<Inputs.ServerlessContainerSecretGetArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.ServerlessContainerSecretGetArgs>());
            set => _secrets = value;
        }

        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        [Input("url")]
        public Input<string>? Url { get; set; }

        public ServerlessContainerState()
        {
        }
        public static new ServerlessContainerState Empty => new ServerlessContainerState();
    }
}
