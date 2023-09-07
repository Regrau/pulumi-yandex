// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Manages a Data Proc cluster. For more information, see [the official documentation](https://cloud.yandex.com/docs/data-proc/).
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"fmt"
// 	"io/ioutil"
//
// 	"github.com/pulumi/pulumi-yandex/sdk/go/yandex"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func readFileOrPanic(path string) pulumi.StringPtrInput {
// 	data, err := ioutil.ReadFile(path)
// 	if err != nil {
// 		panic(err.Error())
// 	}
// 	return pulumi.String(string(data))
// }
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		fooVpcNetwork, err := yandex.NewVpcNetwork(ctx, "fooVpcNetwork", nil)
// 		if err != nil {
// 			return err
// 		}
// 		fooVpcSubnet, err := yandex.NewVpcSubnet(ctx, "fooVpcSubnet", &yandex.VpcSubnetArgs{
// 			Zone:      pulumi.String("ru-central1-b"),
// 			NetworkId: fooVpcNetwork.ID(),
// 			V4CidrBlocks: pulumi.StringArray{
// 				pulumi.String("10.1.0.0/24"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		dataprocIamServiceAccount, err := yandex.NewIamServiceAccount(ctx, "dataprocIamServiceAccount", &yandex.IamServiceAccountArgs{
// 			Description: pulumi.String("service account to manage Dataproc Cluster"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		fooResourcemanagerFolder, err := yandex.LookupResourcemanagerFolder(ctx, &GetResourcemanagerFolderArgs{
// 			FolderId: pulumi.StringRef("some_folder_id"),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		dataprocResourcemanagerFolderIamBinding, err := yandex.NewResourcemanagerFolderIamBinding(ctx, "dataprocResourcemanagerFolderIamBinding", &yandex.ResourcemanagerFolderIamBindingArgs{
// 			FolderId: pulumi.String(fooResourcemanagerFolder.Id),
// 			Role:     pulumi.String("mdb.dataproc.agent"),
// 			Members: pulumi.StringArray{
// 				dataprocIamServiceAccount.ID().ApplyT(func(id string) (string, error) {
// 					return fmt.Sprintf("serviceAccount:%v", id), nil
// 				}).(pulumi.StringOutput),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = yandex.NewResourcemanagerFolderIamBinding(ctx, "bucket-creator", &yandex.ResourcemanagerFolderIamBindingArgs{
// 			FolderId: pulumi.String(fooResourcemanagerFolder.Id),
// 			Role:     pulumi.String("editor"),
// 			Members: pulumi.StringArray{
// 				dataprocIamServiceAccount.ID().ApplyT(func(id string) (string, error) {
// 					return fmt.Sprintf("serviceAccount:%v", id), nil
// 				}).(pulumi.StringOutput),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		fooIamServiceAccountStaticAccessKey, err := yandex.NewIamServiceAccountStaticAccessKey(ctx, "fooIamServiceAccountStaticAccessKey", &yandex.IamServiceAccountStaticAccessKeyArgs{
// 			ServiceAccountId: dataprocIamServiceAccount.ID(),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		fooStorageBucket, err := yandex.NewStorageBucket(ctx, "fooStorageBucket", &yandex.StorageBucketArgs{
// 			Bucket:    pulumi.String("foo"),
// 			AccessKey: fooIamServiceAccountStaticAccessKey.AccessKey,
// 			SecretKey: fooIamServiceAccountStaticAccessKey.SecretKey,
// 		}, pulumi.DependsOn([]pulumi.Resource{
// 			bucket_creator,
// 		}))
// 		if err != nil {
// 			return err
// 		}
// 		_, err = yandex.NewDataprocCluster(ctx, "fooDataprocCluster", &yandex.DataprocClusterArgs{
// 			Bucket:      fooStorageBucket.Bucket,
// 			Description: pulumi.String("Dataproc Cluster created by Terraform"),
// 			Labels: pulumi.StringMap{
// 				"created_by": pulumi.String("terraform"),
// 			},
// 			ServiceAccountId: dataprocIamServiceAccount.ID(),
// 			ZoneId:           pulumi.String("ru-central1-b"),
// 			ClusterConfig: &DataprocClusterClusterConfigArgs{
// 				Hadoop: &DataprocClusterClusterConfigHadoopArgs{
// 					Services: pulumi.StringArray{
// 						pulumi.String("HDFS"),
// 						pulumi.String("YARN"),
// 						pulumi.String("SPARK"),
// 						pulumi.String("TEZ"),
// 						pulumi.String("MAPREDUCE"),
// 						pulumi.String("HIVE"),
// 					},
// 					Properties: pulumi.StringMap{
// 						"yarn:yarn.resourcemanager.am.max-attempts": pulumi.String("5"),
// 					},
// 					SshPublicKeys: pulumi.StringArray{
// 						readFileOrPanic("~/.ssh/id_rsa.pub"),
// 					},
// 				},
// 				SubclusterSpecs: DataprocClusterClusterConfigSubclusterSpecArray{
// 					&DataprocClusterClusterConfigSubclusterSpecArgs{
// 						Name: pulumi.String("main"),
// 						Role: pulumi.String("MASTERNODE"),
// 						Resources: &DataprocClusterClusterConfigSubclusterSpecResourcesArgs{
// 							ResourcePresetId: pulumi.String("s2.small"),
// 							DiskTypeId:       pulumi.String("network-hdd"),
// 							DiskSize:         pulumi.Int(20),
// 						},
// 						SubnetId:   fooVpcSubnet.ID(),
// 						HostsCount: pulumi.Int(1),
// 					},
// 					&DataprocClusterClusterConfigSubclusterSpecArgs{
// 						Name: pulumi.String("data"),
// 						Role: pulumi.String("DATANODE"),
// 						Resources: &DataprocClusterClusterConfigSubclusterSpecResourcesArgs{
// 							ResourcePresetId: pulumi.String("s2.small"),
// 							DiskTypeId:       pulumi.String("network-hdd"),
// 							DiskSize:         pulumi.Int(20),
// 						},
// 						SubnetId:   fooVpcSubnet.ID(),
// 						HostsCount: pulumi.Int(2),
// 					},
// 					&DataprocClusterClusterConfigSubclusterSpecArgs{
// 						Name: pulumi.String("compute"),
// 						Role: pulumi.String("COMPUTENODE"),
// 						Resources: &DataprocClusterClusterConfigSubclusterSpecResourcesArgs{
// 							ResourcePresetId: pulumi.String("s2.small"),
// 							DiskTypeId:       pulumi.String("network-hdd"),
// 							DiskSize:         pulumi.Int(20),
// 						},
// 						SubnetId:   fooVpcSubnet.ID(),
// 						HostsCount: pulumi.Int(2),
// 					},
// 					&DataprocClusterClusterConfigSubclusterSpecArgs{
// 						Name: pulumi.String("compute_autoscaling"),
// 						Role: pulumi.String("COMPUTENODE"),
// 						Resources: &DataprocClusterClusterConfigSubclusterSpecResourcesArgs{
// 							ResourcePresetId: pulumi.String("s2.small"),
// 							DiskTypeId:       pulumi.String("network-hdd"),
// 							DiskSize:         pulumi.Int(20),
// 						},
// 						SubnetId:   fooVpcSubnet.ID(),
// 						HostsCount: pulumi.Int(2),
// 						AutoscalingConfig: &DataprocClusterClusterConfigSubclusterSpecAutoscalingConfigArgs{
// 							MaxHostsCount:         pulumi.Int(10),
// 							MeasurementDuration:   pulumi.Int(60),
// 							WarmupDuration:        pulumi.Int(60),
// 							StabilizationDuration: pulumi.Int(120),
// 							Preemptible:           pulumi.Bool(false),
// 							DecommissionTimeout:   pulumi.Int(60),
// 						},
// 					},
// 				},
// 			},
// 		}, pulumi.DependsOn([]pulumi.Resource{
// 			dataprocResourcemanagerFolderIamBinding,
// 		}))
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// A cluster can be imported using the `id` of the resource, e.g.
//
// ```sh
//  $ pulumi import yandex:index/dataprocCluster:DataprocCluster foo cluster_id
// ```
type DataprocCluster struct {
	pulumi.CustomResourceState

	// Name of the Object Storage bucket to use for Data Proc jobs. Data Proc Agent saves output of job driver's process to specified bucket. In order for this to work service account (specified by the `serviceAccountId` argument) should be given permission to create objects within this bucket.
	Bucket pulumi.StringPtrOutput `pulumi:"bucket"`
	// Configuration and resources for hosts that should be created with the cluster. The structure is documented below.
	ClusterConfig DataprocClusterClusterConfigOutput `pulumi:"clusterConfig"`
	// (Computed) The Data Proc cluster creation timestamp.
	// * `cluster_config.0.subcluster_spec.X.id` - (Computed) ID of the subcluster.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	DeletionProtection pulumi.BoolOutput `pulumi:"deletionProtection"`
	// Description of the Data Proc cluster.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// ID of the folder to create a cluster in. If it is not provided, the default provider folder is used.
	FolderId pulumi.StringOutput `pulumi:"folderId"`
	// A list of host group IDs to place VMs of the cluster on.
	HostGroupIds pulumi.StringArrayOutput `pulumi:"hostGroupIds"`
	// A set of key/value label pairs to assign to the Data Proc cluster.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Name of the Data Proc subcluster.
	Name pulumi.StringOutput `pulumi:"name"`
	// A list of security group IDs that the cluster belongs to.
	SecurityGroupIds pulumi.StringArrayOutput `pulumi:"securityGroupIds"`
	// Service account to be used by the Data Proc agent to access resources of Yandex.Cloud. Selected service account should have `mdb.dataproc.agent` role on the folder where the Data Proc cluster will be located.
	ServiceAccountId pulumi.StringOutput `pulumi:"serviceAccountId"`
	// Whether to enable UI Proxy feature.
	UiProxy pulumi.BoolPtrOutput `pulumi:"uiProxy"`
	// ID of the availability zone to create cluster in. If it is not provided, the default provider zone is used.
	ZoneId pulumi.StringOutput `pulumi:"zoneId"`
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
	opts = pkgResourceDefaultOpts(opts)
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
	// Name of the Object Storage bucket to use for Data Proc jobs. Data Proc Agent saves output of job driver's process to specified bucket. In order for this to work service account (specified by the `serviceAccountId` argument) should be given permission to create objects within this bucket.
	Bucket *string `pulumi:"bucket"`
	// Configuration and resources for hosts that should be created with the cluster. The structure is documented below.
	ClusterConfig *DataprocClusterClusterConfig `pulumi:"clusterConfig"`
	// (Computed) The Data Proc cluster creation timestamp.
	// * `cluster_config.0.subcluster_spec.X.id` - (Computed) ID of the subcluster.
	CreatedAt *string `pulumi:"createdAt"`
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	DeletionProtection *bool `pulumi:"deletionProtection"`
	// Description of the Data Proc cluster.
	Description *string `pulumi:"description"`
	// ID of the folder to create a cluster in. If it is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// A list of host group IDs to place VMs of the cluster on.
	HostGroupIds []string `pulumi:"hostGroupIds"`
	// A set of key/value label pairs to assign to the Data Proc cluster.
	Labels map[string]string `pulumi:"labels"`
	// Name of the Data Proc subcluster.
	Name *string `pulumi:"name"`
	// A list of security group IDs that the cluster belongs to.
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// Service account to be used by the Data Proc agent to access resources of Yandex.Cloud. Selected service account should have `mdb.dataproc.agent` role on the folder where the Data Proc cluster will be located.
	ServiceAccountId *string `pulumi:"serviceAccountId"`
	// Whether to enable UI Proxy feature.
	UiProxy *bool `pulumi:"uiProxy"`
	// ID of the availability zone to create cluster in. If it is not provided, the default provider zone is used.
	ZoneId *string `pulumi:"zoneId"`
}

