// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("clickhouseSource")]
        public Input<Inputs.DatatransferEndpointSettingsClickhouseSourceGetArgs>? ClickhouseSource { get; set; }

        [Input("clickhouseTarget")]
        public Input<Inputs.DatatransferEndpointSettingsClickhouseTargetGetArgs>? ClickhouseTarget { get; set; }

        [Input("mongoSource")]
        public Input<Inputs.DatatransferEndpointSettingsMongoSourceGetArgs>? MongoSource { get; set; }

        [Input("mongoTarget")]
        public Input<Inputs.DatatransferEndpointSettingsMongoTargetGetArgs>? MongoTarget { get; set; }

        /// <summary>
        /// Settings specific to the MySQL source endpoint.
        /// </summary>
        [Input("mysqlSource")]
        public Input<Inputs.DatatransferEndpointSettingsMysqlSourceGetArgs>? MysqlSource { get; set; }

        /// <summary>
        /// Settings specific to the MySQL target endpoint.
        /// </summary>
        [Input("mysqlTarget")]
        public Input<Inputs.DatatransferEndpointSettingsMysqlTargetGetArgs>? MysqlTarget { get; set; }

        /// <summary>
        /// Settings specific to the PostgreSQL source endpoint.
        /// </summary>
        [Input("postgresSource")]
        public Input<Inputs.DatatransferEndpointSettingsPostgresSourceGetArgs>? PostgresSource { get; set; }

        /// <summary>
        /// Settings specific to the PostgreSQL target endpoint.
        /// </summary>
        [Input("postgresTarget")]
        public Input<Inputs.DatatransferEndpointSettingsPostgresTargetGetArgs>? PostgresTarget { get; set; }

        public DatatransferEndpointSettingsGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsGetArgs Empty => new DatatransferEndpointSettingsGetArgs();
    }
}
