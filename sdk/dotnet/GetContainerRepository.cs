// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetContainerRepository
    {
        /// <summary>
        /// Get information about a Yandex Container Repository. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/container-registry/concepts/repository)
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
        ///     var repo_1 = Yandex.GetContainerRepository.Invoke(new()
        ///     {
        ///         Name = "some_repository_name",
        ///     });
        /// 
        ///     var repo_2 = Yandex.GetContainerRepository.Invoke(new()
        ///     {
        ///         RepositoryId = "some_repository_id",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetContainerRepositoryResult> InvokeAsync(GetContainerRepositoryArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetContainerRepositoryResult>("yandex:index/getContainerRepository:getContainerRepository", args ?? new GetContainerRepositoryArgs(), options.WithDefaults());

        /// <summary>
        /// Get information about a Yandex Container Repository. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/container-registry/concepts/repository)
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
        ///     var repo_1 = Yandex.GetContainerRepository.Invoke(new()
        ///     {
        ///         Name = "some_repository_name",
        ///     });
        /// 
        ///     var repo_2 = Yandex.GetContainerRepository.Invoke(new()
        ///     {
        ///         RepositoryId = "some_repository_id",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetContainerRepositoryResult> Invoke(GetContainerRepositoryInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetContainerRepositoryResult>("yandex:index/getContainerRepository:getContainerRepository", args ?? new GetContainerRepositoryInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetContainerRepositoryArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the repository. The name of the repository should start with id of a container registry and match the name of the images in the repository.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The ID of a specific repository.
        /// </summary>
        [Input("repositoryId")]
        public string? RepositoryId { get; set; }

        public GetContainerRepositoryArgs()
        {
        }
        public static new GetContainerRepositoryArgs Empty => new GetContainerRepositoryArgs();
    }

    public sealed class GetContainerRepositoryInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the repository. The name of the repository should start with id of a container registry and match the name of the images in the repository.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of a specific repository.
        /// </summary>
        [Input("repositoryId")]
        public Input<string>? RepositoryId { get; set; }

        public GetContainerRepositoryInvokeArgs()
        {
        }
        public static new GetContainerRepositoryInvokeArgs Empty => new GetContainerRepositoryInvokeArgs();
    }


    [OutputType]
    public sealed class GetContainerRepositoryResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly string RepositoryId;

        [OutputConstructor]
        private GetContainerRepositoryResult(
            string id,

            string name,

            string repositoryId)
        {
            Id = id;
            Name = name;
            RepositoryId = repositoryId;
        }
    }
}
