// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbBackendGroupSessionAffinityArgs : global::Pulumi.ResourceArgs
    {
        [Input("connection")]
        public Input<Inputs.AlbBackendGroupSessionAffinityConnectionArgs>? Connection { get; set; }

        [Input("cookie")]
        public Input<Inputs.AlbBackendGroupSessionAffinityCookieArgs>? Cookie { get; set; }

        [Input("header")]
        public Input<Inputs.AlbBackendGroupSessionAffinityHeaderArgs>? Header { get; set; }

        public AlbBackendGroupSessionAffinityArgs()
        {
        }
        public static new AlbBackendGroupSessionAffinityArgs Empty => new AlbBackendGroupSessionAffinityArgs();
    }
}