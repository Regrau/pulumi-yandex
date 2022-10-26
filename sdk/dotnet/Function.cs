// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/function:Function")]
    public partial class Function : global::Pulumi.CustomResource
    {
        [Output("content")]
        public Output<Outputs.FunctionContent?> Content { get; private set; } = null!;

        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("entrypoint")]
        public Output<string> Entrypoint { get; private set; } = null!;

        [Output("environment")]
        public Output<ImmutableDictionary<string, string>?> Environment { get; private set; } = null!;

        [Output("executionTimeout")]
        public Output<string?> ExecutionTimeout { get; private set; } = null!;

        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        [Output("imageSize")]
        public Output<int> ImageSize { get; private set; } = null!;

        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        [Output("loggroupId")]
        public Output<string> LoggroupId { get; private set; } = null!;

        [Output("memory")]
        public Output<int> Memory { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("package")]
        public Output<Outputs.FunctionPackage?> Package { get; private set; } = null!;

        [Output("runtime")]
        public Output<string> Runtime { get; private set; } = null!;

        [Output("secrets")]
        public Output<ImmutableArray<Outputs.FunctionSecret>> Secrets { get; private set; } = null!;

        [Output("serviceAccountId")]
        public Output<string?> ServiceAccountId { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        [Output("userHash")]
        public Output<string> UserHash { get; private set; } = null!;

        [Output("version")]
        public Output<string> Version { get; private set; } = null!;


        /// <summary>
        /// Create a Function resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Function(string name, FunctionArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/function:Function", name, args ?? new FunctionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Function(string name, Input<string> id, FunctionState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/function:Function", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Function resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Function Get(string name, Input<string> id, FunctionState? state = null, CustomResourceOptions? options = null)
        {
            return new Function(name, id, state, options);
        }
    }

    public sealed class FunctionArgs : global::Pulumi.ResourceArgs
    {
        [Input("content")]
        public Input<Inputs.FunctionContentArgs>? Content { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("entrypoint", required: true)]
        public Input<string> Entrypoint { get; set; } = null!;

        [Input("environment")]
        private InputMap<string>? _environment;
        public InputMap<string> Environment
        {
            get => _environment ?? (_environment = new InputMap<string>());
            set => _environment = value;
        }

        [Input("executionTimeout")]
        public Input<string>? ExecutionTimeout { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("memory", required: true)]
        public Input<int> Memory { get; set; } = null!;

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("package")]
        public Input<Inputs.FunctionPackageArgs>? Package { get; set; }

        [Input("runtime", required: true)]
        public Input<string> Runtime { get; set; } = null!;

        [Input("secrets")]
        private InputList<Inputs.FunctionSecretArgs>? _secrets;
        public InputList<Inputs.FunctionSecretArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.FunctionSecretArgs>());
            set => _secrets = value;
        }

        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("userHash", required: true)]
        public Input<string> UserHash { get; set; } = null!;

        public FunctionArgs()
        {
        }
        public static new FunctionArgs Empty => new FunctionArgs();
    }

    public sealed class FunctionState : global::Pulumi.ResourceArgs
    {
        [Input("content")]
        public Input<Inputs.FunctionContentGetArgs>? Content { get; set; }

        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("entrypoint")]
        public Input<string>? Entrypoint { get; set; }

        [Input("environment")]
        private InputMap<string>? _environment;
        public InputMap<string> Environment
        {
            get => _environment ?? (_environment = new InputMap<string>());
            set => _environment = value;
        }

        [Input("executionTimeout")]
        public Input<string>? ExecutionTimeout { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("imageSize")]
        public Input<int>? ImageSize { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("loggroupId")]
        public Input<string>? LoggroupId { get; set; }

        [Input("memory")]
        public Input<int>? Memory { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("package")]
        public Input<Inputs.FunctionPackageGetArgs>? Package { get; set; }

        [Input("runtime")]
        public Input<string>? Runtime { get; set; }

        [Input("secrets")]
        private InputList<Inputs.FunctionSecretGetArgs>? _secrets;
        public InputList<Inputs.FunctionSecretGetArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.FunctionSecretGetArgs>());
            set => _secrets = value;
        }

        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("userHash")]
        public Input<string>? UserHash { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public FunctionState()
        {
        }
        public static new FunctionState Empty => new FunctionState();
    }
}