type DataprocClusterState struct {
	// Name of the Object Storage bucket to use for Data Proc jobs. Data Proc Agent saves output of job driver's process to specified bucket. In order for this to work service account (specified by the `serviceAccountId` argument) should be given permission to create objects within this bucket.
	Bucket pulumi.StringPtrInput
	// Configuration and resources for hosts that should be created with the cluster. The structure is documented below.
	ClusterConfig DataprocClusterClusterConfigPtrInput
	// (Computed) The Data Proc cluster creation timestamp.
	// * `cluster_config.0.subcluster_spec.X.id` - (Computed) ID of the subcluster.
	CreatedAt pulumi.StringPtrInput
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	DeletionProtection pulumi.BoolPtrInput
	// Description of the Data Proc cluster.
	Description pulumi.StringPtrInput
	// ID of the folder to create a cluster in. If it is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// A list of host group IDs to place VMs of the cluster on.
	HostGroupIds pulumi.StringArrayInput
	// A set of key/value label pairs to assign to the Data Proc cluster.
	Labels pulumi.StringMapInput
	// Name of the Data Proc subcluster.
	Name pulumi.StringPtrInput
	// A list of security group IDs that the cluster belongs to.
	SecurityGroupIds pulumi.StringArrayInput
	// Service account to be used by the Data Proc agent to access resources of Yandex.Cloud. Selected service account should have `mdb.dataproc.agent` role on the folder where the Data Proc cluster will be located.
	ServiceAccountId pulumi.StringPtrInput
	// Whether to enable UI Proxy feature.
	UiProxy pulumi.BoolPtrInput
	// ID of the availability zone to create cluster in. If it is not provided, the default provider zone is used.
	ZoneId pulumi.StringPtrInput
}

