// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Manages a gateway within the Yandex.Cloud. For more information, see
// [the official documentation](https://cloud.yandex.com/en/docs/vpc/concepts/gateways).
//
// * How-to Guides
//   - [Cloud Networking](https://cloud.yandex.com/docs/vpc/)
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-yandex/sdk/go/yandex"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := yandex.NewvpcGateway(ctx, "default", &yandex.vpcGatewayArgs{
//				SharedEgressGateway: nil,
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
//
// ## Import
//
// A gateway can be imported using the `id` of the resource, e.g.
//
// ```sh
//
//	$ pulumi import yandex:index/vpcGateway:vpcGateway default gateway_id
//
// ```
type VpcGateway struct {
	pulumi.CustomResourceState

	// Creation timestamp of the key.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// An optional description of this resource. Provide this property when
	// you create the resource.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId pulumi.StringOutput `pulumi:"folderId"`
	// Labels to apply to this VPC Gateway. A list of key/value pairs.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Name of the VPC Gateway. Provided by the client when the VPC Gateway is created.
	Name pulumi.StringOutput `pulumi:"name"`
	// Shared egress gateway configuration. Currently empty.
	SharedEgressGateway VpcGatewaySharedEgressGatewayPtrOutput `pulumi:"sharedEgressGateway"`
}

// NewVpcGateway registers a new resource with the given unique name, arguments, and options.
func NewVpcGateway(ctx *pulumi.Context,
	name string, args *VpcGatewayArgs, opts ...pulumi.ResourceOption) (*VpcGateway, error) {
	if args == nil {
		args = &VpcGatewayArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource VpcGateway
	err := ctx.RegisterResource("yandex:index/vpcGateway:vpcGateway", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVpcGateway gets an existing VpcGateway resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVpcGateway(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VpcGatewayState, opts ...pulumi.ResourceOption) (*VpcGateway, error) {
	var resource VpcGateway
	err := ctx.ReadResource("yandex:index/vpcGateway:vpcGateway", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VpcGateway resources.
type vpcGatewayState struct {
	// Creation timestamp of the key.
	CreatedAt *string `pulumi:"createdAt"`
	// An optional description of this resource. Provide this property when
	// you create the resource.
	Description *string `pulumi:"description"`
	// ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// Labels to apply to this VPC Gateway. A list of key/value pairs.
	Labels map[string]string `pulumi:"labels"`
	// Name of the VPC Gateway. Provided by the client when the VPC Gateway is created.
	Name *string `pulumi:"name"`
	// Shared egress gateway configuration. Currently empty.
	SharedEgressGateway *VpcGatewaySharedEgressGateway `pulumi:"sharedEgressGateway"`
}

type VpcGatewayState struct {
	// Creation timestamp of the key.
	CreatedAt pulumi.StringPtrInput
	// An optional description of this resource. Provide this property when
	// you create the resource.
	Description pulumi.StringPtrInput
	// ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// Labels to apply to this VPC Gateway. A list of key/value pairs.
	Labels pulumi.StringMapInput
	// Name of the VPC Gateway. Provided by the client when the VPC Gateway is created.
	Name pulumi.StringPtrInput
	// Shared egress gateway configuration. Currently empty.
	SharedEgressGateway VpcGatewaySharedEgressGatewayPtrInput
}

func (VpcGatewayState) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcGatewayState)(nil)).Elem()
}

type vpcGatewayArgs struct {
	// An optional description of this resource. Provide this property when
	// you create the resource.
	Description *string `pulumi:"description"`
	// ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// Labels to apply to this VPC Gateway. A list of key/value pairs.
	Labels map[string]string `pulumi:"labels"`
	// Name of the VPC Gateway. Provided by the client when the VPC Gateway is created.
	Name *string `pulumi:"name"`
	// Shared egress gateway configuration. Currently empty.
	SharedEgressGateway *VpcGatewaySharedEgressGateway `pulumi:"sharedEgressGateway"`
}

// The set of arguments for constructing a VpcGateway resource.
type VpcGatewayArgs struct {
	// An optional description of this resource. Provide this property when
	// you create the resource.
	Description pulumi.StringPtrInput
	// ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// Labels to apply to this VPC Gateway. A list of key/value pairs.
	Labels pulumi.StringMapInput
	// Name of the VPC Gateway. Provided by the client when the VPC Gateway is created.
	Name pulumi.StringPtrInput
	// Shared egress gateway configuration. Currently empty.
	SharedEgressGateway VpcGatewaySharedEgressGatewayPtrInput
}

func (VpcGatewayArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcGatewayArgs)(nil)).Elem()
}

type VpcGatewayInput interface {
	pulumi.Input

	ToVpcGatewayOutput() VpcGatewayOutput
	ToVpcGatewayOutputWithContext(ctx context.Context) VpcGatewayOutput
}

func (*VpcGateway) ElementType() reflect.Type {
	return reflect.TypeOf((**VpcGateway)(nil)).Elem()
}

func (i *VpcGateway) ToVpcGatewayOutput() VpcGatewayOutput {
	return i.ToVpcGatewayOutputWithContext(context.Background())
}

func (i *VpcGateway) ToVpcGatewayOutputWithContext(ctx context.Context) VpcGatewayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VpcGatewayOutput)
}

