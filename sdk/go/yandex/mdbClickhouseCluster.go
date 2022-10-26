// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type MdbClickhouseCluster struct {
	pulumi.CustomResourceState

	Access                MdbClickhouseClusterAccessOutput            `pulumi:"access"`
	AdminPassword         pulumi.StringPtrOutput                      `pulumi:"adminPassword"`
	BackupWindowStart     MdbClickhouseClusterBackupWindowStartOutput `pulumi:"backupWindowStart"`
	Clickhouse            MdbClickhouseClusterClickhouseOutput        `pulumi:"clickhouse"`
	CloudStorage          MdbClickhouseClusterCloudStoragePtrOutput   `pulumi:"cloudStorage"`
	CopySchemaOnNewHosts  pulumi.BoolPtrOutput                        `pulumi:"copySchemaOnNewHosts"`
	CreatedAt             pulumi.StringOutput                         `pulumi:"createdAt"`
	Databases             MdbClickhouseClusterDatabaseArrayOutput     `pulumi:"databases"`
	DeletionProtection    pulumi.BoolOutput                           `pulumi:"deletionProtection"`
	Description           pulumi.StringPtrOutput                      `pulumi:"description"`
	EmbeddedKeeper        pulumi.BoolOutput                           `pulumi:"embeddedKeeper"`
	Environment           pulumi.StringOutput                         `pulumi:"environment"`
	FolderId              pulumi.StringOutput                         `pulumi:"folderId"`
	FormatSchemas         MdbClickhouseClusterFormatSchemaArrayOutput `pulumi:"formatSchemas"`
	Health                pulumi.StringOutput                         `pulumi:"health"`
	Hosts                 MdbClickhouseClusterHostArrayOutput         `pulumi:"hosts"`
	Labels                pulumi.StringMapOutput                      `pulumi:"labels"`
	MaintenanceWindow     MdbClickhouseClusterMaintenanceWindowOutput `pulumi:"maintenanceWindow"`
	MlModels              MdbClickhouseClusterMlModelArrayOutput      `pulumi:"mlModels"`
	Name                  pulumi.StringOutput                         `pulumi:"name"`
	NetworkId             pulumi.StringOutput                         `pulumi:"networkId"`
	SecurityGroupIds      pulumi.StringArrayOutput                    `pulumi:"securityGroupIds"`
	ServiceAccountId      pulumi.StringOutput                         `pulumi:"serviceAccountId"`
	ShardGroups           MdbClickhouseClusterShardGroupArrayOutput   `pulumi:"shardGroups"`
	SqlDatabaseManagement pulumi.BoolOutput                           `pulumi:"sqlDatabaseManagement"`
	SqlUserManagement     pulumi.BoolOutput                           `pulumi:"sqlUserManagement"`
	Status                pulumi.StringOutput                         `pulumi:"status"`
	Users                 MdbClickhouseClusterUserArrayOutput         `pulumi:"users"`
	Version               pulumi.StringOutput                         `pulumi:"version"`
	Zookeeper             MdbClickhouseClusterZookeeperOutput         `pulumi:"zookeeper"`
}

