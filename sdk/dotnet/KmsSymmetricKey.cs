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
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Yandex = Pulumi.Yandex;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var key_a = new Yandex.KmsSymmetricKey("key-a", new()
    ///     {
    ///         DefaultAlgorithm = "AES_128",
    ///         Description = "description for key",
    ///         RotationPeriod = "8760h",
    ///     });
    /// 
    ///     // equal to 1 year
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// A KMS symmetric key can be imported using the `id` of the resource, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import yandex:index/kmsSymmetricKey:KmsSymmetricKey top-secret kms_key_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/kmsSymmetricKey:KmsSymmetricKey")]
    public partial class KmsSymmetricKey : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Creation timestamp of the key.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Encryption algorithm to be used with a new key version, 
        /// generated with the next rotation. The default value is `AES_128`.
        /// </summary>
        [Output("defaultAlgorithm")]
        public Output<string?> DefaultAlgorithm { get; private set; } = null!;

        /// <summary>
        /// An optional description of the key.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the key.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// Name of the key.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Last rotation timestamp of the key.
        /// </summary>
        [Output("rotatedAt")]
        public Output<string> RotatedAt { get; private set; } = null!;

        /// <summary>
        /// Interval between automatic rotations. To disable automatic rotation, omit this parameter.
        /// </summary>
        [Output("rotationPeriod")]
        public Output<string?> RotationPeriod { get; private set; } = null!;

        /// <summary>
        /// The status of the key.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;


        /// <summary>
        /// Create a KmsSymmetricKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KmsSymmetricKey(string name, KmsSymmetricKeyArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/kmsSymmetricKey:KmsSymmetricKey", name, args ?? new KmsSymmetricKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private KmsSymmetricKey(string name, Input<string> id, KmsSymmetricKeyState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/kmsSymmetricKey:KmsSymmetricKey", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing KmsSymmetricKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KmsSymmetricKey Get(string name, Input<string> id, KmsSymmetricKeyState? state = null, CustomResourceOptions? options = null)
        {
            return new KmsSymmetricKey(name, id, state, options);
        }
    }

    public sealed class KmsSymmetricKeyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Encryption algorithm to be used with a new key version, 
        /// generated with the next rotation. The default value is `AES_128`.
        /// </summary>
        [Input("defaultAlgorithm")]
        public Input<string>? DefaultAlgorithm { get; set; }

        /// <summary>
        /// An optional description of the key.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the key.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the key.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Interval between automatic rotations. To disable automatic rotation, omit this parameter.
        /// </summary>
        [Input("rotationPeriod")]
        public Input<string>? RotationPeriod { get; set; }

        public KmsSymmetricKeyArgs()
        {
        }
        public static new KmsSymmetricKeyArgs Empty => new KmsSymmetricKeyArgs();
    }

    public sealed class KmsSymmetricKeyState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Creation timestamp of the key.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// Encryption algorithm to be used with a new key version, 
        /// generated with the next rotation. The default value is `AES_128`.
        /// </summary>
        [Input("defaultAlgorithm")]
        public Input<string>? DefaultAlgorithm { get; set; }

        /// <summary>
        /// An optional description of the key.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the key.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the key.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Last rotation timestamp of the key.
        /// </summary>
        [Input("rotatedAt")]
        public Input<string>? RotatedAt { get; set; }

        /// <summary>
        /// Interval between automatic rotations. To disable automatic rotation, omit this parameter.
        /// </summary>
        [Input("rotationPeriod")]
        public Input<string>? RotationPeriod { get; set; }

        /// <summary>
        /// The status of the key.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public KmsSymmetricKeyState()
        {
        }
        public static new KmsSymmetricKeyState Empty => new KmsSymmetricKeyState();
    }
}
