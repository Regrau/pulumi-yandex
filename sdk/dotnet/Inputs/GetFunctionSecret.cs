// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetFunctionSecretArgs : global::Pulumi.InvokeArgs
    {
        [Input("environmentVariable", required: true)]
        public string EnvironmentVariable { get; set; } = null!;

        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("key", required: true)]
        public string Key { get; set; } = null!;

        [Input("versionId", required: true)]
        public string VersionId { get; set; } = null!;

        public GetFunctionSecretArgs()
        {
        }
        public static new GetFunctionSecretArgs Empty => new GetFunctionSecretArgs();
    }
}