// NewMdbClickhouseCluster registers a new resource with the given unique name, arguments, and options.
func NewMdbClickhouseCluster(ctx *pulumi.Context,
	name string, args *MdbClickhouseClusterArgs, opts ...pulumi.ResourceOption) (*MdbClickhouseCluster, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Clickhouse == nil {
		return nil, errors.New("invalid value for required argument 'Clickhouse'")
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
	var resource MdbClickhouseCluster
	err := ctx.RegisterResource("yandex:index/mdbClickhouseCluster:MdbClickhouseCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMdbClickhouseCluster gets an existing MdbClickhouseCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMdbClickhouseCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MdbClickhouseClusterState, opts ...pulumi.ResourceOption) (*MdbClickhouseCluster, error) {
	var resource MdbClickhouseCluster
	err := ctx.ReadResource("yandex:index/mdbClickhouseCluster:MdbClickhouseCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MdbClickhouseCluster resources.
type mdbClickhouseClusterState struct {
	Access                *MdbClickhouseClusterAccess            `pulumi:"access"`
	AdminPassword         *string                                `pulumi:"adminPassword"`
	BackupWindowStart     *MdbClickhouseClusterBackupWindowStart `pulumi:"backupWindowStart"`
	Clickhouse            *MdbClickhouseClusterClickhouse        `pulumi:"clickhouse"`
	CloudStorage          *MdbClickhouseClusterCloudStorage      `pulumi:"cloudStorage"`
	CopySchemaOnNewHosts  *bool                                  `pulumi:"copySchemaOnNewHosts"`
	CreatedAt             *string                                `pulumi:"createdAt"`
	Databases             []MdbClickhouseClusterDatabase         `pulumi:"databases"`
	DeletionProtection    *bool                                  `pulumi:"deletionProtection"`
	Description           *string                                `pulumi:"description"`
	EmbeddedKeeper        *bool                                  `pulumi:"embeddedKeeper"`
	Environment           *string                                `pulumi:"environment"`
	FolderId              *string                                `pulumi:"folderId"`
	FormatSchemas         []MdbClickhouseClusterFormatSchema     `pulumi:"formatSchemas"`
	Health                *string                                `pulumi:"health"`
	Hosts                 []MdbClickhouseClusterHost             `pulumi:"hosts"`
	Labels                map[string]string                      `pulumi:"labels"`
	MaintenanceWindow     *MdbClickhouseClusterMaintenanceWindow `pulumi:"maintenanceWindow"`
	MlModels              []MdbClickhouseClusterMlModel          `pulumi:"mlModels"`
	Name                  *string                                `pulumi:"name"`
	NetworkId             *string                                `pulumi:"networkId"`
	SecurityGroupIds      []string                               `pulumi:"securityGroupIds"`
	ServiceAccountId      *string                                `pulumi:"serviceAccountId"`
	ShardGroups           []MdbClickhouseClusterShardGroup       `pulumi:"shardGroups"`
	SqlDatabaseManagement *bool                                  `pulumi:"sqlDatabaseManagement"`
	SqlUserManagement     *bool                                  `pulumi:"sqlUserManagement"`
	Status                *string                                `pulumi:"status"`
	Users                 []MdbClickhouseClusterUser             `pulumi:"users"`
	Version               *string                                `pulumi:"version"`
	Zookeeper             *MdbClickhouseClusterZookeeper         `pulumi:"zookeeper"`
}

type MdbClickhouseClusterState struct {
	Access                MdbClickhouseClusterAccessPtrInput
	AdminPassword         pulumi.StringPtrInput
	BackupWindowStart     MdbClickhouseClusterBackupWindowStartPtrInput
	Clickhouse            MdbClickhouseClusterClickhousePtrInput
	CloudStorage          MdbClickhouseClusterCloudStoragePtrInput
	CopySchemaOnNewHosts  pulumi.BoolPtrInput
	CreatedAt             pulumi.StringPtrInput
	Databases             MdbClickhouseClusterDatabaseArrayInput
	DeletionProtection    pulumi.BoolPtrInput
	Description           pulumi.StringPtrInput
	EmbeddedKeeper        pulumi.BoolPtrInput
	Environment           pulumi.StringPtrInput
	FolderId              pulumi.StringPtrInput
	FormatSchemas         MdbClickhouseClusterFormatSchemaArrayInput
	Health                pulumi.StringPtrInput
	Hosts                 MdbClickhouseClusterHostArrayInput
	Labels                pulumi.StringMapInput
	MaintenanceWindow     MdbClickhouseClusterMaintenanceWindowPtrInput
	MlModels              MdbClickhouseClusterMlModelArrayInput
	Name                  pulumi.StringPtrInput
	NetworkId             pulumi.StringPtrInput
	SecurityGroupIds      pulumi.StringArrayInput
	ServiceAccountId      pulumi.StringPtrInput
	ShardGroups           MdbClickhouseClusterShardGroupArrayInput
	SqlDatabaseManagement pulumi.BoolPtrInput
	SqlUserManagement     pulumi.BoolPtrInput
	Status                pulumi.StringPtrInput
	Users                 MdbClickhouseClusterUserArrayInput
	Version               pulumi.StringPtrInput
	Zookeeper             MdbClickhouseClusterZookeeperPtrInput
}

func (MdbClickhouseClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbClickhouseClusterState)(nil)).Elem()
}

type mdbClickhouseClusterArgs struct {
	Access                *MdbClickhouseClusterAccess            `pulumi:"access"`
	AdminPassword         *string                                `pulumi:"adminPassword"`
	BackupWindowStart     *MdbClickhouseClusterBackupWindowStart `pulumi:"backupWindowStart"`
	Clickhouse            MdbClickhouseClusterClickhouse         `pulumi:"clickhouse"`
	CloudStorage          *MdbClickhouseClusterCloudStorage      `pulumi:"cloudStorage"`
	CopySchemaOnNewHosts  *bool                                  `pulumi:"copySchemaOnNewHosts"`
	Databases             []MdbClickhouseClusterDatabase         `pulumi:"databases"`
	DeletionProtection    *bool                                  `pulumi:"deletionProtection"`
	Description           *string                                `pulumi:"description"`
	EmbeddedKeeper        *bool                                  `pulumi:"embeddedKeeper"`
	Environment           string                                 `pulumi:"environment"`
	FolderId              *string                                `pulumi:"folderId"`
	FormatSchemas         []MdbClickhouseClusterFormatSchema     `pulumi:"formatSchemas"`
	Hosts                 []MdbClickhouseClusterHost             `pulumi:"hosts"`
	Labels                map[string]string                      `pulumi:"labels"`
	MaintenanceWindow     *MdbClickhouseClusterMaintenanceWindow `pulumi:"maintenanceWindow"`
	MlModels              []MdbClickhouseClusterMlModel          `pulumi:"mlModels"`
	Name                  *string                                `pulumi:"name"`
	NetworkId             string                                 `pulumi:"networkId"`
	SecurityGroupIds      []string                               `pulumi:"securityGroupIds"`
	ServiceAccountId      *string                                `pulumi:"serviceAccountId"`
	ShardGroups           []MdbClickhouseClusterShardGroup       `pulumi:"shardGroups"`
	SqlDatabaseManagement *bool                                  `pulumi:"sqlDatabaseManagement"`
	SqlUserManagement     *bool                                  `pulumi:"sqlUserManagement"`
	Users                 []MdbClickhouseClusterUser             `pulumi:"users"`
	Version               *string                                `pulumi:"version"`
	Zookeeper             *MdbClickhouseClusterZookeeper         `pulumi:"zookeeper"`
}

// The set of arguments for constructing a MdbClickhouseCluster resource.
type MdbClickhouseClusterArgs struct {
	Access                MdbClickhouseClusterAccessPtrInput
	AdminPassword         pulumi.StringPtrInput
	BackupWindowStart     MdbClickhouseClusterBackupWindowStartPtrInput
	Clickhouse            MdbClickhouseClusterClickhouseInput
	CloudStorage          MdbClickhouseClusterCloudStoragePtrInput
	CopySchemaOnNewHosts  pulumi.BoolPtrInput
	Databases             MdbClickhouseClusterDatabaseArrayInput
	DeletionProtection    pulumi.BoolPtrInput
	Description           pulumi.StringPtrInput
	EmbeddedKeeper        pulumi.BoolPtrInput
	Environment           pulumi.StringInput
	FolderId              pulumi.StringPtrInput
	FormatSchemas         MdbClickhouseClusterFormatSchemaArrayInput
	Hosts                 MdbClickhouseClusterHostArrayInput
	Labels                pulumi.StringMapInput
	MaintenanceWindow     MdbClickhouseClusterMaintenanceWindowPtrInput
	MlModels              MdbClickhouseClusterMlModelArrayInput
	Name                  pulumi.StringPtrInput
	NetworkId             pulumi.StringInput
	SecurityGroupIds      pulumi.StringArrayInput
	ServiceAccountId      pulumi.StringPtrInput
	ShardGroups           MdbClickhouseClusterShardGroupArrayInput
	SqlDatabaseManagement pulumi.BoolPtrInput
	SqlUserManagement     pulumi.BoolPtrInput
	Users                 MdbClickhouseClusterUserArrayInput
	Version               pulumi.StringPtrInput
	Zookeeper             MdbClickhouseClusterZookeeperPtrInput
}

func (MdbClickhouseClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbClickhouseClusterArgs)(nil)).Elem()
}

