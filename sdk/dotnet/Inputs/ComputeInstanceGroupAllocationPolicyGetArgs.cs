// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupAllocationPolicyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("zones", required: true)]
        private InputList<string>? _zones;

        /// <summary>
        /// A list of availability zones.
        /// </summary>
        public InputList<string> Zones
        {
            get => _zones ?? (_zones = new InputList<string>());
            set => _zones = value;
        }

        public ComputeInstanceGroupAllocationPolicyGetArgs()
        {
        }
        public static new ComputeInstanceGroupAllocationPolicyGetArgs Empty => new ComputeInstanceGroupAllocationPolicyGetArgs();
    }
}
