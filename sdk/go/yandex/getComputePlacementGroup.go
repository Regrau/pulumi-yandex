// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupComputePlacementGroup(ctx *pulumi.Context, args *LookupComputePlacementGroupArgs, opts ...pulumi.InvokeOption) (*LookupComputePlacementGroupResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupComputePlacementGroupResult
	err := ctx.Invoke("yandex:index/getComputePlacementGroup:getComputePlacementGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getComputePlacementGroup.
type LookupComputePlacementGroupArgs struct {
	Description *string           `pulumi:"description"`
	FolderId    *string           `pulumi:"folderId"`
	GroupId     *string           `pulumi:"groupId"`
	Labels      map[string]string `pulumi:"labels"`
	Name        *string           `pulumi:"name"`
}

// A collection of values returned by getComputePlacementGroup.
type LookupComputePlacementGroupResult struct {
	CreatedAt   string  `pulumi:"createdAt"`
	Description *string `pulumi:"description"`
	FolderId    string  `pulumi:"folderId"`
	GroupId     string  `pulumi:"groupId"`
	// The provider-assigned unique ID for this managed resource.
	Id     string            `pulumi:"id"`
	Labels map[string]string `pulumi:"labels"`
	Name   *string           `pulumi:"name"`
}

func LookupComputePlacementGroupOutput(ctx *pulumi.Context, args LookupComputePlacementGroupOutputArgs, opts ...pulumi.InvokeOption) LookupComputePlacementGroupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupComputePlacementGroupResult, error) {
			args := v.(LookupComputePlacementGroupArgs)
			r, err := LookupComputePlacementGroup(ctx, &args, opts...)
			var s LookupComputePlacementGroupResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupComputePlacementGroupResultOutput)
}

// A collection of arguments for invoking getComputePlacementGroup.
type LookupComputePlacementGroupOutputArgs struct {
	Description pulumi.StringPtrInput `pulumi:"description"`
	FolderId    pulumi.StringPtrInput `pulumi:"folderId"`
	GroupId     pulumi.StringPtrInput `pulumi:"groupId"`
	Labels      pulumi.StringMapInput `pulumi:"labels"`
	Name        pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupComputePlacementGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputePlacementGroupArgs)(nil)).Elem()
}

// A collection of values returned by getComputePlacementGroup.
type LookupComputePlacementGroupResultOutput struct{ *pulumi.OutputState }

func (LookupComputePlacementGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputePlacementGroupResult)(nil)).Elem()
}

func (o LookupComputePlacementGroupResultOutput) ToLookupComputePlacementGroupResultOutput() LookupComputePlacementGroupResultOutput {
	return o
}

func (o LookupComputePlacementGroupResultOutput) ToLookupComputePlacementGroupResultOutputWithContext(ctx context.Context) LookupComputePlacementGroupResultOutput {
	return o
}

func (o LookupComputePlacementGroupResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputePlacementGroupResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupComputePlacementGroupResultOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupComputePlacementGroupResult) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o LookupComputePlacementGroupResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputePlacementGroupResult) string { return v.FolderId }).(pulumi.StringOutput)
}

func (o LookupComputePlacementGroupResultOutput) GroupId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputePlacementGroupResult) string { return v.GroupId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupComputePlacementGroupResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputePlacementGroupResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupComputePlacementGroupResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupComputePlacementGroupResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupComputePlacementGroupResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupComputePlacementGroupResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupComputePlacementGroupResultOutput{})
}
