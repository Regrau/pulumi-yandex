// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Generates an [IAM] policy document that may be referenced by and applied to
// other Yandex.Cloud Platform resources, such as the `ResourcemanagerFolder` resource.
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
//			_, err = yandex.GetIamPolicy(ctx, &GetIamPolicyArgs{
//				Bindings: []GetIamPolicyBinding{
//					GetIamPolicyBinding{
//						Members: []string{
//							"userAccount:user_id_1",
//						},
//						Role: "admin",
//					},
//					GetIamPolicyBinding{
//						Members: []string{
//							"userAccount:user_id_2",
//						},
//						Role: "viewer",
//					},
//				},
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
// This data source is used to define [IAM] policies to apply to other resources.
// Currently, defining a policy through a data source and referencing that policy
// from another resource is the only way to apply an IAM policy to a resource.
func GetIamPolicy(ctx *pulumi.Context, args *GetIamPolicyArgs, opts ...pulumi.InvokeOption) (*GetIamPolicyResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetIamPolicyResult
	err := ctx.Invoke("yandex:index/getIamPolicy:getIamPolicy", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getIamPolicy.
type GetIamPolicyArgs struct {
	// A nested configuration block (described below)
	// that defines a binding to be included in the policy document. Multiple
	// `binding` arguments are supported.
	Bindings []GetIamPolicyBinding `pulumi:"bindings"`
}

// A collection of values returned by getIamPolicy.
type GetIamPolicyResult struct {
	Bindings []GetIamPolicyBinding `pulumi:"bindings"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The above bindings serialized in a format suitable for
	// referencing from a resource that supports IAM.
	PolicyData string `pulumi:"policyData"`
}

func GetIamPolicyOutput(ctx *pulumi.Context, args GetIamPolicyOutputArgs, opts ...pulumi.InvokeOption) GetIamPolicyResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetIamPolicyResult, error) {
			args := v.(GetIamPolicyArgs)
			r, err := GetIamPolicy(ctx, &args, opts...)
			var s GetIamPolicyResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetIamPolicyResultOutput)
}

// A collection of arguments for invoking getIamPolicy.
type GetIamPolicyOutputArgs struct {
	// A nested configuration block (described below)
	// that defines a binding to be included in the policy document. Multiple
	// `binding` arguments are supported.
	Bindings GetIamPolicyBindingArrayInput `pulumi:"bindings"`
}

func (GetIamPolicyOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetIamPolicyArgs)(nil)).Elem()
}

// A collection of values returned by getIamPolicy.
type GetIamPolicyResultOutput struct{ *pulumi.OutputState }

func (GetIamPolicyResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetIamPolicyResult)(nil)).Elem()
}

func (o GetIamPolicyResultOutput) ToGetIamPolicyResultOutput() GetIamPolicyResultOutput {
	return o
}

func (o GetIamPolicyResultOutput) ToGetIamPolicyResultOutputWithContext(ctx context.Context) GetIamPolicyResultOutput {
	return o
}

func (o GetIamPolicyResultOutput) Bindings() GetIamPolicyBindingArrayOutput {
	return o.ApplyT(func(v GetIamPolicyResult) []GetIamPolicyBinding { return v.Bindings }).(GetIamPolicyBindingArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetIamPolicyResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetIamPolicyResult) string { return v.Id }).(pulumi.StringOutput)
}

// The above bindings serialized in a format suitable for
// referencing from a resource that supports IAM.
func (o GetIamPolicyResultOutput) PolicyData() pulumi.StringOutput {
	return o.ApplyT(func(v GetIamPolicyResult) string { return v.PolicyData }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetIamPolicyResultOutput{})
}
