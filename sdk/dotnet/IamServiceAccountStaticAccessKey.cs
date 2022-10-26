// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/iamServiceAccountStaticAccessKey:IamServiceAccountStaticAccessKey")]
    public partial class IamServiceAccountStaticAccessKey : global::Pulumi.CustomResource
    {
        [Output("accessKey")]
        public Output<string> AccessKey { get; private set; } = null!;

        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("encryptedSecretKey")]
        public Output<string> EncryptedSecretKey { get; private set; } = null!;

        [Output("keyFingerprint")]
        public Output<string> KeyFingerprint { get; private set; } = null!;

        [Output("pgpKey")]
        public Output<string?> PgpKey { get; private set; } = null!;

        [Output("secretKey")]
        public Output<string> SecretKey { get; private set; } = null!;

        [Output("serviceAccountId")]
        public Output<string> ServiceAccountId { get; private set; } = null!;


        /// <summary>
        /// Create a IamServiceAccountStaticAccessKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IamServiceAccountStaticAccessKey(string name, IamServiceAccountStaticAccessKeyArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/iamServiceAccountStaticAccessKey:IamServiceAccountStaticAccessKey", name, args ?? new IamServiceAccountStaticAccessKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IamServiceAccountStaticAccessKey(string name, Input<string> id, IamServiceAccountStaticAccessKeyState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/iamServiceAccountStaticAccessKey:IamServiceAccountStaticAccessKey", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github/regrau/pulumi-yandex/releases",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing IamServiceAccountStaticAccessKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IamServiceAccountStaticAccessKey Get(string name, Input<string> id, IamServiceAccountStaticAccessKeyState? state = null, CustomResourceOptions? options = null)
        {
            return new IamServiceAccountStaticAccessKey(name, id, state, options);
        }
    }

    public sealed class IamServiceAccountStaticAccessKeyArgs : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("pgpKey")]
        public Input<string>? PgpKey { get; set; }

        [Input("serviceAccountId", required: true)]
        public Input<string> ServiceAccountId { get; set; } = null!;

        public IamServiceAccountStaticAccessKeyArgs()
        {
        }
        public static new IamServiceAccountStaticAccessKeyArgs Empty => new IamServiceAccountStaticAccessKeyArgs();
    }

    public sealed class IamServiceAccountStaticAccessKeyState : global::Pulumi.ResourceArgs
    {
        [Input("accessKey")]
        public Input<string>? AccessKey { get; set; }

        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("encryptedSecretKey")]
        public Input<string>? EncryptedSecretKey { get; set; }

        [Input("keyFingerprint")]
        public Input<string>? KeyFingerprint { get; set; }

        [Input("pgpKey")]
        public Input<string>? PgpKey { get; set; }

        [Input("secretKey")]
        public Input<string>? SecretKey { get; set; }

        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        public IamServiceAccountStaticAccessKeyState()
        {
        }
        public static new IamServiceAccountStaticAccessKeyState Empty => new IamServiceAccountStaticAccessKeyState();
    }
}
