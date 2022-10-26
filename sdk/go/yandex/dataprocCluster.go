// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type DataprocCluster struct {
	pulumi.CustomResourceState

	Bucket             pulumi.StringPtrOutput             `pulumi:"bucket"`
	ClusterConfig      DataprocClusterClusterConfigOutput `pulumi:"clusterConfig"`
	CreatedAt          pulumi.StringOutput                `pulumi:"createdAt"`
	DeletionProtection pulumi.BoolOutput                  `pulumi:"deletionProtection"`
	Description        pulumi.StringPtrOutput             `pulumi:"description"`
	FolderId           pulumi.StringOutput                `pulumi:"folderId"`
	HostGroupIds       pulumi.StringArrayOutput           `pulumi:"hostGroupIds"`
	Labels             pulumi.StringMapOutput             `pulumi:"labels"`
	Name               pulumi.StringOutput                `pulumi:"name"`
	SecurityGroupIds   pulumi.StringArrayOutput           `pulumi:"securityGroupIds"`
	ServiceAccountId   pulumi.StringOutput                `pulumi:"serviceAccountId"`
	UiProxy            pulumi.BoolPtrOutput               `pulumi:"uiProxy"`
	ZoneId             pulumi.StringOutput                `pulumi:"zoneId"`
}

// NewDataprocCluster registers a new resource with the given unique name, arguments, and options.
func NewDataprocCluster(ctx *pulumi.Context,
	name string, args *DataprocClusterArgs, opts ...pulumi.ResourceOption) (*DataprocCluster, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClusterConfig == nil {
		return nil, errors.New("invalid value for required argument 'ClusterConfig'")
	}
	if args.ServiceAccountId == nil {
		return nil, errors.New("invalid value for required argument 'ServiceAccountId'")
	}
	var resource DataprocCluster
	err := ctx.RegisterResource("yandex:index/dataprocCluster:DataprocCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDataprocCluster gets an existing DataprocCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDataprocCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DataprocClusterState, opts ...pulumi.ResourceOption) (*DataprocCluster, error) {
	var resource DataprocCluster
	err := ctx.ReadResource("yandex:index/dataprocCluster:DataprocCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DataprocCluster resources.
type dataprocClusterState struct {
	Bucket             *string                       `pulumi:"bucket"`
	ClusterConfig      *DataprocClusterClusterConfig `pulumi:"clusterConfig"`
	CreatedAt          *string                       `pulumi:"createdAt"`
	DeletionProtection *bool                         `pulumi:"deletionProtection"`
	Description        *string                       `pulumi:"description"`
	FolderId           *string                       `pulumi:"folderId"`
	HostGroupIds       []string                      `pulumi:"hostGroupIds"`
	Labels             map[string]string             `pulumi:"labels"`
	Name               *string                       `pulumi:"name"`
	SecurityGroupIds   []string                      `pulumi:"securityGroupIds"`
	ServiceAccountId   *string                       `pulumi:"serviceAccountId"`
	UiProxy            *bool                         `pulumi:"uiProxy"`
	ZoneId             *string                       `pulumi:"zoneId"`
}

type DataprocClusterState struct {
	Bucket             pulumi.StringPtrInput
	ClusterConfig      DataprocClusterClusterConfigPtrInput
	CreatedAt          pulumi.StringPtrInput
	DeletionProtection pulumi.BoolPtrInput
	Description        pulumi.StringPtrInput
	FolderId           pulumi.StringPtrInput
	HostGroupIds       pulumi.StringArrayInput
	Labels             pulumi.StringMapInput
	Name               pulumi.StringPtrInput
	SecurityGroupIds   pulumi.StringArrayInput
	ServiceAccountId   pulumi.StringPtrInput
	UiProxy            pulumi.BoolPtrInput
	ZoneId             pulumi.StringPtrInput
}

func (DataprocClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*dataprocClusterState)(nil)).Elem()
}

type dataprocClusterArgs struct {
	Bucket             *string                      `pulumi:"bucket"`
	ClusterConfig      DataprocClusterClusterConfig `pulumi:"clusterConfig"`
	DeletionProtection *bool                        `pulumi:"deletionProtection"`
	Description        *string                      `pulumi:"description"`
	FolderId           *string                      `pulumi:"folderId"`
	HostGroupIds       []string                     `pulumi:"hostGroupIds"`
	Labels             map[string]string            `pulumi:"labels"`
	Name               *string                      `pulumi:"name"`
	SecurityGroupIds   []string                     `pulumi:"securityGroupIds"`
	ServiceAccountId   string                       `pulumi:"serviceAccountId"`
	UiProxy            *bool                        `pulumi:"uiProxy"`
	ZoneId             *string                      `pulumi:"zoneId"`
}

// The set of arguments for constructing a DataprocCluster resource.
type DataprocClusterArgs struct {
	Bucket             pulumi.StringPtrInput
	ClusterConfig      DataprocClusterClusterConfigInput
	DeletionProtection pulumi.BoolPtrInput
	Description        pulumi.StringPtrInput
	FolderId           pulumi.StringPtrInput
	HostGroupIds       pulumi.StringArrayInput
	Labels             pulumi.StringMapInput
	Name               pulumi.StringPtrInput
	SecurityGroupIds   pulumi.StringArrayInput
	ServiceAccountId   pulumi.StringInput
	UiProxy            pulumi.BoolPtrInput
	ZoneId             pulumi.StringPtrInput
}

func (DataprocClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dataprocClusterArgs)(nil)).Elem()
}

