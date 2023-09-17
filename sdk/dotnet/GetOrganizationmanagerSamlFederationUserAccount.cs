// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetOrganizationmanagerSamlFederationUserAccount
    {
        /// <summary>
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var account = Yandex.GetOrganizationmanagerSamlFederationUserAccount.Invoke(new()
        ///     {
        ///         FederationId = "some_federation_id",
        ///         NameId = "example@example.org",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["myFederation.id"] = account.Apply(getOrganizationmanagerSamlFederationUserAccountResult =&gt; getOrganizationmanagerSamlFederationUserAccountResult.Id),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetOrganizationmanagerSamlFederationUserAccountResult> InvokeAsync(GetOrganizationmanagerSamlFederationUserAccountArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetOrganizationmanagerSamlFederationUserAccountResult>("yandex:index/getOrganizationmanagerSamlFederationUserAccount:getOrganizationmanagerSamlFederationUserAccount", args ?? new GetOrganizationmanagerSamlFederationUserAccountArgs(), options.WithDefaults());

        /// <summary>
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var account = Yandex.GetOrganizationmanagerSamlFederationUserAccount.Invoke(new()
        ///     {
        ///         FederationId = "some_federation_id",
        ///         NameId = "example@example.org",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["myFederation.id"] = account.Apply(getOrganizationmanagerSamlFederationUserAccountResult =&gt; getOrganizationmanagerSamlFederationUserAccountResult.Id),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetOrganizationmanagerSamlFederationUserAccountResult> Invoke(GetOrganizationmanagerSamlFederationUserAccountInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetOrganizationmanagerSamlFederationUserAccountResult>("yandex:index/getOrganizationmanagerSamlFederationUserAccount:getOrganizationmanagerSamlFederationUserAccount", args ?? new GetOrganizationmanagerSamlFederationUserAccountInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetOrganizationmanagerSamlFederationUserAccountArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of a SAML Federation.
        /// </summary>
        [Input("federationId", required: true)]
        public string FederationId { get; set; } = null!;

        /// <summary>
        /// Name Id of the SAML federated user.
        /// </summary>
        [Input("nameId", required: true)]
        public string NameId { get; set; } = null!;

        public GetOrganizationmanagerSamlFederationUserAccountArgs()
        {
        }
        public static new GetOrganizationmanagerSamlFederationUserAccountArgs Empty => new GetOrganizationmanagerSamlFederationUserAccountArgs();
    }

    public sealed class GetOrganizationmanagerSamlFederationUserAccountInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of a SAML Federation.
        /// </summary>
        [Input("federationId", required: true)]
        public Input<string> FederationId { get; set; } = null!;

        /// <summary>
        /// Name Id of the SAML federated user.
        /// </summary>
        [Input("nameId", required: true)]
        public Input<string> NameId { get; set; } = null!;

        public GetOrganizationmanagerSamlFederationUserAccountInvokeArgs()
        {
        }
        public static new GetOrganizationmanagerSamlFederationUserAccountInvokeArgs Empty => new GetOrganizationmanagerSamlFederationUserAccountInvokeArgs();
    }


    [OutputType]
    public sealed class GetOrganizationmanagerSamlFederationUserAccountResult
    {
        public readonly string FederationId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string NameId;

        [OutputConstructor]
        private GetOrganizationmanagerSamlFederationUserAccountResult(
            string federationId,

            string id,

            string nameId)
        {
            FederationId = federationId;
            Id = id;
            NameId = nameId;
        }
    }
}
