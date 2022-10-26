// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsMongoSourceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("collections")]
        private InputList<Inputs.DatatransferEndpointSettingsMongoSourceCollectionGetArgs>? _collections;
        public InputList<Inputs.DatatransferEndpointSettingsMongoSourceCollectionGetArgs> Collections
        {
            get => _collections ?? (_collections = new InputList<Inputs.DatatransferEndpointSettingsMongoSourceCollectionGetArgs>());
            set => _collections = value;
        }

        [Input("connection")]
        public Input<Inputs.DatatransferEndpointSettingsMongoSourceConnectionGetArgs>? Connection { get; set; }

        [Input("excludedCollections")]
        private InputList<Inputs.DatatransferEndpointSettingsMongoSourceExcludedCollectionGetArgs>? _excludedCollections;
        public InputList<Inputs.DatatransferEndpointSettingsMongoSourceExcludedCollectionGetArgs> ExcludedCollections
        {
            get => _excludedCollections ?? (_excludedCollections = new InputList<Inputs.DatatransferEndpointSettingsMongoSourceExcludedCollectionGetArgs>());
            set => _excludedCollections = value;
        }

        [Input("secondaryPreferredMode")]
        public Input<bool>? SecondaryPreferredMode { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public DatatransferEndpointSettingsMongoSourceGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsMongoSourceGetArgs Empty => new DatatransferEndpointSettingsMongoSourceGetArgs();
    }
}