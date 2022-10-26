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
    public sealed class MdbElasticSearchClusterConfig
    {
        public readonly string AdminPassword;
        public readonly Outputs.MdbElasticSearchClusterConfigDataNode DataNode;
        public readonly string? Edition;
        public readonly Outputs.MdbElasticSearchClusterConfigMasterNode? MasterNode;
        public readonly ImmutableArray<string> Plugins;
        public readonly string? Version;

        [OutputConstructor]
        private MdbElasticSearchClusterConfig(
            string adminPassword,

            Outputs.MdbElasticSearchClusterConfigDataNode dataNode,

            string? edition,

            Outputs.MdbElasticSearchClusterConfigMasterNode? masterNode,

            ImmutableArray<string> plugins,

            string? version)
        {
            AdminPassword = adminPassword;
            DataNode = dataNode;
            Edition = edition;
            MasterNode = masterNode;
            Plugins = plugins;
            Version = version;
        }
    }
}
