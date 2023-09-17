// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    /// <summary>
    /// Allows management of [Yandex.Cloud Storage Object](https://cloud.yandex.com/docs/storage/concepts/object).
    /// 
    /// ## Example Usage
    /// 
    /// Example creating an object in an existing `cat-pictures` bucket.
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Yandex = Pulumi.Yandex;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var cute_cat_picture = new Yandex.StorageObject("cute-cat-picture", new()
    ///     {
    ///         Bucket = "cat-pictures",
    ///         Key = "cute-cat",
    ///         Source = "/images/cats/cute-cat.jpg",
    ///         Tags = 
    ///         {
    ///             { "test", "value" },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/storageObject:StorageObject")]
    public partial class StorageObject : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The access key to use when applying changes. If omitted, `storage_access_key` specified in config is used.
        /// </summary>
        [Output("accessKey")]
        public Output<string?> AccessKey { get; private set; } = null!;

        /// <summary>
        /// The [predefined ACL](https://cloud.yandex.com/docs/storage/concepts/acl#predefined_acls) to apply. Defaults to `private`.
        /// </summary>
        [Output("acl")]
        public Output<string?> Acl { get; private set; } = null!;

        /// <summary>
        /// The name of the containing bucket.
        /// </summary>
        [Output("bucket")]
        public Output<string> Bucket { get; private set; } = null!;

        /// <summary>
        /// Literal string value to use as the object content, which will be uploaded as UTF-8-encoded text.
        /// </summary>
        [Output("content")]
        public Output<string?> Content { get; private set; } = null!;

        /// <summary>
        /// Base64-encoded data that will be decoded and uploaded as raw bytes for the object content. This allows safely uploading non-UTF8 binary data, but is recommended only for small content such as the result of the `gzipbase64` function with small text strings. For larger objects, use `source` to stream the content from a disk file.
        /// </summary>
        [Output("contentBase64")]
        public Output<string?> ContentBase64 { get; private set; } = null!;

        /// <summary>
        /// A standard MIME type describing the format of the object data, e.g. `application/octet-stream`. All Valid MIME Types are valid for this input.
        /// </summary>
        [Output("contentType")]
        public Output<string> ContentType { get; private set; } = null!;

        /// <summary>
        /// The name of the object once it is in the bucket.
        /// </summary>
        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        /// <summary>
        /// Specifies a [legal hold status](https://cloud.yandex.com/en/docs/storage/concepts/object-lock#types) of an object. Requires `object_lock_configuration` to be enabled on a bucket.
        /// </summary>
        [Output("objectLockLegalHoldStatus")]
        public Output<string?> ObjectLockLegalHoldStatus { get; private set; } = null!;

        /// <summary>
        /// Specifies a type of object lock. One of `["GOVERNANCE", "COMPLIANCE"]`. It must be set simultaneously with `object_lock_retain_until_date`. Requires `object_lock_configuration` to be enabled on a bucket.
        /// </summary>
        [Output("objectLockMode")]
        public Output<string?> ObjectLockMode { get; private set; } = null!;

        /// <summary>
        /// Specifies date and time in RTC3339 format until which an object is to be locked. It must be set simultaneously with `object_lock_mode`. Requires `object_lock_configuration` to be enabled on a bucket.
        /// </summary>
        [Output("objectLockRetainUntilDate")]
        public Output<string?> ObjectLockRetainUntilDate { get; private set; } = null!;

        /// <summary>
        /// The secret key to use when applying changes. If omitted, `storage_secret_key` specified in config is used.
        /// </summary>
        [Output("secretKey")]
        public Output<string?> SecretKey { get; private set; } = null!;

        /// <summary>
        /// The path to a file that will be read and uploaded as raw bytes for the object content.
        /// </summary>
        [Output("source")]
        public Output<string?> Source { get; private set; } = null!;

        /// <summary>
        /// Used to trigger object update when the source content changes. So the only meaningful value is `filemd5("path/to/source")` (The value is only stored in state and not saved by Yandex Storage).
        /// </summary>
        [Output("sourceHash")]
        public Output<string?> SourceHash { get; private set; } = null!;

        /// <summary>
        /// Specifies an object tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a StorageObject resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public StorageObject(string name, StorageObjectArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/storageObject:StorageObject", name, args ?? new StorageObjectArgs(), MakeResourceOptions(options, ""))
        {
        }

        private StorageObject(string name, Input<string> id, StorageObjectState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/storageObject:StorageObject", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/regrau/pulumi-yandex/releases",
                AdditionalSecretOutputs =
                {
                    "secretKey",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing StorageObject resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static StorageObject Get(string name, Input<string> id, StorageObjectState? state = null, CustomResourceOptions? options = null)
        {
            return new StorageObject(name, id, state, options);
        }
    }

    public sealed class StorageObjectArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The access key to use when applying changes. If omitted, `storage_access_key` specified in config is used.
        /// </summary>
        [Input("accessKey")]
        public Input<string>? AccessKey { get; set; }

        /// <summary>
        /// The [predefined ACL](https://cloud.yandex.com/docs/storage/concepts/acl#predefined_acls) to apply. Defaults to `private`.
        /// </summary>
        [Input("acl")]
        public Input<string>? Acl { get; set; }

        /// <summary>
        /// The name of the containing bucket.
        /// </summary>
        [Input("bucket", required: true)]
        public Input<string> Bucket { get; set; } = null!;

        /// <summary>
        /// Literal string value to use as the object content, which will be uploaded as UTF-8-encoded text.
        /// </summary>
        [Input("content")]
        public Input<string>? Content { get; set; }

        /// <summary>
        /// Base64-encoded data that will be decoded and uploaded as raw bytes for the object content. This allows safely uploading non-UTF8 binary data, but is recommended only for small content such as the result of the `gzipbase64` function with small text strings. For larger objects, use `source` to stream the content from a disk file.
        /// </summary>
        [Input("contentBase64")]
        public Input<string>? ContentBase64 { get; set; }

        /// <summary>
        /// A standard MIME type describing the format of the object data, e.g. `application/octet-stream`. All Valid MIME Types are valid for this input.
        /// </summary>
        [Input("contentType")]
        public Input<string>? ContentType { get; set; }

        /// <summary>
        /// The name of the object once it is in the bucket.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Specifies a [legal hold status](https://cloud.yandex.com/en/docs/storage/concepts/object-lock#types) of an object. Requires `object_lock_configuration` to be enabled on a bucket.
        /// </summary>
        [Input("objectLockLegalHoldStatus")]
        public Input<string>? ObjectLockLegalHoldStatus { get; set; }

        /// <summary>
        /// Specifies a type of object lock. One of `["GOVERNANCE", "COMPLIANCE"]`. It must be set simultaneously with `object_lock_retain_until_date`. Requires `object_lock_configuration` to be enabled on a bucket.
        /// </summary>
        [Input("objectLockMode")]
        public Input<string>? ObjectLockMode { get; set; }

        /// <summary>
        /// Specifies date and time in RTC3339 format until which an object is to be locked. It must be set simultaneously with `object_lock_mode`. Requires `object_lock_configuration` to be enabled on a bucket.
        /// </summary>
        [Input("objectLockRetainUntilDate")]
        public Input<string>? ObjectLockRetainUntilDate { get; set; }

        [Input("secretKey")]
        private Input<string>? _secretKey;

        /// <summary>
        /// The secret key to use when applying changes. If omitted, `storage_secret_key` specified in config is used.
        /// </summary>
        public Input<string>? SecretKey
        {
            get => _secretKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _secretKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The path to a file that will be read and uploaded as raw bytes for the object content.
        /// </summary>
        [Input("source")]
        public Input<string>? Source { get; set; }

        /// <summary>
        /// Used to trigger object update when the source content changes. So the only meaningful value is `filemd5("path/to/source")` (The value is only stored in state and not saved by Yandex Storage).
        /// </summary>
        [Input("sourceHash")]
        public Input<string>? SourceHash { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Specifies an object tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public StorageObjectArgs()
        {
        }
        public static new StorageObjectArgs Empty => new StorageObjectArgs();
    }

    public sealed class StorageObjectState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The access key to use when applying changes. If omitted, `storage_access_key` specified in config is used.
        /// </summary>
        [Input("accessKey")]
        public Input<string>? AccessKey { get; set; }

        /// <summary>
        /// The [predefined ACL](https://cloud.yandex.com/docs/storage/concepts/acl#predefined_acls) to apply. Defaults to `private`.
        /// </summary>
        [Input("acl")]
        public Input<string>? Acl { get; set; }

        /// <summary>
        /// The name of the containing bucket.
        /// </summary>
        [Input("bucket")]
        public Input<string>? Bucket { get; set; }

        /// <summary>
        /// Literal string value to use as the object content, which will be uploaded as UTF-8-encoded text.
        /// </summary>
        [Input("content")]
        public Input<string>? Content { get; set; }

        /// <summary>
        /// Base64-encoded data that will be decoded and uploaded as raw bytes for the object content. This allows safely uploading non-UTF8 binary data, but is recommended only for small content such as the result of the `gzipbase64` function with small text strings. For larger objects, use `source` to stream the content from a disk file.
        /// </summary>
        [Input("contentBase64")]
        public Input<string>? ContentBase64 { get; set; }

        /// <summary>
        /// A standard MIME type describing the format of the object data, e.g. `application/octet-stream`. All Valid MIME Types are valid for this input.
        /// </summary>
        [Input("contentType")]
        public Input<string>? ContentType { get; set; }

        /// <summary>
        /// The name of the object once it is in the bucket.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// Specifies a [legal hold status](https://cloud.yandex.com/en/docs/storage/concepts/object-lock#types) of an object. Requires `object_lock_configuration` to be enabled on a bucket.
        /// </summary>
        [Input("objectLockLegalHoldStatus")]
        public Input<string>? ObjectLockLegalHoldStatus { get; set; }

        /// <summary>
        /// Specifies a type of object lock. One of `["GOVERNANCE", "COMPLIANCE"]`. It must be set simultaneously with `object_lock_retain_until_date`. Requires `object_lock_configuration` to be enabled on a bucket.
        /// </summary>
        [Input("objectLockMode")]
        public Input<string>? ObjectLockMode { get; set; }

        /// <summary>
        /// Specifies date and time in RTC3339 format until which an object is to be locked. It must be set simultaneously with `object_lock_mode`. Requires `object_lock_configuration` to be enabled on a bucket.
        /// </summary>
        [Input("objectLockRetainUntilDate")]
        public Input<string>? ObjectLockRetainUntilDate { get; set; }

        [Input("secretKey")]
        private Input<string>? _secretKey;

        /// <summary>
        /// The secret key to use when applying changes. If omitted, `storage_secret_key` specified in config is used.
        /// </summary>
        public Input<string>? SecretKey
        {
            get => _secretKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _secretKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The path to a file that will be read and uploaded as raw bytes for the object content.
        /// </summary>
        [Input("source")]
        public Input<string>? Source { get; set; }

        /// <summary>
        /// Used to trigger object update when the source content changes. So the only meaningful value is `filemd5("path/to/source")` (The value is only stored in state and not saved by Yandex Storage).
        /// </summary>
        [Input("sourceHash")]
        public Input<string>? SourceHash { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Specifies an object tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public StorageObjectState()
        {
        }
        public static new StorageObjectState Empty => new StorageObjectState();
    }
}
