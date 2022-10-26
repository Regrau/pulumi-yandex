// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMysqlClusterAccessInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Allow access for [Yandex DataLens](https://cloud.yandex.com/services/datalens).
        /// </summary>
        [Input("dataLens", required: true)]
        public Input<bool> DataLens { get; set; } = null!;

        /// <summary>
        /// (Optional) Allow access for [DataTransfer](https://cloud.yandex.com/services/data-transfer)
        /// </summary>
        [Input("dataTransfer", required: true)]
        public Input<bool> DataTransfer { get; set; } = null!;

        /// <summary>
        /// Allows access for [SQL queries in the management console](https://cloud.yandex.com/docs/managed-mysql/operations/web-sql-query).
        /// </summary>
        [Input("webSql", required: true)]
        public Input<bool> WebSql { get; set; } = null!;

        public GetMdbMysqlClusterAccessInputArgs()
        {
        }
        public static new GetMdbMysqlClusterAccessInputArgs Empty => new GetMdbMysqlClusterAccessInputArgs();
    }
}
