// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about a Yandex IAM service account. For more information about accounts, see
// [Yandex.Cloud IAM accounts](https://cloud.yandex.com/docs/iam/concepts/#accounts).
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
//			_, err = yandex.LookupIamServiceAccount(ctx, &GetIamServiceAccountArgs{
//				ServiceAccountId: pulumi.StringRef("sa_id"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = yandex.LookupIamServiceAccount(ctx, &GetIamServiceAccountArgs{
//				Name: pulumi.StringRef("sa_name"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupIamServiceAccount(ctx *pulumi.Context, args *LookupIamServiceAccountArgs, opts ...pulumi.InvokeOption) (*LookupIamServiceAccountResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupIamServiceAccountResult
	err := ctx.Invoke("yandex:index/getIamServiceAccount:getIamServiceAccount", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getIamServiceAccount.
type LookupIamServiceAccountArgs struct {
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// Name of a specific service account.
	Name *string `pulumi:"name"`
	// ID of a specific service account.
	ServiceAccountId *string `pulumi:"serviceAccountId"`
}

// A collection of values returned by getIamServiceAccount.
type LookupIamServiceAccountResult struct {
	CreatedAt string `pulumi:"createdAt"`
	// Description of the service account.
	Description string `pulumi:"description"`
	FolderId    string `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id               string `pulumi:"id"`
	Name             string `pulumi:"name"`
	ServiceAccountId string `pulumi:"serviceAccountId"`
}

func LookupIamServiceAccountOutput(ctx *pulumi.Context, args LookupIamServiceAccountOutputArgs, opts ...pulumi.InvokeOption) LookupIamServiceAccountResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupIamServiceAccountResult, error) {
			args := v.(LookupIamServiceAccountArgs)
			r, err := LookupIamServiceAccount(ctx, &args, opts...)
			var s LookupIamServiceAccountResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupIamServiceAccountResultOutput)
}

// A collection of arguments for invoking getIamServiceAccount.
type LookupIamServiceAccountOutputArgs struct {
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId pulumi.StringPtrInput `pulumi:"folderId"`
	// Name of a specific service account.
	Name pulumi.StringPtrInput `pulumi:"name"`
	// ID of a specific service account.
	ServiceAccountId pulumi.StringPtrInput `pulumi:"serviceAccountId"`
}

func (LookupIamServiceAccountOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIamServiceAccountArgs)(nil)).Elem()
}

// A collection of values returned by getIamServiceAccount.
type LookupIamServiceAccountResultOutput struct{ *pulumi.OutputState }

func (LookupIamServiceAccountResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIamServiceAccountResult)(nil)).Elem()
}

func (o LookupIamServiceAccountResultOutput) ToLookupIamServiceAccountResultOutput() LookupIamServiceAccountResultOutput {
	return o
}

func (o LookupIamServiceAccountResultOutput) ToLookupIamServiceAccountResultOutputWithContext(ctx context.Context) LookupIamServiceAccountResultOutput {
	return o
}

func (o LookupIamServiceAccountResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIamServiceAccountResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

// Description of the service account.
func (o LookupIamServiceAccountResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIamServiceAccountResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupIamServiceAccountResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIamServiceAccountResult) string { return v.FolderId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupIamServiceAccountResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIamServiceAccountResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupIamServiceAccountResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIamServiceAccountResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupIamServiceAccountResultOutput) ServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIamServiceAccountResult) string { return v.ServiceAccountId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupIamServiceAccountResultOutput{})
}