func (DataprocClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*dataprocClusterState)(nil)).Elem()
}

type dataprocClusterArgs struct {
	// Name of the Object Storage bucket to use for Data Proc jobs. Data Proc Agent saves output of job driver's process to specified bucket. In order for this to work service account (specified by the `serviceAccountId` argument) should be given permission to create objects within this bucket.
	Bucket *string `pulumi:"bucket"`
	// Configuration and resources for hosts that should be created with the cluster. The structure is documented below.
	ClusterConfig DataprocClusterClusterConfig `pulumi:"clusterConfig"`
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	DeletionProtection *bool `pulumi:"deletionProtection"`
	// Description of the Data Proc cluster.
	Description *string `pulumi:"description"`
	// ID of the folder to create a cluster in. If it is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// A list of host group IDs to place VMs of the cluster on.
	HostGroupIds []string `pulumi:"hostGroupIds"`
	// A set of key/value label pairs to assign to the Data Proc cluster.
	Labels map[string]string `pulumi:"labels"`
	// Name of the Data Proc subcluster.
	Name *string `pulumi:"name"`
	// A list of security group IDs that the cluster belongs to.
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// Service account to be used by the Data Proc agent to access resources of Yandex.Cloud. Selected service account should have `mdb.dataproc.agent` role on the folder where the Data Proc cluster will be located.
	ServiceAccountId string `pulumi:"serviceAccountId"`
	// Whether to enable UI Proxy feature.
	UiProxy *bool `pulumi:"uiProxy"`
	// ID of the availability zone to create cluster in. If it is not provided, the default provider zone is used.
	ZoneId *string `pulumi:"zoneId"`
}