type MdbClickhouseClusterInput interface {
	pulumi.Input

	ToMdbClickhouseClusterOutput() MdbClickhouseClusterOutput
	ToMdbClickhouseClusterOutputWithContext(ctx context.Context) MdbClickhouseClusterOutput
}

func (*MdbClickhouseCluster) ElementType() reflect.Type {
	return reflect.TypeOf((**MdbClickhouseCluster)(nil)).Elem()
}

func (i *MdbClickhouseCluster) ToMdbClickhouseClusterOutput() MdbClickhouseClusterOutput {
	return i.ToMdbClickhouseClusterOutputWithContext(context.Background())
}

func (i *MdbClickhouseCluster) ToMdbClickhouseClusterOutputWithContext(ctx context.Context) MdbClickhouseClusterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbClickhouseClusterOutput)
}

// MdbClickhouseClusterArrayInput is an input type that accepts MdbClickhouseClusterArray and MdbClickhouseClusterArrayOutput values.
// You can construct a concrete instance of `MdbClickhouseClusterArrayInput` via:
//
//	MdbClickhouseClusterArray{ MdbClickhouseClusterArgs{...} }
type MdbClickhouseClusterArrayInput interface {
	pulumi.Input

	ToMdbClickhouseClusterArrayOutput() MdbClickhouseClusterArrayOutput
	ToMdbClickhouseClusterArrayOutputWithContext(context.Context) MdbClickhouseClusterArrayOutput
}

