// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetMdbKafkaTopic
    {
        public static Task<GetMdbKafkaTopicResult> InvokeAsync(GetMdbKafkaTopicArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMdbKafkaTopicResult>("yandex:index/getMdbKafkaTopic:getMdbKafkaTopic", args ?? new GetMdbKafkaTopicArgs(), options.WithDefaults());

        public static Output<GetMdbKafkaTopicResult> Invoke(GetMdbKafkaTopicInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetMdbKafkaTopicResult>("yandex:index/getMdbKafkaTopic:getMdbKafkaTopic", args ?? new GetMdbKafkaTopicInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMdbKafkaTopicArgs : global::Pulumi.InvokeArgs
    {
        [Input("clusterId", required: true)]
        public string ClusterId { get; set; } = null!;

        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetMdbKafkaTopicArgs()
        {
        }
        public static new GetMdbKafkaTopicArgs Empty => new GetMdbKafkaTopicArgs();
    }

    public sealed class GetMdbKafkaTopicInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public GetMdbKafkaTopicInvokeArgs()
        {
        }
        public static new GetMdbKafkaTopicInvokeArgs Empty => new GetMdbKafkaTopicInvokeArgs();
    }


    [OutputType]
    public sealed class GetMdbKafkaTopicResult
    {
        public readonly string ClusterId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly int Partitions;
        public readonly int ReplicationFactor;
        public readonly ImmutableArray<Outputs.GetMdbKafkaTopicTopicConfigResult> TopicConfigs;

        [OutputConstructor]
        private GetMdbKafkaTopicResult(
            string clusterId,

            string id,

            string name,

            int partitions,

            int replicationFactor,

            ImmutableArray<Outputs.GetMdbKafkaTopicTopicConfigResult> topicConfigs)
        {
            ClusterId = clusterId;
            Id = id;
            Name = name;
            Partitions = partitions;
            ReplicationFactor = replicationFactor;
            TopicConfigs = topicConfigs;
        }
    }
}