// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type ResourcemanagerCloudIamMember struct {
	pulumi.CustomResourceState

	CloudId    pulumi.StringOutput `pulumi:"cloudId"`
	Member     pulumi.StringOutput `pulumi:"member"`
	Role       pulumi.StringOutput `pulumi:"role"`
	SleepAfter pulumi.IntPtrOutput `pulumi:"sleepAfter"`
}

// NewResourcemanagerCloudIamMember registers a new resource with the given unique name, arguments, and options.
func NewResourcemanagerCloudIamMember(ctx *pulumi.Context,
	name string, args *ResourcemanagerCloudIamMemberArgs, opts ...pulumi.ResourceOption) (*ResourcemanagerCloudIamMember, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CloudId == nil {
		return nil, errors.New("invalid value for required argument 'CloudId'")
	}
	if args.Member == nil {
		return nil, errors.New("invalid value for required argument 'Member'")
	}
	if args.Role == nil {
		return nil, errors.New("invalid value for required argument 'Role'")
	}
	var resource ResourcemanagerCloudIamMember
	err := ctx.RegisterResource("yandex:index/resourcemanagerCloudIamMember:ResourcemanagerCloudIamMember", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetResourcemanagerCloudIamMember gets an existing ResourcemanagerCloudIamMember resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetResourcemanagerCloudIamMember(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ResourcemanagerCloudIamMemberState, opts ...pulumi.ResourceOption) (*ResourcemanagerCloudIamMember, error) {
	var resource ResourcemanagerCloudIamMember
	err := ctx.ReadResource("yandex:index/resourcemanagerCloudIamMember:ResourcemanagerCloudIamMember", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ResourcemanagerCloudIamMember resources.
type resourcemanagerCloudIamMemberState struct {
	CloudId    *string `pulumi:"cloudId"`
	Member     *string `pulumi:"member"`
	Role       *string `pulumi:"role"`
	SleepAfter *int    `pulumi:"sleepAfter"`
}

type ResourcemanagerCloudIamMemberState struct {
	CloudId    pulumi.StringPtrInput
	Member     pulumi.StringPtrInput
	Role       pulumi.StringPtrInput
	SleepAfter pulumi.IntPtrInput
}

func (ResourcemanagerCloudIamMemberState) ElementType() reflect.Type {
	return reflect.TypeOf((*resourcemanagerCloudIamMemberState)(nil)).Elem()
}

type resourcemanagerCloudIamMemberArgs struct {
	CloudId    string `pulumi:"cloudId"`
	Member     string `pulumi:"member"`
	Role       string `pulumi:"role"`
	SleepAfter *int   `pulumi:"sleepAfter"`
}

// The set of arguments for constructing a ResourcemanagerCloudIamMember resource.
type ResourcemanagerCloudIamMemberArgs struct {
	CloudId    pulumi.StringInput
	Member     pulumi.StringInput
	Role       pulumi.StringInput
	SleepAfter pulumi.IntPtrInput
}

func (ResourcemanagerCloudIamMemberArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*resourcemanagerCloudIamMemberArgs)(nil)).Elem()
}

type ResourcemanagerCloudIamMemberInput interface {
	pulumi.Input

	ToResourcemanagerCloudIamMemberOutput() ResourcemanagerCloudIamMemberOutput
	ToResourcemanagerCloudIamMemberOutputWithContext(ctx context.Context) ResourcemanagerCloudIamMemberOutput
}

func (*ResourcemanagerCloudIamMember) ElementType() reflect.Type {
	return reflect.TypeOf((**ResourcemanagerCloudIamMember)(nil)).Elem()
}

func (i *ResourcemanagerCloudIamMember) ToResourcemanagerCloudIamMemberOutput() ResourcemanagerCloudIamMemberOutput {
	return i.ToResourcemanagerCloudIamMemberOutputWithContext(context.Background())
}

func (i *ResourcemanagerCloudIamMember) ToResourcemanagerCloudIamMemberOutputWithContext(ctx context.Context) ResourcemanagerCloudIamMemberOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourcemanagerCloudIamMemberOutput)
}

// ResourcemanagerCloudIamMemberArrayInput is an input type that accepts ResourcemanagerCloudIamMemberArray and ResourcemanagerCloudIamMemberArrayOutput values.
// You can construct a concrete instance of `ResourcemanagerCloudIamMemberArrayInput` via:
//
//	ResourcemanagerCloudIamMemberArray{ ResourcemanagerCloudIamMemberArgs{...} }
type ResourcemanagerCloudIamMemberArrayInput interface {
	pulumi.Input

	ToResourcemanagerCloudIamMemberArrayOutput() ResourcemanagerCloudIamMemberArrayOutput
	ToResourcemanagerCloudIamMemberArrayOutputWithContext(context.Context) ResourcemanagerCloudIamMemberArrayOutput
}

type ResourcemanagerCloudIamMemberArray []ResourcemanagerCloudIamMemberInput

func (ResourcemanagerCloudIamMemberArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ResourcemanagerCloudIamMember)(nil)).Elem()
}

func (i ResourcemanagerCloudIamMemberArray) ToResourcemanagerCloudIamMemberArrayOutput() ResourcemanagerCloudIamMemberArrayOutput {
	return i.ToResourcemanagerCloudIamMemberArrayOutputWithContext(context.Background())
}

func (i ResourcemanagerCloudIamMemberArray) ToResourcemanagerCloudIamMemberArrayOutputWithContext(ctx context.Context) ResourcemanagerCloudIamMemberArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourcemanagerCloudIamMemberArrayOutput)
}

