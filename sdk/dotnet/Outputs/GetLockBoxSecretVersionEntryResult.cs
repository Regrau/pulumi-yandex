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
    public sealed class GetLockBoxSecretVersionEntryResult
    {
        /// <summary>
        /// The key of the entry.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// The text value of the entry.
        /// </summary>
        public readonly string TextValue;

        [OutputConstructor]
        private GetLockBoxSecretVersionEntryResult(
            string key,

            string textValue)
        {
            Key = key;
            TextValue = textValue;
        }
    }
}
