// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsKafkaSourceParserJsonParserDataSchemaFieldsFieldArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// -Mark field as Primary Key.
        /// </summary>
        [Input("key")]
        public Input<bool>? Key { get; set; }

        /// <summary>
        /// Name of the endpoint.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Path to the field.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// Mark field as required.
        /// </summary>
        [Input("required")]
        public Input<bool>? Required { get; set; }

        /// <summary>
        /// Field type, one of: `INT64`, `INT32`, `INT16`, `INT8`, `UINT64`, `UINT32`, `UINT16`, `UINT8`, `DOUBLE`, `BOOLEAN`, `STRING`, `UTF8`, `ANY`, `DATETIME`.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public DatatransferEndpointSettingsKafkaSourceParserJsonParserDataSchemaFieldsFieldArgs()
        {
        }
        public static new DatatransferEndpointSettingsKafkaSourceParserJsonParserDataSchemaFieldsFieldArgs Empty => new DatatransferEndpointSettingsKafkaSourceParserJsonParserDataSchemaFieldsFieldArgs();
    }
}
