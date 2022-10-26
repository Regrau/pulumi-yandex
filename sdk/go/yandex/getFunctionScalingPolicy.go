// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupFunctionScalingPolicy(ctx *pulumi.Context, args *LookupFunctionScalingPolicyArgs, opts ...pulumi.InvokeOption) (*LookupFunctionScalingPolicyResult, error) {
	var rv LookupFunctionScalingPolicyResult
	err := ctx.Invoke("yandex:index/getFunctionScalingPolicy:getFunctionScalingPolicy", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getFunctionScalingPolicy.
type LookupFunctionScalingPolicyArgs struct {
	FunctionId string                           `pulumi:"functionId"`
	Policies   []GetFunctionScalingPolicyPolicy `pulumi:"policies"`
}

// A collection of values returned by getFunctionScalingPolicy.
type LookupFunctionScalingPolicyResult struct {
	FunctionId string `pulumi:"functionId"`
	// The provider-assigned unique ID for this managed resource.
	Id       string                           `pulumi:"id"`
	Policies []GetFunctionScalingPolicyPolicy `pulumi:"policies"`
}

func LookupFunctionScalingPolicyOutput(ctx *pulumi.Context, args LookupFunctionScalingPolicyOutputArgs, opts ...pulumi.InvokeOption) LookupFunctionScalingPolicyResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupFunctionScalingPolicyResult, error) {
			args := v.(LookupFunctionScalingPolicyArgs)
			r, err := LookupFunctionScalingPolicy(ctx, &args, opts...)
			var s LookupFunctionScalingPolicyResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupFunctionScalingPolicyResultOutput)
}

// A collection of arguments for invoking getFunctionScalingPolicy.
type LookupFunctionScalingPolicyOutputArgs struct {
	FunctionId pulumi.StringInput                       `pulumi:"functionId"`
	Policies   GetFunctionScalingPolicyPolicyArrayInput `pulumi:"policies"`
}

func (LookupFunctionScalingPolicyOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupFunctionScalingPolicyArgs)(nil)).Elem()
}

// A collection of values returned by getFunctionScalingPolicy.
type LookupFunctionScalingPolicyResultOutput struct{ *pulumi.OutputState }

func (LookupFunctionScalingPolicyResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupFunctionScalingPolicyResult)(nil)).Elem()
}

func (o LookupFunctionScalingPolicyResultOutput) ToLookupFunctionScalingPolicyResultOutput() LookupFunctionScalingPolicyResultOutput {
	return o
}

func (o LookupFunctionScalingPolicyResultOutput) ToLookupFunctionScalingPolicyResultOutputWithContext(ctx context.Context) LookupFunctionScalingPolicyResultOutput {
	return o
}

func (o LookupFunctionScalingPolicyResultOutput) FunctionId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFunctionScalingPolicyResult) string { return v.FunctionId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupFunctionScalingPolicyResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFunctionScalingPolicyResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupFunctionScalingPolicyResultOutput) Policies() GetFunctionScalingPolicyPolicyArrayOutput {
	return o.ApplyT(func(v LookupFunctionScalingPolicyResult) []GetFunctionScalingPolicyPolicy { return v.Policies }).(GetFunctionScalingPolicyPolicyArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupFunctionScalingPolicyResultOutput{})
}