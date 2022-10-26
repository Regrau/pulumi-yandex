// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type ContainerRegistry struct {
	pulumi.CustomResourceState

	CreatedAt pulumi.StringOutput    `pulumi:"createdAt"`
	FolderId  pulumi.StringOutput    `pulumi:"folderId"`
	Labels    pulumi.StringMapOutput `pulumi:"labels"`
	Name      pulumi.StringOutput    `pulumi:"name"`
	Status    pulumi.StringOutput    `pulumi:"status"`
}

// NewContainerRegistry registers a new resource with the given unique name, arguments, and options.
func NewContainerRegistry(ctx *pulumi.Context,
	name string, args *ContainerRegistryArgs, opts ...pulumi.ResourceOption) (*ContainerRegistry, error) {
	if args == nil {
		args = &ContainerRegistryArgs{}
	}

	var resource ContainerRegistry
	err := ctx.RegisterResource("yandex:index/containerRegistry:ContainerRegistry", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetContainerRegistry gets an existing ContainerRegistry resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetContainerRegistry(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ContainerRegistryState, opts ...pulumi.ResourceOption) (*ContainerRegistry, error) {
	var resource ContainerRegistry
	err := ctx.ReadResource("yandex:index/containerRegistry:ContainerRegistry", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ContainerRegistry resources.
type containerRegistryState struct {
	CreatedAt *string           `pulumi:"createdAt"`
	FolderId  *string           `pulumi:"folderId"`
	Labels    map[string]string `pulumi:"labels"`
	Name      *string           `pulumi:"name"`
	Status    *string           `pulumi:"status"`
}

type ContainerRegistryState struct {
	CreatedAt pulumi.StringPtrInput
	FolderId  pulumi.StringPtrInput
	Labels    pulumi.StringMapInput
	Name      pulumi.StringPtrInput
	Status    pulumi.StringPtrInput
}

func (ContainerRegistryState) ElementType() reflect.Type {
	return reflect.TypeOf((*containerRegistryState)(nil)).Elem()
}

type containerRegistryArgs struct {
	FolderId *string           `pulumi:"folderId"`
	Labels   map[string]string `pulumi:"labels"`
	Name     *string           `pulumi:"name"`
}

// The set of arguments for constructing a ContainerRegistry resource.
type ContainerRegistryArgs struct {
	FolderId pulumi.StringPtrInput
	Labels   pulumi.StringMapInput
	Name     pulumi.StringPtrInput
}

func (ContainerRegistryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*containerRegistryArgs)(nil)).Elem()
}

type ContainerRegistryInput interface {
	pulumi.Input

	ToContainerRegistryOutput() ContainerRegistryOutput
	ToContainerRegistryOutputWithContext(ctx context.Context) ContainerRegistryOutput
}

func (*ContainerRegistry) ElementType() reflect.Type {
	return reflect.TypeOf((**ContainerRegistry)(nil)).Elem()
}

func (i *ContainerRegistry) ToContainerRegistryOutput() ContainerRegistryOutput {
	return i.ToContainerRegistryOutputWithContext(context.Background())
}

func (i *ContainerRegistry) ToContainerRegistryOutputWithContext(ctx context.Context) ContainerRegistryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerRegistryOutput)
}

// ContainerRegistryArrayInput is an input type that accepts ContainerRegistryArray and ContainerRegistryArrayOutput values.
// You can construct a concrete instance of `ContainerRegistryArrayInput` via:
//
//	ContainerRegistryArray{ ContainerRegistryArgs{...} }
type ContainerRegistryArrayInput interface {
	pulumi.Input

	ToContainerRegistryArrayOutput() ContainerRegistryArrayOutput
	ToContainerRegistryArrayOutputWithContext(context.Context) ContainerRegistryArrayOutput
}

type ContainerRegistryArray []ContainerRegistryInput

func (ContainerRegistryArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ContainerRegistry)(nil)).Elem()
}

