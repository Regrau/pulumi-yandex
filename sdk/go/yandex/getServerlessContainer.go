// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupServerlessContainer(ctx *pulumi.Context, args *LookupServerlessContainerArgs, opts ...pulumi.InvokeOption) (*LookupServerlessContainerResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupServerlessContainerResult
	err := ctx.Invoke("yandex:index/getServerlessContainer:getServerlessContainer", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getServerlessContainer.
type LookupServerlessContainerArgs struct {
	ContainerId *string                        `pulumi:"containerId"`
	FolderId    *string                        `pulumi:"folderId"`
	Name        *string                        `pulumi:"name"`
	Secrets     []GetServerlessContainerSecret `pulumi:"secrets"`
}

// A collection of values returned by getServerlessContainer.
type LookupServerlessContainerResult struct {
	Concurrency      int     `pulumi:"concurrency"`
	ContainerId      *string `pulumi:"containerId"`
	CoreFraction     int     `pulumi:"coreFraction"`
	Cores            int     `pulumi:"cores"`
	CreatedAt        string  `pulumi:"createdAt"`
	Description      string  `pulumi:"description"`
	ExecutionTimeout string  `pulumi:"executionTimeout"`
	FolderId         *string `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                         `pulumi:"id"`
	Images           []GetServerlessContainerImage  `pulumi:"images"`
	Labels           map[string]string              `pulumi:"labels"`
	Memory           int                            `pulumi:"memory"`
	Name             *string                        `pulumi:"name"`
	RevisionId       string                         `pulumi:"revisionId"`
	Secrets          []GetServerlessContainerSecret `pulumi:"secrets"`
	ServiceAccountId string                         `pulumi:"serviceAccountId"`
	Url              string                         `pulumi:"url"`
}

func LookupServerlessContainerOutput(ctx *pulumi.Context, args LookupServerlessContainerOutputArgs, opts ...pulumi.InvokeOption) LookupServerlessContainerResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupServerlessContainerResult, error) {
			args := v.(LookupServerlessContainerArgs)
			r, err := LookupServerlessContainer(ctx, &args, opts...)
			var s LookupServerlessContainerResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupServerlessContainerResultOutput)
}

// A collection of arguments for invoking getServerlessContainer.
type LookupServerlessContainerOutputArgs struct {
	ContainerId pulumi.StringPtrInput                  `pulumi:"containerId"`
	FolderId    pulumi.StringPtrInput                  `pulumi:"folderId"`
	Name        pulumi.StringPtrInput                  `pulumi:"name"`
	Secrets     GetServerlessContainerSecretArrayInput `pulumi:"secrets"`
}

func (LookupServerlessContainerOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupServerlessContainerArgs)(nil)).Elem()
}

// A collection of values returned by getServerlessContainer.
type LookupServerlessContainerResultOutput struct{ *pulumi.OutputState }

func (LookupServerlessContainerResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupServerlessContainerResult)(nil)).Elem()
}

func (o LookupServerlessContainerResultOutput) ToLookupServerlessContainerResultOutput() LookupServerlessContainerResultOutput {
	return o
}

func (o LookupServerlessContainerResultOutput) ToLookupServerlessContainerResultOutputWithContext(ctx context.Context) LookupServerlessContainerResultOutput {
	return o
}

func (o LookupServerlessContainerResultOutput) Concurrency() pulumi.IntOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) int { return v.Concurrency }).(pulumi.IntOutput)
}

func (o LookupServerlessContainerResultOutput) ContainerId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) *string { return v.ContainerId }).(pulumi.StringPtrOutput)
}

func (o LookupServerlessContainerResultOutput) CoreFraction() pulumi.IntOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) int { return v.CoreFraction }).(pulumi.IntOutput)
}

func (o LookupServerlessContainerResultOutput) Cores() pulumi.IntOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) int { return v.Cores }).(pulumi.IntOutput)
}

func (o LookupServerlessContainerResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupServerlessContainerResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupServerlessContainerResultOutput) ExecutionTimeout() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) string { return v.ExecutionTimeout }).(pulumi.StringOutput)
}

func (o LookupServerlessContainerResultOutput) FolderId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) *string { return v.FolderId }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupServerlessContainerResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupServerlessContainerResultOutput) Images() GetServerlessContainerImageArrayOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) []GetServerlessContainerImage { return v.Images }).(GetServerlessContainerImageArrayOutput)
}

func (o LookupServerlessContainerResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupServerlessContainerResultOutput) Memory() pulumi.IntOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) int { return v.Memory }).(pulumi.IntOutput)
}

func (o LookupServerlessContainerResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o LookupServerlessContainerResultOutput) RevisionId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) string { return v.RevisionId }).(pulumi.StringOutput)
}

func (o LookupServerlessContainerResultOutput) Secrets() GetServerlessContainerSecretArrayOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) []GetServerlessContainerSecret { return v.Secrets }).(GetServerlessContainerSecretArrayOutput)
}

func (o LookupServerlessContainerResultOutput) ServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) string { return v.ServiceAccountId }).(pulumi.StringOutput)
}

func (o LookupServerlessContainerResultOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServerlessContainerResult) string { return v.Url }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupServerlessContainerResultOutput{})
}
