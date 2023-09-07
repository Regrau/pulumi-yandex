// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Manages a Greenplum cluster within the Yandex.Cloud. For more information, see
// [the official documentation](https://cloud.yandex.ru/docs/managed-greenplum/).
//
// Please read [Pricing for Managed Service for Greenplum](https://cloud.yandex.ru/docs/managed-greenplum/) before using Greenplum cluster.
//
// Yandex Managed Service for Greenplum® is now in preview
//
// ## Greenplum cluster settings
//
// | Setting name and type \ Greenplum version | 6.17 | 6.19 |
// | ------------------------------------------| ---- | ---- |
// | maxConnections : integer | supported | supported |
// | maxPreparedTransactions : integer | supported | supported |
// | gpWorkfileLimitPerQuery : integer | supported | supported |
// | gpWorkfileLimitFilesPerQuery : integer | supported | supported |
// | maxSlotWalKeepSize : integer | supported | supported |
// | gpWorkfileLimitPerSegment : integer | supported | supported |
// | gpWorkfileCompression : boolean | supported | supported |
// | maxStatementMem : integer | - | supported |
// | logStatement : one of<br>  - 0: " LOG_STATEMENT_UNSPECIFIED"<br>  - 1: " LOG_STATEMENT_NONE"<br>  - 2: " LOG_STATEMENT_DDL"<er>  - 3: " LOG_STATEMENT_MOD"<br>  - 4: " LOG_STATEMENT_ALL"  | - | supported |
//
// ## Import
//
// A cluster can be imported using the `id` of the resource, e.g.
//
// ```sh
//  $ pulumi import yandex:index/mdbGreenplumCluster:MdbGreenplumCluster foo cluster_id
// ```
type MdbGreenplumCluster struct {
	pulumi.CustomResourceState

	// Access policy to the Greenplum cluster. The structure is documented below.
	Access MdbGreenplumClusterAccessOutput `pulumi:"access"`
	// Sets whether the master hosts should get a public IP address on creation. Changing this parameter for an existing host is not supported at the moment.
	AssignPublicIp pulumi.BoolOutput `pulumi:"assignPublicIp"`
	// Time to start the daily backup, in the UTC timezone. The structure is documented below.
	BackupWindowStart MdbGreenplumClusterBackupWindowStartOutput `pulumi:"backupWindowStart"`
	// Creation timestamp of the cluster.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	DeletionProtection pulumi.BoolOutput `pulumi:"deletionProtection"`
	// Description of the Greenplum cluster.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Deployment environment of the Greenplum cluster. (PRODUCTION, PRESTABLE)
	Environment pulumi.StringOutput `pulumi:"environment"`
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId pulumi.StringOutput `pulumi:"folderId"`
	// Greenplum cluster config. Detail info in "Greenplum cluster settings" section (documented below).
	GreenplumConfig pulumi.StringMapOutput `pulumi:"greenplumConfig"`
	// Aggregated health of the cluster.
	Health pulumi.StringOutput `pulumi:"health"`
	// A set of key/value label pairs to assign to the Greenplum cluster.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Maintenance policy of the Greenplum cluster. The structure is documented below.
	MaintenanceWindow MdbGreenplumClusterMaintenanceWindowOutput `pulumi:"maintenanceWindow"`
	// Number of hosts in master subcluster (1 or 2).
	MasterHostCount pulumi.IntOutput `pulumi:"masterHostCount"`
	// (Computed) Info about hosts in master subcluster. The structure is documented below.
	MasterHosts MdbGreenplumClusterMasterHostArrayOutput `pulumi:"masterHosts"`
	// Settings for master subcluster. The structure is documented below.
	MasterSubcluster MdbGreenplumClusterMasterSubclusterOutput `pulumi:"masterSubcluster"`
	// Name of the Greenplum cluster. Provided by the client when the cluster is created.
	Name pulumi.StringOutput `pulumi:"name"`
	// ID of the network, to which the Greenplum cluster uses.
	NetworkId pulumi.StringOutput `pulumi:"networkId"`
	// Configuration of the connection pooler. The structure is documented below.
	PoolerConfig MdbGreenplumClusterPoolerConfigOutput `pulumi:"poolerConfig"`
	// A set of ids of security groups assigned to hosts of the cluster.
	SecurityGroupIds pulumi.StringArrayOutput `pulumi:"securityGroupIds"`
	// Number of hosts in segment subcluster (from 1 to 32).
	SegmentHostCount pulumi.IntOutput `pulumi:"segmentHostCount"`
	// (Computed) Info about hosts in segment subcluster. The structure is documented below.
	SegmentHosts MdbGreenplumClusterSegmentHostArrayOutput `pulumi:"segmentHosts"`
	// Number of segments on segment host (not more then 1 + RAM/8).
	SegmentInHost pulumi.IntOutput `pulumi:"segmentInHost"`
	// Settings for segment subcluster. The structure is documented below.
	SegmentSubcluster MdbGreenplumClusterSegmentSubclusterOutput `pulumi:"segmentSubcluster"`
	// Status of the cluster.
	Status pulumi.StringOutput `pulumi:"status"`
	// The ID of the subnet, to which the hosts belongs. The subnet must be a part of the network to which the cluster belongs.
	SubnetId pulumi.StringOutput `pulumi:"subnetId"`
	// Greenplum cluster admin user name.
	UserName pulumi.StringOutput `pulumi:"userName"`
	// Greenplum cluster admin password name.
	UserPassword pulumi.StringOutput `pulumi:"userPassword"`
	// Version of the Greenplum cluster. (6.19)
	Version pulumi.StringOutput `pulumi:"version"`
	// The availability zone where the Greenplum hosts will be created.
	Zone pulumi.StringOutput `pulumi:"zone"`
}

