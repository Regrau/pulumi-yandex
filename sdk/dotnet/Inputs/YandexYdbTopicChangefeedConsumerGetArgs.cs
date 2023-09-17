// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class YandexYdbTopicChangefeedConsumerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("startingMessageTimestampMs")]
        public Input<int>? StartingMessageTimestampMs { get; set; }

        [Input("supportedCodecs")]
        private InputList<string>? _supportedCodecs;
        public InputList<string> SupportedCodecs
        {
            get => _supportedCodecs ?? (_supportedCodecs = new InputList<string>());
            set => _supportedCodecs = value;
        }

        public YandexYdbTopicChangefeedConsumerGetArgs()
        {
        }
        public static new YandexYdbTopicChangefeedConsumerGetArgs Empty => new YandexYdbTopicChangefeedConsumerGetArgs();
    }
}