type MdbClickhouseClusterArray []MdbClickhouseClusterInput

func (MdbClickhouseClusterArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MdbClickhouseCluster)(nil)).Elem()
}

func (i MdbClickhouseClusterArray) ToMdbClickhouseClusterArrayOutput() MdbClickhouseClusterArrayOutput {
	return i.ToMdbClickhouseClusterArrayOutputWithContext(context.Background())
}

func (i MdbClickhouseClusterArray) ToMdbClickhouseClusterArrayOutputWithContext(ctx context.Context) MdbClickhouseClusterArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbClickhouseClusterArrayOutput)
}

// MdbClickhouseClusterMapInput is an input type that accepts MdbClickhouseClusterMap and MdbClickhouseClusterMapOutput values.
// You can construct a concrete instance of `MdbClickhouseClusterMapInput` via:
//
//	MdbClickhouseClusterMap{ "key": MdbClickhouseClusterArgs{...} }
type MdbClickhouseClusterMapInput interface {
	pulumi.Input

	ToMdbClickhouseClusterMapOutput() MdbClickhouseClusterMapOutput
	ToMdbClickhouseClusterMapOutputWithContext(context.Context) MdbClickhouseClusterMapOutput
}

type MdbClickhouseClusterMap map[string]MdbClickhouseClusterInput

func (MdbClickhouseClusterMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MdbClickhouseCluster)(nil)).Elem()
}

func (i MdbClickhouseClusterMap) ToMdbClickhouseClusterMapOutput() MdbClickhouseClusterMapOutput {
	return i.ToMdbClickhouseClusterMapOutputWithContext(context.Background())
}

func (i MdbClickhouseClusterMap) ToMdbClickhouseClusterMapOutputWithContext(ctx context.Context) MdbClickhouseClusterMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbClickhouseClusterMapOutput)
}

