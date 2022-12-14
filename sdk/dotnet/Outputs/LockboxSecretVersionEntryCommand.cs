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
    public sealed class LockboxSecretVersionEntryCommand
    {
        /// <summary>
        /// List of arguments to be passed to the script/command.
        /// </summary>
        public readonly ImmutableArray<string> Args;
        /// <summary>
        /// Map of environment variables to set before calling the script/command.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Env;
        /// <summary>
        /// The path to the script or command to execute.
        /// </summary>
        public readonly string Path;

        [OutputConstructor]
        private LockboxSecretVersionEntryCommand(
            ImmutableArray<string> args,

            ImmutableDictionary<string, string>? env,

            string path)
        {
            Args = args;
            Env = env;
            Path = path;
        }
    }
}
