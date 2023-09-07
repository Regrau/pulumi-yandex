// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-yandex/sdk/go/yandex"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := yandex.NewKmsSymmetricKey(ctx, "key-a", &yandex.KmsSymmetricKeyArgs{
// 			DefaultAlgorithm: pulumi.String("AES_128"),
// 			Description:      pulumi.String("description for key"),
// 			RotationPeriod:   pulumi.String("8760h"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// A KMS symmetric key can be imported using the `id` of the resource, e.g.
//
// ```sh
//  $ pulumi import yandex:index/kmsSymmetricKey:KmsSymmetricKey top-secret kms_key_id
// ```
type KmsSymmetricKey struct {
	pulumi.CustomResourceState

	// Creation timestamp of the key.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// Encryption algorithm to be used with a new key version,
	// generated with the next rotation. The default value is `AES_128`.
	DefaultAlgorithm pulumi.StringPtrOutput `pulumi:"defaultAlgorithm"`
	// An optional description of the key.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId pulumi.StringOutput `pulumi:"folderId"`
	// A set of key/value label pairs to assign to the key.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Name of the key.
	Name pulumi.StringOutput `pulumi:"name"`
	// Last rotation timestamp of the key.
	RotatedAt pulumi.StringOutput `pulumi:"rotatedAt"`
	// Interval between automatic rotations. To disable automatic rotation, omit this parameter.
	RotationPeriod pulumi.StringPtrOutput `pulumi:"rotationPeriod"`
	// The status of the key.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewKmsSymmetricKey registers a new resource with the given unique name, arguments, and options.
func NewKmsSymmetricKey(ctx *pulumi.Context,
	name string, args *KmsSymmetricKeyArgs, opts ...pulumi.ResourceOption) (*KmsSymmetricKey, error) {
	if args == nil {
		args = &KmsSymmetricKeyArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource KmsSymmetricKey
	err := ctx.RegisterResource("yandex:index/kmsSymmetricKey:KmsSymmetricKey", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetKmsSymmetricKey gets an existing KmsSymmetricKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKmsSymmetricKey(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *KmsSymmetricKeyState, opts ...pulumi.ResourceOption) (*KmsSymmetricKey, error) {
	var resource KmsSymmetricKey
	err := ctx.ReadResource("yandex:index/kmsSymmetricKey:KmsSymmetricKey", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering KmsSymmetricKey resources.
type kmsSymmetricKeyState struct {
	// Creation timestamp of the key.
	CreatedAt *string `pulumi:"createdAt"`
	// Encryption algorithm to be used with a new key version,
	// generated with the next rotation. The default value is `AES_128`.
	DefaultAlgorithm *string `pulumi:"defaultAlgorithm"`
	// An optional description of the key.
	Description *string `pulumi:"description"`
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// A set of key/value label pairs to assign to the key.
	Labels map[string]string `pulumi:"labels"`
	// Name of the key.
	Name *string `pulumi:"name"`
	// Last rotation timestamp of the key.
	RotatedAt *string `pulumi:"rotatedAt"`
	// Interval between automatic rotations. To disable automatic rotation, omit this parameter.
	RotationPeriod *string `pulumi:"rotationPeriod"`
	// The status of the key.
	Status *string `pulumi:"status"`
}

type KmsSymmetricKeyState struct {
	// Creation timestamp of the key.
	CreatedAt pulumi.StringPtrInput
	// Encryption algorithm to be used with a new key version,
	// generated with the next rotation. The default value is `AES_128`.
	DefaultAlgorithm pulumi.StringPtrInput
	// An optional description of the key.
	Description pulumi.StringPtrInput
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// A set of key/value label pairs to assign to the key.
	Labels pulumi.StringMapInput
	// Name of the key.
	Name pulumi.StringPtrInput
	// Last rotation timestamp of the key.
	RotatedAt pulumi.StringPtrInput
	// Interval between automatic rotations. To disable automatic rotation, omit this parameter.
	RotationPeriod pulumi.StringPtrInput
	// The status of the key.
	Status pulumi.StringPtrInput
}

func (KmsSymmetricKeyState) ElementType() reflect.Type {
	return reflect.TypeOf((*kmsSymmetricKeyState)(nil)).Elem()
}

type kmsSymmetricKeyArgs struct {
	// Encryption algorithm to be used with a new key version,
	// generated with the next rotation. The default value is `AES_128`.
	DefaultAlgorithm *string `pulumi:"defaultAlgorithm"`
	// An optional description of the key.
	Description *string `pulumi:"description"`
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// A set of key/value label pairs to assign to the key.
	Labels map[string]string `pulumi:"labels"`
	// Name of the key.
	Name *string `pulumi:"name"`
	// Interval between automatic rotations. To disable automatic rotation, omit this parameter.
	RotationPeriod *string `pulumi:"rotationPeriod"`
}

// The set of arguments for constructing a KmsSymmetricKey resource.
type KmsSymmetricKeyArgs struct {
	// Encryption algorithm to be used with a new key version,
	// generated with the next rotation. The default value is `AES_128`.
	DefaultAlgorithm pulumi.StringPtrInput
	// An optional description of the key.
	Description pulumi.StringPtrInput
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// A set of key/value label pairs to assign to the key.
	Labels pulumi.StringMapInput
	// Name of the key.
	Name pulumi.StringPtrInput
	// Interval between automatic rotations. To disable automatic rotation, omit this parameter.
	RotationPeriod pulumi.StringPtrInput
}

func (KmsSymmetricKeyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*kmsSymmetricKeyArgs)(nil)).Elem()
}

type KmsSymmetricKeyInput interface {
	pulumi.Input

	ToKmsSymmetricKeyOutput() KmsSymmetricKeyOutput
	ToKmsSymmetricKeyOutputWithContext(ctx context.Context) KmsSymmetricKeyOutput
}

func (*KmsSymmetricKey) ElementType() reflect.Type {
	return reflect.TypeOf((**KmsSymmetricKey)(nil)).Elem()
}

func (i *KmsSymmetricKey) ToKmsSymmetricKeyOutput() KmsSymmetricKeyOutput {
	return i.ToKmsSymmetricKeyOutputWithContext(context.Background())
}

func (i *KmsSymmetricKey) ToKmsSymmetricKeyOutputWithContext(ctx context.Context) KmsSymmetricKeyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KmsSymmetricKeyOutput)
}

// KmsSymmetricKeyArrayInput is an input type that accepts KmsSymmetricKeyArray and KmsSymmetricKeyArrayOutput values.
// You can construct a concrete instance of `KmsSymmetricKeyArrayInput` via:
//
//          KmsSymmetricKeyArray{ KmsSymmetricKeyArgs{...} }
type KmsSymmetricKeyArrayInput interface {
	pulumi.Input

	ToKmsSymmetricKeyArrayOutput() KmsSymmetricKeyArrayOutput
	ToKmsSymmetricKeyArrayOutputWithContext(context.Context) KmsSymmetricKeyArrayOutput
}

type KmsSymmetricKeyArray []KmsSymmetricKeyInput

func (KmsSymmetricKeyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*KmsSymmetricKey)(nil)).Elem()
}

