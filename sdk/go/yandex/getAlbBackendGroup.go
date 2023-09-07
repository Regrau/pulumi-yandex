// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about a Yandex Application Load Balancer Backend Group. For more information, see
// [Yandex.Cloud Application Load Balancer](https://cloud.yandex.com/en/docs/application-load-balancer/quickstart).
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
// 		_, err = yandex.LookupAlbBackendGroup(ctx, &GetAlbBackendGroupArgs{
// 			BackendGroupId: pulumi.StringRef("my-backend-group-id"),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// This data source is used to define [Application Load Balancer Backend Groups] that can be used by other resources.
func LookupAlbBackendGroup(ctx *pulumi.Context, args *LookupAlbBackendGroupArgs, opts ...pulumi.InvokeOption) (*LookupAlbBackendGroupResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupAlbBackendGroupResult
	err := ctx.Invoke("yandex:index/getAlbBackendGroup:getAlbBackendGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getAlbBackendGroup.
type LookupAlbBackendGroupArgs struct {
	// Backend Group ID.
	BackendGroupId *string `pulumi:"backendGroupId"`
	// Description of the backend group.
	Description *string `pulumi:"description"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// Grpc backend specification that will be used by the ALB Backend Group. Structure is documented below.
	GrpcBackends []GetAlbBackendGroupGrpcBackend `pulumi:"grpcBackends"`
	// Http backend specification that will be used by the ALB Backend Group. Structure is documented below.
	HttpBackends []GetAlbBackendGroupHttpBackend `pulumi:"httpBackends"`
	// Labels to assign to this backend group.
	Labels map[string]string `pulumi:"labels"`
	// - Name of the Backend Group.
	Name            *string                            `pulumi:"name"`
	SessionAffinity *GetAlbBackendGroupSessionAffinity `pulumi:"sessionAffinity"`
	// Stream backend specification that will be used by the ALB Backend Group. Structure is documented below.
	StreamBackends []GetAlbBackendGroupStreamBackend `pulumi:"streamBackends"`
}

// A collection of values returned by getAlbBackendGroup.
type LookupAlbBackendGroupResult struct {
	BackendGroupId string `pulumi:"backendGroupId"`
	// Creation timestamp of this backend group.
	CreatedAt string `pulumi:"createdAt"`
	// Description of the backend group.
	Description string `pulumi:"description"`
	FolderId    string `pulumi:"folderId"`
	// Grpc backend specification that will be used by the ALB Backend Group. Structure is documented below.
	GrpcBackends []GetAlbBackendGroupGrpcBackend `pulumi:"grpcBackends"`
	// Http backend specification that will be used by the ALB Backend Group. Structure is documented below.
	HttpBackends []GetAlbBackendGroupHttpBackend `pulumi:"httpBackends"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Labels to assign to this backend group.
	Labels map[string]string `pulumi:"labels"`
	// Name of the backend.
	Name            string                            `pulumi:"name"`
	SessionAffinity GetAlbBackendGroupSessionAffinity `pulumi:"sessionAffinity"`
	// Stream backend specification that will be used by the ALB Backend Group. Structure is documented below.
	StreamBackends []GetAlbBackendGroupStreamBackend `pulumi:"streamBackends"`
}

func LookupAlbBackendGroupOutput(ctx *pulumi.Context, args LookupAlbBackendGroupOutputArgs, opts ...pulumi.InvokeOption) LookupAlbBackendGroupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupAlbBackendGroupResult, error) {
			args := v.(LookupAlbBackendGroupArgs)
			r, err := LookupAlbBackendGroup(ctx, &args, opts...)
			var s LookupAlbBackendGroupResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupAlbBackendGroupResultOutput)
}

