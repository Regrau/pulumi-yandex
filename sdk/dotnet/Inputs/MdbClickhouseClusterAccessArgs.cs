// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterAccessArgs : global::Pulumi.ResourceArgs
    {
        [Input("dataLens")]
        public Input<bool>? DataLens { get; set; }

        [Input("dataTransfer")]
        public Input<bool>? DataTransfer { get; set; }

        [Input("metrika")]
        public Input<bool>? Metrika { get; set; }

        [Input("serverless")]
        public Input<bool>? Serverless { get; set; }

        [Input("webSql")]
        public Input<bool>? WebSql { get; set; }

        [Input("yandexQuery")]
        public Input<bool>? YandexQuery { get; set; }

        public MdbClickhouseClusterAccessArgs()
        {
        }
        public static new MdbClickhouseClusterAccessArgs Empty => new MdbClickhouseClusterAccessArgs();
    }
}