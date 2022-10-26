// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about a Yandex VPC network. For more information, see
// [Yandex.Cloud VPC](https://cloud.yandex.com/docs/vpc/concepts/index).
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
//			_, err := yandex.LookupVpcNetwork(ctx, &GetVpcNetworkArgs{
//				NetworkId: pulumi.StringRef("my-network-id"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
//
// This data source is used to define [VPC Networks] that can be used by other resources.
func LookupVpcNetwork(ctx *pulumi.Context, args *LookupVpcNetworkArgs, opts ...pulumi.InvokeOption) (*LookupVpcNetworkResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupVpcNetworkResult
	err := ctx.Invoke("yandex:index/getVpcNetwork:getVpcNetwork", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getVpcNetwork.
type LookupVpcNetworkArgs struct {
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// Name of the network.
	Name *string `pulumi:"name"`
	// ID of the network.
	NetworkId *string `pulumi:"networkId"`
}

// A collection of values returned by getVpcNetwork.
type LookupVpcNetworkResult struct {
	// Creation timestamp of this network.
	CreatedAt string `pulumi:"createdAt"`
	// ID of default Security Group of this network.
	DefaultSecurityGroupId string `pulumi:"defaultSecurityGroupId"`
	// Description of the network.
	Description string `pulumi:"description"`
	FolderId    string `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Labels assigned to this network.
	Labels    map[string]string `pulumi:"labels"`
	Name      string            `pulumi:"name"`
	NetworkId string            `pulumi:"networkId"`
	// List of subnet ids.
	SubnetIds []string `pulumi:"subnetIds"`
}

func LookupVpcNetworkOutput(ctx *pulumi.Context, args LookupVpcNetworkOutputArgs, opts ...pulumi.InvokeOption) LookupVpcNetworkResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupVpcNetworkResult, error) {
			args := v.(LookupVpcNetworkArgs)
			r, err := LookupVpcNetwork(ctx, &args, opts...)
			var s LookupVpcNetworkResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupVpcNetworkResultOutput)
}

// A collection of arguments for invoking getVpcNetwork.
type LookupVpcNetworkOutputArgs struct {
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId pulumi.StringPtrInput `pulumi:"folderId"`
	// Name of the network.
	Name pulumi.StringPtrInput `pulumi:"name"`
	// ID of the network.
	NetworkId pulumi.StringPtrInput `pulumi:"networkId"`
}

func (LookupVpcNetworkOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVpcNetworkArgs)(nil)).Elem()
}

// A collection of values returned by getVpcNetwork.
type LookupVpcNetworkResultOutput struct{ *pulumi.OutputState }

func (LookupVpcNetworkResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVpcNetworkResult)(nil)).Elem()
}

func (o LookupVpcNetworkResultOutput) ToLookupVpcNetworkResultOutput() LookupVpcNetworkResultOutput {
	return o
}

func (o LookupVpcNetworkResultOutput) ToLookupVpcNetworkResultOutputWithContext(ctx context.Context) LookupVpcNetworkResultOutput {
	return o
}

// Creation timestamp of this network.
func (o LookupVpcNetworkResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcNetworkResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

// ID of default Security Group of this network.
func (o LookupVpcNetworkResultOutput) DefaultSecurityGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcNetworkResult) string { return v.DefaultSecurityGroupId }).(pulumi.StringOutput)
}

// Description of the network.
func (o LookupVpcNetworkResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcNetworkResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupVpcNetworkResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcNetworkResult) string { return v.FolderId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupVpcNetworkResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcNetworkResult) string { return v.Id }).(pulumi.StringOutput)
}

// Labels assigned to this network.
func (o LookupVpcNetworkResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVpcNetworkResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupVpcNetworkResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcNetworkResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupVpcNetworkResultOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcNetworkResult) string { return v.NetworkId }).(pulumi.StringOutput)
}

// List of subnet ids.
func (o LookupVpcNetworkResultOutput) SubnetIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupVpcNetworkResult) []string { return v.SubnetIds }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupVpcNetworkResultOutput{})
}
