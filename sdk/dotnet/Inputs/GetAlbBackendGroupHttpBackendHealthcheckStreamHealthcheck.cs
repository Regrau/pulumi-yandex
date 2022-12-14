// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetAlbBackendGroupHttpBackendHealthcheckStreamHealthcheckArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Optional text that must be contained in the messages received from targets for a successful health check.
        /// </summary>
        [Input("receive", required: true)]
        public string Receive { get; set; } = null!;

        /// <summary>
        /// Optional message text sent to targets during TCP data transfer.
        /// </summary>
        [Input("send", required: true)]
        public string Send { get; set; } = null!;

        public GetAlbBackendGroupHttpBackendHealthcheckStreamHealthcheckArgs()
        {
        }
        public static new GetAlbBackendGroupHttpBackendHealthcheckStreamHealthcheckArgs Empty => new GetAlbBackendGroupHttpBackendHealthcheckStreamHealthcheckArgs();
    }
}
