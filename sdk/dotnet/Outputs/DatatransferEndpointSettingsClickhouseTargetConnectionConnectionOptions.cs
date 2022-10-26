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
    public sealed class DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptions
    {
        public readonly string? Database;
        public readonly string? MdbClusterId;
        public readonly Outputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremise? OnPremise;
        public readonly Outputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsPassword? Password;
        public readonly string? User;

        [OutputConstructor]
        private DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptions(
            string? database,

            string? mdbClusterId,

            Outputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremise? onPremise,

            Outputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsPassword? password,

            string? user)
        {
            Database = database;
            MdbClusterId = mdbClusterId;
            OnPremise = onPremise;
            Password = password;
            User = user;
        }
    }
}