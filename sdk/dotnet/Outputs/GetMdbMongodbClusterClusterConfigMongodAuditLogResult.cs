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
    public sealed class GetMdbMongodbClusterClusterConfigMongodAuditLogResult
    {
        /// <summary>
        /// (Optional) Configuration of the audit log filter in JSON format.
        /// For more information see [auditLog.filter](https://www.mongodb.com/docs/manual/reference/configuration-options/#mongodb-setting-auditLog.filter)
        /// description in the official documentation. Available only in enterprise edition.
        /// </summary>
        public readonly string? Filter;
        public readonly bool? RuntimeConfiguration;

        [OutputConstructor]
        private GetMdbMongodbClusterClusterConfigMongodAuditLogResult(
            string? filter,

            bool? runtimeConfiguration)
        {
            Filter = filter;
            RuntimeConfiguration = runtimeConfiguration;
        }
    }
}
