// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class FunctionTriggerLoggingGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("batchCutoff", required: true)]
        public Input<string> BatchCutoff { get; set; } = null!;

        [Input("batchSize")]
        public Input<string>? BatchSize { get; set; }

        [Input("groupId", required: true)]
        public Input<string> GroupId { get; set; } = null!;

        [Input("levels", required: true)]
        private InputList<string>? _levels;
        public InputList<string> Levels
        {
            get => _levels ?? (_levels = new InputList<string>());
            set => _levels = value;
        }

        [Input("resourceIds", required: true)]
        private InputList<string>? _resourceIds;
        public InputList<string> ResourceIds
        {
            get => _resourceIds ?? (_resourceIds = new InputList<string>());
            set => _resourceIds = value;
        }

        [Input("resourceTypes", required: true)]
        private InputList<string>? _resourceTypes;
        public InputList<string> ResourceTypes
        {
            get => _resourceTypes ?? (_resourceTypes = new InputList<string>());
            set => _resourceTypes = value;
        }

        public FunctionTriggerLoggingGetArgs()
        {
        }
        public static new FunctionTriggerLoggingGetArgs Empty => new FunctionTriggerLoggingGetArgs();
    }
}
