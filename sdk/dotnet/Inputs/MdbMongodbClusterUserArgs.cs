// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbMongodbClusterUserArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The fully qualified domain name of the host. Computed on server side.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("password", required: true)]
        private Input<string>? _password;

        /// <summary>
        /// The password of the user.
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("permissions")]
        private InputList<Inputs.MdbMongodbClusterUserPermissionArgs>? _permissions;

        /// <summary>
        /// Set of permissions granted to the user. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbMongodbClusterUserPermissionArgs> Permissions
        {
            get => _permissions ?? (_permissions = new InputList<Inputs.MdbMongodbClusterUserPermissionArgs>());
            set => _permissions = value;
        }

        public MdbMongodbClusterUserArgs()
        {
        }
        public static new MdbMongodbClusterUserArgs Empty => new MdbMongodbClusterUserArgs();
    }
}
