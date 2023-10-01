// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetMdbPostgresqlUser
    {
        /// <summary>
        /// Get information about a Yandex Managed PostgreSQL user. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/managed-postgresql/).
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
        ///     var foo = Yandex.GetMdbPostgresqlUser.Invoke(new()
        ///     {
        ///         ClusterId = "some_cluster_id",
        ///         Name = "test",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["permission"] = foo.Apply(getMdbPostgresqlUserResult =&gt; getMdbPostgresqlUserResult.Permissions),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetMdbPostgresqlUserResult> InvokeAsync(GetMdbPostgresqlUserArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetMdbPostgresqlUserResult>("yandex:index/getMdbPostgresqlUser:getMdbPostgresqlUser", args ?? new GetMdbPostgresqlUserArgs(), options.WithDefaults());

        /// <summary>
        /// Get information about a Yandex Managed PostgreSQL user. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/managed-postgresql/).
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
        ///     var foo = Yandex.GetMdbPostgresqlUser.Invoke(new()
        ///     {
        ///         ClusterId = "some_cluster_id",
        ///         Name = "test",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["permission"] = foo.Apply(getMdbPostgresqlUserResult =&gt; getMdbPostgresqlUserResult.Permissions),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetMdbPostgresqlUserResult> Invoke(GetMdbPostgresqlUserInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetMdbPostgresqlUserResult>("yandex:index/getMdbPostgresqlUser:getMdbPostgresqlUser", args ?? new GetMdbPostgresqlUserInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMdbPostgresqlUserArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the PostgreSQL cluster.
        /// </summary>
        [Input("clusterId", required: true)]
        public string ClusterId { get; set; } = null!;

        /// <summary>
        /// The maximum number of connections per user.
        /// </summary>
        [Input("connLimit")]
        public int? ConnLimit { get; set; }

        /// <summary>
        /// Inhibits deletion of the user.
        /// </summary>
        [Input("deletionProtection")]
        public string? DeletionProtection { get; set; }

        /// <summary>
        /// User's ability to login.
        /// </summary>
        [Input("login")]
        public bool? Login { get; set; }

        /// <summary>
        /// The name of the PostgreSQL user.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("settings")]
        private Dictionary<string, string>? _settings;

        /// <summary>
        /// Map of user settings.
        /// </summary>
        public Dictionary<string, string> Settings
        {
            get => _settings ?? (_settings = new Dictionary<string, string>());
            set => _settings = value;
        }

        public GetMdbPostgresqlUserArgs()
        {
        }
        public static new GetMdbPostgresqlUserArgs Empty => new GetMdbPostgresqlUserArgs();
    }

    public sealed class GetMdbPostgresqlUserInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the PostgreSQL cluster.
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        /// <summary>
        /// The maximum number of connections per user.
        /// </summary>
        [Input("connLimit")]
        public Input<int>? ConnLimit { get; set; }

        /// <summary>
        /// Inhibits deletion of the user.
        /// </summary>
        [Input("deletionProtection")]
        public Input<string>? DeletionProtection { get; set; }

        /// <summary>
        /// User's ability to login.
        /// </summary>
        [Input("login")]
        public Input<bool>? Login { get; set; }

        /// <summary>
        /// The name of the PostgreSQL user.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("settings")]
        private InputMap<string>? _settings;

        /// <summary>
        /// Map of user settings.
        /// </summary>
        public InputMap<string> Settings
        {
            get => _settings ?? (_settings = new InputMap<string>());
            set => _settings = value;
        }

        public GetMdbPostgresqlUserInvokeArgs()
        {
        }
        public static new GetMdbPostgresqlUserInvokeArgs Empty => new GetMdbPostgresqlUserInvokeArgs();
    }


    [OutputType]
    public sealed class GetMdbPostgresqlUserResult
    {
        public readonly string ClusterId;
        /// <summary>
        /// The maximum number of connections per user.
        /// </summary>
        public readonly int? ConnLimit;
        /// <summary>
        /// Inhibits deletion of the user.
        /// </summary>
        public readonly string? DeletionProtection;
        /// <summary>
        /// List of the user's grants.
        /// </summary>
        public readonly ImmutableArray<string> Grants;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// User's ability to login.
        /// </summary>
        public readonly bool? Login;
        public readonly string Name;
        /// <summary>
        /// The password of the user.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// Set of permissions granted to the user. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbPostgresqlUserPermissionResult> Permissions;
        /// <summary>
        /// Map of user settings.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Settings;

        [OutputConstructor]
        private GetMdbPostgresqlUserResult(
            string clusterId,

            int? connLimit,

            string? deletionProtection,

            ImmutableArray<string> grants,

            string id,

            bool? login,

            string name,

            string password,

            ImmutableArray<Outputs.GetMdbPostgresqlUserPermissionResult> permissions,

            ImmutableDictionary<string, string> settings)
        {
            ClusterId = clusterId;
            ConnLimit = connLimit;
            DeletionProtection = deletionProtection;
            Grants = grants;
            Id = id;
            Login = login;
            Name = name;
            Password = password;
            Permissions = permissions;
            Settings = settings;
        }
    }
}