// The set of arguments for constructing a DataprocCluster resource.
type DataprocClusterArgs struct {
	// Name of the Object Storage bucket to use for Data Proc jobs. Data Proc Agent saves output of job driver's process to specified bucket. In order for this to work service account (specified by the `serviceAccountId` argument) should be given permission to create objects within this bucket.
	Bucket pulumi.StringPtrInput
	// Configuration and resources for hosts that should be created with the cluster. The structure is documented below.
	ClusterConfig DataprocClusterClusterConfigInput
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	DeletionProtection pulumi.BoolPtrInput
	// Description of the Data Proc cluster.
	Description pulumi.StringPtrInput
	// ID of the folder to create a cluster in. If it is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// A list of host group IDs to place VMs of the cluster on.
	HostGroupIds pulumi.StringArrayInput
	// A set of key/value label pairs to assign to the Data Proc cluster.
	Labels pulumi.StringMapInput
	// Name of the Data Proc subcluster.
	Name pulumi.StringPtrInput
	// A list of security group IDs that the cluster belongs to.
	SecurityGroupIds pulumi.StringArrayInput
	// Service account to be used by the Data Proc agent to access resources of Yandex.Cloud. Selected service account should have `mdb.dataproc.agent` role on the folder where the Data Proc cluster will be located.
	ServiceAccountId pulumi.StringInput
	// Whether to enable UI Proxy feature.
	UiProxy pulumi.BoolPtrInput
	// ID of the availability zone to create cluster in. If it is not provided, the default provider zone is used.
	ZoneId pulumi.StringPtrInput
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
//          DataprocClusterArray{ DataprocClusterArgs{...} }
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
//          DataprocClusterMap{ "key": DataprocClusterArgs{...} }
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

// Name of the Object Storage bucket to use for Data Proc jobs. Data Proc Agent saves output of job driver's process to specified bucket. In order for this to work service account (specified by the `serviceAccountId` argument) should be given permission to create objects within this bucket.
func (o DataprocClusterOutput) Bucket() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringPtrOutput { return v.Bucket }).(pulumi.StringPtrOutput)
}

