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
    public sealed class GetMdbPostgresqlClusterConfigPerformanceDiagnosticResult
    {
        public readonly bool Enabled;
        public readonly int SessionsSamplingInterval;
        public readonly int StatementsSamplingInterval;

        [OutputConstructor]
        private GetMdbPostgresqlClusterConfigPerformanceDiagnosticResult(
            bool enabled,

            int sessionsSamplingInterval,

            int statementsSamplingInterval)
        {
            Enabled = enabled;
            SessionsSamplingInterval = sessionsSamplingInterval;
            StatementsSamplingInterval = statementsSamplingInterval;
        }
    }
}