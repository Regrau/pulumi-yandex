// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupDataprocCluster(ctx *pulumi.Context, args *LookupDataprocClusterArgs, opts ...pulumi.InvokeOption) (*LookupDataprocClusterResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupDataprocClusterResult
	err := ctx.Invoke("yandex:index/getDataprocCluster:getDataprocCluster", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getDataprocCluster.
type LookupDataprocClusterArgs struct {
	ClusterId *string `pulumi:"clusterId"`
	Name      *string `pulumi:"name"`
}

// A collection of values returned by getDataprocCluster.
type LookupDataprocClusterResult struct {
	Bucket             string                            `pulumi:"bucket"`
	ClusterConfigs     []GetDataprocClusterClusterConfig `pulumi:"clusterConfigs"`
	ClusterId          string                            `pulumi:"clusterId"`
	CreatedAt          string                            `pulumi:"createdAt"`
	DeletionProtection bool                              `pulumi:"deletionProtection"`
	Description        string                            `pulumi:"description"`
	FolderId           string                            `pulumi:"folderId"`
	HostGroupIds       []string                          `pulumi:"hostGroupIds"`
	// The provider-assigned unique ID for this managed resource.
	Id               string            `pulumi:"id"`
	Labels           map[string]string `pulumi:"labels"`
	Name             string            `pulumi:"name"`
	SecurityGroupIds []string          `pulumi:"securityGroupIds"`
	ServiceAccountId string            `pulumi:"serviceAccountId"`
	UiProxy          bool              `pulumi:"uiProxy"`
	ZoneId           string            `pulumi:"zoneId"`
}

func LookupDataprocClusterOutput(ctx *pulumi.Context, args LookupDataprocClusterOutputArgs, opts ...pulumi.InvokeOption) LookupDataprocClusterResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupDataprocClusterResult, error) {
			args := v.(LookupDataprocClusterArgs)
			r, err := LookupDataprocCluster(ctx, &args, opts...)
			var s LookupDataprocClusterResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupDataprocClusterResultOutput)
}

// A collection of arguments for invoking getDataprocCluster.
type LookupDataprocClusterOutputArgs struct {
	ClusterId pulumi.StringPtrInput `pulumi:"clusterId"`
	Name      pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupDataprocClusterOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupDataprocClusterArgs)(nil)).Elem()
}

// A collection of values returned by getDataprocCluster.
type LookupDataprocClusterResultOutput struct{ *pulumi.OutputState }

func (LookupDataprocClusterResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupDataprocClusterResult)(nil)).Elem()
}

func (o LookupDataprocClusterResultOutput) ToLookupDataprocClusterResultOutput() LookupDataprocClusterResultOutput {
	return o
}

func (o LookupDataprocClusterResultOutput) ToLookupDataprocClusterResultOutputWithContext(ctx context.Context) LookupDataprocClusterResultOutput {
	return o
}

func (o LookupDataprocClusterResultOutput) Bucket() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) string { return v.Bucket }).(pulumi.StringOutput)
}

func (o LookupDataprocClusterResultOutput) ClusterConfigs() GetDataprocClusterClusterConfigArrayOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) []GetDataprocClusterClusterConfig { return v.ClusterConfigs }).(GetDataprocClusterClusterConfigArrayOutput)
}

func (o LookupDataprocClusterResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

func (o LookupDataprocClusterResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupDataprocClusterResultOutput) DeletionProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) bool { return v.DeletionProtection }).(pulumi.BoolOutput)
}

func (o LookupDataprocClusterResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupDataprocClusterResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) string { return v.FolderId }).(pulumi.StringOutput)
}

func (o LookupDataprocClusterResultOutput) HostGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) []string { return v.HostGroupIds }).(pulumi.StringArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupDataprocClusterResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupDataprocClusterResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupDataprocClusterResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupDataprocClusterResultOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) []string { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

func (o LookupDataprocClusterResultOutput) ServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) string { return v.ServiceAccountId }).(pulumi.StringOutput)
}

func (o LookupDataprocClusterResultOutput) UiProxy() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) bool { return v.UiProxy }).(pulumi.BoolOutput)
}

func (o LookupDataprocClusterResultOutput) ZoneId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataprocClusterResult) string { return v.ZoneId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupDataprocClusterResultOutput{})
}