// A collection of arguments for invoking getAlbBackendGroup.
type LookupAlbBackendGroupOutputArgs struct {
	// Backend Group ID.
	BackendGroupId pulumi.StringPtrInput `pulumi:"backendGroupId"`
	// Description of the backend group.
	Description pulumi.StringPtrInput `pulumi:"description"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId pulumi.StringPtrInput `pulumi:"folderId"`
	// Grpc backend specification that will be used by the ALB Backend Group. Structure is documented below.
	GrpcBackends GetAlbBackendGroupGrpcBackendArrayInput `pulumi:"grpcBackends"`
	// Http backend specification that will be used by the ALB Backend Group. Structure is documented below.
	HttpBackends GetAlbBackendGroupHttpBackendArrayInput `pulumi:"httpBackends"`
	// Labels to assign to this backend group.
	Labels pulumi.StringMapInput `pulumi:"labels"`
	// - Name of the Backend Group.
	Name            pulumi.StringPtrInput                     `pulumi:"name"`
	SessionAffinity GetAlbBackendGroupSessionAffinityPtrInput `pulumi:"sessionAffinity"`
	// Stream backend specification that will be used by the ALB Backend Group. Structure is documented below.
	StreamBackends GetAlbBackendGroupStreamBackendArrayInput `pulumi:"streamBackends"`
}

func (LookupAlbBackendGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAlbBackendGroupArgs)(nil)).Elem()
}

// A collection of values returned by getAlbBackendGroup.
type LookupAlbBackendGroupResultOutput struct{ *pulumi.OutputState }

func (LookupAlbBackendGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAlbBackendGroupResult)(nil)).Elem()
}

func (o LookupAlbBackendGroupResultOutput) ToLookupAlbBackendGroupResultOutput() LookupAlbBackendGroupResultOutput {
	return o
}

func (o LookupAlbBackendGroupResultOutput) ToLookupAlbBackendGroupResultOutputWithContext(ctx context.Context) LookupAlbBackendGroupResultOutput {
	return o
}

func (o LookupAlbBackendGroupResultOutput) BackendGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAlbBackendGroupResult) string { return v.BackendGroupId }).(pulumi.StringOutput)
}

// Creation timestamp of this backend group.
func (o LookupAlbBackendGroupResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAlbBackendGroupResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

// Description of the backend group.
func (o LookupAlbBackendGroupResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAlbBackendGroupResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupAlbBackendGroupResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAlbBackendGroupResult) string { return v.FolderId }).(pulumi.StringOutput)
}

// Grpc backend specification that will be used by the ALB Backend Group. Structure is documented below.
func (o LookupAlbBackendGroupResultOutput) GrpcBackends() GetAlbBackendGroupGrpcBackendArrayOutput {
	return o.ApplyT(func(v LookupAlbBackendGroupResult) []GetAlbBackendGroupGrpcBackend { return v.GrpcBackends }).(GetAlbBackendGroupGrpcBackendArrayOutput)
}

// Http backend specification that will be used by the ALB Backend Group. Structure is documented below.
func (o LookupAlbBackendGroupResultOutput) HttpBackends() GetAlbBackendGroupHttpBackendArrayOutput {
	return o.ApplyT(func(v LookupAlbBackendGroupResult) []GetAlbBackendGroupHttpBackend { return v.HttpBackends }).(GetAlbBackendGroupHttpBackendArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupAlbBackendGroupResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAlbBackendGroupResult) string { return v.Id }).(pulumi.StringOutput)
}

// Labels to assign to this backend group.
func (o LookupAlbBackendGroupResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupAlbBackendGroupResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

// Name of the backend.
func (o LookupAlbBackendGroupResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAlbBackendGroupResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupAlbBackendGroupResultOutput) SessionAffinity() GetAlbBackendGroupSessionAffinityOutput {
	return o.ApplyT(func(v LookupAlbBackendGroupResult) GetAlbBackendGroupSessionAffinity { return v.SessionAffinity }).(GetAlbBackendGroupSessionAffinityOutput)
}

// Stream backend specification that will be used by the ALB Backend Group. Structure is documented below.
func (o LookupAlbBackendGroupResultOutput) StreamBackends() GetAlbBackendGroupStreamBackendArrayOutput {
	return o.ApplyT(func(v LookupAlbBackendGroupResult) []GetAlbBackendGroupStreamBackend { return v.StreamBackends }).(GetAlbBackendGroupStreamBackendArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupAlbBackendGroupResultOutput{})
}
