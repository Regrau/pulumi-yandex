// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type MdbPostgresqlCluster struct {
	pulumi.CustomResourceState

	Config    MdbPostgresqlClusterConfigOutput `pulumi:"config"`
	CreatedAt pulumi.StringOutput              `pulumi:"createdAt"`
	// Deprecated: to manage databases, please switch to using a separate resource type yandex_mdb_postgresql_database
	Databases          MdbPostgresqlClusterDatabaseArrayOutput     `pulumi:"databases"`
	DeletionProtection pulumi.BoolOutput                           `pulumi:"deletionProtection"`
	Description        pulumi.StringPtrOutput                      `pulumi:"description"`
	Environment        pulumi.StringOutput                         `pulumi:"environment"`
	FolderId           pulumi.StringOutput                         `pulumi:"folderId"`
	Health             pulumi.StringOutput                         `pulumi:"health"`
	HostGroupIds       pulumi.StringArrayOutput                    `pulumi:"hostGroupIds"`
	HostMasterName     pulumi.StringOutput                         `pulumi:"hostMasterName"`
	Hosts              MdbPostgresqlClusterHostArrayOutput         `pulumi:"hosts"`
	Labels             pulumi.StringMapOutput                      `pulumi:"labels"`
	MaintenanceWindow  MdbPostgresqlClusterMaintenanceWindowOutput `pulumi:"maintenanceWindow"`
	Name               pulumi.StringOutput                         `pulumi:"name"`
	NetworkId          pulumi.StringOutput                         `pulumi:"networkId"`
	Restore            MdbPostgresqlClusterRestorePtrOutput        `pulumi:"restore"`
	SecurityGroupIds   pulumi.StringArrayOutput                    `pulumi:"securityGroupIds"`
	Status             pulumi.StringOutput                         `pulumi:"status"`
	// Deprecated: to manage users, please switch to using a separate resource type yandex_mdb_postgresql_user
	Users MdbPostgresqlClusterUserArrayOutput `pulumi:"users"`
}