func (i KmsSymmetricKeyArray) ToKmsSymmetricKeyArrayOutput() KmsSymmetricKeyArrayOutput {
	return i.ToKmsSymmetricKeyArrayOutputWithContext(context.Background())
}

func (i KmsSymmetricKeyArray) ToKmsSymmetricKeyArrayOutputWithContext(ctx context.Context) KmsSymmetricKeyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KmsSymmetricKeyArrayOutput)
}

// KmsSymmetricKeyMapInput is an input type that accepts KmsSymmetricKeyMap and KmsSymmetricKeyMapOutput values.
// You can construct a concrete instance of `KmsSymmetricKeyMapInput` via:
//
//          KmsSymmetricKeyMap{ "key": KmsSymmetricKeyArgs{...} }
type KmsSymmetricKeyMapInput interface {
	pulumi.Input

	ToKmsSymmetricKeyMapOutput() KmsSymmetricKeyMapOutput
	ToKmsSymmetricKeyMapOutputWithContext(context.Context) KmsSymmetricKeyMapOutput
}

type KmsSymmetricKeyMap map[string]KmsSymmetricKeyInput

func (KmsSymmetricKeyMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*KmsSymmetricKey)(nil)).Elem()
}

func (i KmsSymmetricKeyMap) ToKmsSymmetricKeyMapOutput() KmsSymmetricKeyMapOutput {
	return i.ToKmsSymmetricKeyMapOutputWithContext(context.Background())
}

