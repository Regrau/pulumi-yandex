// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

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
	AddressId *string `pulumi:"addressId"`
	FolderId  *string `pulumi:"folderId"`
	Name      *string `pulumi:"name"`
}

// A collection of values returned by getVpcAddress.
type LookupVpcAddressResult struct {
	AddressId             string                             `pulumi:"addressId"`
	CreatedAt             string                             `pulumi:"createdAt"`
	Description           string                             `pulumi:"description"`
	ExternalIpv4Addresses []GetVpcAddressExternalIpv4Address `pulumi:"externalIpv4Addresses"`
	FolderId              string                             `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id       string            `pulumi:"id"`
	Labels   map[string]string `pulumi:"labels"`
	Name     string            `pulumi:"name"`
	Reserved bool              `pulumi:"reserved"`
	Used     bool              `pulumi:"used"`
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
	AddressId pulumi.StringPtrInput `pulumi:"addressId"`
	FolderId  pulumi.StringPtrInput `pulumi:"folderId"`
	Name      pulumi.StringPtrInput `pulumi:"name"`
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

func (o LookupVpcAddressResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupVpcAddressResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) string { return v.Description }).(pulumi.StringOutput)
}

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

func (o LookupVpcAddressResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupVpcAddressResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupVpcAddressResultOutput) Reserved() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) bool { return v.Reserved }).(pulumi.BoolOutput)
}

func (o LookupVpcAddressResultOutput) Used() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupVpcAddressResult) bool { return v.Used }).(pulumi.BoolOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupVpcAddressResultOutput{})
}
