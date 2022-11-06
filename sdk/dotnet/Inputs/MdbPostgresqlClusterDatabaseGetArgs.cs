// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbPostgresqlClusterDatabaseGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("extensions")]
        private InputList<Inputs.MdbPostgresqlClusterDatabaseExtensionGetArgs>? _extensions;
        public InputList<Inputs.MdbPostgresqlClusterDatabaseExtensionGetArgs> Extensions
        {
            get => _extensions ?? (_extensions = new InputList<Inputs.MdbPostgresqlClusterDatabaseExtensionGetArgs>());
            set => _extensions = value;
        }

        [Input("lcCollate")]
        public Input<string>? LcCollate { get; set; }

        [Input("lcType")]
        public Input<string>? LcType { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("owner", required: true)]
        public Input<string> Owner { get; set; } = null!;

        [Input("templateDb")]
        public Input<string>? TemplateDb { get; set; }

        public MdbPostgresqlClusterDatabaseGetArgs()
        {
        }
        public static new MdbPostgresqlClusterDatabaseGetArgs Empty => new MdbPostgresqlClusterDatabaseGetArgs();
    }
}