// VpcGatewayArrayInput is an input type that accepts VpcGatewayArray and VpcGatewayArrayOutput values.
// You can construct a concrete instance of `VpcGatewayArrayInput` via:
//
//	VpcGatewayArray{ VpcGatewayArgs{...} }
type VpcGatewayArrayInput interface {
	pulumi.Input

	ToVpcGatewayArrayOutput() VpcGatewayArrayOutput
	ToVpcGatewayArrayOutputWithContext(context.Context) VpcGatewayArrayOutput
}

type VpcGatewayArray []VpcGatewayInput

func (VpcGatewayArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*VpcGateway)(nil)).Elem()
}

func (i VpcGatewayArray) ToVpcGatewayArrayOutput() VpcGatewayArrayOutput {
	return i.ToVpcGatewayArrayOutputWithContext(context.Background())
}

func (i VpcGatewayArray) ToVpcGatewayArrayOutputWithContext(ctx context.Context) VpcGatewayArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VpcGatewayArrayOutput)
}

// VpcGatewayMapInput is an input type that accepts VpcGatewayMap and VpcGatewayMapOutput values.
// You can construct a concrete instance of `VpcGatewayMapInput` via:
//
//	VpcGatewayMap{ "key": VpcGatewayArgs{...} }
type VpcGatewayMapInput interface {
	pulumi.Input

	ToVpcGatewayMapOutput() VpcGatewayMapOutput
	ToVpcGatewayMapOutputWithContext(context.Context) VpcGatewayMapOutput
}

type VpcGatewayMap map[string]VpcGatewayInput

func (VpcGatewayMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*VpcGateway)(nil)).Elem()
}

func (i VpcGatewayMap) ToVpcGatewayMapOutput() VpcGatewayMapOutput {
	return i.ToVpcGatewayMapOutputWithContext(context.Background())
}

func (i VpcGatewayMap) ToVpcGatewayMapOutputWithContext(ctx context.Context) VpcGatewayMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VpcGatewayMapOutput)
}

type VpcGatewayOutput struct{ *pulumi.OutputState }

func (VpcGatewayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**VpcGateway)(nil)).Elem()
}

func (o VpcGatewayOutput) ToVpcGatewayOutput() VpcGatewayOutput {
	return o
}

func (o VpcGatewayOutput) ToVpcGatewayOutputWithContext(ctx context.Context) VpcGatewayOutput {
	return o
}

// Creation timestamp of the key.
func (o VpcGatewayOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *VpcGateway) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// An optional description of this resource. Provide this property when
// you create the resource.
func (o VpcGatewayOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VpcGateway) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// ID of the folder that the resource belongs to. If it
// is not provided, the default provider folder is used.
func (o VpcGatewayOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *VpcGateway) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

// Labels to apply to this VPC Gateway. A list of key/value pairs.
func (o VpcGatewayOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *VpcGateway) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// Name of the VPC Gateway. Provided by the client when the VPC Gateway is created.
func (o VpcGatewayOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *VpcGateway) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Shared egress gateway configuration. Currently empty.
func (o VpcGatewayOutput) SharedEgressGateway() VpcGatewaySharedEgressGatewayPtrOutput {
	return o.ApplyT(func(v *VpcGateway) VpcGatewaySharedEgressGatewayPtrOutput { return v.SharedEgressGateway }).(VpcGatewaySharedEgressGatewayPtrOutput)
}

type VpcGatewayArrayOutput struct{ *pulumi.OutputState }

func (VpcGatewayArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*VpcGateway)(nil)).Elem()
}

func (o VpcGatewayArrayOutput) ToVpcGatewayArrayOutput() VpcGatewayArrayOutput {
	return o
}

func (o VpcGatewayArrayOutput) ToVpcGatewayArrayOutputWithContext(ctx context.Context) VpcGatewayArrayOutput {
	return o
}

func (o VpcGatewayArrayOutput) Index(i pulumi.IntInput) VpcGatewayOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *VpcGateway {
		return vs[0].([]*VpcGateway)[vs[1].(int)]
	}).(VpcGatewayOutput)
}

type VpcGatewayMapOutput struct{ *pulumi.OutputState }

func (VpcGatewayMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*VpcGateway)(nil)).Elem()
}

func (o VpcGatewayMapOutput) ToVpcGatewayMapOutput() VpcGatewayMapOutput {
	return o
}

func (o VpcGatewayMapOutput) ToVpcGatewayMapOutputWithContext(ctx context.Context) VpcGatewayMapOutput {
	return o
}

func (o VpcGatewayMapOutput) MapIndex(k pulumi.StringInput) VpcGatewayOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *VpcGateway {
		return vs[0].(map[string]*VpcGateway)[vs[1].(string)]
	}).(VpcGatewayOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*VpcGatewayInput)(nil)).Elem(), &VpcGateway{})
	pulumi.RegisterInputType(reflect.TypeOf((*VpcGatewayArrayInput)(nil)).Elem(), VpcGatewayArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*VpcGatewayMapInput)(nil)).Elem(), VpcGatewayMap{})
	pulumi.RegisterOutputType(VpcGatewayOutput{})
	pulumi.RegisterOutputType(VpcGatewayArrayOutput{})
	pulumi.RegisterOutputType(VpcGatewayMapOutput{})
}
