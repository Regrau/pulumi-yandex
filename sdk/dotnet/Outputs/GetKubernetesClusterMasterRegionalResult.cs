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
    public sealed class GetKubernetesClusterMasterRegionalResult
    {
        /// <summary>
        /// ID of the availability region where the master compute instances resides.
        /// </summary>
        public readonly string Region;

        [OutputConstructor]
        private GetKubernetesClusterMasterRegionalResult(string region)
        {
            Region = region;
        }
    }
}