type MdbClickhouseClusterOutput struct{ *pulumi.OutputState }

func (MdbClickhouseClusterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MdbClickhouseCluster)(nil)).Elem()
}

func (o MdbClickhouseClusterOutput) ToMdbClickhouseClusterOutput() MdbClickhouseClusterOutput {
	return o
}

func (o MdbClickhouseClusterOutput) ToMdbClickhouseClusterOutputWithContext(ctx context.Context) MdbClickhouseClusterOutput {
	return o
}

func (o MdbClickhouseClusterOutput) Access() MdbClickhouseClusterAccessOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) MdbClickhouseClusterAccessOutput { return v.Access }).(MdbClickhouseClusterAccessOutput)
}

func (o MdbClickhouseClusterOutput) AdminPassword() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringPtrOutput { return v.AdminPassword }).(pulumi.StringPtrOutput)
}

func (o MdbClickhouseClusterOutput) BackupWindowStart() MdbClickhouseClusterBackupWindowStartOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) MdbClickhouseClusterBackupWindowStartOutput { return v.BackupWindowStart }).(MdbClickhouseClusterBackupWindowStartOutput)
}

func (o MdbClickhouseClusterOutput) Clickhouse() MdbClickhouseClusterClickhouseOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) MdbClickhouseClusterClickhouseOutput { return v.Clickhouse }).(MdbClickhouseClusterClickhouseOutput)
}

func (o MdbClickhouseClusterOutput) CloudStorage() MdbClickhouseClusterCloudStoragePtrOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) MdbClickhouseClusterCloudStoragePtrOutput { return v.CloudStorage }).(MdbClickhouseClusterCloudStoragePtrOutput)
}

func (o MdbClickhouseClusterOutput) CopySchemaOnNewHosts() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.BoolPtrOutput { return v.CopySchemaOnNewHosts }).(pulumi.BoolPtrOutput)
}

func (o MdbClickhouseClusterOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o MdbClickhouseClusterOutput) Databases() MdbClickhouseClusterDatabaseArrayOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) MdbClickhouseClusterDatabaseArrayOutput { return v.Databases }).(MdbClickhouseClusterDatabaseArrayOutput)
}

func (o MdbClickhouseClusterOutput) DeletionProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.BoolOutput { return v.DeletionProtection }).(pulumi.BoolOutput)
}

func (o MdbClickhouseClusterOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

func (o MdbClickhouseClusterOutput) EmbeddedKeeper() pulumi.BoolOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.BoolOutput { return v.EmbeddedKeeper }).(pulumi.BoolOutput)
}

func (o MdbClickhouseClusterOutput) Environment() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringOutput { return v.Environment }).(pulumi.StringOutput)
}

func (o MdbClickhouseClusterOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

func (o MdbClickhouseClusterOutput) FormatSchemas() MdbClickhouseClusterFormatSchemaArrayOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) MdbClickhouseClusterFormatSchemaArrayOutput { return v.FormatSchemas }).(MdbClickhouseClusterFormatSchemaArrayOutput)
}

func (o MdbClickhouseClusterOutput) Health() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringOutput { return v.Health }).(pulumi.StringOutput)
}

func (o MdbClickhouseClusterOutput) Hosts() MdbClickhouseClusterHostArrayOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) MdbClickhouseClusterHostArrayOutput { return v.Hosts }).(MdbClickhouseClusterHostArrayOutput)
}

func (o MdbClickhouseClusterOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o MdbClickhouseClusterOutput) MaintenanceWindow() MdbClickhouseClusterMaintenanceWindowOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) MdbClickhouseClusterMaintenanceWindowOutput { return v.MaintenanceWindow }).(MdbClickhouseClusterMaintenanceWindowOutput)
}

func (o MdbClickhouseClusterOutput) MlModels() MdbClickhouseClusterMlModelArrayOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) MdbClickhouseClusterMlModelArrayOutput { return v.MlModels }).(MdbClickhouseClusterMlModelArrayOutput)
}