// NewMdbGreenplumCluster registers a new resource with the given unique name, arguments, and options.
func NewMdbGreenplumCluster(ctx *pulumi.Context,
	name string, args *MdbGreenplumClusterArgs, opts ...pulumi.ResourceOption) (*MdbGreenplumCluster, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AssignPublicIp == nil {
		return nil, errors.New("invalid value for required argument 'AssignPublicIp'")
	}
	if args.Environment == nil {
		return nil, errors.New("invalid value for required argument 'Environment'")
	}
	if args.MasterHostCount == nil {
		return nil, errors.New("invalid value for required argument 'MasterHostCount'")
	}
	if args.MasterSubcluster == nil {
		return nil, errors.New("invalid value for required argument 'MasterSubcluster'")
	}
	if args.NetworkId == nil {
		return nil, errors.New("invalid value for required argument 'NetworkId'")
	}
	if args.SegmentHostCount == nil {
		return nil, errors.New("invalid value for required argument 'SegmentHostCount'")
	}
	if args.SegmentInHost == nil {
		return nil, errors.New("invalid value for required argument 'SegmentInHost'")
	}
	if args.SegmentSubcluster == nil {
		return nil, errors.New("invalid value for required argument 'SegmentSubcluster'")
	}
	if args.SubnetId == nil {
		return nil, errors.New("invalid value for required argument 'SubnetId'")
	}
	if args.UserName == nil {
		return nil, errors.New("invalid value for required argument 'UserName'")
	}
	if args.UserPassword == nil {
		return nil, errors.New("invalid value for required argument 'UserPassword'")
	}
	if args.Version == nil {
		return nil, errors.New("invalid value for required argument 'Version'")
	}
	if args.Zone == nil {
		return nil, errors.New("invalid value for required argument 'Zone'")
	}
	if args.UserPassword != nil {
		args.UserPassword = pulumi.ToSecret(args.UserPassword).(pulumi.StringOutput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"userPassword",
	})
	opts = append(opts, secrets)
	opts = pkgResourceDefaultOpts(opts)
	var resource MdbGreenplumCluster
	err := ctx.RegisterResource("yandex:index/mdbGreenplumCluster:MdbGreenplumCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMdbGreenplumCluster gets an existing MdbGreenplumCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMdbGreenplumCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MdbGreenplumClusterState, opts ...pulumi.ResourceOption) (*MdbGreenplumCluster, error) {
	var resource MdbGreenplumCluster
	err := ctx.ReadResource("yandex:index/mdbGreenplumCluster:MdbGreenplumCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MdbGreenplumCluster resources.
type mdbGreenplumClusterState struct {
	// Access policy to the Greenplum cluster. The structure is documented below.
	Access *MdbGreenplumClusterAccess `pulumi:"access"`
	// Sets whether the master hosts should get a public IP address on creation. Changing this parameter for an existing host is not supported at the moment.
	AssignPublicIp *bool `pulumi:"assignPublicIp"`
	// Time to start the daily backup, in the UTC timezone. The structure is documented below.
	BackupWindowStart *MdbGreenplumClusterBackupWindowStart `pulumi:"backupWindowStart"`
	// Creation timestamp of the cluster.
	CreatedAt *string `pulumi:"createdAt"`
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	DeletionProtection *bool `pulumi:"deletionProtection"`
	// Description of the Greenplum cluster.
	Description *string `pulumi:"description"`
	// Deployment environment of the Greenplum cluster. (PRODUCTION, PRESTABLE)
	Environment *string `pulumi:"environment"`
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// Greenplum cluster config. Detail info in "Greenplum cluster settings" section (documented below).
	GreenplumConfig map[string]string `pulumi:"greenplumConfig"`
	// Aggregated health of the cluster.
	Health *string `pulumi:"health"`
	// A set of key/value label pairs to assign to the Greenplum cluster.
	Labels map[string]string `pulumi:"labels"`
	// Maintenance policy of the Greenplum cluster. The structure is documented below.
	MaintenanceWindow *MdbGreenplumClusterMaintenanceWindow `pulumi:"maintenanceWindow"`
	// Number of hosts in master subcluster (1 or 2).
	MasterHostCount *int `pulumi:"masterHostCount"`
	// (Computed) Info about hosts in master subcluster. The structure is documented below.
	MasterHosts []MdbGreenplumClusterMasterHost `pulumi:"masterHosts"`
	// Settings for master subcluster. The structure is documented below.
	MasterSubcluster *MdbGreenplumClusterMasterSubcluster `pulumi:"masterSubcluster"`
	// Name of the Greenplum cluster. Provided by the client when the cluster is created.
	Name *string `pulumi:"name"`
	// ID of the network, to which the Greenplum cluster uses.
	NetworkId *string `pulumi:"networkId"`
	// Configuration of the connection pooler. The structure is documented below.
	PoolerConfig *MdbGreenplumClusterPoolerConfig `pulumi:"poolerConfig"`
	// A set of ids of security groups assigned to hosts of the cluster.
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// Number of hosts in segment subcluster (from 1 to 32).
	SegmentHostCount *int `pulumi:"segmentHostCount"`
	// (Computed) Info about hosts in segment subcluster. The structure is documented below.
	SegmentHosts []MdbGreenplumClusterSegmentHost `pulumi:"segmentHosts"`
	// Number of segments on segment host (not more then 1 + RAM/8).
	SegmentInHost *int `pulumi:"segmentInHost"`
	// Settings for segment subcluster. The structure is documented below.
	SegmentSubcluster *MdbGreenplumClusterSegmentSubcluster `pulumi:"segmentSubcluster"`
	// Status of the cluster.
	Status *string `pulumi:"status"`
	// The ID of the subnet, to which the hosts belongs. The subnet must be a part of the network to which the cluster belongs.
	SubnetId *string `pulumi:"subnetId"`
	// Greenplum cluster admin user name.
	UserName *string `pulumi:"userName"`
	// Greenplum cluster admin password name.
	UserPassword *string `pulumi:"userPassword"`
	// Version of the Greenplum cluster. (6.19)
	Version *string `pulumi:"version"`
	// The availability zone where the Greenplum hosts will be created.
	Zone *string `pulumi:"zone"`
}

type MdbGreenplumClusterState struct {
	// Access policy to the Greenplum cluster. The structure is documented below.
	Access MdbGreenplumClusterAccessPtrInput
	// Sets whether the master hosts should get a public IP address on creation. Changing this parameter for an existing host is not supported at the moment.
	AssignPublicIp pulumi.BoolPtrInput
	// Time to start the daily backup, in the UTC timezone. The structure is documented below.
	BackupWindowStart MdbGreenplumClusterBackupWindowStartPtrInput
	// Creation timestamp of the cluster.
	CreatedAt pulumi.StringPtrInput
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	DeletionProtection pulumi.BoolPtrInput
	// Description of the Greenplum cluster.
	Description pulumi.StringPtrInput
	// Deployment environment of the Greenplum cluster. (PRODUCTION, PRESTABLE)
	Environment pulumi.StringPtrInput
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// Greenplum cluster config. Detail info in "Greenplum cluster settings" section (documented below).
	GreenplumConfig pulumi.StringMapInput
	// Aggregated health of the cluster.
	Health pulumi.StringPtrInput
	// A set of key/value label pairs to assign to the Greenplum cluster.
	Labels pulumi.StringMapInput
	// Maintenance policy of the Greenplum cluster. The structure is documented below.
	MaintenanceWindow MdbGreenplumClusterMaintenanceWindowPtrInput
	// Number of hosts in master subcluster (1 or 2).
	MasterHostCount pulumi.IntPtrInput
	// (Computed) Info about hosts in master subcluster. The structure is documented below.
	MasterHosts MdbGreenplumClusterMasterHostArrayInput
	// Settings for master subcluster. The structure is documented below.
	MasterSubcluster MdbGreenplumClusterMasterSubclusterPtrInput
	// Name of the Greenplum cluster. Provided by the client when the cluster is created.
	Name pulumi.StringPtrInput
	// ID of the network, to which the Greenplum cluster uses.
	NetworkId pulumi.StringPtrInput
	// Configuration of the connection pooler. The structure is documented below.
	PoolerConfig MdbGreenplumClusterPoolerConfigPtrInput
	// A set of ids of security groups assigned to hosts of the cluster.
	SecurityGroupIds pulumi.StringArrayInput
	// Number of hosts in segment subcluster (from 1 to 32).
	SegmentHostCount pulumi.IntPtrInput
	// (Computed) Info about hosts in segment subcluster. The structure is documented below.
	SegmentHosts MdbGreenplumClusterSegmentHostArrayInput
	// Number of segments on segment host (not more then 1 + RAM/8).
	SegmentInHost pulumi.IntPtrInput
	// Settings for segment subcluster. The structure is documented below.
	SegmentSubcluster MdbGreenplumClusterSegmentSubclusterPtrInput
	// Status of the cluster.
	Status pulumi.StringPtrInput
	// The ID of the subnet, to which the hosts belongs. The subnet must be a part of the network to which the cluster belongs.
	SubnetId pulumi.StringPtrInput
	// Greenplum cluster admin user name.
	UserName pulumi.StringPtrInput
	// Greenplum cluster admin password name.
	UserPassword pulumi.StringPtrInput
	// Version of the Greenplum cluster. (6.19)
	Version pulumi.StringPtrInput
	// The availability zone where the Greenplum hosts will be created.
	Zone pulumi.StringPtrInput
}

func (MdbGreenplumClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbGreenplumClusterState)(nil)).Elem()
}

type mdbGreenplumClusterArgs struct {
	// Access policy to the Greenplum cluster. The structure is documented below.
	Access *MdbGreenplumClusterAccess `pulumi:"access"`
	// Sets whether the master hosts should get a public IP address on creation. Changing this parameter for an existing host is not supported at the moment.
	AssignPublicIp bool `pulumi:"assignPublicIp"`
	// Time to start the daily backup, in the UTC timezone. The structure is documented below.
	BackupWindowStart *MdbGreenplumClusterBackupWindowStart `pulumi:"backupWindowStart"`
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	DeletionProtection *bool `pulumi:"deletionProtection"`
	// Description of the Greenplum cluster.
	Description *string `pulumi:"description"`
	// Deployment environment of the Greenplum cluster. (PRODUCTION, PRESTABLE)
	Environment string `pulumi:"environment"`
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// Greenplum cluster config. Detail info in "Greenplum cluster settings" section (documented below).
	GreenplumConfig map[string]string `pulumi:"greenplumConfig"`
	// A set of key/value label pairs to assign to the Greenplum cluster.
	Labels map[string]string `pulumi:"labels"`
	// Maintenance policy of the Greenplum cluster. The structure is documented below.
	MaintenanceWindow *MdbGreenplumClusterMaintenanceWindow `pulumi:"maintenanceWindow"`
	// Number of hosts in master subcluster (1 or 2).
	MasterHostCount int `pulumi:"masterHostCount"`
	// Settings for master subcluster. The structure is documented below.
	MasterSubcluster MdbGreenplumClusterMasterSubcluster `pulumi:"masterSubcluster"`
	// Name of the Greenplum cluster. Provided by the client when the cluster is created.
	Name *string `pulumi:"name"`
	// ID of the network, to which the Greenplum cluster uses.
	NetworkId string `pulumi:"networkId"`
	// Configuration of the connection pooler. The structure is documented below.
	PoolerConfig *MdbGreenplumClusterPoolerConfig `pulumi:"poolerConfig"`
	// A set of ids of security groups assigned to hosts of the cluster.
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// Number of hosts in segment subcluster (from 1 to 32).
	SegmentHostCount int `pulumi:"segmentHostCount"`
	// Number of segments on segment host (not more then 1 + RAM/8).
	SegmentInHost int `pulumi:"segmentInHost"`
	// Settings for segment subcluster. The structure is documented below.
	SegmentSubcluster MdbGreenplumClusterSegmentSubcluster `pulumi:"segmentSubcluster"`
	// The ID of the subnet, to which the hosts belongs. The subnet must be a part of the network to which the cluster belongs.
	SubnetId string `pulumi:"subnetId"`
	// Greenplum cluster admin user name.
	UserName string `pulumi:"userName"`
	// Greenplum cluster admin password name.
	UserPassword string `pulumi:"userPassword"`
	// Version of the Greenplum cluster. (6.19)
	Version string `pulumi:"version"`
	// The availability zone where the Greenplum hosts will be created.
	Zone string `pulumi:"zone"`
}

// The set of arguments for constructing a MdbGreenplumCluster resource.
type MdbGreenplumClusterArgs struct {
	// Access policy to the Greenplum cluster. The structure is documented below.
	Access MdbGreenplumClusterAccessPtrInput
	// Sets whether the master hosts should get a public IP address on creation. Changing this parameter for an existing host is not supported at the moment.
	AssignPublicIp pulumi.BoolInput
	// Time to start the daily backup, in the UTC timezone. The structure is documented below.
	BackupWindowStart MdbGreenplumClusterBackupWindowStartPtrInput
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	DeletionProtection pulumi.BoolPtrInput
	// Description of the Greenplum cluster.
	Description pulumi.StringPtrInput
	// Deployment environment of the Greenplum cluster. (PRODUCTION, PRESTABLE)
	Environment pulumi.StringInput
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// Greenplum cluster config. Detail info in "Greenplum cluster settings" section (documented below).
	GreenplumConfig pulumi.StringMapInput
	// A set of key/value label pairs to assign to the Greenplum cluster.
	Labels pulumi.StringMapInput
	// Maintenance policy of the Greenplum cluster. The structure is documented below.
	MaintenanceWindow MdbGreenplumClusterMaintenanceWindowPtrInput
	// Number of hosts in master subcluster (1 or 2).
	MasterHostCount pulumi.IntInput
	// Settings for master subcluster. The structure is documented below.
	MasterSubcluster MdbGreenplumClusterMasterSubclusterInput
	// Name of the Greenplum cluster. Provided by the client when the cluster is created.
	Name pulumi.StringPtrInput
	// ID of the network, to which the Greenplum cluster uses.
	NetworkId pulumi.StringInput
	// Configuration of the connection pooler. The structure is documented below.
	PoolerConfig MdbGreenplumClusterPoolerConfigPtrInput
	// A set of ids of security groups assigned to hosts of the cluster.
	SecurityGroupIds pulumi.StringArrayInput
	// Number of hosts in segment subcluster (from 1 to 32).
	SegmentHostCount pulumi.IntInput
	// Number of segments on segment host (not more then 1 + RAM/8).
	SegmentInHost pulumi.IntInput
	// Settings for segment subcluster. The structure is documented below.
	SegmentSubcluster MdbGreenplumClusterSegmentSubclusterInput
	// The ID of the subnet, to which the hosts belongs. The subnet must be a part of the network to which the cluster belongs.
	SubnetId pulumi.StringInput
	// Greenplum cluster admin user name.
	UserName pulumi.StringInput
	// Greenplum cluster admin password name.
	UserPassword pulumi.StringInput
	// Version of the Greenplum cluster. (6.19)
	Version pulumi.StringInput
	// The availability zone where the Greenplum hosts will be created.
	Zone pulumi.StringInput
}

func (MdbGreenplumClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbGreenplumClusterArgs)(nil)).Elem()
}

