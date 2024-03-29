// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetLockBoxSecretVersion
    {
        /// <summary>
        /// Get information about Yandex Cloud Lockbox secret version. For more information,
        /// see [the official documentation](https://cloud.yandex.com/en/docs/lockbox/).
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
        ///     var mySecretVersion = Yandex.GetLockBoxSecretVersion.Invoke(new()
        ///     {
        ///         SecretId = "some-secret-id",
        ///         VersionId = "some-version-id",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["mySecretEntries"] = mySecretVersion.Apply(getLockBoxSecretVersionResult =&gt; getLockBoxSecretVersionResult.Entries),
        ///     };
        /// });
        /// ```
        /// 
        /// If you're creating the secret in the same project, then you should indicate `version_id`,
        /// since otherwise you may refer to a wrong version of the secret
        /// (e.g. the first version, when it is still empty).
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var mySecret = new Yandex.LockboxSecret("mySecret");
        /// 
        ///     // ...
        ///     var myVersionlockboxSecretVersion = new Yandex.LockboxSecretVersion("myVersionlockboxSecretVersion", new()
        ///     {
        ///         SecretId = mySecret.Id,
        ///     });
        /// 
        ///     // ...
        ///     var myVersionLockBoxSecretVersion = Yandex.GetLockBoxSecretVersion.Invoke(new()
        ///     {
        ///         SecretId = mySecret.Id,
        ///         VersionId = myVersionlockboxSecretVersion.Id,
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["mySecretEntries"] = myVersionlockboxSecretVersion.Entries,
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetLockBoxSecretVersionResult> InvokeAsync(GetLockBoxSecretVersionArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetLockBoxSecretVersionResult>("yandex:index/getLockBoxSecretVersion:getLockBoxSecretVersion", args ?? new GetLockBoxSecretVersionArgs(), options.WithDefaults());

        /// <summary>
        /// Get information about Yandex Cloud Lockbox secret version. For more information,
        /// see [the official documentation](https://cloud.yandex.com/en/docs/lockbox/).
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
        ///     var mySecretVersion = Yandex.GetLockBoxSecretVersion.Invoke(new()
        ///     {
        ///         SecretId = "some-secret-id",
        ///         VersionId = "some-version-id",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["mySecretEntries"] = mySecretVersion.Apply(getLockBoxSecretVersionResult =&gt; getLockBoxSecretVersionResult.Entries),
        ///     };
        /// });
        /// ```
        /// 
        /// If you're creating the secret in the same project, then you should indicate `version_id`,
        /// since otherwise you may refer to a wrong version of the secret
        /// (e.g. the first version, when it is still empty).
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var mySecret = new Yandex.LockboxSecret("mySecret");
        /// 
        ///     // ...
        ///     var myVersionlockboxSecretVersion = new Yandex.LockboxSecretVersion("myVersionlockboxSecretVersion", new()
        ///     {
        ///         SecretId = mySecret.Id,
        ///     });
        /// 
        ///     // ...
        ///     var myVersionLockBoxSecretVersion = Yandex.GetLockBoxSecretVersion.Invoke(new()
        ///     {
        ///         SecretId = mySecret.Id,
        ///         VersionId = myVersionlockboxSecretVersion.Id,
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["mySecretEntries"] = myVersionlockboxSecretVersion.Entries,
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetLockBoxSecretVersionResult> Invoke(GetLockBoxSecretVersionInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetLockBoxSecretVersionResult>("yandex:index/getLockBoxSecretVersion:getLockBoxSecretVersion", args ?? new GetLockBoxSecretVersionInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetLockBoxSecretVersionArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Yandex Cloud Lockbox secret ID.
        /// </summary>
        [Input("secretId", required: true)]
        public string SecretId { get; set; } = null!;

        /// <summary>
        /// The Yandex Cloud Lockbox secret version ID.
        /// </summary>
        [Input("versionId")]
        public string? VersionId { get; set; }

        public GetLockBoxSecretVersionArgs()
        {
        }
        public static new GetLockBoxSecretVersionArgs Empty => new GetLockBoxSecretVersionArgs();
    }

    public sealed class GetLockBoxSecretVersionInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Yandex Cloud Lockbox secret ID.
        /// </summary>
        [Input("secretId", required: true)]
        public Input<string> SecretId { get; set; } = null!;

        /// <summary>
        /// The Yandex Cloud Lockbox secret version ID.
        /// </summary>
        [Input("versionId")]
        public Input<string>? VersionId { get; set; }

        public GetLockBoxSecretVersionInvokeArgs()
        {
        }
        public static new GetLockBoxSecretVersionInvokeArgs Empty => new GetLockBoxSecretVersionInvokeArgs();
    }


    [OutputType]
    public sealed class GetLockBoxSecretVersionResult
    {
        /// <summary>
        /// List of entries in the Yandex Cloud Lockbox secret version.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLockBoxSecretVersionEntryResult> Entries;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string SecretId;
        public readonly string VersionId;

        [OutputConstructor]
        private GetLockBoxSecretVersionResult(
            ImmutableArray<Outputs.GetLockBoxSecretVersionEntryResult> entries,

            string id,

            string secretId,

            string versionId)
        {
            Entries = entries;
            Id = id;
            SecretId = secretId;
            VersionId = versionId;
        }
    }
}
