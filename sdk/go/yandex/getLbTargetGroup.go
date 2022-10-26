// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupLbTargetGroup(ctx *pulumi.Context, args *LookupLbTargetGroupArgs, opts ...pulumi.InvokeOption) (*LookupLbTargetGroupResult, error) {
	var rv LookupLbTargetGroupResult
	err := ctx.Invoke("yandex:index/getLbTargetGroup:getLbTargetGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getLbTargetGroup.
type LookupLbTargetGroupArgs struct {
	FolderId      *string `pulumi:"folderId"`
	Name          *string `pulumi:"name"`
	TargetGroupId *string `pulumi:"targetGroupId"`
}

// A collection of values returned by getLbTargetGroup.
type LookupLbTargetGroupResult struct {
	CreatedAt   string `pulumi:"createdAt"`
	Description string `pulumi:"description"`
	FolderId    string `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id            string                   `pulumi:"id"`
	Labels        map[string]string        `pulumi:"labels"`
	Name          string                   `pulumi:"name"`
	TargetGroupId string                   `pulumi:"targetGroupId"`
	Targets       []GetLbTargetGroupTarget `pulumi:"targets"`
}

func LookupLbTargetGroupOutput(ctx *pulumi.Context, args LookupLbTargetGroupOutputArgs, opts ...pulumi.InvokeOption) LookupLbTargetGroupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupLbTargetGroupResult, error) {
			args := v.(LookupLbTargetGroupArgs)
			r, err := LookupLbTargetGroup(ctx, &args, opts...)
			var s LookupLbTargetGroupResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupLbTargetGroupResultOutput)
}

// A collection of arguments for invoking getLbTargetGroup.
type LookupLbTargetGroupOutputArgs struct {
	FolderId      pulumi.StringPtrInput `pulumi:"folderId"`
	Name          pulumi.StringPtrInput `pulumi:"name"`
	TargetGroupId pulumi.StringPtrInput `pulumi:"targetGroupId"`
}

func (LookupLbTargetGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupLbTargetGroupArgs)(nil)).Elem()
}

// A collection of values returned by getLbTargetGroup.
type LookupLbTargetGroupResultOutput struct{ *pulumi.OutputState }

func (LookupLbTargetGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupLbTargetGroupResult)(nil)).Elem()
}

func (o LookupLbTargetGroupResultOutput) ToLookupLbTargetGroupResultOutput() LookupLbTargetGroupResultOutput {
	return o
}

func (o LookupLbTargetGroupResultOutput) ToLookupLbTargetGroupResultOutputWithContext(ctx context.Context) LookupLbTargetGroupResultOutput {
	return o
}

func (o LookupLbTargetGroupResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLbTargetGroupResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupLbTargetGroupResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLbTargetGroupResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupLbTargetGroupResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLbTargetGroupResult) string { return v.FolderId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupLbTargetGroupResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLbTargetGroupResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupLbTargetGroupResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupLbTargetGroupResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupLbTargetGroupResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLbTargetGroupResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupLbTargetGroupResultOutput) TargetGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLbTargetGroupResult) string { return v.TargetGroupId }).(pulumi.StringOutput)
}

func (o LookupLbTargetGroupResultOutput) Targets() GetLbTargetGroupTargetArrayOutput {
	return o.ApplyT(func(v LookupLbTargetGroupResult) []GetLbTargetGroupTarget { return v.Targets }).(GetLbTargetGroupTargetArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupLbTargetGroupResultOutput{})
}