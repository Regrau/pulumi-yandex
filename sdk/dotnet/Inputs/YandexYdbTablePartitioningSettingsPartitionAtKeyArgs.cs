// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class YandexYdbTablePartitioningSettingsPartitionAtKeyArgs : global::Pulumi.ResourceArgs
    {
        [Input("keys", required: true)]
        private InputList<string>? _keys;
        public InputList<string> Keys
        {
            get => _keys ?? (_keys = new InputList<string>());
            set => _keys = value;
        }

        public YandexYdbTablePartitioningSettingsPartitionAtKeyArgs()
        {
        }
        public static new YandexYdbTablePartitioningSettingsPartitionAtKeyArgs Empty => new YandexYdbTablePartitioningSettingsPartitionAtKeyArgs();
    }
}
