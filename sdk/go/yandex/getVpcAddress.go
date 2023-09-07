// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about a Yandex VPC address. For more information, see
// Yandex.Cloud VPC.
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
// 		_, err = yandex.LookupVpcAddress(ctx, &GetVpcAddressArgs{
// 			AddressId: pulumi.StringRef("my-address-id"),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// This data source is used to define [VPC Address] that can be used by other resources.
func LookupVpcAddress(ctx *pulumi.Context, args *LookupVpcAddressArgs, opts ...pulumi.InvokeOption) (*LookupVpcAddressResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupVpcAddressResult
	err := ctx.Invoke("yandex:index/getVpcAddress:getVpcAddress", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getVpcAddress.
type LookupVpcAddressArgs struct {
	// ID of the address.
	AddressId *string `pulumi:"addressId"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// Name of the address.
	Name *string `pulumi:"name"`
}

// A collection of values returned by getVpcAddress.
type LookupVpcAddressResult struct {
	AddressId string `pulumi:"addressId"`
	// Creation timestamp of this address.
	CreatedAt string `pulumi:"createdAt"`
	// Description of the address.
	Description string `pulumi:"description"`
	// spec of IP v4 address.
	ExternalIpv4Addresses []GetVpcAddressExternalIpv4Address `pulumi:"externalIpv4Addresses"`
	FolderId              string                             `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Labels assigned to this address.
	Labels map[string]string `pulumi:"labels"`
	Name   string            `pulumi:"name"`
	// `false` means that address is ephemeral.
	Reserved bool `pulumi:"reserved"`
	// `true` if address is used.
	Used bool `pulumi:"used"`
}

func LookupVpcAddressOutput(ctx *pulumi.Context, args LookupVpcAddressOutputArgs, opts ...pulumi.InvokeOption) LookupVpcAddressResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupVpcAddressResult, error) {
			args := v.(LookupVpcAddressArgs)
			r, err := LookupVpcAddress(ctx, &args, opts...)
			var s LookupVpcAddressResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupVpcAddressResultOutput)
}

// A collection of arguments for invoking getVpcAddress.
type LookupVpcAddressOutputArgs struct {
	// ID of the address.
	AddressId pulumi.StringPtrInput `pulumi:"addressId"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId pulumi.StringPtrInput `pulumi:"folderId"`
	// Name of the address.
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupVpcAddressOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVpcAddressArgs)(nil)).Elem()
}

// A collection of values returned by getVpcAddress.
type LookupVpcAddressResultOutput struct{ *pulumi.OutputState }

func (LookupVpcAddressResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVpcAddressResult)(nil)).Elem()
}

func (o LookupVpcAddressResultOutput) ToLookupVpcAddressResultOutput() LookupVpcAddressResultOutput {
	return o
}

func (o LookupVpcAddressResultOutput) ToLookupVpcAddressResultOutputWithContext(ctx context.Context) LookupVpcAddressResultOutput {
	return o
}

func (o LookupVpcAddressResultOutput) AddressId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) string { return v.AddressId }).(pulumi.StringOutput)
}

// Creation timestamp of this address.
func (o LookupVpcAddressResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

// Description of the address.
func (o LookupVpcAddressResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) string { return v.Description }).(pulumi.StringOutput)
}

// spec of IP v4 address.
func (o LookupVpcAddressResultOutput) ExternalIpv4Addresses() GetVpcAddressExternalIpv4AddressArrayOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) []GetVpcAddressExternalIpv4Address { return v.ExternalIpv4Addresses }).(GetVpcAddressExternalIpv4AddressArrayOutput)
}

func (o LookupVpcAddressResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) string { return v.FolderId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupVpcAddressResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) string { return v.Id }).(pulumi.StringOutput)
}

// Labels assigned to this address.
func (o LookupVpcAddressResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupVpcAddressResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) string { return v.Name }).(pulumi.StringOutput)
}

// `false` means that address is ephemeral.
func (o LookupVpcAddressResultOutput) Reserved() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) bool { return v.Reserved }).(pulumi.BoolOutput)
}

// `true` if address is used.
func (o LookupVpcAddressResultOutput) Used() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) bool { return v.Used }).(pulumi.BoolOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupVpcAddressResultOutput{})
}