type MdbGreenplumClusterInput interface {
	pulumi.Input

	ToMdbGreenplumClusterOutput() MdbGreenplumClusterOutput
	ToMdbGreenplumClusterOutputWithContext(ctx context.Context) MdbGreenplumClusterOutput
}

func (*MdbGreenplumCluster) ElementType() reflect.Type {
	return reflect.TypeOf((**MdbGreenplumCluster)(nil)).Elem()
}

func (i *MdbGreenplumCluster) ToMdbGreenplumClusterOutput() MdbGreenplumClusterOutput {
	return i.ToMdbGreenplumClusterOutputWithContext(context.Background())
}

func (i *MdbGreenplumCluster) ToMdbGreenplumClusterOutputWithContext(ctx context.Context) MdbGreenplumClusterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbGreenplumClusterOutput)
}

// MdbGreenplumClusterArrayInput is an input type that accepts MdbGreenplumClusterArray and MdbGreenplumClusterArrayOutput values.
// You can construct a concrete instance of `MdbGreenplumClusterArrayInput` via:
//
//          MdbGreenplumClusterArray{ MdbGreenplumClusterArgs{...} }
type MdbGreenplumClusterArrayInput interface {
	pulumi.Input

	ToMdbGreenplumClusterArrayOutput() MdbGreenplumClusterArrayOutput
	ToMdbGreenplumClusterArrayOutputWithContext(context.Context) MdbGreenplumClusterArrayOutput
}

