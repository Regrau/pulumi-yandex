// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class StorageBucketCorsRule
    {
        public readonly ImmutableArray<string> AllowedHeaders;
        public readonly ImmutableArray<string> AllowedMethods;
        public readonly ImmutableArray<string> AllowedOrigins;
        public readonly ImmutableArray<string> ExposeHeaders;
        public readonly int? MaxAgeSeconds;

        [OutputConstructor]
        private StorageBucketCorsRule(
            ImmutableArray<string> allowedHeaders,

            ImmutableArray<string> allowedMethods,

            ImmutableArray<string> allowedOrigins,

            ImmutableArray<string> exposeHeaders,

            int? maxAgeSeconds)
        {
            AllowedHeaders = allowedHeaders;
            AllowedMethods = allowedMethods;
            AllowedOrigins = allowedOrigins;
            ExposeHeaders = exposeHeaders;
            MaxAgeSeconds = maxAgeSeconds;
        }
    }
}
