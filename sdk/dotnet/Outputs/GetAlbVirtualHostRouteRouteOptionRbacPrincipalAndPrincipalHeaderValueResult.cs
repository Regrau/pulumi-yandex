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
    public sealed class GetAlbVirtualHostRouteRouteOptionRbacPrincipalAndPrincipalHeaderValueResult
    {
        public readonly string Exact;
        public readonly string Prefix;
        public readonly string Regex;

        [OutputConstructor]
        private GetAlbVirtualHostRouteRouteOptionRbacPrincipalAndPrincipalHeaderValueResult(
            string exact,

            string prefix,

            string regex)
        {
            Exact = exact;
            Prefix = prefix;
            Regex = regex;
        }
    }
}