type DataprocClusterInput interface {
	pulumi.Input

	ToDataprocClusterOutput() DataprocClusterOutput
	ToDataprocClusterOutputWithContext(ctx context.Context) DataprocClusterOutput
}

func (*DataprocCluster) ElementType() reflect.Type {
	return reflect.TypeOf((**DataprocCluster)(nil)).Elem()
}

func (i *DataprocCluster) ToDataprocClusterOutput() DataprocClusterOutput {
	return i.ToDataprocClusterOutputWithContext(context.Background())
}

func (i *DataprocCluster) ToDataprocClusterOutputWithContext(ctx context.Context) DataprocClusterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DataprocClusterOutput)
}

// DataprocClusterArrayInput is an input type that accepts DataprocClusterArray and DataprocClusterArrayOutput values.
// You can construct a concrete instance of `DataprocClusterArrayInput` via:
//
//	DataprocClusterArray{ DataprocClusterArgs{...} }
type DataprocClusterArrayInput interface {
	pulumi.Input

	ToDataprocClusterArrayOutput() DataprocClusterArrayOutput
	ToDataprocClusterArrayOutputWithContext(context.Context) DataprocClusterArrayOutput
}

type DataprocClusterArray []DataprocClusterInput

func (DataprocClusterArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DataprocCluster)(nil)).Elem()
}

func (i DataprocClusterArray) ToDataprocClusterArrayOutput() DataprocClusterArrayOutput {
	return i.ToDataprocClusterArrayOutputWithContext(context.Background())
}

func (i DataprocClusterArray) ToDataprocClusterArrayOutputWithContext(ctx context.Context) DataprocClusterArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DataprocClusterArrayOutput)
}

// DataprocClusterMapInput is an input type that accepts DataprocClusterMap and DataprocClusterMapOutput values.
// You can construct a concrete instance of `DataprocClusterMapInput` via:
//
//	DataprocClusterMap{ "key": DataprocClusterArgs{...} }
type DataprocClusterMapInput interface {
	pulumi.Input

	ToDataprocClusterMapOutput() DataprocClusterMapOutput
	ToDataprocClusterMapOutputWithContext(context.Context) DataprocClusterMapOutput
}

type DataprocClusterMap map[string]DataprocClusterInput

func (DataprocClusterMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DataprocCluster)(nil)).Elem()
}

