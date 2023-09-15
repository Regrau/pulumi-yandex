// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetApiGateway
    {
        public static Task<GetApiGatewayResult> InvokeAsync(GetApiGatewayArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetApiGatewayResult>("yandex:index/getApiGateway:getApiGateway", args ?? new GetApiGatewayArgs(), options.WithDefaults());

        public static Output<GetApiGatewayResult> Invoke(GetApiGatewayInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetApiGatewayResult>("yandex:index/getApiGateway:getApiGateway", args ?? new GetApiGatewayInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApiGatewayArgs : global::Pulumi.InvokeArgs
    {
        [Input("apiGatewayId")]
        public string? ApiGatewayId { get; set; }

        [Input("connectivity")]
        public Inputs.GetApiGatewayConnectivityArgs? Connectivity { get; set; }

        [Input("customDomains")]
        private List<Inputs.GetApiGatewayCustomDomainArgs>? _customDomains;
        public List<Inputs.GetApiGatewayCustomDomainArgs> CustomDomains
        {
            get => _customDomains ?? (_customDomains = new List<Inputs.GetApiGatewayCustomDomainArgs>());
            set => _customDomains = value;
        }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        public GetApiGatewayArgs()
        {
        }
        public static new GetApiGatewayArgs Empty => new GetApiGatewayArgs();
    }

    public sealed class GetApiGatewayInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("apiGatewayId")]
        public Input<string>? ApiGatewayId { get; set; }

        [Input("connectivity")]
        public Input<Inputs.GetApiGatewayConnectivityInputArgs>? Connectivity { get; set; }

        [Input("customDomains")]
        private InputList<Inputs.GetApiGatewayCustomDomainInputArgs>? _customDomains;
        public InputList<Inputs.GetApiGatewayCustomDomainInputArgs> CustomDomains
        {
            get => _customDomains ?? (_customDomains = new InputList<Inputs.GetApiGatewayCustomDomainInputArgs>());
            set => _customDomains = value;
        }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetApiGatewayInvokeArgs()
        {
        }
        public static new GetApiGatewayInvokeArgs Empty => new GetApiGatewayInvokeArgs();
    }


    [OutputType]
    public sealed class GetApiGatewayResult
    {
        public readonly string? ApiGatewayId;
        public readonly Outputs.GetApiGatewayConnectivityResult? Connectivity;
        public readonly string CreatedAt;
        public readonly ImmutableArray<Outputs.GetApiGatewayCustomDomainResult> CustomDomains;
        public readonly string Description;
        public readonly string Domain;
        public readonly string? FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string LogGroupId;
        public readonly string? Name;
        public readonly string Status;
        public readonly ImmutableArray<string> UserDomains;

        [OutputConstructor]
        private GetApiGatewayResult(
            string? apiGatewayId,

            Outputs.GetApiGatewayConnectivityResult? connectivity,

            string createdAt,

            ImmutableArray<Outputs.GetApiGatewayCustomDomainResult> customDomains,

            string description,

            string domain,

            string? folderId,

            string id,

            ImmutableDictionary<string, string> labels,

            string logGroupId,

            string? name,

            string status,

            ImmutableArray<string> userDomains)
        {
            ApiGatewayId = apiGatewayId;
            Connectivity = connectivity;
            CreatedAt = createdAt;
            CustomDomains = customDomains;
            Description = description;
            Domain = domain;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            LogGroupId = logGroupId;
            Name = name;
            Status = status;
            UserDomains = userDomains;
        }
    }
}