// Configuration and resources for hosts that should be created with the cluster. The structure is documented below.
func (o DataprocClusterOutput) ClusterConfig() DataprocClusterClusterConfigOutput {
	return o.ApplyT(func(v *DataprocCluster) DataprocClusterClusterConfigOutput { return v.ClusterConfig }).(DataprocClusterClusterConfigOutput)
}

// (Computed) The Data Proc cluster creation timestamp.
// * `cluster_config.0.subcluster_spec.X.id` - (Computed) ID of the subcluster.
func (o DataprocClusterOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// Inhibits deletion of the cluster.  Can be either `true` or `false`.
func (o DataprocClusterOutput) DeletionProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.BoolOutput { return v.DeletionProtection }).(pulumi.BoolOutput)
}

// Description of the Data Proc cluster.
func (o DataprocClusterOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// ID of the folder to create a cluster in. If it is not provided, the default provider folder is used.
func (o DataprocClusterOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

// A list of host group IDs to place VMs of the cluster on.
func (o DataprocClusterOutput) HostGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringArrayOutput { return v.HostGroupIds }).(pulumi.StringArrayOutput)
}

// A set of key/value label pairs to assign to the Data Proc cluster.
func (o DataprocClusterOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// Name of the Data Proc subcluster.
func (o DataprocClusterOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// A list of security group IDs that the cluster belongs to.
func (o DataprocClusterOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringArrayOutput { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

// Service account to be used by the Data Proc agent to access resources of Yandex.Cloud. Selected service account should have `mdb.dataproc.agent` role on the folder where the Data Proc cluster will be located.
func (o DataprocClusterOutput) ServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.StringOutput { return v.ServiceAccountId }).(pulumi.StringOutput)
}

// Whether to enable UI Proxy feature.
func (o DataprocClusterOutput) UiProxy() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DataprocCluster) pulumi.BoolPtrOutput { return v.UiProxy }).(pulumi.BoolPtrOutput)
}

// ID of the availability zone to create cluster in. If it is not provided, the default provider zone is used.
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
