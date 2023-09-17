// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterAccessInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Allow access for Web SQL.
        /// </summary>
        [Input("dataLens")]
        public Input<bool>? DataLens { get; set; }

        /// <summary>
        /// Allow access for DataTransfer
        /// </summary>
        [Input("dataTransfer")]
        public Input<bool>? DataTransfer { get; set; }

        /// <summary>
        /// Allow access for Yandex.Metrika.
        /// </summary>
        [Input("metrika")]
        public Input<bool>? Metrika { get; set; }

        /// <summary>
        /// Allow access for Serverless.
        /// </summary>
        [Input("serverless")]
        public Input<bool>? Serverless { get; set; }

        /// <summary>
        /// Allow access for DataLens.
        /// </summary>
        [Input("webSql")]
        public Input<bool>? WebSql { get; set; }

        /// <summary>
        /// Allow access for YandexQuery
        /// </summary>
        [Input("yandexQuery")]
        public Input<bool>? YandexQuery { get; set; }

        public GetMdbClickhouseClusterAccessInputArgs()
        {
        }
        public static new GetMdbClickhouseClusterAccessInputArgs Empty => new GetMdbClickhouseClusterAccessInputArgs();
    }
}
