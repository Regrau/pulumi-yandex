// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupMdbRedisCluster(ctx *pulumi.Context, args *LookupMdbRedisClusterArgs, opts ...pulumi.InvokeOption) (*LookupMdbRedisClusterResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupMdbRedisClusterResult
	err := ctx.Invoke("yandex:index/getMdbRedisCluster:getMdbRedisCluster", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMdbRedisCluster.
type LookupMdbRedisClusterArgs struct {
	ClusterId          *string `pulumi:"clusterId"`
	DeletionProtection *bool   `pulumi:"deletionProtection"`
	FolderId           *string `pulumi:"folderId"`
	Name               *string `pulumi:"name"`
}

// A collection of values returned by getMdbRedisCluster.
type LookupMdbRedisClusterResult struct {
	ClusterId          string                     `pulumi:"clusterId"`
	Configs            []GetMdbRedisClusterConfig `pulumi:"configs"`
	CreatedAt          string                     `pulumi:"createdAt"`
	DeletionProtection bool                       `pulumi:"deletionProtection"`
	Description        string                     `pulumi:"description"`
	Environment        string                     `pulumi:"environment"`
	FolderId           string                     `pulumi:"folderId"`
	Health             string                     `pulumi:"health"`
	Hosts              []GetMdbRedisClusterHost   `pulumi:"hosts"`
	// The provider-assigned unique ID for this managed resource.
	Id                 string                                `pulumi:"id"`
	Labels             map[string]string                     `pulumi:"labels"`
	MaintenanceWindows []GetMdbRedisClusterMaintenanceWindow `pulumi:"maintenanceWindows"`
	Name               string                                `pulumi:"name"`
	NetworkId          string                                `pulumi:"networkId"`
	PersistenceMode    string                                `pulumi:"persistenceMode"`
	Resources          []GetMdbRedisClusterResource          `pulumi:"resources"`
	SecurityGroupIds   []string                              `pulumi:"securityGroupIds"`
	Sharded            bool                                  `pulumi:"sharded"`
	Status             string                                `pulumi:"status"`
	TlsEnabled         bool                                  `pulumi:"tlsEnabled"`
}

func LookupMdbRedisClusterOutput(ctx *pulumi.Context, args LookupMdbRedisClusterOutputArgs, opts ...pulumi.InvokeOption) LookupMdbRedisClusterResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupMdbRedisClusterResult, error) {
			args := v.(LookupMdbRedisClusterArgs)
			r, err := LookupMdbRedisCluster(ctx, &args, opts...)
			var s LookupMdbRedisClusterResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupMdbRedisClusterResultOutput)
}

// A collection of arguments for invoking getMdbRedisCluster.
type LookupMdbRedisClusterOutputArgs struct {
	ClusterId          pulumi.StringPtrInput `pulumi:"clusterId"`
	DeletionProtection pulumi.BoolPtrInput   `pulumi:"deletionProtection"`
	FolderId           pulumi.StringPtrInput `pulumi:"folderId"`
	Name               pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupMdbRedisClusterOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbRedisClusterArgs)(nil)).Elem()
}

// A collection of values returned by getMdbRedisCluster.
type LookupMdbRedisClusterResultOutput struct{ *pulumi.OutputState }

func (LookupMdbRedisClusterResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbRedisClusterResult)(nil)).Elem()
}

func (o LookupMdbRedisClusterResultOutput) ToLookupMdbRedisClusterResultOutput() LookupMdbRedisClusterResultOutput {
	return o
}

func (o LookupMdbRedisClusterResultOutput) ToLookupMdbRedisClusterResultOutputWithContext(ctx context.Context) LookupMdbRedisClusterResultOutput {
	return o
}

func (o LookupMdbRedisClusterResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

func (o LookupMdbRedisClusterResultOutput) Configs() GetMdbRedisClusterConfigArrayOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) []GetMdbRedisClusterConfig { return v.Configs }).(GetMdbRedisClusterConfigArrayOutput)
}

func (o LookupMdbRedisClusterResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupMdbRedisClusterResultOutput) DeletionProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) bool { return v.DeletionProtection }).(pulumi.BoolOutput)
}

func (o LookupMdbRedisClusterResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupMdbRedisClusterResultOutput) Environment() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) string { return v.Environment }).(pulumi.StringOutput)
}

func (o LookupMdbRedisClusterResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) string { return v.FolderId }).(pulumi.StringOutput)
}

func (o LookupMdbRedisClusterResultOutput) Health() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) string { return v.Health }).(pulumi.StringOutput)
}

func (o LookupMdbRedisClusterResultOutput) Hosts() GetMdbRedisClusterHostArrayOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) []GetMdbRedisClusterHost { return v.Hosts }).(GetMdbRedisClusterHostArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupMdbRedisClusterResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupMdbRedisClusterResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupMdbRedisClusterResultOutput) MaintenanceWindows() GetMdbRedisClusterMaintenanceWindowArrayOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) []GetMdbRedisClusterMaintenanceWindow { return v.MaintenanceWindows }).(GetMdbRedisClusterMaintenanceWindowArrayOutput)
}

func (o LookupMdbRedisClusterResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupMdbRedisClusterResultOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) string { return v.NetworkId }).(pulumi.StringOutput)
}

func (o LookupMdbRedisClusterResultOutput) PersistenceMode() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) string { return v.PersistenceMode }).(pulumi.StringOutput)
}

func (o LookupMdbRedisClusterResultOutput) Resources() GetMdbRedisClusterResourceArrayOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) []GetMdbRedisClusterResource { return v.Resources }).(GetMdbRedisClusterResourceArrayOutput)
}

func (o LookupMdbRedisClusterResultOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) []string { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

func (o LookupMdbRedisClusterResultOutput) Sharded() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) bool { return v.Sharded }).(pulumi.BoolOutput)
}

func (o LookupMdbRedisClusterResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) string { return v.Status }).(pulumi.StringOutput)
}

func (o LookupMdbRedisClusterResultOutput) TlsEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupMdbRedisClusterResult) bool { return v.TlsEnabled }).(pulumi.BoolOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupMdbRedisClusterResultOutput{})
}
