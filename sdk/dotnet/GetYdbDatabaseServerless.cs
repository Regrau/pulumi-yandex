// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetYdbDatabaseServerless
    {
        /// <summary>
        /// Get information about a Yandex Database serverless cluster.
        /// For more information, see [the official documentation](https://cloud.yandex.com/en/docs/ydb/concepts/serverless_and_dedicated).
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
        ///     var myDatabase = Yandex.GetYdbDatabaseServerless.Invoke(new()
        ///     {
        ///         DatabaseId = "some_ydb_serverless_database_id",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["ydbApiEndpoint"] = myDatabase.Apply(getYdbDatabaseServerlessResult =&gt; getYdbDatabaseServerlessResult.YdbApiEndpoint),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetYdbDatabaseServerlessResult> InvokeAsync(GetYdbDatabaseServerlessArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetYdbDatabaseServerlessResult>("yandex:index/getYdbDatabaseServerless:getYdbDatabaseServerless", args ?? new GetYdbDatabaseServerlessArgs(), options.WithDefaults());

        /// <summary>
        /// Get information about a Yandex Database serverless cluster.
        /// For more information, see [the official documentation](https://cloud.yandex.com/en/docs/ydb/concepts/serverless_and_dedicated).
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
        ///     var myDatabase = Yandex.GetYdbDatabaseServerless.Invoke(new()
        ///     {
        ///         DatabaseId = "some_ydb_serverless_database_id",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["ydbApiEndpoint"] = myDatabase.Apply(getYdbDatabaseServerlessResult =&gt; getYdbDatabaseServerlessResult.YdbApiEndpoint),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetYdbDatabaseServerlessResult> Invoke(GetYdbDatabaseServerlessInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetYdbDatabaseServerlessResult>("yandex:index/getYdbDatabaseServerless:getYdbDatabaseServerless", args ?? new GetYdbDatabaseServerlessInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetYdbDatabaseServerlessArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of the Yandex Database serverless cluster.
        /// </summary>
        [Input("databaseId")]
        public string? DatabaseId { get; set; }

        /// <summary>
        /// Inhibits deletion of the database. Can be either `true` or `false`
        /// </summary>
        [Input("deletionProtection")]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// ID of the folder that the Yandex Database serverless cluster belongs to.
        /// It will be deduced from provider configuration if not set explicitly.
        /// </summary>
        [Input("folderId")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Name of the Yandex Database serverless cluster.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        [Input("serverlessDatabases")]
        private List<Inputs.GetYdbDatabaseServerlessServerlessDatabaseArgs>? _serverlessDatabases;
        public List<Inputs.GetYdbDatabaseServerlessServerlessDatabaseArgs> ServerlessDatabases
        {
            get => _serverlessDatabases ?? (_serverlessDatabases = new List<Inputs.GetYdbDatabaseServerlessServerlessDatabaseArgs>());
            set => _serverlessDatabases = value;
        }

        public GetYdbDatabaseServerlessArgs()
        {
        }
        public static new GetYdbDatabaseServerlessArgs Empty => new GetYdbDatabaseServerlessArgs();
    }

    public sealed class GetYdbDatabaseServerlessInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of the Yandex Database serverless cluster.
        /// </summary>
        [Input("databaseId")]
        public Input<string>? DatabaseId { get; set; }

        /// <summary>
        /// Inhibits deletion of the database. Can be either `true` or `false`
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// ID of the folder that the Yandex Database serverless cluster belongs to.
        /// It will be deduced from provider configuration if not set explicitly.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// Name of the Yandex Database serverless cluster.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("serverlessDatabases")]
        private InputList<Inputs.GetYdbDatabaseServerlessServerlessDatabaseInputArgs>? _serverlessDatabases;
        public InputList<Inputs.GetYdbDatabaseServerlessServerlessDatabaseInputArgs> ServerlessDatabases
        {
            get => _serverlessDatabases ?? (_serverlessDatabases = new InputList<Inputs.GetYdbDatabaseServerlessServerlessDatabaseInputArgs>());
            set => _serverlessDatabases = value;
        }

        public GetYdbDatabaseServerlessInvokeArgs()
        {
        }
        public static new GetYdbDatabaseServerlessInvokeArgs Empty => new GetYdbDatabaseServerlessInvokeArgs();
    }


    [OutputType]
    public sealed class GetYdbDatabaseServerlessResult
    {
        /// <summary>
        /// The Yandex Database serverless cluster creation timestamp.
        /// </summary>
        public readonly string CreatedAt;
        public readonly string? DatabaseId;
        /// <summary>
        /// Full database path of the Yandex Database serverless cluster.
        /// Useful for SDK configuration.
        /// </summary>
        public readonly string DatabasePath;
        /// <summary>
        /// Inhibits deletion of the database. Can be either `true` or `false`
        /// </summary>
        public readonly bool DeletionProtection;
        /// <summary>
        /// A description of the Yandex Database serverless cluster.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Document API endpoint of the Yandex Database serverless cluster.
        /// </summary>
        public readonly string DocumentApiEndpoint;
        public readonly string? FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A set of key/value label pairs assigned to the Yandex Database serverless cluster.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        /// <summary>
        /// Location ID of the Yandex Database serverless cluster.
        /// </summary>
        public readonly string LocationId;
        public readonly string? Name;
        public readonly ImmutableArray<Outputs.GetYdbDatabaseServerlessServerlessDatabaseResult> ServerlessDatabases;
        /// <summary>
        /// Status of the Yandex Database serverless cluster.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Whether TLS is enabled for the Yandex Database serverless cluster.
        /// Useful for SDK configuration.
        /// </summary>
        public readonly bool TlsEnabled;
        /// <summary>
        /// API endpoint of the Yandex Database serverless cluster.
        /// Useful for SDK configuration.
        /// </summary>
        public readonly string YdbApiEndpoint;
        /// <summary>
        /// Full endpoint of the Yandex Database serverless cluster.
        /// </summary>
        public readonly string YdbFullEndpoint;

        [OutputConstructor]
        private GetYdbDatabaseServerlessResult(
            string createdAt,

            string? databaseId,

            string databasePath,

            bool deletionProtection,

            string description,

            string documentApiEndpoint,

            string? folderId,

            string id,

            ImmutableDictionary<string, string> labels,

            string locationId,

            string? name,

            ImmutableArray<Outputs.GetYdbDatabaseServerlessServerlessDatabaseResult> serverlessDatabases,

            string status,

            bool tlsEnabled,

            string ydbApiEndpoint,

            string ydbFullEndpoint)
        {
            CreatedAt = createdAt;
            DatabaseId = databaseId;
            DatabasePath = databasePath;
            DeletionProtection = deletionProtection;
            Description = description;
            DocumentApiEndpoint = documentApiEndpoint;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            LocationId = locationId;
            Name = name;
            ServerlessDatabases = serverlessDatabases;
            Status = status;
            TlsEnabled = tlsEnabled;
            YdbApiEndpoint = ydbApiEndpoint;
            YdbFullEndpoint = ydbFullEndpoint;
        }
    }
}
