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
    /// Allows creation and management of a single binding within IAM policy for
    /// an existing Yandex.Cloud Organization Manager organization.
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
    ///     var editor = new Yandex.OrganizationManagerOrganizationIamBinding("editor", new()
    ///     {
    ///         Members = new[]
    ///         {
    ///             "userAccount:some_user_id",
    ///         },
    ///         OrganizationId = "some_organization_id",
    ///         Role = "editor",
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// IAM binding imports use space-delimited identifiers; first the resource in question and then the role. These bindings can be imported using the `organization_id` and role, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import yandex:index/organizationManagerOrganizationIamBinding:OrganizationManagerOrganizationIamBinding viewer "organization_id viewer"
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/organizationManagerOrganizationIamBinding:OrganizationManagerOrganizationIamBinding")]
    public partial class OrganizationManagerOrganizationIamBinding : global::Pulumi.CustomResource
    {
        /// <summary>
        /// An array of identities that will be granted the privilege in the `role`.
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
        /// ID of the organization to attach the policy to.
        /// </summary>
        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        /// <summary>
        /// The role that should be assigned. Only one
        /// `yandex.OrganizationManagerOrganizationIamBinding` can be used per role.
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        [Output("sleepAfter")]
        public Output<int?> SleepAfter { get; private set; } = null!;


        /// <summary>
        /// Create a OrganizationManagerOrganizationIamBinding resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OrganizationManagerOrganizationIamBinding(string name, OrganizationManagerOrganizationIamBindingArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/organizationManagerOrganizationIamBinding:OrganizationManagerOrganizationIamBinding", name, args ?? new OrganizationManagerOrganizationIamBindingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OrganizationManagerOrganizationIamBinding(string name, Input<string> id, OrganizationManagerOrganizationIamBindingState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/organizationManagerOrganizationIamBinding:OrganizationManagerOrganizationIamBinding", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing OrganizationManagerOrganizationIamBinding resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OrganizationManagerOrganizationIamBinding Get(string name, Input<string> id, OrganizationManagerOrganizationIamBindingState? state = null, CustomResourceOptions? options = null)
        {
            return new OrganizationManagerOrganizationIamBinding(name, id, state, options);
        }
    }

    public sealed class OrganizationManagerOrganizationIamBindingArgs : global::Pulumi.ResourceArgs
    {
        [Input("members", required: true)]
        private InputList<string>? _members;

        /// <summary>
        /// An array of identities that will be granted the privilege in the `role`.
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
        /// ID of the organization to attach the policy to.
        /// </summary>
        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        /// <summary>
        /// The role that should be assigned. Only one
        /// `yandex.OrganizationManagerOrganizationIamBinding` can be used per role.
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public OrganizationManagerOrganizationIamBindingArgs()
        {
        }
        public static new OrganizationManagerOrganizationIamBindingArgs Empty => new OrganizationManagerOrganizationIamBindingArgs();
    }

    public sealed class OrganizationManagerOrganizationIamBindingState : global::Pulumi.ResourceArgs
    {
        [Input("members")]
        private InputList<string>? _members;

        /// <summary>
        /// An array of identities that will be granted the privilege in the `role`.
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
        /// ID of the organization to attach the policy to.
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        /// <summary>
        /// The role that should be assigned. Only one
        /// `yandex.OrganizationManagerOrganizationIamBinding` can be used per role.
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public OrganizationManagerOrganizationIamBindingState()
        {
        }
        public static new OrganizationManagerOrganizationIamBindingState Empty => new OrganizationManagerOrganizationIamBindingState();
    }
}
