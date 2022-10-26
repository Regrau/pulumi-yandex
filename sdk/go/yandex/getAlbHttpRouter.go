// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about a Yandex Application Load Balancer HTTP Router. For more information, see
// [Yandex.Cloud Application Load Balancer](https://cloud.yandex.com/en/docs/application-load-balancer/quickstart).
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
//			_, err := yandex.LookupAlbHttpRouter(ctx, &GetAlbHttpRouterArgs{
//				HttpRouterId: pulumi.StringRef("my-http-router-id"),
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
// This data source is used to define [Application Load Balancer HTTP Router] that can be used by other resources.
func LookupAlbHttpRouter(ctx *pulumi.Context, args *LookupAlbHttpRouterArgs, opts ...pulumi.InvokeOption) (*LookupAlbHttpRouterResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupAlbHttpRouterResult
	err := ctx.Invoke("yandex:index/getAlbHttpRouter:getAlbHttpRouter", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getAlbHttpRouter.
type LookupAlbHttpRouterArgs struct {
	// Description of the HTTP Router.
	Description *string `pulumi:"description"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// HTTP Router ID.
	HttpRouterId *string `pulumi:"httpRouterId"`
	// - Name of the HTTP Router.
	Name *string `pulumi:"name"`
}

// A collection of values returned by getAlbHttpRouter.
type LookupAlbHttpRouterResult struct {
	// Creation timestamp of this HTTP Router.
	CreatedAt string `pulumi:"createdAt"`
	// Description of the HTTP Router.
	Description  string `pulumi:"description"`
	FolderId     string `pulumi:"folderId"`
	HttpRouterId string `pulumi:"httpRouterId"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Labels to assign to this HTTP Router.
	Labels       map[string]string             `pulumi:"labels"`
	Name         string                        `pulumi:"name"`
	RouteOptions []GetAlbHttpRouterRouteOption `pulumi:"routeOptions"`
}

func LookupAlbHttpRouterOutput(ctx *pulumi.Context, args LookupAlbHttpRouterOutputArgs, opts ...pulumi.InvokeOption) LookupAlbHttpRouterResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupAlbHttpRouterResult, error) {
			args := v.(LookupAlbHttpRouterArgs)
			r, err := LookupAlbHttpRouter(ctx, &args, opts...)
			var s LookupAlbHttpRouterResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupAlbHttpRouterResultOutput)
}

// A collection of arguments for invoking getAlbHttpRouter.
type LookupAlbHttpRouterOutputArgs struct {
	// Description of the HTTP Router.
	Description pulumi.StringPtrInput `pulumi:"description"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId pulumi.StringPtrInput `pulumi:"folderId"`
	// HTTP Router ID.
	HttpRouterId pulumi.StringPtrInput `pulumi:"httpRouterId"`
	// - Name of the HTTP Router.
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupAlbHttpRouterOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAlbHttpRouterArgs)(nil)).Elem()
}

// A collection of values returned by getAlbHttpRouter.
type LookupAlbHttpRouterResultOutput struct{ *pulumi.OutputState }

func (LookupAlbHttpRouterResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAlbHttpRouterResult)(nil)).Elem()
}

func (o LookupAlbHttpRouterResultOutput) ToLookupAlbHttpRouterResultOutput() LookupAlbHttpRouterResultOutput {
	return o
}

func (o LookupAlbHttpRouterResultOutput) ToLookupAlbHttpRouterResultOutputWithContext(ctx context.Context) LookupAlbHttpRouterResultOutput {
	return o
}

// Creation timestamp of this HTTP Router.
func (o LookupAlbHttpRouterResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAlbHttpRouterResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

// Description of the HTTP Router.
func (o LookupAlbHttpRouterResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAlbHttpRouterResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupAlbHttpRouterResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAlbHttpRouterResult) string { return v.FolderId }).(pulumi.StringOutput)
}

func (o LookupAlbHttpRouterResultOutput) HttpRouterId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAlbHttpRouterResult) string { return v.HttpRouterId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupAlbHttpRouterResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAlbHttpRouterResult) string { return v.Id }).(pulumi.StringOutput)
}

// Labels to assign to this HTTP Router.
func (o LookupAlbHttpRouterResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupAlbHttpRouterResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupAlbHttpRouterResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAlbHttpRouterResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupAlbHttpRouterResultOutput) RouteOptions() GetAlbHttpRouterRouteOptionArrayOutput {
	return o.ApplyT(func(v LookupAlbHttpRouterResult) []GetAlbHttpRouterRouteOption { return v.RouteOptions }).(GetAlbHttpRouterRouteOptionArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupAlbHttpRouterResultOutput{})
}
