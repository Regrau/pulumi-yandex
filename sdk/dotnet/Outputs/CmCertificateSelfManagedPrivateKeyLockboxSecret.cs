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
    public sealed class CmCertificateSelfManagedPrivateKeyLockboxSecret
    {
        /// <summary>
        /// Certificate Id.
        /// </summary>
        public readonly string Id;
        public readonly string Key;

        [OutputConstructor]
        private CmCertificateSelfManagedPrivateKeyLockboxSecret(
            string id,

            string key)
        {
            Id = id;
            Key = key;
        }
    }
}