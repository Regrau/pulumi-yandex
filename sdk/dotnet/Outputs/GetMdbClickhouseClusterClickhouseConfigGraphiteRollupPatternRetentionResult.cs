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
    public sealed class GetMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetentionResult
    {
        public readonly int Age;
        public readonly int Precision;

        [OutputConstructor]
        private GetMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetentionResult(
            int age,

            int precision)
        {
            Age = age;
            Precision = precision;
        }
    }
}