// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetMdbPostgresqlCluster(ctx *pulumi.Context, args *GetMdbPostgresqlClusterArgs, opts ...pulumi.InvokeOption) (*GetMdbPostgresqlClusterResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetMdbPostgresqlClusterResult
	err := ctx.Invoke("yandex:index/getMdbPostgresqlCluster:getMdbPostgresqlCluster", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMdbPostgresqlCluster.
type GetMdbPostgresqlClusterArgs struct {
	ClusterId          *string `pulumi:"clusterId"`
	DeletionProtection *bool   `pulumi:"deletionProtection"`
	Description        *string `pulumi:"description"`
	FolderId           *string `pulumi:"folderId"`
	Name               *string `pulumi:"name"`
}

// A collection of values returned by getMdbPostgresqlCluster.
type GetMdbPostgresqlClusterResult struct {
	ClusterId          string                          `pulumi:"clusterId"`
	Configs            []GetMdbPostgresqlClusterConfig `pulumi:"configs"`
	CreatedAt          string                          `pulumi:"createdAt"`
	DeletionProtection bool                            `pulumi:"deletionProtection"`
	Description        *string                         `pulumi:"description"`
	Environment        string                          `pulumi:"environment"`
	FolderId           string                          `pulumi:"folderId"`
	Health             string                          `pulumi:"health"`
	HostGroupIds       []string                        `pulumi:"hostGroupIds"`
	Hosts              []GetMdbPostgresqlClusterHost   `pulumi:"hosts"`
	// The provider-assigned unique ID for this managed resource.
	Id                 string                                     `pulumi:"id"`
	Labels             map[string]string                          `pulumi:"labels"`
	MaintenanceWindows []GetMdbPostgresqlClusterMaintenanceWindow `pulumi:"maintenanceWindows"`
	Name               string                                     `pulumi:"name"`
	NetworkId          string                                     `pulumi:"networkId"`
	SecurityGroupIds   []string                                   `pulumi:"securityGroupIds"`
	Status             string                                     `pulumi:"status"`
}

func GetMdbPostgresqlClusterOutput(ctx *pulumi.Context, args GetMdbPostgresqlClusterOutputArgs, opts ...pulumi.InvokeOption) GetMdbPostgresqlClusterResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetMdbPostgresqlClusterResult, error) {
			args := v.(GetMdbPostgresqlClusterArgs)
			r, err := GetMdbPostgresqlCluster(ctx, &args, opts...)
			var s GetMdbPostgresqlClusterResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetMdbPostgresqlClusterResultOutput)
}

// A collection of arguments for invoking getMdbPostgresqlCluster.
type GetMdbPostgresqlClusterOutputArgs struct {
	ClusterId          pulumi.StringPtrInput `pulumi:"clusterId"`
	DeletionProtection pulumi.BoolPtrInput   `pulumi:"deletionProtection"`
	Description        pulumi.StringPtrInput `pulumi:"description"`
	FolderId           pulumi.StringPtrInput `pulumi:"folderId"`
	Name               pulumi.StringPtrInput `pulumi:"name"`
}

func (GetMdbPostgresqlClusterOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetMdbPostgresqlClusterArgs)(nil)).Elem()
}

// A collection of values returned by getMdbPostgresqlCluster.
type GetMdbPostgresqlClusterResultOutput struct{ *pulumi.OutputState }

func (GetMdbPostgresqlClusterResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetMdbPostgresqlClusterResult)(nil)).Elem()
}

func (o GetMdbPostgresqlClusterResultOutput) ToGetMdbPostgresqlClusterResultOutput() GetMdbPostgresqlClusterResultOutput {
	return o
}

func (o GetMdbPostgresqlClusterResultOutput) ToGetMdbPostgresqlClusterResultOutputWithContext(ctx context.Context) GetMdbPostgresqlClusterResultOutput {
	return o
}

func (o GetMdbPostgresqlClusterResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) Configs() GetMdbPostgresqlClusterConfigArrayOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) []GetMdbPostgresqlClusterConfig { return v.Configs }).(GetMdbPostgresqlClusterConfigArrayOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) DeletionProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) bool { return v.DeletionProtection }).(pulumi.BoolOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) Environment() pulumi.StringOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) string { return v.Environment }).(pulumi.StringOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) string { return v.FolderId }).(pulumi.StringOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) Health() pulumi.StringOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) string { return v.Health }).(pulumi.StringOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) HostGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) []string { return v.HostGroupIds }).(pulumi.StringArrayOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) Hosts() GetMdbPostgresqlClusterHostArrayOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) []GetMdbPostgresqlClusterHost { return v.Hosts }).(GetMdbPostgresqlClusterHostArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetMdbPostgresqlClusterResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) MaintenanceWindows() GetMdbPostgresqlClusterMaintenanceWindowArrayOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) []GetMdbPostgresqlClusterMaintenanceWindow {
		return v.MaintenanceWindows
	}).(GetMdbPostgresqlClusterMaintenanceWindowArrayOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) string { return v.NetworkId }).(pulumi.StringOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) []string { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

func (o GetMdbPostgresqlClusterResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v GetMdbPostgresqlClusterResult) string { return v.Status }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetMdbPostgresqlClusterResultOutput{})
}
