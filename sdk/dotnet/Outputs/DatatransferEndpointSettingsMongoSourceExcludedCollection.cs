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
    public sealed class DatatransferEndpointSettingsMongoSourceExcludedCollection
    {
        public readonly string? CollectionName;
        public readonly string? DatabaseName;

        [OutputConstructor]
        private DatatransferEndpointSettingsMongoSourceExcludedCollection(
            string? collectionName,

            string? databaseName)
        {
            CollectionName = collectionName;
            DatabaseName = databaseName;
        }
    }
}
