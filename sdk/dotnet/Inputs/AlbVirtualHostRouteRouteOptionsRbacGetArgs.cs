// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbVirtualHostRouteRouteOptionsRbacGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("action")]
        public Input<string>? Action { get; set; }

        [Input("principals", required: true)]
        private InputList<Inputs.AlbVirtualHostRouteRouteOptionsRbacPrincipalGetArgs>? _principals;
        public InputList<Inputs.AlbVirtualHostRouteRouteOptionsRbacPrincipalGetArgs> Principals
        {
            get => _principals ?? (_principals = new InputList<Inputs.AlbVirtualHostRouteRouteOptionsRbacPrincipalGetArgs>());
            set => _principals = value;
        }

        public AlbVirtualHostRouteRouteOptionsRbacGetArgs()
        {
        }
        public static new AlbVirtualHostRouteRouteOptionsRbacGetArgs Empty => new AlbVirtualHostRouteRouteOptionsRbacGetArgs();
    }
}