func (i KmsSymmetricKeyMap) ToKmsSymmetricKeyMapOutputWithContext(ctx context.Context) KmsSymmetricKeyMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KmsSymmetricKeyMapOutput)
}

type KmsSymmetricKeyOutput struct{ *pulumi.OutputState }

func (KmsSymmetricKeyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**KmsSymmetricKey)(nil)).Elem()
}

func (o KmsSymmetricKeyOutput) ToKmsSymmetricKeyOutput() KmsSymmetricKeyOutput {
	return o
}

func (o KmsSymmetricKeyOutput) ToKmsSymmetricKeyOutputWithContext(ctx context.Context) KmsSymmetricKeyOutput {
	return o
}

// Creation timestamp of the key.
func (o KmsSymmetricKeyOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *KmsSymmetricKey) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// Encryption algorithm to be used with a new key version,
// generated with the next rotation. The default value is `AES_128`.
func (o KmsSymmetricKeyOutput) DefaultAlgorithm() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *KmsSymmetricKey) pulumi.StringPtrOutput { return v.DefaultAlgorithm }).(pulumi.StringPtrOutput)
}

// An optional description of the key.
func (o KmsSymmetricKeyOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *KmsSymmetricKey) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// The ID of the folder that the resource belongs to. If it
// is not provided, the default provider folder is used.
func (o KmsSymmetricKeyOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *KmsSymmetricKey) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

// A set of key/value label pairs to assign to the key.
func (o KmsSymmetricKeyOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *KmsSymmetricKey) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// Name of the key.
func (o KmsSymmetricKeyOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *KmsSymmetricKey) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Last rotation timestamp of the key.
func (o KmsSymmetricKeyOutput) RotatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *KmsSymmetricKey) pulumi.StringOutput { return v.RotatedAt }).(pulumi.StringOutput)
}

// Interval between automatic rotations. To disable automatic rotation, omit this parameter.
func (o KmsSymmetricKeyOutput) RotationPeriod() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *KmsSymmetricKey) pulumi.StringPtrOutput { return v.RotationPeriod }).(pulumi.StringPtrOutput)
}

// The status of the key.
func (o KmsSymmetricKeyOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *KmsSymmetricKey) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type KmsSymmetricKeyArrayOutput struct{ *pulumi.OutputState }

func (KmsSymmetricKeyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*KmsSymmetricKey)(nil)).Elem()
}

func (o KmsSymmetricKeyArrayOutput) ToKmsSymmetricKeyArrayOutput() KmsSymmetricKeyArrayOutput {
	return o
}

func (o KmsSymmetricKeyArrayOutput) ToKmsSymmetricKeyArrayOutputWithContext(ctx context.Context) KmsSymmetricKeyArrayOutput {
	return o
}

func (o KmsSymmetricKeyArrayOutput) Index(i pulumi.IntInput) KmsSymmetricKeyOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *KmsSymmetricKey {
		return vs[0].([]*KmsSymmetricKey)[vs[1].(int)]
	}).(KmsSymmetricKeyOutput)
}

type KmsSymmetricKeyMapOutput struct{ *pulumi.OutputState }

func (KmsSymmetricKeyMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*KmsSymmetricKey)(nil)).Elem()
}

func (o KmsSymmetricKeyMapOutput) ToKmsSymmetricKeyMapOutput() KmsSymmetricKeyMapOutput {
	return o
}

func (o KmsSymmetricKeyMapOutput) ToKmsSymmetricKeyMapOutputWithContext(ctx context.Context) KmsSymmetricKeyMapOutput {
	return o
}

func (o KmsSymmetricKeyMapOutput) MapIndex(k pulumi.StringInput) KmsSymmetricKeyOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *KmsSymmetricKey {
		return vs[0].(map[string]*KmsSymmetricKey)[vs[1].(string)]
	}).(KmsSymmetricKeyOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*KmsSymmetricKeyInput)(nil)).Elem(), &KmsSymmetricKey{})
	pulumi.RegisterInputType(reflect.TypeOf((*KmsSymmetricKeyArrayInput)(nil)).Elem(), KmsSymmetricKeyArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*KmsSymmetricKeyMapInput)(nil)).Elem(), KmsSymmetricKeyMap{})
	pulumi.RegisterOutputType(KmsSymmetricKeyOutput{})
	pulumi.RegisterOutputType(KmsSymmetricKeyArrayOutput{})
	pulumi.RegisterOutputType(KmsSymmetricKeyMapOutput{})
}
