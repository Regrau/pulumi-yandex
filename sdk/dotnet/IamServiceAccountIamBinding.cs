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
    /// When managing IAM roles, you can treat a service account either as a resource or as an identity.
    /// This resource is used to add IAM policy bindings to a service account resource to configure permissions
    /// that define who can edit the service account.
    /// 
    /// There are three different resources that help you manage your IAM policy for a service account.
    /// Each of these resources is used for a different use case:
    /// 
    /// * yandex_iam_service_account_iam_policy: Authoritative. Sets the IAM policy for the service account and replaces any existing policy already attached.
    /// * yandex_iam_service_account_iam_binding: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the service account are preserved.
    /// * yandex_iam_service_account_iam_member: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role of the service account are preserved.
    /// 
    /// &gt; **Note:** `yandex.IamServiceAccountIamPolicy` **cannot** be used in conjunction with `yandex.IamServiceAccountIamBinding` and `yandex.IamServiceAccountIamMember` or they will conflict over what your policy should be.
    /// 
    /// &gt; **Note:** `yandex.IamServiceAccountIamBinding` resources **can be** used in conjunction with `yandex.IamServiceAccountIamMember` resources **only if** they do not grant privileges to the same role.
    /// 
    /// ## yandex\_service\_account\_iam\_binding
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Yandex = Pulumi.Yandex;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var admin_account_iam = new Yandex.IamServiceAccountIamBinding("admin-account-iam", new()
    ///     {
    ///         Members = new[]
    ///         {
    ///             "userAccount:foo_user_id",
    ///         },
    ///         Role = "admin",
    ///         ServiceAccountId = "your-service-account-id",
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// Service account IAM binding resources can be imported using the service account ID and role.
    /// 
    /// ```sh
    ///  $ pulumi import yandex:index/iamServiceAccountIamBinding:IamServiceAccountIamBinding admin-account-iam "service_account_id roles/editor"
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/iamServiceAccountIamBinding:IamServiceAccountIamBinding")]
    public partial class IamServiceAccountIamBinding : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Identities that will be granted the privilege in `role`.
        /// Each entry can have one of the following values:
        /// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
        /// * **serviceAccount:{service_account_id}**: A unique service account ID.
        /// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
        /// * **group:{group_id}**: A unique group ID.
        /// * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
        /// </summary>
        [Output("members")]
        public Output<ImmutableArray<string>> Members { get; private set; } = null!;

        /// <summary>
        /// The role that should be applied. Only one
        /// `yandex.IamServiceAccountIamBinding` can be used per role.
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        /// <summary>
        /// The service account ID to apply a binding to.
        /// </summary>
        [Output("serviceAccountId")]
        public Output<string> ServiceAccountId { get; private set; } = null!;

        [Output("sleepAfter")]
        public Output<int?> SleepAfter { get; private set; } = null!;


        /// <summary>
        /// Create a IamServiceAccountIamBinding resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IamServiceAccountIamBinding(string name, IamServiceAccountIamBindingArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/iamServiceAccountIamBinding:IamServiceAccountIamBinding", name, args ?? new IamServiceAccountIamBindingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IamServiceAccountIamBinding(string name, Input<string> id, IamServiceAccountIamBindingState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/iamServiceAccountIamBinding:IamServiceAccountIamBinding", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IamServiceAccountIamBinding resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IamServiceAccountIamBinding Get(string name, Input<string> id, IamServiceAccountIamBindingState? state = null, CustomResourceOptions? options = null)
        {
            return new IamServiceAccountIamBinding(name, id, state, options);
        }
    }

    public sealed class IamServiceAccountIamBindingArgs : global::Pulumi.ResourceArgs
    {
        [Input("members", required: true)]
        private InputList<string>? _members;

        /// <summary>
        /// Identities that will be granted the privilege in `role`.
        /// Each entry can have one of the following values:
        /// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
        /// * **serviceAccount:{service_account_id}**: A unique service account ID.
        /// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
        /// * **group:{group_id}**: A unique group ID.
        /// * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
        /// </summary>
        public InputList<string> Members
        {
            get => _members ?? (_members = new InputList<string>());
            set => _members = value;
        }

        /// <summary>
        /// The role that should be applied. Only one
        /// `yandex.IamServiceAccountIamBinding` can be used per role.
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        /// <summary>
        /// The service account ID to apply a binding to.
        /// </summary>
        [Input("serviceAccountId", required: true)]
        public Input<string> ServiceAccountId { get; set; } = null!;

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public IamServiceAccountIamBindingArgs()
        {
        }
        public static new IamServiceAccountIamBindingArgs Empty => new IamServiceAccountIamBindingArgs();
    }

    public sealed class IamServiceAccountIamBindingState : global::Pulumi.ResourceArgs
    {
        [Input("members")]
        private InputList<string>? _members;

        /// <summary>
        /// Identities that will be granted the privilege in `role`.
        /// Each entry can have one of the following values:
        /// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
        /// * **serviceAccount:{service_account_id}**: A unique service account ID.
        /// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
        /// * **group:{group_id}**: A unique group ID.
        /// * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
        /// </summary>
        public InputList<string> Members
        {
            get => _members ?? (_members = new InputList<string>());
            set => _members = value;
        }

        /// <summary>
        /// The role that should be applied. Only one
        /// `yandex.IamServiceAccountIamBinding` can be used per role.
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        /// <summary>
        /// The service account ID to apply a binding to.
        /// </summary>
        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public IamServiceAccountIamBindingState()
        {
        }
        public static new IamServiceAccountIamBindingState Empty => new IamServiceAccountIamBindingState();
    }
}
