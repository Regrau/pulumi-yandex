// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsKafkaSourceParserTskvParserArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Add fields, that are not in the schema, into the _rest column.
        /// </summary>
        [Input("addRestColumn")]
        public Input<bool>? AddRestColumn { get; set; }

        /// <summary>
        /// Data parsing scheme.The structure is documented below.
        /// </summary>
        [Input("dataSchema")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaSourceParserTskvParserDataSchemaArgs>? DataSchema { get; set; }

        /// <summary>
        /// Allow null keys. If `false` - null keys will be putted to unparsed data
        /// </summary>
        [Input("nullKeysAllowed")]
        public Input<bool>? NullKeysAllowed { get; set; }

        public DatatransferEndpointSettingsKafkaSourceParserTskvParserArgs()
        {
        }
        public static new DatatransferEndpointSettingsKafkaSourceParserTskvParserArgs Empty => new DatatransferEndpointSettingsKafkaSourceParserTskvParserArgs();
    }
}