// ResourcemanagerCloudIamMemberMapInput is an input type that accepts ResourcemanagerCloudIamMemberMap and ResourcemanagerCloudIamMemberMapOutput values.
// You can construct a concrete instance of `ResourcemanagerCloudIamMemberMapInput` via:
//
//	ResourcemanagerCloudIamMemberMap{ "key": ResourcemanagerCloudIamMemberArgs{...} }
type ResourcemanagerCloudIamMemberMapInput interface {
	pulumi.Input

	ToResourcemanagerCloudIamMemberMapOutput() ResourcemanagerCloudIamMemberMapOutput
	ToResourcemanagerCloudIamMemberMapOutputWithContext(context.Context) ResourcemanagerCloudIamMemberMapOutput
}

type ResourcemanagerCloudIamMemberMap map[string]ResourcemanagerCloudIamMemberInput

func (ResourcemanagerCloudIamMemberMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ResourcemanagerCloudIamMember)(nil)).Elem()
}

func (i ResourcemanagerCloudIamMemberMap) ToResourcemanagerCloudIamMemberMapOutput() ResourcemanagerCloudIamMemberMapOutput {
	return i.ToResourcemanagerCloudIamMemberMapOutputWithContext(context.Background())
}

func (i ResourcemanagerCloudIamMemberMap) ToResourcemanagerCloudIamMemberMapOutputWithContext(ctx context.Context) ResourcemanagerCloudIamMemberMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourcemanagerCloudIamMemberMapOutput)
}

type ResourcemanagerCloudIamMemberOutput struct{ *pulumi.OutputState }

func (ResourcemanagerCloudIamMemberOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ResourcemanagerCloudIamMember)(nil)).Elem()
}

func (o ResourcemanagerCloudIamMemberOutput) ToResourcemanagerCloudIamMemberOutput() ResourcemanagerCloudIamMemberOutput {
	return o
}

func (o ResourcemanagerCloudIamMemberOutput) ToResourcemanagerCloudIamMemberOutputWithContext(ctx context.Context) ResourcemanagerCloudIamMemberOutput {
	return o
}

func (o ResourcemanagerCloudIamMemberOutput) CloudId() pulumi.StringOutput {
	return o.ApplyT(func(v *ResourcemanagerCloudIamMember) pulumi.StringOutput { return v.CloudId }).(pulumi.StringOutput)
}

func (o ResourcemanagerCloudIamMemberOutput) Member() pulumi.StringOutput {
	return o.ApplyT(func(v *ResourcemanagerCloudIamMember) pulumi.StringOutput { return v.Member }).(pulumi.StringOutput)
}

func (o ResourcemanagerCloudIamMemberOutput) Role() pulumi.StringOutput {
	return o.ApplyT(func(v *ResourcemanagerCloudIamMember) pulumi.StringOutput { return v.Role }).(pulumi.StringOutput)
}

func (o ResourcemanagerCloudIamMemberOutput) SleepAfter() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ResourcemanagerCloudIamMember) pulumi.IntPtrOutput { return v.SleepAfter }).(pulumi.IntPtrOutput)
}

type ResourcemanagerCloudIamMemberArrayOutput struct{ *pulumi.OutputState }

func (ResourcemanagerCloudIamMemberArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ResourcemanagerCloudIamMember)(nil)).Elem()
}

func (o ResourcemanagerCloudIamMemberArrayOutput) ToResourcemanagerCloudIamMemberArrayOutput() ResourcemanagerCloudIamMemberArrayOutput {
	return o
}

func (o ResourcemanagerCloudIamMemberArrayOutput) ToResourcemanagerCloudIamMemberArrayOutputWithContext(ctx context.Context) ResourcemanagerCloudIamMemberArrayOutput {
	return o
}

func (o ResourcemanagerCloudIamMemberArrayOutput) Index(i pulumi.IntInput) ResourcemanagerCloudIamMemberOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ResourcemanagerCloudIamMember {
		return vs[0].([]*ResourcemanagerCloudIamMember)[vs[1].(int)]
	}).(ResourcemanagerCloudIamMemberOutput)
}

type ResourcemanagerCloudIamMemberMapOutput struct{ *pulumi.OutputState }

func (ResourcemanagerCloudIamMemberMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ResourcemanagerCloudIamMember)(nil)).Elem()
}

func (o ResourcemanagerCloudIamMemberMapOutput) ToResourcemanagerCloudIamMemberMapOutput() ResourcemanagerCloudIamMemberMapOutput {
	return o
}

func (o ResourcemanagerCloudIamMemberMapOutput) ToResourcemanagerCloudIamMemberMapOutputWithContext(ctx context.Context) ResourcemanagerCloudIamMemberMapOutput {
	return o
}

func (o ResourcemanagerCloudIamMemberMapOutput) MapIndex(k pulumi.StringInput) ResourcemanagerCloudIamMemberOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ResourcemanagerCloudIamMember {
		return vs[0].(map[string]*ResourcemanagerCloudIamMember)[vs[1].(string)]
	}).(ResourcemanagerCloudIamMemberOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ResourcemanagerCloudIamMemberInput)(nil)).Elem(), &ResourcemanagerCloudIamMember{})
	pulumi.RegisterInputType(reflect.TypeOf((*ResourcemanagerCloudIamMemberArrayInput)(nil)).Elem(), ResourcemanagerCloudIamMemberArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ResourcemanagerCloudIamMemberMapInput)(nil)).Elem(), ResourcemanagerCloudIamMemberMap{})
	pulumi.RegisterOutputType(ResourcemanagerCloudIamMemberOutput{})
	pulumi.RegisterOutputType(ResourcemanagerCloudIamMemberArrayOutput{})
	pulumi.RegisterOutputType(ResourcemanagerCloudIamMemberMapOutput{})
}