type MdbGreenplumClusterArray []MdbGreenplumClusterInput

func (MdbGreenplumClusterArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MdbGreenplumCluster)(nil)).Elem()
}

func (i MdbGreenplumClusterArray) ToMdbGreenplumClusterArrayOutput() MdbGreenplumClusterArrayOutput {
	return i.ToMdbGreenplumClusterArrayOutputWithContext(context.Background())
}

func (i MdbGreenplumClusterArray) ToMdbGreenplumClusterArrayOutputWithContext(ctx context.Context) MdbGreenplumClusterArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbGreenplumClusterArrayOutput)
}

// MdbGreenplumClusterMapInput is an input type that accepts MdbGreenplumClusterMap and MdbGreenplumClusterMapOutput values.
// You can construct a concrete instance of `MdbGreenplumClusterMapInput` via:
//
//          MdbGreenplumClusterMap{ "key": MdbGreenplumClusterArgs{...} }
type MdbGreenplumClusterMapInput interface {
	pulumi.Input

	ToMdbGreenplumClusterMapOutput() MdbGreenplumClusterMapOutput
	ToMdbGreenplumClusterMapOutputWithContext(context.Context) MdbGreenplumClusterMapOutput
}

type MdbGreenplumClusterMap map[string]MdbGreenplumClusterInput