func (i DataprocClusterMap) ToDataprocClusterMapOutput() DataprocClusterMapOutput {
	return i.ToDataprocClusterMapOutputWithContext(context.Background())
}

func (i DataprocClusterMap) ToDataprocClusterMapOutputWithContext(ctx context.Context) DataprocClusterMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DataprocClusterMapOutput)
}

type DataprocClusterOutput struct{ *pulumi.OutputState }

func (DataprocClusterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DataprocCluster)(nil)).Elem()
}

func (o DataprocClusterOutput) ToDataprocClusterOutput() DataprocClusterOutput {
	return o
}

func (o DataprocClusterOutput) ToDataprocClusterOutputWithContext(ctx context.Context) DataprocClusterOutput {
	return o
}

func (o DataprocClusterOutput) Bucket() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringPtrOutput { return v.Bucket }).(pulumi.StringPtrOutput)
}

func (o DataprocClusterOutput) ClusterConfig() DataprocClusterClusterConfigOutput {
	return o.ApplyT(func(v *DataprocCluster) DataprocClusterClusterConfigOutput { return v.ClusterConfig }).(DataprocClusterClusterConfigOutput)
}

func (o DataprocClusterOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o DataprocClusterOutput) DeletionProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.BoolOutput { return v.DeletionProtection }).(pulumi.BoolOutput)
}

func (o DataprocClusterOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

func (o DataprocClusterOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

func (o DataprocClusterOutput) HostGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringArrayOutput { return v.HostGroupIds }).(pulumi.StringArrayOutput)
}

func (o DataprocClusterOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o DataprocClusterOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o DataprocClusterOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringArrayOutput { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

func (o DataprocClusterOutput) ServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringOutput { return v.ServiceAccountId }).(pulumi.StringOutput)
}

func (o DataprocClusterOutput) UiProxy() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.BoolPtrOutput { return v.UiProxy }).(pulumi.BoolPtrOutput)
}

func (o DataprocClusterOutput) ZoneId() pulumi.StringOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringOutput { return v.ZoneId }).(pulumi.StringOutput)
}

type DataprocClusterArrayOutput struct{ *pulumi.OutputState }

func (DataprocClusterArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DataprocCluster)(nil)).Elem()
}

func (o DataprocClusterArrayOutput) ToDataprocClusterArrayOutput() DataprocClusterArrayOutput {
	return o
}

func (o DataprocClusterArrayOutput) ToDataprocClusterArrayOutputWithContext(ctx context.Context) DataprocClusterArrayOutput {
	return o
}

func (o DataprocClusterArrayOutput) Index(i pulumi.IntInput) DataprocClusterOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DataprocCluster {
		return vs[0].([]*DataprocCluster)[vs[1].(int)]
	}).(DataprocClusterOutput)
}

type DataprocClusterMapOutput struct{ *pulumi.OutputState }

func (DataprocClusterMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DataprocCluster)(nil)).Elem()
}

func (o DataprocClusterMapOutput) ToDataprocClusterMapOutput() DataprocClusterMapOutput {
	return o
}

func (o DataprocClusterMapOutput) ToDataprocClusterMapOutputWithContext(ctx context.Context) DataprocClusterMapOutput {
	return o
}

func (o DataprocClusterMapOutput) MapIndex(k pulumi.StringInput) DataprocClusterOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DataprocCluster {
		return vs[0].(map[string]*DataprocCluster)[vs[1].(string)]
	}).(DataprocClusterOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DataprocClusterInput)(nil)).Elem(), &DataprocCluster{})
	pulumi.RegisterInputType(reflect.TypeOf((*DataprocClusterArrayInput)(nil)).Elem(), DataprocClusterArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DataprocClusterMapInput)(nil)).Elem(), DataprocClusterMap{})
	pulumi.RegisterOutputType(DataprocClusterOutput{})
	pulumi.RegisterOutputType(DataprocClusterArrayOutput{})
	pulumi.RegisterOutputType(DataprocClusterMapOutput{})
}
