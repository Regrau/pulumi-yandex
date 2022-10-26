// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetIamUser(ctx *pulumi.Context, args *GetIamUserArgs, opts ...pulumi.InvokeOption) (*GetIamUserResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetIamUserResult
	err := ctx.Invoke("yandex:index/getIamUser:getIamUser", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getIamUser.
type GetIamUserArgs struct {
	Login  *string `pulumi:"login"`
	UserId *string `pulumi:"userId"`
}

// A collection of values returned by getIamUser.
type GetIamUserResult struct {
	DefaultEmail string `pulumi:"defaultEmail"`
	// The provider-assigned unique ID for this managed resource.
	Id     string `pulumi:"id"`
	Login  string `pulumi:"login"`
	UserId string `pulumi:"userId"`
}

func GetIamUserOutput(ctx *pulumi.Context, args GetIamUserOutputArgs, opts ...pulumi.InvokeOption) GetIamUserResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetIamUserResult, error) {
			args := v.(GetIamUserArgs)
			r, err := GetIamUser(ctx, &args, opts...)
			var s GetIamUserResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetIamUserResultOutput)
}

// A collection of arguments for invoking getIamUser.
type GetIamUserOutputArgs struct {
	Login  pulumi.StringPtrInput `pulumi:"login"`
	UserId pulumi.StringPtrInput `pulumi:"userId"`
}

func (GetIamUserOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetIamUserArgs)(nil)).Elem()
}

// A collection of values returned by getIamUser.
type GetIamUserResultOutput struct{ *pulumi.OutputState }

func (GetIamUserResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetIamUserResult)(nil)).Elem()
}

func (o GetIamUserResultOutput) ToGetIamUserResultOutput() GetIamUserResultOutput {
	return o
}

func (o GetIamUserResultOutput) ToGetIamUserResultOutputWithContext(ctx context.Context) GetIamUserResultOutput {
	return o
}

func (o GetIamUserResultOutput) DefaultEmail() pulumi.StringOutput {
	return o.ApplyT(func(v GetIamUserResult) string { return v.DefaultEmail }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetIamUserResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetIamUserResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetIamUserResultOutput) Login() pulumi.StringOutput {
	return o.ApplyT(func(v GetIamUserResult) string { return v.Login }).(pulumi.StringOutput)
}

func (o GetIamUserResultOutput) UserId() pulumi.StringOutput {
	return o.ApplyT(func(v GetIamUserResult) string { return v.UserId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetIamUserResultOutput{})
}
