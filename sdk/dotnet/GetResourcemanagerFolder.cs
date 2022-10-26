// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetResourcemanagerFolder
    {
        /// <summary>
        /// Use this data source to get information about a Yandex Resource Manager Folder. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/resource-manager/concepts/resources-hierarchy#folder).
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var myFolder1 = Yandex.GetResourcemanagerFolder.Invoke(new()
        ///     {
        ///         FolderId = "folder_id_number_1",
        ///     });
        /// 
        ///     var myFolder2 = Yandex.GetResourcemanagerFolder.Invoke(new()
        ///     {
        ///         CloudId = "some_cloud_id",
        ///         Name = "folder_name",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["myFolder1Name"] = myFolder1.Apply(getResourcemanagerFolderResult =&gt; getResourcemanagerFolderResult.Name),
        ///         ["myFolder2CloudId"] = myFolder2.Apply(getResourcemanagerFolderResult =&gt; getResourcemanagerFolderResult.CloudId),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Task<GetResourcemanagerFolderResult> InvokeAsync(GetResourcemanagerFolderArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetResourcemanagerFolderResult>("yandex:index/getResourcemanagerFolder:getResourcemanagerFolder", args ?? new GetResourcemanagerFolderArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to get information about a Yandex Resource Manager Folder. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/resource-manager/concepts/resources-hierarchy#folder).
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var myFolder1 = Yandex.GetResourcemanagerFolder.Invoke(new()
        ///     {
        ///         FolderId = "folder_id_number_1",
        ///     });
        /// 
        ///     var myFolder2 = Yandex.GetResourcemanagerFolder.Invoke(new()
        ///     {
        ///         CloudId = "some_cloud_id",
        ///         Name = "folder_name",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["myFolder1Name"] = myFolder1.Apply(getResourcemanagerFolderResult =&gt; getResourcemanagerFolderResult.Name),
        ///         ["myFolder2CloudId"] = myFolder2.Apply(getResourcemanagerFolderResult =&gt; getResourcemanagerFolderResult.CloudId),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetResourcemanagerFolderResult> Invoke(GetResourcemanagerFolderInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetResourcemanagerFolderResult>("yandex:index/getResourcemanagerFolder:getResourcemanagerFolder", args ?? new GetResourcemanagerFolderInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetResourcemanagerFolderArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Cloud that the resource belongs to. If value is omitted, the default provider cloud is used.
        /// </summary>
        [Input("cloudId")]
        public string? CloudId { get; set; }

        /// <summary>
        /// ID of the folder.
        /// </summary>
        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("labels")]
        private Dictionary<string, string>? _labels;

        /// <summary>
        /// A map of labels applied to this folder.
        /// </summary>
        public Dictionary<string, string> Labels
        {
            get => _labels ?? (_labels = new Dictionary<string, string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the folder.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        public GetResourcemanagerFolderArgs()
        {
        }
        public static new GetResourcemanagerFolderArgs Empty => new GetResourcemanagerFolderArgs();
    }

    public sealed class GetResourcemanagerFolderInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Cloud that the resource belongs to. If value is omitted, the default provider cloud is used.
        /// </summary>
        [Input("cloudId")]
        public Input<string>? CloudId { get; set; }

        /// <summary>
        /// ID of the folder.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A map of labels applied to this folder.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the folder.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetResourcemanagerFolderInvokeArgs()
        {
        }
        public static new GetResourcemanagerFolderInvokeArgs Empty => new GetResourcemanagerFolderInvokeArgs();
    }


    [OutputType]
    public sealed class GetResourcemanagerFolderResult
    {
        /// <summary>
        /// ID of the cloud that contains the folder.
        /// </summary>
        public readonly string CloudId;
        /// <summary>
        /// Folder creation timestamp.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// Description of the folder.
        /// </summary>
        public readonly string Description;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A map of labels applied to this folder.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Labels;
        public readonly string Name;
        /// <summary>
        /// Current status of the folder.
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private GetResourcemanagerFolderResult(
            string cloudId,

            string createdAt,

            string description,

            string folderId,

            string id,

            ImmutableDictionary<string, string>? labels,

            string name,

            string status)
        {
            CloudId = cloudId;
            CreatedAt = createdAt;
            Description = description;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            Name = name;
            Status = status;
        }
    }
}
