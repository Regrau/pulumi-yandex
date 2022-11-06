// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsMysqlTargetPasswordGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("raw")]
        private Input<string>? _raw;
        public Input<string>? Raw
        {
            get => _raw;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _raw = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public DatatransferEndpointSettingsMysqlTargetPasswordGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsMysqlTargetPasswordGetArgs Empty => new DatatransferEndpointSettingsMysqlTargetPasswordGetArgs();
    }
}
