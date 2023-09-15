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
    public sealed class YandexYdbTopicConsumer
    {
        /// <summary>
        /// Topic name. Type: string, required. Default value: "".
        /// </summary>
        public readonly string Name;
        public readonly string? ServiceType;
        public readonly int? StartingMessageTimestampMs;
        /// <summary>
        /// Supported data encodings. Types: array[string]. Default value: ["gzip", "raw", "zstd"].
        /// </summary>
        public readonly ImmutableArray<string> SupportedCodecs;

        [OutputConstructor]
        private YandexYdbTopicConsumer(
            string name,

            string? serviceType,

            int? startingMessageTimestampMs,

            ImmutableArray<string> supportedCodecs)
        {
            Name = name;
            ServiceType = serviceType;
            StartingMessageTimestampMs = startingMessageTimestampMs;
            SupportedCodecs = supportedCodecs;
        }
    }
}