func (MdbGreenplumClusterMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MdbGreenplumCluster)(nil)).Elem()
}

func (i MdbGreenplumClusterMap) ToMdbGreenplumClusterMapOutput() MdbGreenplumClusterMapOutput {
	return i.ToMdbGreenplumClusterMapOutputWithContext(context.Background())
}

func (i MdbGreenplumClusterMap) ToMdbGreenplumClusterMapOutputWithContext(ctx context.Context) MdbGreenplumClusterMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbGreenplumClusterMapOutput)
}

type MdbGreenplumClusterOutput struct{ *pulumi.OutputState }

func (MdbGreenplumClusterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MdbGreenplumCluster)(nil)).Elem()
}

func (o MdbGreenplumClusterOutput) ToMdbGreenplumClusterOutput() MdbGreenplumClusterOutput {
	return o
}

func (o MdbGreenplumClusterOutput) ToMdbGreenplumClusterOutputWithContext(ctx context.Context) MdbGreenplumClusterOutput {
	return o
}

// Access policy to the Greenplum cluster. The structure is documented below.
func (o MdbGreenplumClusterOutput) Access() MdbGreenplumClusterAccessOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) MdbGreenplumClusterAccessOutput { return v.Access }).(MdbGreenplumClusterAccessOutput)
}

