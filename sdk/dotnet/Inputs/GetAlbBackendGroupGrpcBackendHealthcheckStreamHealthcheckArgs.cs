// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("receive", required: true)]
        public Input<string> Receive { get; set; } = null!;

        [Input("send", required: true)]
        public Input<string> Send { get; set; } = null!;

        public GetAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckInputArgs()
        {
        }
        public static new GetAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckInputArgs Empty => new GetAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckInputArgs();
    }
}
