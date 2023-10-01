// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ApiGatewayCanaryArgs : global::Pulumi.ResourceArgs
    {
        [Input("variables")]
        private InputMap<string>? _variables;

        /// <summary>
        /// A set of values for variables in gateway specification.
        /// </summary>
        public InputMap<string> Variables
        {
            get => _variables ?? (_variables = new InputMap<string>());
            set => _variables = value;
        }

        [Input("weight")]
        public Input<int>? Weight { get; set; }

        public ApiGatewayCanaryArgs()
        {
        }
        public static new ApiGatewayCanaryArgs Empty => new ApiGatewayCanaryArgs();
    }
}
