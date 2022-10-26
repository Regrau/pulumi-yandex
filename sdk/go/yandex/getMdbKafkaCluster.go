// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupMdbKafkaCluster(ctx *pulumi.Context, args *LookupMdbKafkaClusterArgs, opts ...pulumi.InvokeOption) (*LookupMdbKafkaClusterResult, error) {
	var rv LookupMdbKafkaClusterResult
	err := ctx.Invoke("yandex:index/getMdbKafkaCluster:getMdbKafkaCluster", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMdbKafkaCluster.
type LookupMdbKafkaClusterArgs struct {
	ClusterId          *string                   `pulumi:"clusterId"`
	Config             *GetMdbKafkaClusterConfig `pulumi:"config"`
	DeletionProtection *bool                     `pulumi:"deletionProtection"`
	FolderId           *string                   `pulumi:"folderId"`
	Name               *string                   `pulumi:"name"`
	SubnetIds          []string                  `pulumi:"subnetIds"`
	Topics             []GetMdbKafkaClusterTopic `pulumi:"topics"`
	Users              []GetMdbKafkaClusterUser  `pulumi:"users"`
}

// A collection of values returned by getMdbKafkaCluster.
type LookupMdbKafkaClusterResult struct {
	Accesses           []GetMdbKafkaClusterAccess `pulumi:"accesses"`
	ClusterId          string                     `pulumi:"clusterId"`
	Config             *GetMdbKafkaClusterConfig  `pulumi:"config"`
	CreatedAt          string                     `pulumi:"createdAt"`
	DeletionProtection bool                       `pulumi:"deletionProtection"`
	Description        string                     `pulumi:"description"`
	Environment        string                     `pulumi:"environment"`
	FolderId           string                     `pulumi:"folderId"`
	Health             string                     `pulumi:"health"`
	HostGroupIds       []string                   `pulumi:"hostGroupIds"`
	Hosts              []GetMdbKafkaClusterHost   `pulumi:"hosts"`
	// The provider-assigned unique ID for this managed resource.
	Id                 string                                `pulumi:"id"`
	Labels             map[string]string                     `pulumi:"labels"`
	MaintenanceWindows []GetMdbKafkaClusterMaintenanceWindow `pulumi:"maintenanceWindows"`
	Name               string                                `pulumi:"name"`
	NetworkId          string                                `pulumi:"networkId"`
	SecurityGroupIds   []string                              `pulumi:"securityGroupIds"`
	Status             string                                `pulumi:"status"`
	SubnetIds          []string                              `pulumi:"subnetIds"`
	Topics             []GetMdbKafkaClusterTopic             `pulumi:"topics"`
	Users              []GetMdbKafkaClusterUser              `pulumi:"users"`
}

func LookupMdbKafkaClusterOutput(ctx *pulumi.Context, args LookupMdbKafkaClusterOutputArgs, opts ...pulumi.InvokeOption) LookupMdbKafkaClusterResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupMdbKafkaClusterResult, error) {
			args := v.(LookupMdbKafkaClusterArgs)
			r, err := LookupMdbKafkaCluster(ctx, &args, opts...)
			var s LookupMdbKafkaClusterResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupMdbKafkaClusterResultOutput)
}

// A collection of arguments for invoking getMdbKafkaCluster.
type LookupMdbKafkaClusterOutputArgs struct {
	ClusterId          pulumi.StringPtrInput             `pulumi:"clusterId"`
	Config             GetMdbKafkaClusterConfigPtrInput  `pulumi:"config"`
	DeletionProtection pulumi.BoolPtrInput               `pulumi:"deletionProtection"`
	FolderId           pulumi.StringPtrInput             `pulumi:"folderId"`
	Name               pulumi.StringPtrInput             `pulumi:"name"`
	SubnetIds          pulumi.StringArrayInput           `pulumi:"subnetIds"`
	Topics             GetMdbKafkaClusterTopicArrayInput `pulumi:"topics"`
	Users              GetMdbKafkaClusterUserArrayInput  `pulumi:"users"`
}

func (LookupMdbKafkaClusterOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbKafkaClusterArgs)(nil)).Elem()
}

// A collection of values returned by getMdbKafkaCluster.
type LookupMdbKafkaClusterResultOutput struct{ *pulumi.OutputState }

func (LookupMdbKafkaClusterResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbKafkaClusterResult)(nil)).Elem()
}

func (o LookupMdbKafkaClusterResultOutput) ToLookupMdbKafkaClusterResultOutput() LookupMdbKafkaClusterResultOutput {
	return o
}

func (o LookupMdbKafkaClusterResultOutput) ToLookupMdbKafkaClusterResultOutputWithContext(ctx context.Context) LookupMdbKafkaClusterResultOutput {
	return o
}

func (o LookupMdbKafkaClusterResultOutput) Accesses() GetMdbKafkaClusterAccessArrayOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) []GetMdbKafkaClusterAccess { return v.Accesses }).(GetMdbKafkaClusterAccessArrayOutput)
}

func (o LookupMdbKafkaClusterResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaClusterResultOutput) Config() GetMdbKafkaClusterConfigPtrOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) *GetMdbKafkaClusterConfig { return v.Config }).(GetMdbKafkaClusterConfigPtrOutput)
}

func (o LookupMdbKafkaClusterResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaClusterResultOutput) DeletionProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) bool { return v.DeletionProtection }).(pulumi.BoolOutput)
}

func (o LookupMdbKafkaClusterResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaClusterResultOutput) Environment() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) string { return v.Environment }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaClusterResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) string { return v.FolderId }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaClusterResultOutput) Health() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) string { return v.Health }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaClusterResultOutput) HostGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) []string { return v.HostGroupIds }).(pulumi.StringArrayOutput)
}

func (o LookupMdbKafkaClusterResultOutput) Hosts() GetMdbKafkaClusterHostArrayOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) []GetMdbKafkaClusterHost { return v.Hosts }).(GetMdbKafkaClusterHostArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupMdbKafkaClusterResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaClusterResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupMdbKafkaClusterResultOutput) MaintenanceWindows() GetMdbKafkaClusterMaintenanceWindowArrayOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) []GetMdbKafkaClusterMaintenanceWindow { return v.MaintenanceWindows }).(GetMdbKafkaClusterMaintenanceWindowArrayOutput)
}

func (o LookupMdbKafkaClusterResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaClusterResultOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) string { return v.NetworkId }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaClusterResultOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) []string { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

func (o LookupMdbKafkaClusterResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) string { return v.Status }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaClusterResultOutput) SubnetIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) []string { return v.SubnetIds }).(pulumi.StringArrayOutput)
}

func (o LookupMdbKafkaClusterResultOutput) Topics() GetMdbKafkaClusterTopicArrayOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) []GetMdbKafkaClusterTopic { return v.Topics }).(GetMdbKafkaClusterTopicArrayOutput)
}

func (o LookupMdbKafkaClusterResultOutput) Users() GetMdbKafkaClusterUserArrayOutput {
	return o.ApplyT(func(v LookupMdbKafkaClusterResult) []GetMdbKafkaClusterUser { return v.Users }).(GetMdbKafkaClusterUserArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupMdbKafkaClusterResultOutput{})
}