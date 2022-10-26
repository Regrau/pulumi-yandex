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
    /// Allows management of [Yandex.Cloud CDN Origin Groups](https://cloud.yandex.ru/docs/cdn/concepts/origins).
    /// 
    /// &gt; **_NOTE:_**  CDN provider must be activated prior usage of CDN resources, either via UI console or via yc cli command: ```yc cdn provider activate --folder-id &lt;folder-id&gt; --type gcore```
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
    ///     var myGroup = new Yandex.CdnOriginGroup("myGroup", new()
    ///     {
    ///         Origins = new[]
    ///         {
    ///             new Yandex.Inputs.CdnOriginGroupOriginArgs
    ///             {
    ///                 Source = "ya.ru",
    ///             },
    ///             new Yandex.Inputs.CdnOriginGroupOriginArgs
    ///             {
    ///                 Source = "yandex.ru",
    ///             },
    ///             new Yandex.Inputs.CdnOriginGroupOriginArgs
    ///             {
    ///                 Source = "goo.gl",
    ///             },
    ///             new Yandex.Inputs.CdnOriginGroupOriginArgs
    ///             {
    ///                 Backup = false,
    ///                 Source = "amazon.com",
    ///             },
    ///         },
    ///         UseNext = true,
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// A origin group can be imported using any of these accepted formats
    /// 
    /// ```sh
    ///  $ pulumi import yandex:index/cdnOriginGroup:CdnOriginGroup default origin_group_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/cdnOriginGroup:CdnOriginGroup")]
    public partial class CdnOriginGroup : global::Pulumi.CustomResource
    {
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// CDN Origin Group name used to define device.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("origins")]
        public Output<ImmutableArray<Outputs.CdnOriginGroupOrigin>> Origins { get; private set; } = null!;

        /// <summary>
        /// If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
        /// </summary>
        [Output("useNext")]
        public Output<bool?> UseNext { get; private set; } = null!;


        /// <summary>
        /// Create a CdnOriginGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CdnOriginGroup(string name, CdnOriginGroupArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/cdnOriginGroup:CdnOriginGroup", name, args ?? new CdnOriginGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CdnOriginGroup(string name, Input<string> id, CdnOriginGroupState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/cdnOriginGroup:CdnOriginGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CdnOriginGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CdnOriginGroup Get(string name, Input<string> id, CdnOriginGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new CdnOriginGroup(name, id, state, options);
        }
    }

    public sealed class CdnOriginGroupArgs : global::Pulumi.ResourceArgs
    {
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// CDN Origin Group name used to define device.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("origins", required: true)]
        private InputList<Inputs.CdnOriginGroupOriginArgs>? _origins;
        public InputList<Inputs.CdnOriginGroupOriginArgs> Origins
        {
            get => _origins ?? (_origins = new InputList<Inputs.CdnOriginGroupOriginArgs>());
            set => _origins = value;
        }

        /// <summary>
        /// If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
        /// </summary>
        [Input("useNext")]
        public Input<bool>? UseNext { get; set; }

        public CdnOriginGroupArgs()
        {
        }
        public static new CdnOriginGroupArgs Empty => new CdnOriginGroupArgs();
    }

    public sealed class CdnOriginGroupState : global::Pulumi.ResourceArgs
    {
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// CDN Origin Group name used to define device.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("origins")]
        private InputList<Inputs.CdnOriginGroupOriginGetArgs>? _origins;
        public InputList<Inputs.CdnOriginGroupOriginGetArgs> Origins
        {
            get => _origins ?? (_origins = new InputList<Inputs.CdnOriginGroupOriginGetArgs>());
            set => _origins = value;
        }

        /// <summary>
        /// If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
        /// </summary>
        [Input("useNext")]
        public Input<bool>? UseNext { get; set; }

        public CdnOriginGroupState()
        {
        }
        public static new CdnOriginGroupState Empty => new CdnOriginGroupState();
    }
}