func (o MdbClickhouseClusterOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o MdbClickhouseClusterOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringOutput { return v.NetworkId }).(pulumi.StringOutput)
}

func (o MdbClickhouseClusterOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringArrayOutput { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

func (o MdbClickhouseClusterOutput) ServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringOutput { return v.ServiceAccountId }).(pulumi.StringOutput)
}

func (o MdbClickhouseClusterOutput) ShardGroups() MdbClickhouseClusterShardGroupArrayOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) MdbClickhouseClusterShardGroupArrayOutput { return v.ShardGroups }).(MdbClickhouseClusterShardGroupArrayOutput)
}

func (o MdbClickhouseClusterOutput) SqlDatabaseManagement() pulumi.BoolOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.BoolOutput { return v.SqlDatabaseManagement }).(pulumi.BoolOutput)
}

func (o MdbClickhouseClusterOutput) SqlUserManagement() pulumi.BoolOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.BoolOutput { return v.SqlUserManagement }).(pulumi.BoolOutput)
}

func (o MdbClickhouseClusterOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

func (o MdbClickhouseClusterOutput) Users() MdbClickhouseClusterUserArrayOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) MdbClickhouseClusterUserArrayOutput { return v.Users }).(MdbClickhouseClusterUserArrayOutput)
}

func (o MdbClickhouseClusterOutput) Version() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) pulumi.StringOutput { return v.Version }).(pulumi.StringOutput)
}

func (o MdbClickhouseClusterOutput) Zookeeper() MdbClickhouseClusterZookeeperOutput {
	return o.ApplyT(func(v *MdbClickhouseCluster) MdbClickhouseClusterZookeeperOutput { return v.Zookeeper }).(MdbClickhouseClusterZookeeperOutput)
}

type MdbClickhouseClusterArrayOutput struct{ *pulumi.OutputState }

func (MdbClickhouseClusterArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MdbClickhouseCluster)(nil)).Elem()
}

func (o MdbClickhouseClusterArrayOutput) ToMdbClickhouseClusterArrayOutput() MdbClickhouseClusterArrayOutput {
	return o
}

func (o MdbClickhouseClusterArrayOutput) ToMdbClickhouseClusterArrayOutputWithContext(ctx context.Context) MdbClickhouseClusterArrayOutput {
	return o
}

func (o MdbClickhouseClusterArrayOutput) Index(i pulumi.IntInput) MdbClickhouseClusterOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MdbClickhouseCluster {
		return vs[0].([]*MdbClickhouseCluster)[vs[1].(int)]
	}).(MdbClickhouseClusterOutput)
}

type MdbClickhouseClusterMapOutput struct{ *pulumi.OutputState }

func (MdbClickhouseClusterMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MdbClickhouseCluster)(nil)).Elem()
}

func (o MdbClickhouseClusterMapOutput) ToMdbClickhouseClusterMapOutput() MdbClickhouseClusterMapOutput {
	return o
}

func (o MdbClickhouseClusterMapOutput) ToMdbClickhouseClusterMapOutputWithContext(ctx context.Context) MdbClickhouseClusterMapOutput {
	return o
}

func (o MdbClickhouseClusterMapOutput) MapIndex(k pulumi.StringInput) MdbClickhouseClusterOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MdbClickhouseCluster {
		return vs[0].(map[string]*MdbClickhouseCluster)[vs[1].(string)]
	}).(MdbClickhouseClusterOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MdbClickhouseClusterInput)(nil)).Elem(), &MdbClickhouseCluster{})
	pulumi.RegisterInputType(reflect.TypeOf((*MdbClickhouseClusterArrayInput)(nil)).Elem(), MdbClickhouseClusterArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MdbClickhouseClusterMapInput)(nil)).Elem(), MdbClickhouseClusterMap{})
	pulumi.RegisterOutputType(MdbClickhouseClusterOutput{})
	pulumi.RegisterOutputType(MdbClickhouseClusterArrayOutput{})
	pulumi.RegisterOutputType(MdbClickhouseClusterMapOutput{})
}
