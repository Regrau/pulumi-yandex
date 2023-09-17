// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterUserArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the ClickHouse cluster.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        [Input("password")]
        private string? _password;

        /// <summary>
        /// RabbitMQ user password.
        /// </summary>
        public string? Password
        {
            get => _password;
            set => _password = value;
        }

        [Input("permissions", required: true)]
        private List<Inputs.GetMdbClickhouseClusterUserPermissionArgs>? _permissions;

        /// <summary>
        /// Set of permissions granted to the user. The structure is documented below.
        /// </summary>
        public List<Inputs.GetMdbClickhouseClusterUserPermissionArgs> Permissions
        {
            get => _permissions ?? (_permissions = new List<Inputs.GetMdbClickhouseClusterUserPermissionArgs>());
            set => _permissions = value;
        }

        [Input("quotas", required: true)]
        private List<Inputs.GetMdbClickhouseClusterUserQuotaArgs>? _quotas;

        /// <summary>
        /// Set of user quotas. The structure is documented below.
        /// </summary>
        public List<Inputs.GetMdbClickhouseClusterUserQuotaArgs> Quotas
        {
            get => _quotas ?? (_quotas = new List<Inputs.GetMdbClickhouseClusterUserQuotaArgs>());
            set => _quotas = value;
        }

        /// <summary>
        /// Kafka connection settngs sanem as `kafka` block.
        /// </summary>
        [Input("settings", required: true)]
        public Inputs.GetMdbClickhouseClusterUserSettingsArgs Settings { get; set; } = null!;

        public GetMdbClickhouseClusterUserArgs()
        {
        }
        public static new GetMdbClickhouseClusterUserArgs Empty => new GetMdbClickhouseClusterUserArgs();
    }
}