// Sets whether the master hosts should get a public IP address on creation. Changing this parameter for an existing host is not supported at the moment.
func (o MdbGreenplumClusterOutput) AssignPublicIp() pulumi.BoolOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.BoolOutput { return v.AssignPublicIp }).(pulumi.BoolOutput)
}

// Time to start the daily backup, in the UTC timezone. The structure is documented below.
func (o MdbGreenplumClusterOutput) BackupWindowStart() MdbGreenplumClusterBackupWindowStartOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) MdbGreenplumClusterBackupWindowStartOutput { return v.BackupWindowStart }).(MdbGreenplumClusterBackupWindowStartOutput)
}

// Creation timestamp of the cluster.
func (o MdbGreenplumClusterOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// Inhibits deletion of the cluster.  Can be either `true` or `false`.
func (o MdbGreenplumClusterOutput) DeletionProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.BoolOutput { return v.DeletionProtection }).(pulumi.BoolOutput)
}

// Description of the Greenplum cluster.
func (o MdbGreenplumClusterOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Deployment environment of the Greenplum cluster. (PRODUCTION, PRESTABLE)
func (o MdbGreenplumClusterOutput) Environment() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringOutput { return v.Environment }).(pulumi.StringOutput)
}

// The ID of the folder that the resource belongs to. If it
// is not provided, the default provider folder is used.
func (o MdbGreenplumClusterOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

// Greenplum cluster config. Detail info in "Greenplum cluster settings" section (documented below).
func (o MdbGreenplumClusterOutput) GreenplumConfig() pulumi.StringMapOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringMapOutput { return v.GreenplumConfig }).(pulumi.StringMapOutput)
}