func (i ContainerRegistryArray) ToContainerRegistryArrayOutput() ContainerRegistryArrayOutput {
	return i.ToContainerRegistryArrayOutputWithContext(context.Background())
}

func (i ContainerRegistryArray) ToContainerRegistryArrayOutputWithContext(ctx context.Context) ContainerRegistryArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerRegistryArrayOutput)
}

// ContainerRegistryMapInput is an input type that accepts ContainerRegistryMap and ContainerRegistryMapOutput values.
// You can construct a concrete instance of `ContainerRegistryMapInput` via:
//
//	ContainerRegistryMap{ "key": ContainerRegistryArgs{...} }
type ContainerRegistryMapInput interface {
	pulumi.Input

	ToContainerRegistryMapOutput() ContainerRegistryMapOutput
	ToContainerRegistryMapOutputWithContext(context.Context) ContainerRegistryMapOutput
}

type ContainerRegistryMap map[string]ContainerRegistryInput

func (ContainerRegistryMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ContainerRegistry)(nil)).Elem()
}

func (i ContainerRegistryMap) ToContainerRegistryMapOutput() ContainerRegistryMapOutput {
	return i.ToContainerRegistryMapOutputWithContext(context.Background())
}

func (i ContainerRegistryMap) ToContainerRegistryMapOutputWithContext(ctx context.Context) ContainerRegistryMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerRegistryMapOutput)
}

type ContainerRegistryOutput struct{ *pulumi.OutputState }

func (ContainerRegistryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ContainerRegistry)(nil)).Elem()
}

func (o ContainerRegistryOutput) ToContainerRegistryOutput() ContainerRegistryOutput {
	return o
}

func (o ContainerRegistryOutput) ToContainerRegistryOutputWithContext(ctx context.Context) ContainerRegistryOutput {
	return o
}

func (o ContainerRegistryOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRegistry) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o ContainerRegistryOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRegistry) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

func (o ContainerRegistryOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *ContainerRegistry) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o ContainerRegistryOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRegistry) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o ContainerRegistryOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRegistry) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type ContainerRegistryArrayOutput struct{ *pulumi.OutputState }

func (ContainerRegistryArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ContainerRegistry)(nil)).Elem()
}

func (o ContainerRegistryArrayOutput) ToContainerRegistryArrayOutput() ContainerRegistryArrayOutput {
	return o
}

func (o ContainerRegistryArrayOutput) ToContainerRegistryArrayOutputWithContext(ctx context.Context) ContainerRegistryArrayOutput {
	return o
}

func (o ContainerRegistryArrayOutput) Index(i pulumi.IntInput) ContainerRegistryOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ContainerRegistry {
		return vs[0].([]*ContainerRegistry)[vs[1].(int)]
	}).(ContainerRegistryOutput)
}

type ContainerRegistryMapOutput struct{ *pulumi.OutputState }

func (ContainerRegistryMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ContainerRegistry)(nil)).Elem()
}

func (o ContainerRegistryMapOutput) ToContainerRegistryMapOutput() ContainerRegistryMapOutput {
	return o
}

func (o ContainerRegistryMapOutput) ToContainerRegistryMapOutputWithContext(ctx context.Context) ContainerRegistryMapOutput {
	return o
}

func (o ContainerRegistryMapOutput) MapIndex(k pulumi.StringInput) ContainerRegistryOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ContainerRegistry {
		return vs[0].(map[string]*ContainerRegistry)[vs[1].(string)]
	}).(ContainerRegistryOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerRegistryInput)(nil)).Elem(), &ContainerRegistry{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerRegistryArrayInput)(nil)).Elem(), ContainerRegistryArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerRegistryMapInput)(nil)).Elem(), ContainerRegistryMap{})
	pulumi.RegisterOutputType(ContainerRegistryOutput{})
	pulumi.RegisterOutputType(ContainerRegistryArrayOutput{})
	pulumi.RegisterOutputType(ContainerRegistryMapOutput{})
}
