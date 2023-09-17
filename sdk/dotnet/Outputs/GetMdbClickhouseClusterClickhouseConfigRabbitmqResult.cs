// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class GetMdbClickhouseClusterClickhouseConfigRabbitmqResult
    {
        /// <summary>
        /// RabbitMQ user password.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// RabbitMQ username.
        /// </summary>
        public readonly string Username;
        /// <summary>
        /// (Optional) RabbitMQ vhost. Default: '\'.
        /// </summary>
        public readonly string Vhost;

        [OutputConstructor]
        private GetMdbClickhouseClusterClickhouseConfigRabbitmqResult(
            string password,

            string username,

            string vhost)
        {
            Password = password;
            Username = username;
            Vhost = vhost;
        }
    }
}
