// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupComputeGpuCluster(ctx *pulumi.Context, args *LookupComputeGpuClusterArgs, opts ...pulumi.InvokeOption) (*LookupComputeGpuClusterResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupComputeGpuClusterResult
	err := ctx.Invoke("yandex:index/getComputeGpuCluster:getComputeGpuCluster", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getComputeGpuCluster.
type LookupComputeGpuClusterArgs struct {
	FolderId     *string `pulumi:"folderId"`
	GpuClusterId *string `pulumi:"gpuClusterId"`
	Name         *string `pulumi:"name"`
}

// A collection of values returned by getComputeGpuCluster.
type LookupComputeGpuClusterResult struct {
	CreatedAt    string `pulumi:"createdAt"`
	Description  string `pulumi:"description"`
	FolderId     string `pulumi:"folderId"`
	GpuClusterId string `pulumi:"gpuClusterId"`
	// The provider-assigned unique ID for this managed resource.
	Id               string            `pulumi:"id"`
	InterconnectType string            `pulumi:"interconnectType"`
	Labels           map[string]string `pulumi:"labels"`
	Name             string            `pulumi:"name"`
	Status           string            `pulumi:"status"`
	Zone             string            `pulumi:"zone"`
}

func LookupComputeGpuClusterOutput(ctx *pulumi.Context, args LookupComputeGpuClusterOutputArgs, opts ...pulumi.InvokeOption) LookupComputeGpuClusterResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupComputeGpuClusterResult, error) {
			args := v.(LookupComputeGpuClusterArgs)
			r, err := LookupComputeGpuCluster(ctx, &args, opts...)
			var s LookupComputeGpuClusterResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupComputeGpuClusterResultOutput)
}

// A collection of arguments for invoking getComputeGpuCluster.
type LookupComputeGpuClusterOutputArgs struct {
	FolderId     pulumi.StringPtrInput `pulumi:"folderId"`
	GpuClusterId pulumi.StringPtrInput `pulumi:"gpuClusterId"`
	Name         pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupComputeGpuClusterOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputeGpuClusterArgs)(nil)).Elem()
}

// A collection of values returned by getComputeGpuCluster.
type LookupComputeGpuClusterResultOutput struct{ *pulumi.OutputState }

func (LookupComputeGpuClusterResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputeGpuClusterResult)(nil)).Elem()
}

func (o LookupComputeGpuClusterResultOutput) ToLookupComputeGpuClusterResultOutput() LookupComputeGpuClusterResultOutput {
	return o
}

func (o LookupComputeGpuClusterResultOutput) ToLookupComputeGpuClusterResultOutputWithContext(ctx context.Context) LookupComputeGpuClusterResultOutput {
	return o
}

func (o LookupComputeGpuClusterResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeGpuClusterResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupComputeGpuClusterResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeGpuClusterResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupComputeGpuClusterResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeGpuClusterResult) string { return v.FolderId }).(pulumi.StringOutput)
}

func (o LookupComputeGpuClusterResultOutput) GpuClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeGpuClusterResult) string { return v.GpuClusterId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupComputeGpuClusterResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeGpuClusterResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupComputeGpuClusterResultOutput) InterconnectType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeGpuClusterResult) string { return v.InterconnectType }).(pulumi.StringOutput)
}

func (o LookupComputeGpuClusterResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupComputeGpuClusterResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupComputeGpuClusterResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeGpuClusterResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupComputeGpuClusterResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeGpuClusterResult) string { return v.Status }).(pulumi.StringOutput)
}

func (o LookupComputeGpuClusterResultOutput) Zone() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeGpuClusterResult) string { return v.Zone }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupComputeGpuClusterResultOutput{})
}
