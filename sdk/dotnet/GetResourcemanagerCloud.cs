// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetResourcemanagerCloud
    {
        /// <summary>
        /// Use this data source to get cloud details.
        /// For more information, see [Cloud](https://cloud.yandex.com/docs/resource-manager/concepts/resources-hierarchy#cloud).
        /// 
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
        ///     var foo = Yandex.GetResourcemanagerCloud.Invoke(new()
        ///     {
        ///         Name = "foo-cloud",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["cloudCreateTimestamp"] = foo.Apply(getResourcemanagerCloudResult =&gt; getResourcemanagerCloudResult.CreatedAt),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetResourcemanagerCloudResult> InvokeAsync(GetResourcemanagerCloudArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetResourcemanagerCloudResult>("yandex:index/getResourcemanagerCloud:getResourcemanagerCloud", args ?? new GetResourcemanagerCloudArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to get cloud details.
        /// For more information, see [Cloud](https://cloud.yandex.com/docs/resource-manager/concepts/resources-hierarchy#cloud).
        /// 
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
        ///     var foo = Yandex.GetResourcemanagerCloud.Invoke(new()
        ///     {
        ///         Name = "foo-cloud",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["cloudCreateTimestamp"] = foo.Apply(getResourcemanagerCloudResult =&gt; getResourcemanagerCloudResult.CreatedAt),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetResourcemanagerCloudResult> Invoke(GetResourcemanagerCloudInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetResourcemanagerCloudResult>("yandex:index/getResourcemanagerCloud:getResourcemanagerCloud", args ?? new GetResourcemanagerCloudInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetResourcemanagerCloudArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of the cloud.
        /// </summary>
        [Input("cloudId")]
        public string? CloudId { get; set; }

        /// <summary>
        /// Description of the cloud.
        /// </summary>
        [Input("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name of the cloud.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        public GetResourcemanagerCloudArgs()
        {
        }
        public static new GetResourcemanagerCloudArgs Empty => new GetResourcemanagerCloudArgs();
    }

    public sealed class GetResourcemanagerCloudInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of the cloud.
        /// </summary>
        [Input("cloudId")]
        public Input<string>? CloudId { get; set; }

        /// <summary>
        /// Description of the cloud.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Name of the cloud.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetResourcemanagerCloudInvokeArgs()
        {
        }
        public static new GetResourcemanagerCloudInvokeArgs Empty => new GetResourcemanagerCloudInvokeArgs();
    }


    [OutputType]
    public sealed class GetResourcemanagerCloudResult
    {
        public readonly string CloudId;
        /// <summary>
        /// Cloud creation timestamp.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// Description of the cloud.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Name of the cloud.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetResourcemanagerCloudResult(
            string cloudId,

            string createdAt,

            string? description,

            string id,

            string name)
        {
            CloudId = cloudId;
            CreatedAt = createdAt;
            Description = description;
            Id = id;
            Name = name;
        }
    }
}
