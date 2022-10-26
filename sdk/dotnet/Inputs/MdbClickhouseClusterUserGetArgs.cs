// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterUserGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Graphite rollup configuration name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// RabbitMQ user password.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        [Input("permissions")]
        private InputList<Inputs.MdbClickhouseClusterUserPermissionGetArgs>? _permissions;

        /// <summary>
        /// Set of permissions granted to the user. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterUserPermissionGetArgs> Permissions
        {
            get => _permissions ?? (_permissions = new InputList<Inputs.MdbClickhouseClusterUserPermissionGetArgs>());
            set => _permissions = value;
        }

        [Input("quotas")]
        private InputList<Inputs.MdbClickhouseClusterUserQuotaGetArgs>? _quotas;

        /// <summary>
        /// Set of user quotas. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterUserQuotaGetArgs> Quotas
        {
            get => _quotas ?? (_quotas = new InputList<Inputs.MdbClickhouseClusterUserQuotaGetArgs>());
            set => _quotas = value;
        }

        /// <summary>
        /// Kafka connection settngs sanem as `kafka` block.
        /// </summary>
        [Input("settings")]
        public Input<Inputs.MdbClickhouseClusterUserSettingsGetArgs>? Settings { get; set; }

        public MdbClickhouseClusterUserGetArgs()
        {
        }
        public static new MdbClickhouseClusterUserGetArgs Empty => new MdbClickhouseClusterUserGetArgs();
    }
}