// NewMdbPostgresqlCluster registers a new resource with the given unique name, arguments, and options.
func NewMdbPostgresqlCluster(ctx *pulumi.Context,
	name string, args *MdbPostgresqlClusterArgs, opts ...pulumi.ResourceOption) (*MdbPostgresqlCluster, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Config == nil {
		return nil, errors.New("invalid value for required argument 'Config'")
	}
	if args.Environment == nil {
		return nil, errors.New("invalid value for required argument 'Environment'")
	}
	if args.Hosts == nil {
		return nil, errors.New("invalid value for required argument 'Hosts'")
	}
	if args.NetworkId == nil {
		return nil, errors.New("invalid value for required argument 'NetworkId'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource MdbPostgresqlCluster
	err := ctx.RegisterResource("yandex:index/mdbPostgresqlCluster:MdbPostgresqlCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMdbPostgresqlCluster gets an existing MdbPostgresqlCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMdbPostgresqlCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MdbPostgresqlClusterState, opts ...pulumi.ResourceOption) (*MdbPostgresqlCluster, error) {
	var resource MdbPostgresqlCluster
	err := ctx.ReadResource("yandex:index/mdbPostgresqlCluster:MdbPostgresqlCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MdbPostgresqlCluster resources.
type mdbPostgresqlClusterState struct {
	Config    *MdbPostgresqlClusterConfig `pulumi:"config"`
	CreatedAt *string                     `pulumi:"createdAt"`
	// Deprecated: to manage databases, please switch to using a separate resource type yandex_mdb_postgresql_database
	Databases          []MdbPostgresqlClusterDatabase         `pulumi:"databases"`
	DeletionProtection *bool                                  `pulumi:"deletionProtection"`
	Description        *string                                `pulumi:"description"`
	Environment        *string                                `pulumi:"environment"`
	FolderId           *string                                `pulumi:"folderId"`
	Health             *string                                `pulumi:"health"`
	HostGroupIds       []string                               `pulumi:"hostGroupIds"`
	HostMasterName     *string                                `pulumi:"hostMasterName"`
	Hosts              []MdbPostgresqlClusterHost             `pulumi:"hosts"`
	Labels             map[string]string                      `pulumi:"labels"`
	MaintenanceWindow  *MdbPostgresqlClusterMaintenanceWindow `pulumi:"maintenanceWindow"`
	Name               *string                                `pulumi:"name"`
	NetworkId          *string                                `pulumi:"networkId"`
	Restore            *MdbPostgresqlClusterRestore           `pulumi:"restore"`
	SecurityGroupIds   []string                               `pulumi:"securityGroupIds"`
	Status             *string                                `pulumi:"status"`
	// Deprecated: to manage users, please switch to using a separate resource type yandex_mdb_postgresql_user
	Users []MdbPostgresqlClusterUser `pulumi:"users"`
}

type MdbPostgresqlClusterState struct {
	Config    MdbPostgresqlClusterConfigPtrInput
	CreatedAt pulumi.StringPtrInput
	// Deprecated: to manage databases, please switch to using a separate resource type yandex_mdb_postgresql_database
	Databases          MdbPostgresqlClusterDatabaseArrayInput
	DeletionProtection pulumi.BoolPtrInput
	Description        pulumi.StringPtrInput
	Environment        pulumi.StringPtrInput
	FolderId           pulumi.StringPtrInput
	Health             pulumi.StringPtrInput
	HostGroupIds       pulumi.StringArrayInput
	HostMasterName     pulumi.StringPtrInput
	Hosts              MdbPostgresqlClusterHostArrayInput
	Labels             pulumi.StringMapInput
	MaintenanceWindow  MdbPostgresqlClusterMaintenanceWindowPtrInput
	Name               pulumi.StringPtrInput
	NetworkId          pulumi.StringPtrInput
	Restore            MdbPostgresqlClusterRestorePtrInput
	SecurityGroupIds   pulumi.StringArrayInput
	Status             pulumi.StringPtrInput
	// Deprecated: to manage users, please switch to using a separate resource type yandex_mdb_postgresql_user
	Users MdbPostgresqlClusterUserArrayInput
}

func (MdbPostgresqlClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbPostgresqlClusterState)(nil)).Elem()
}

type mdbPostgresqlClusterArgs struct {
	Config MdbPostgresqlClusterConfig `pulumi:"config"`
	// Deprecated: to manage databases, please switch to using a separate resource type yandex_mdb_postgresql_database
	Databases          []MdbPostgresqlClusterDatabase         `pulumi:"databases"`
	DeletionProtection *bool                                  `pulumi:"deletionProtection"`
	Description        *string                                `pulumi:"description"`
	Environment        string                                 `pulumi:"environment"`
	FolderId           *string                                `pulumi:"folderId"`
	HostGroupIds       []string                               `pulumi:"hostGroupIds"`
	HostMasterName     *string                                `pulumi:"hostMasterName"`
	Hosts              []MdbPostgresqlClusterHost             `pulumi:"hosts"`
	Labels             map[string]string                      `pulumi:"labels"`
	MaintenanceWindow  *MdbPostgresqlClusterMaintenanceWindow `pulumi:"maintenanceWindow"`
	Name               *string                                `pulumi:"name"`
	NetworkId          string                                 `pulumi:"networkId"`
	Restore            *MdbPostgresqlClusterRestore           `pulumi:"restore"`
	SecurityGroupIds   []string                               `pulumi:"securityGroupIds"`
	// Deprecated: to manage users, please switch to using a separate resource type yandex_mdb_postgresql_user
	Users []MdbPostgresqlClusterUser `pulumi:"users"`
}

// The set of arguments for constructing a MdbPostgresqlCluster resource.
type MdbPostgresqlClusterArgs struct {
	Config MdbPostgresqlClusterConfigInput
	// Deprecated: to manage databases, please switch to using a separate resource type yandex_mdb_postgresql_database
	Databases          MdbPostgresqlClusterDatabaseArrayInput
	DeletionProtection pulumi.BoolPtrInput
	Description        pulumi.StringPtrInput
	Environment        pulumi.StringInput
	FolderId           pulumi.StringPtrInput
	HostGroupIds       pulumi.StringArrayInput
	HostMasterName     pulumi.StringPtrInput
	Hosts              MdbPostgresqlClusterHostArrayInput
	Labels             pulumi.StringMapInput
	MaintenanceWindow  MdbPostgresqlClusterMaintenanceWindowPtrInput
	Name               pulumi.StringPtrInput
	NetworkId          pulumi.StringInput
	Restore            MdbPostgresqlClusterRestorePtrInput
	SecurityGroupIds   pulumi.StringArrayInput
	// Deprecated: to manage users, please switch to using a separate resource type yandex_mdb_postgresql_user
	Users MdbPostgresqlClusterUserArrayInput
}

func (MdbPostgresqlClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbPostgresqlClusterArgs)(nil)).Elem()
}

type MdbPostgresqlClusterInput interface {
	pulumi.Input

	ToMdbPostgresqlClusterOutput() MdbPostgresqlClusterOutput
	ToMdbPostgresqlClusterOutputWithContext(ctx context.Context) MdbPostgresqlClusterOutput
}

func (*MdbPostgresqlCluster) ElementType() reflect.Type {
	return reflect.TypeOf((**MdbPostgresqlCluster)(nil)).Elem()
}

func (i *MdbPostgresqlCluster) ToMdbPostgresqlClusterOutput() MdbPostgresqlClusterOutput {
	return i.ToMdbPostgresqlClusterOutputWithContext(context.Background())
}

func (i *MdbPostgresqlCluster) ToMdbPostgresqlClusterOutputWithContext(ctx context.Context) MdbPostgresqlClusterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbPostgresqlClusterOutput)
}

