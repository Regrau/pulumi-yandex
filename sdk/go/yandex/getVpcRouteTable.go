// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupVpcRouteTable(ctx *pulumi.Context, args *LookupVpcRouteTableArgs, opts ...pulumi.InvokeOption) (*LookupVpcRouteTableResult, error) {
	var rv LookupVpcRouteTableResult
	err := ctx.Invoke("yandex:index/getVpcRouteTable:getVpcRouteTable", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getVpcRouteTable.
type LookupVpcRouteTableArgs struct {
	FolderId     *string `pulumi:"folderId"`
	Name         *string `pulumi:"name"`
	RouteTableId *string `pulumi:"routeTableId"`
}

// A collection of values returned by getVpcRouteTable.
type LookupVpcRouteTableResult struct {
	CreatedAt   string `pulumi:"createdAt"`
	Description string `pulumi:"description"`
	FolderId    string `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id           string                        `pulumi:"id"`
	Labels       map[string]string             `pulumi:"labels"`
	Name         string                        `pulumi:"name"`
	NetworkId    string                        `pulumi:"networkId"`
	RouteTableId string                        `pulumi:"routeTableId"`
	StaticRoutes []GetVpcRouteTableStaticRoute `pulumi:"staticRoutes"`
}

func LookupVpcRouteTableOutput(ctx *pulumi.Context, args LookupVpcRouteTableOutputArgs, opts ...pulumi.InvokeOption) LookupVpcRouteTableResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupVpcRouteTableResult, error) {
			args := v.(LookupVpcRouteTableArgs)
			r, err := LookupVpcRouteTable(ctx, &args, opts...)
			var s LookupVpcRouteTableResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupVpcRouteTableResultOutput)
}

// A collection of arguments for invoking getVpcRouteTable.
type LookupVpcRouteTableOutputArgs struct {
	FolderId     pulumi.StringPtrInput `pulumi:"folderId"`
	Name         pulumi.StringPtrInput `pulumi:"name"`
	RouteTableId pulumi.StringPtrInput `pulumi:"routeTableId"`
}

func (LookupVpcRouteTableOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVpcRouteTableArgs)(nil)).Elem()
}

// A collection of values returned by getVpcRouteTable.
type LookupVpcRouteTableResultOutput struct{ *pulumi.OutputState }

func (LookupVpcRouteTableResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVpcRouteTableResult)(nil)).Elem()
}

func (o LookupVpcRouteTableResultOutput) ToLookupVpcRouteTableResultOutput() LookupVpcRouteTableResultOutput {
	return o
}

func (o LookupVpcRouteTableResultOutput) ToLookupVpcRouteTableResultOutputWithContext(ctx context.Context) LookupVpcRouteTableResultOutput {
	return o
}

func (o LookupVpcRouteTableResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcRouteTableResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupVpcRouteTableResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcRouteTableResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupVpcRouteTableResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcRouteTableResult) string { return v.FolderId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupVpcRouteTableResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcRouteTableResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupVpcRouteTableResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVpcRouteTableResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupVpcRouteTableResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcRouteTableResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupVpcRouteTableResultOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcRouteTableResult) string { return v.NetworkId }).(pulumi.StringOutput)
}

func (o LookupVpcRouteTableResultOutput) RouteTableId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcRouteTableResult) string { return v.RouteTableId }).(pulumi.StringOutput)
}

func (o LookupVpcRouteTableResultOutput) StaticRoutes() GetVpcRouteTableStaticRouteArrayOutput {
	return o.ApplyT(func(v LookupVpcRouteTableResult) []GetVpcRouteTableStaticRoute { return v.StaticRoutes }).(GetVpcRouteTableStaticRouteArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupVpcRouteTableResultOutput{})
}