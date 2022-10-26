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
    public sealed class MdbMysqlClusterUserConnectionLimits
    {
        /// <summary>
        /// Max connections per hour.
        /// </summary>
        public readonly int? MaxConnectionsPerHour;
        /// <summary>
        /// Max questions per hour.
        /// </summary>
        public readonly int? MaxQuestionsPerHour;
        /// <summary>
        /// Max updates per hour.
        /// </summary>
        public readonly int? MaxUpdatesPerHour;
        /// <summary>
        /// Max user connections.
        /// </summary>
        public readonly int? MaxUserConnections;

        [OutputConstructor]
        private MdbMysqlClusterUserConnectionLimits(
            int? maxConnectionsPerHour,

            int? maxQuestionsPerHour,

            int? maxUpdatesPerHour,

            int? maxUserConnections)
        {
            MaxConnectionsPerHour = maxConnectionsPerHour;
            MaxQuestionsPerHour = maxQuestionsPerHour;
            MaxUpdatesPerHour = maxUpdatesPerHour;
            MaxUserConnections = maxUserConnections;
        }
    }
}
