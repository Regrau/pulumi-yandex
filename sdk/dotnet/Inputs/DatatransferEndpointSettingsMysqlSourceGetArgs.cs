// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsMysqlSourceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("connection")]
        public Input<Inputs.DatatransferEndpointSettingsMysqlSourceConnectionGetArgs>? Connection { get; set; }

        [Input("database")]
        public Input<string>? Database { get; set; }

        [Input("excludeTablesRegexes")]
        private InputList<string>? _excludeTablesRegexes;
        public InputList<string> ExcludeTablesRegexes
        {
            get => _excludeTablesRegexes ?? (_excludeTablesRegexes = new InputList<string>());
            set => _excludeTablesRegexes = value;
        }

        [Input("includeTablesRegexes")]
        private InputList<string>? _includeTablesRegexes;
        public InputList<string> IncludeTablesRegexes
        {
            get => _includeTablesRegexes ?? (_includeTablesRegexes = new InputList<string>());
            set => _includeTablesRegexes = value;
        }

        [Input("objectTransferSettings")]
        public Input<Inputs.DatatransferEndpointSettingsMysqlSourceObjectTransferSettingsGetArgs>? ObjectTransferSettings { get; set; }

        [Input("password")]
        public Input<Inputs.DatatransferEndpointSettingsMysqlSourcePasswordGetArgs>? Password { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        [Input("serviceDatabase")]
        public Input<string>? ServiceDatabase { get; set; }

        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        [Input("user")]
        public Input<string>? User { get; set; }

        public DatatransferEndpointSettingsMysqlSourceGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsMysqlSourceGetArgs Empty => new DatatransferEndpointSettingsMysqlSourceGetArgs();
    }
}
