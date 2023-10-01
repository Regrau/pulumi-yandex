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
    public sealed class YandexYdbTableFamily
    {
        public readonly string Compression;
        public readonly string Data;
        public readonly string Name;

        [OutputConstructor]
        private YandexYdbTableFamily(
            string compression,

            string data,

            string name)
        {
            Compression = compression;
            Data = data;
            Name = name;
        }
    }
}