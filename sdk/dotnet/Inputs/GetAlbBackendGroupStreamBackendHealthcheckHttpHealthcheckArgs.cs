// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetAlbBackendGroupStreamBackendHealthcheckHttpHealthcheckInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        [Input("http2", required: true)]
        public Input<bool> Http2 { get; set; } = null!;

        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        public GetAlbBackendGroupStreamBackendHealthcheckHttpHealthcheckInputArgs()
        {
        }
        public static new GetAlbBackendGroupStreamBackendHealthcheckHttpHealthcheckInputArgs Empty => new GetAlbBackendGroupStreamBackendHealthcheckHttpHealthcheckInputArgs();
    }
}
