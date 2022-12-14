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
    /// Allows management of a [Yandex.Cloud IAM service account API key](https://cloud.yandex.com/docs/iam/concepts/authorization/api-key).
    /// The API key is a private key used for simplified authorization in the Yandex.Cloud API. API keys are only used for [service accounts](https://cloud.yandex.com/docs/iam/concepts/users/service-accounts).
    /// 
    /// API keys do not expire. This means that this authentication method is simpler, but less secure. Use it if you can't automatically request an [IAM token](https://cloud.yandex.com/docs/iam/concepts/authorization/iam-token).
    /// 
    /// ## Example Usage
    /// 
    /// This snippet creates an API key.
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Yandex = Pulumi.Yandex;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var sa_api_key = new Yandex.IamServiceAccountApiKey("sa-api-key", new()
    ///     {
    ///         Description = "api key for authorization",
    ///         PgpKey = "keybase:keybaseusername",
    ///         ServiceAccountId = "some_sa_id",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/iamServiceAccountApiKey:IamServiceAccountApiKey")]
    public partial class IamServiceAccountApiKey : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Creation timestamp of the static access key.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// The description of the key.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The encrypted secret key, base64 encoded. This is only populated when `pgp_key` is supplied.
        /// </summary>
        [Output("encryptedSecretKey")]
        public Output<string> EncryptedSecretKey { get; private set; } = null!;

        /// <summary>
        /// The fingerprint of the PGP key used to encrypt the secret key. This is only populated when `pgp_key` is supplied.
        /// </summary>
        [Output("keyFingerprint")]
        public Output<string> KeyFingerprint { get; private set; } = null!;

        /// <summary>
        /// An optional PGP key to encrypt the resulting secret key material. May either be a base64-encoded public key or a keybase username in the form `keybase:keybaseusername`.
        /// </summary>
        [Output("pgpKey")]
        public Output<string?> PgpKey { get; private set; } = null!;

        /// <summary>
        /// The secret key. This is only populated when no `pgp_key` is provided.
        /// </summary>
        [Output("secretKey")]
        public Output<string> SecretKey { get; private set; } = null!;

        /// <summary>
        /// ID of the service account to an API key for.
        /// </summary>
        [Output("serviceAccountId")]
        public Output<string> ServiceAccountId { get; private set; } = null!;


        /// <summary>
        /// Create a IamServiceAccountApiKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IamServiceAccountApiKey(string name, IamServiceAccountApiKeyArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/iamServiceAccountApiKey:IamServiceAccountApiKey", name, args ?? new IamServiceAccountApiKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IamServiceAccountApiKey(string name, Input<string> id, IamServiceAccountApiKeyState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/iamServiceAccountApiKey:IamServiceAccountApiKey", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/regrau/pulumi-yandex/releases",
                AdditionalSecretOutputs =
                {
                    "secretKey",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing IamServiceAccountApiKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IamServiceAccountApiKey Get(string name, Input<string> id, IamServiceAccountApiKeyState? state = null, CustomResourceOptions? options = null)
        {
            return new IamServiceAccountApiKey(name, id, state, options);
        }
    }

    public sealed class IamServiceAccountApiKeyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the key.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// An optional PGP key to encrypt the resulting secret key material. May either be a base64-encoded public key or a keybase username in the form `keybase:keybaseusername`.
        /// </summary>
        [Input("pgpKey")]
        public Input<string>? PgpKey { get; set; }

        /// <summary>
        /// ID of the service account to an API key for.
        /// </summary>
        [Input("serviceAccountId", required: true)]
        public Input<string> ServiceAccountId { get; set; } = null!;

        public IamServiceAccountApiKeyArgs()
        {
        }
        public static new IamServiceAccountApiKeyArgs Empty => new IamServiceAccountApiKeyArgs();
    }

    public sealed class IamServiceAccountApiKeyState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Creation timestamp of the static access key.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// The description of the key.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The encrypted secret key, base64 encoded. This is only populated when `pgp_key` is supplied.
        /// </summary>
        [Input("encryptedSecretKey")]
        public Input<string>? EncryptedSecretKey { get; set; }

        /// <summary>
        /// The fingerprint of the PGP key used to encrypt the secret key. This is only populated when `pgp_key` is supplied.
        /// </summary>
        [Input("keyFingerprint")]
        public Input<string>? KeyFingerprint { get; set; }

        /// <summary>
        /// An optional PGP key to encrypt the resulting secret key material. May either be a base64-encoded public key or a keybase username in the form `keybase:keybaseusername`.
        /// </summary>
        [Input("pgpKey")]
        public Input<string>? PgpKey { get; set; }

        [Input("secretKey")]
        private Input<string>? _secretKey;

        /// <summary>
        /// The secret key. This is only populated when no `pgp_key` is provided.
        /// </summary>
        public Input<string>? SecretKey
        {
            get => _secretKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _secretKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// ID of the service account to an API key for.
        /// </summary>
        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        public IamServiceAccountApiKeyState()
        {
        }
        public static new IamServiceAccountApiKeyState Empty => new IamServiceAccountApiKeyState();
    }
}
