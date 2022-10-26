// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetResourcemanagerCloud(ctx *pulumi.Context, args *GetResourcemanagerCloudArgs, opts ...pulumi.InvokeOption) (*GetResourcemanagerCloudResult, error) {
	var rv GetResourcemanagerCloudResult
	err := ctx.Invoke("yandex:index/getResourcemanagerCloud:getResourcemanagerCloud", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getResourcemanagerCloud.
type GetResourcemanagerCloudArgs struct {
	CloudId     *string `pulumi:"cloudId"`
	Description *string `pulumi:"description"`
	Name        *string `pulumi:"name"`
}

// A collection of values returned by getResourcemanagerCloud.
type GetResourcemanagerCloudResult struct {
	CloudId     string  `pulumi:"cloudId"`
	CreatedAt   string  `pulumi:"createdAt"`
	Description *string `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id   string `pulumi:"id"`
	Name string `pulumi:"name"`
}

func GetResourcemanagerCloudOutput(ctx *pulumi.Context, args GetResourcemanagerCloudOutputArgs, opts ...pulumi.InvokeOption) GetResourcemanagerCloudResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetResourcemanagerCloudResult, error) {
			args := v.(GetResourcemanagerCloudArgs)
			r, err := GetResourcemanagerCloud(ctx, &args, opts...)
			var s GetResourcemanagerCloudResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetResourcemanagerCloudResultOutput)
}

// A collection of arguments for invoking getResourcemanagerCloud.
type GetResourcemanagerCloudOutputArgs struct {
	CloudId     pulumi.StringPtrInput `pulumi:"cloudId"`
	Description pulumi.StringPtrInput `pulumi:"description"`
	Name        pulumi.StringPtrInput `pulumi:"name"`
}

func (GetResourcemanagerCloudOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetResourcemanagerCloudArgs)(nil)).Elem()
}

// A collection of values returned by getResourcemanagerCloud.
type GetResourcemanagerCloudResultOutput struct{ *pulumi.OutputState }

func (GetResourcemanagerCloudResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetResourcemanagerCloudResult)(nil)).Elem()
}

func (o GetResourcemanagerCloudResultOutput) ToGetResourcemanagerCloudResultOutput() GetResourcemanagerCloudResultOutput {
	return o
}

func (o GetResourcemanagerCloudResultOutput) ToGetResourcemanagerCloudResultOutputWithContext(ctx context.Context) GetResourcemanagerCloudResultOutput {
	return o
}

func (o GetResourcemanagerCloudResultOutput) CloudId() pulumi.StringOutput {
	return o.ApplyT(func(v GetResourcemanagerCloudResult) string { return v.CloudId }).(pulumi.StringOutput)
}

func (o GetResourcemanagerCloudResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v GetResourcemanagerCloudResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o GetResourcemanagerCloudResultOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetResourcemanagerCloudResult) *string { return v.Description }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetResourcemanagerCloudResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetResourcemanagerCloudResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetResourcemanagerCloudResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetResourcemanagerCloudResult) string { return v.Name }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetResourcemanagerCloudResultOutput{})
}