// Aggregated health of the cluster.
func (o MdbGreenplumClusterOutput) Health() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringOutput { return v.Health }).(pulumi.StringOutput)
}

// A set of key/value label pairs to assign to the Greenplum cluster.
func (o MdbGreenplumClusterOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// Maintenance policy of the Greenplum cluster. The structure is documented below.
func (o MdbGreenplumClusterOutput) MaintenanceWindow() MdbGreenplumClusterMaintenanceWindowOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) MdbGreenplumClusterMaintenanceWindowOutput { return v.MaintenanceWindow }).(MdbGreenplumClusterMaintenanceWindowOutput)
}

// Number of hosts in master subcluster (1 or 2).
func (o MdbGreenplumClusterOutput) MasterHostCount() pulumi.IntOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.IntOutput { return v.MasterHostCount }).(pulumi.IntOutput)
}

// (Computed) Info about hosts in master subcluster. The structure is documented below.
func (o MdbGreenplumClusterOutput) MasterHosts() MdbGreenplumClusterMasterHostArrayOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) MdbGreenplumClusterMasterHostArrayOutput { return v.MasterHosts }).(MdbGreenplumClusterMasterHostArrayOutput)
}

// Settings for master subcluster. The structure is documented below.
func (o MdbGreenplumClusterOutput) MasterSubcluster() MdbGreenplumClusterMasterSubclusterOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) MdbGreenplumClusterMasterSubclusterOutput { return v.MasterSubcluster }).(MdbGreenplumClusterMasterSubclusterOutput)
}

// Name of the Greenplum cluster. Provided by the client when the cluster is created.
func (o MdbGreenplumClusterOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// ID of the network, to which the Greenplum cluster uses.
func (o MdbGreenplumClusterOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringOutput { return v.NetworkId }).(pulumi.StringOutput)
}

// Configuration of the connection pooler. The structure is documented below.
func (o MdbGreenplumClusterOutput) PoolerConfig() MdbGreenplumClusterPoolerConfigOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) MdbGreenplumClusterPoolerConfigOutput { return v.PoolerConfig }).(MdbGreenplumClusterPoolerConfigOutput)
}

// A set of ids of security groups assigned to hosts of the cluster.
func (o MdbGreenplumClusterOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringArrayOutput { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

// Number of hosts in segment subcluster (from 1 to 32).
func (o MdbGreenplumClusterOutput) SegmentHostCount() pulumi.IntOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.IntOutput { return v.SegmentHostCount }).(pulumi.IntOutput)
}