// MdbPostgresqlClusterArrayInput is an input type that accepts MdbPostgresqlClusterArray and MdbPostgresqlClusterArrayOutput values.
// You can construct a concrete instance of `MdbPostgresqlClusterArrayInput` via:
//
//	MdbPostgresqlClusterArray{ MdbPostgresqlClusterArgs{...} }
type MdbPostgresqlClusterArrayInput interface {
	pulumi.Input

	ToMdbPostgresqlClusterArrayOutput() MdbPostgresqlClusterArrayOutput
	ToMdbPostgresqlClusterArrayOutputWithContext(context.Context) MdbPostgresqlClusterArrayOutput
}

type MdbPostgresqlClusterArray []MdbPostgresqlClusterInput

func (MdbPostgresqlClusterArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MdbPostgresqlCluster)(nil)).Elem()
}

func (i MdbPostgresqlClusterArray) ToMdbPostgresqlClusterArrayOutput() MdbPostgresqlClusterArrayOutput {
	return i.ToMdbPostgresqlClusterArrayOutputWithContext(context.Background())
}

func (i MdbPostgresqlClusterArray) ToMdbPostgresqlClusterArrayOutputWithContext(ctx context.Context) MdbPostgresqlClusterArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbPostgresqlClusterArrayOutput)
}

// MdbPostgresqlClusterMapInput is an input type that accepts MdbPostgresqlClusterMap and MdbPostgresqlClusterMapOutput values.
// You can construct a concrete instance of `MdbPostgresqlClusterMapInput` via:
//
//	MdbPostgresqlClusterMap{ "key": MdbPostgresqlClusterArgs{...} }
type MdbPostgresqlClusterMapInput interface {
	pulumi.Input

	ToMdbPostgresqlClusterMapOutput() MdbPostgresqlClusterMapOutput
	ToMdbPostgresqlClusterMapOutputWithContext(context.Context) MdbPostgresqlClusterMapOutput
}

type MdbPostgresqlClusterMap map[string]MdbPostgresqlClusterInput

func (MdbPostgresqlClusterMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MdbPostgresqlCluster)(nil)).Elem()
}

func (i MdbPostgresqlClusterMap) ToMdbPostgresqlClusterMapOutput() MdbPostgresqlClusterMapOutput {
	return i.ToMdbPostgresqlClusterMapOutputWithContext(context.Background())
}

func (i MdbPostgresqlClusterMap) ToMdbPostgresqlClusterMapOutputWithContext(ctx context.Context) MdbPostgresqlClusterMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbPostgresqlClusterMapOutput)
}

type MdbPostgresqlClusterOutput struct{ *pulumi.OutputState }

func (MdbPostgresqlClusterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MdbPostgresqlCluster)(nil)).Elem()
}

func (o MdbPostgresqlClusterOutput) ToMdbPostgresqlClusterOutput() MdbPostgresqlClusterOutput {
	return o
}

func (o MdbPostgresqlClusterOutput) ToMdbPostgresqlClusterOutputWithContext(ctx context.Context) MdbPostgresqlClusterOutput {
	return o
}

func (o MdbPostgresqlClusterOutput) Config() MdbPostgresqlClusterConfigOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) MdbPostgresqlClusterConfigOutput { return v.Config }).(MdbPostgresqlClusterConfigOutput)
}

func (o MdbPostgresqlClusterOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// Deprecated: to manage databases, please switch to using a separate resource type yandex_mdb_postgresql_database
func (o MdbPostgresqlClusterOutput) Databases() MdbPostgresqlClusterDatabaseArrayOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) MdbPostgresqlClusterDatabaseArrayOutput { return v.Databases }).(MdbPostgresqlClusterDatabaseArrayOutput)
}

func (o MdbPostgresqlClusterOutput) DeletionProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.BoolOutput { return v.DeletionProtection }).(pulumi.BoolOutput)
}

func (o MdbPostgresqlClusterOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

func (o MdbPostgresqlClusterOutput) Environment() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.StringOutput { return v.Environment }).(pulumi.StringOutput)
}

func (o MdbPostgresqlClusterOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

func (o MdbPostgresqlClusterOutput) Health() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.StringOutput { return v.Health }).(pulumi.StringOutput)
}

func (o MdbPostgresqlClusterOutput) HostGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.StringArrayOutput { return v.HostGroupIds }).(pulumi.StringArrayOutput)
}

func (o MdbPostgresqlClusterOutput) HostMasterName() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.StringOutput { return v.HostMasterName }).(pulumi.StringOutput)
}

func (o MdbPostgresqlClusterOutput) Hosts() MdbPostgresqlClusterHostArrayOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) MdbPostgresqlClusterHostArrayOutput { return v.Hosts }).(MdbPostgresqlClusterHostArrayOutput)
}

func (o MdbPostgresqlClusterOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o MdbPostgresqlClusterOutput) MaintenanceWindow() MdbPostgresqlClusterMaintenanceWindowOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) MdbPostgresqlClusterMaintenanceWindowOutput { return v.MaintenanceWindow }).(MdbPostgresqlClusterMaintenanceWindowOutput)
}

func (o MdbPostgresqlClusterOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o MdbPostgresqlClusterOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.StringOutput { return v.NetworkId }).(pulumi.StringOutput)
}

func (o MdbPostgresqlClusterOutput) Restore() MdbPostgresqlClusterRestorePtrOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) MdbPostgresqlClusterRestorePtrOutput { return v.Restore }).(MdbPostgresqlClusterRestorePtrOutput)
}

func (o MdbPostgresqlClusterOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.StringArrayOutput { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

func (o MdbPostgresqlClusterOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

// Deprecated: to manage users, please switch to using a separate resource type yandex_mdb_postgresql_user
func (o MdbPostgresqlClusterOutput) Users() MdbPostgresqlClusterUserArrayOutput {
	return o.ApplyT(func(v *MdbPostgresqlCluster) MdbPostgresqlClusterUserArrayOutput { return v.Users }).(MdbPostgresqlClusterUserArrayOutput)
}

type MdbPostgresqlClusterArrayOutput struct{ *pulumi.OutputState }

func (MdbPostgresqlClusterArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MdbPostgresqlCluster)(nil)).Elem()
}

func (o MdbPostgresqlClusterArrayOutput) ToMdbPostgresqlClusterArrayOutput() MdbPostgresqlClusterArrayOutput {
	return o
}

func (o MdbPostgresqlClusterArrayOutput) ToMdbPostgresqlClusterArrayOutputWithContext(ctx context.Context) MdbPostgresqlClusterArrayOutput {
	return o
}

func (o MdbPostgresqlClusterArrayOutput) Index(i pulumi.IntInput) MdbPostgresqlClusterOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MdbPostgresqlCluster {
		return vs[0].([]*MdbPostgresqlCluster)[vs[1].(int)]
	}).(MdbPostgresqlClusterOutput)
}

type MdbPostgresqlClusterMapOutput struct{ *pulumi.OutputState }

func (MdbPostgresqlClusterMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MdbPostgresqlCluster)(nil)).Elem()
}

func (o MdbPostgresqlClusterMapOutput) ToMdbPostgresqlClusterMapOutput() MdbPostgresqlClusterMapOutput {
	return o
}

func (o MdbPostgresqlClusterMapOutput) ToMdbPostgresqlClusterMapOutputWithContext(ctx context.Context) MdbPostgresqlClusterMapOutput {
	return o
}

func (o MdbPostgresqlClusterMapOutput) MapIndex(k pulumi.StringInput) MdbPostgresqlClusterOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MdbPostgresqlCluster {
		return vs[0].(map[string]*MdbPostgresqlCluster)[vs[1].(string)]
	}).(MdbPostgresqlClusterOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MdbPostgresqlClusterInput)(nil)).Elem(), &MdbPostgresqlCluster{})
	pulumi.RegisterInputType(reflect.TypeOf((*MdbPostgresqlClusterArrayInput)(nil)).Elem(), MdbPostgresqlClusterArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MdbPostgresqlClusterMapInput)(nil)).Elem(), MdbPostgresqlClusterMap{})
	pulumi.RegisterOutputType(MdbPostgresqlClusterOutput{})
	pulumi.RegisterOutputType(MdbPostgresqlClusterArrayOutput{})
	pulumi.RegisterOutputType(MdbPostgresqlClusterMapOutput{})
}
