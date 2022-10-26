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
    /// Allows management of [Yandex.Cloud CDN Resource](https://cloud.yandex.ru/docs/cdn/concepts/resource).
    /// 
    /// &gt; **_NOTE:_**  CDN provider must be activated prior usage of CDN resources, either via UI console or via yc cli command: ```yc cdn provider activate --folder-id &lt;folder-id&gt; --type gcore```
    /// 
    /// ## Import
    /// 
    /// A origin group can be imported using any of these accepted formats
    /// 
    /// ```sh
    ///  $ pulumi import yandex:index/cdnResource:CdnResource default origin_group_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/cdnResource:CdnResource")]
    public partial class CdnResource : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Flag to create Resource either in active or disabled state. True - the content from CDN is available to clients.
        /// </summary>
        [Output("active")]
        public Output<bool?> Active { get; private set; } = null!;

        /// <summary>
        /// CDN endpoint CNAME, must be unique among resources.
        /// </summary>
        [Output("cname")]
        public Output<string> Cname { get; private set; } = null!;

        /// <summary>
        /// Creation timestamp of the IoT Core Device
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// CDN Resource settings and options to tune CDN edge behavior.
        /// </summary>
        [Output("options")]
        public Output<Outputs.CdnResourceOptions> Options { get; private set; } = null!;

        [Output("originGroupId")]
        public Output<int?> OriginGroupId { get; private set; } = null!;

        [Output("originGroupName")]
        public Output<string?> OriginGroupName { get; private set; } = null!;

        [Output("originProtocol")]
        public Output<string?> OriginProtocol { get; private set; } = null!;

        /// <summary>
        /// list of secondary hostname strings.
        /// </summary>
        [Output("secondaryHostnames")]
        public Output<ImmutableArray<string>> SecondaryHostnames { get; private set; } = null!;

        /// <summary>
        /// SSL certificate of CDN resource.
        /// ---
        /// </summary>
        [Output("sslCertificate")]
        public Output<Outputs.CdnResourceSslCertificate> SslCertificate { get; private set; } = null!;

        [Output("updatedAt")]
        public Output<string> UpdatedAt { get; private set; } = null!;


        /// <summary>
        /// Create a CdnResource resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CdnResource(string name, CdnResourceArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/cdnResource:CdnResource", name, args ?? new CdnResourceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CdnResource(string name, Input<string> id, CdnResourceState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/cdnResource:CdnResource", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CdnResource resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CdnResource Get(string name, Input<string> id, CdnResourceState? state = null, CustomResourceOptions? options = null)
        {
            return new CdnResource(name, id, state, options);
        }
    }

    public sealed class CdnResourceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Flag to create Resource either in active or disabled state. True - the content from CDN is available to clients.
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        /// <summary>
        /// CDN endpoint CNAME, must be unique among resources.
        /// </summary>
        [Input("cname")]
        public Input<string>? Cname { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// CDN Resource settings and options to tune CDN edge behavior.
        /// </summary>
        [Input("options")]
        public Input<Inputs.CdnResourceOptionsArgs>? Options { get; set; }

        [Input("originGroupId")]
        public Input<int>? OriginGroupId { get; set; }

        [Input("originGroupName")]
        public Input<string>? OriginGroupName { get; set; }

        [Input("originProtocol")]
        public Input<string>? OriginProtocol { get; set; }

        [Input("secondaryHostnames")]
        private InputList<string>? _secondaryHostnames;

        /// <summary>
        /// list of secondary hostname strings.
        /// </summary>
        public InputList<string> SecondaryHostnames
        {
            get => _secondaryHostnames ?? (_secondaryHostnames = new InputList<string>());
            set => _secondaryHostnames = value;
        }

        /// <summary>
        /// SSL certificate of CDN resource.
        /// ---
        /// </summary>
        [Input("sslCertificate")]
        public Input<Inputs.CdnResourceSslCertificateArgs>? SslCertificate { get; set; }

        [Input("updatedAt")]
        public Input<string>? UpdatedAt { get; set; }

        public CdnResourceArgs()
        {
        }
        public static new CdnResourceArgs Empty => new CdnResourceArgs();
    }

    public sealed class CdnResourceState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Flag to create Resource either in active or disabled state. True - the content from CDN is available to clients.
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        /// <summary>
        /// CDN endpoint CNAME, must be unique among resources.
        /// </summary>
        [Input("cname")]
        public Input<string>? Cname { get; set; }

        /// <summary>
        /// Creation timestamp of the IoT Core Device
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// CDN Resource settings and options to tune CDN edge behavior.
        /// </summary>
        [Input("options")]
        public Input<Inputs.CdnResourceOptionsGetArgs>? Options { get; set; }

        [Input("originGroupId")]
        public Input<int>? OriginGroupId { get; set; }

        [Input("originGroupName")]
        public Input<string>? OriginGroupName { get; set; }

        [Input("originProtocol")]
        public Input<string>? OriginProtocol { get; set; }

        [Input("secondaryHostnames")]
        private InputList<string>? _secondaryHostnames;

        /// <summary>
        /// list of secondary hostname strings.
        /// </summary>
        public InputList<string> SecondaryHostnames
        {
            get => _secondaryHostnames ?? (_secondaryHostnames = new InputList<string>());
            set => _secondaryHostnames = value;
        }

        /// <summary>
        /// SSL certificate of CDN resource.
        /// ---
        /// </summary>
        [Input("sslCertificate")]
        public Input<Inputs.CdnResourceSslCertificateGetArgs>? SslCertificate { get; set; }

        [Input("updatedAt")]
        public Input<string>? UpdatedAt { get; set; }

        public CdnResourceState()
        {
        }
        public static new CdnResourceState Empty => new CdnResourceState();
    }
}