// (Computed) Info about hosts in segment subcluster. The structure is documented below.
func (o MdbGreenplumClusterOutput) SegmentHosts() MdbGreenplumClusterSegmentHostArrayOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) MdbGreenplumClusterSegmentHostArrayOutput { return v.SegmentHosts }).(MdbGreenplumClusterSegmentHostArrayOutput)
}

// Number of segments on segment host (not more then 1 + RAM/8).
func (o MdbGreenplumClusterOutput) SegmentInHost() pulumi.IntOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.IntOutput { return v.SegmentInHost }).(pulumi.IntOutput)
}

// Settings for segment subcluster. The structure is documented below.
func (o MdbGreenplumClusterOutput) SegmentSubcluster() MdbGreenplumClusterSegmentSubclusterOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) MdbGreenplumClusterSegmentSubclusterOutput { return v.SegmentSubcluster }).(MdbGreenplumClusterSegmentSubclusterOutput)
}

// Status of the cluster.
func (o MdbGreenplumClusterOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

// The ID of the subnet, to which the hosts belongs. The subnet must be a part of the network to which the cluster belongs.
func (o MdbGreenplumClusterOutput) SubnetId() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringOutput { return v.SubnetId }).(pulumi.StringOutput)
}

// Greenplum cluster admin user name.
func (o MdbGreenplumClusterOutput) UserName() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringOutput { return v.UserName }).(pulumi.StringOutput)
}

// Greenplum cluster admin password name.
func (o MdbGreenplumClusterOutput) UserPassword() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringOutput { return v.UserPassword }).(pulumi.StringOutput)
}

// Version of the Greenplum cluster. (6.19)
func (o MdbGreenplumClusterOutput) Version() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringOutput { return v.Version }).(pulumi.StringOutput)
}

// The availability zone where the Greenplum hosts will be created.
func (o MdbGreenplumClusterOutput) Zone() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbGreenplumCluster) pulumi.StringOutput { return v.Zone }).(pulumi.StringOutput)
}

type MdbGreenplumClusterArrayOutput struct{ *pulumi.OutputState }

func (MdbGreenplumClusterArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MdbGreenplumCluster)(nil)).Elem()
}

func (o MdbGreenplumClusterArrayOutput) ToMdbGreenplumClusterArrayOutput() MdbGreenplumClusterArrayOutput {
	return o
}

func (o MdbGreenplumClusterArrayOutput) ToMdbGreenplumClusterArrayOutputWithContext(ctx context.Context) MdbGreenplumClusterArrayOutput {
	return o
}

func (o MdbGreenplumClusterArrayOutput) Index(i pulumi.IntInput) MdbGreenplumClusterOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MdbGreenplumCluster {
		return vs[0].([]*MdbGreenplumCluster)[vs[1].(int)]
	}).(MdbGreenplumClusterOutput)
}

type MdbGreenplumClusterMapOutput struct{ *pulumi.OutputState }

func (MdbGreenplumClusterMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MdbGreenplumCluster)(nil)).Elem()
}

func (o MdbGreenplumClusterMapOutput) ToMdbGreenplumClusterMapOutput() MdbGreenplumClusterMapOutput {
	return o
}

func (o MdbGreenplumClusterMapOutput) ToMdbGreenplumClusterMapOutputWithContext(ctx context.Context) MdbGreenplumClusterMapOutput {
	return o
}

func (o MdbGreenplumClusterMapOutput) MapIndex(k pulumi.StringInput) MdbGreenplumClusterOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MdbGreenplumCluster {
		return vs[0].(map[string]*MdbGreenplumCluster)[vs[1].(string)]
	}).(MdbGreenplumClusterOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MdbGreenplumClusterInput)(nil)).Elem(), &MdbGreenplumCluster{})
	pulumi.RegisterInputType(reflect.TypeOf((*MdbGreenplumClusterArrayInput)(nil)).Elem(), MdbGreenplumClusterArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MdbGreenplumClusterMapInput)(nil)).Elem(), MdbGreenplumClusterMap{})
	pulumi.RegisterOutputType(MdbGreenplumClusterOutput{})
	pulumi.RegisterOutputType(MdbGreenplumClusterArrayOutput{})
	pulumi.RegisterOutputType(MdbGreenplumClusterMapOutput{})
}
