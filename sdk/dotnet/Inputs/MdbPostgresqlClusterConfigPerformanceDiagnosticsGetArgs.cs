// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbPostgresqlClusterConfigPerformanceDiagnosticsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("sessionsSamplingInterval", required: true)]
        public Input<int> SessionsSamplingInterval { get; set; } = null!;

        [Input("statementsSamplingInterval", required: true)]
        public Input<int> StatementsSamplingInterval { get; set; } = null!;

        public MdbPostgresqlClusterConfigPerformanceDiagnosticsGetArgs()
        {
        }
        public static new MdbPostgresqlClusterConfigPerformanceDiagnosticsGetArgs Empty => new MdbPostgresqlClusterConfigPerformanceDiagnosticsGetArgs();
    }
}
