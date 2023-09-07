// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Manages a MySQL database within the Yandex.Cloud. For more information, see
// [the official documentation](https://cloud.yandex.com/docs/managed-mysql/).
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-yandex/sdk/go/yandex"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		fooVpcNetwork, err := yandex.NewVpcNetwork(ctx, "fooVpcNetwork", nil)
// 		if err != nil {
// 			return err
// 		}
// 		fooVpcSubnet, err := yandex.NewVpcSubnet(ctx, "fooVpcSubnet", &yandex.VpcSubnetArgs{
// 			Zone:      pulumi.String("ru-central1-a"),
// 			NetworkId: fooVpcNetwork.ID(),
// 			V4CidrBlocks: pulumi.StringArray{
// 				pulumi.String("10.5.0.0/24"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		fooMdbMysqlCluster, err := yandex.NewMdbMysqlCluster(ctx, "fooMdbMysqlCluster", &yandex.MdbMysqlClusterArgs{
// 			Environment: pulumi.String("PRESTABLE"),
// 			NetworkId:   fooVpcNetwork.ID(),
// 			Version:     pulumi.String("8.0"),
// 			Resources: &MdbMysqlClusterResourcesArgs{
// 				ResourcePresetId: pulumi.String("s2.micro"),
// 				DiskTypeId:       pulumi.String("network-ssd"),
// 				DiskSize:         pulumi.Int(16),
// 			},
// 			Hosts: MdbMysqlClusterHostArray{
// 				&MdbMysqlClusterHostArgs{
// 					Zone:     pulumi.String("ru-central1-a"),
// 					SubnetId: fooVpcSubnet.ID(),
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = yandex.NewmdbMysqlDatabase(ctx, "foomdbMysqlDatabase", &yandex.mdbMysqlDatabaseArgs{
// 			ClusterId: fooMdbMysqlCluster.ID(),
// 		})
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
// A MySQL database can be imported using the following format
//
// ```sh
//  $ pulumi import yandex:index/mdbMysqlDatabase:mdbMysqlDatabase foo {{cluster_id}}:{{database_name}}
// ```
type MdbMysqlDatabase struct {
	pulumi.CustomResourceState

	ClusterId pulumi.StringOutput `pulumi:"clusterId"`
	// The name of the database.
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewMdbMysqlDatabase registers a new resource with the given unique name, arguments, and options.
func NewMdbMysqlDatabase(ctx *pulumi.Context,
	name string, args *MdbMysqlDatabaseArgs, opts ...pulumi.ResourceOption) (*MdbMysqlDatabase, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClusterId == nil {
		return nil, errors.New("invalid value for required argument 'ClusterId'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource MdbMysqlDatabase
	err := ctx.RegisterResource("yandex:index/mdbMysqlDatabase:mdbMysqlDatabase", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMdbMysqlDatabase gets an existing MdbMysqlDatabase resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMdbMysqlDatabase(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MdbMysqlDatabaseState, opts ...pulumi.ResourceOption) (*MdbMysqlDatabase, error) {
	var resource MdbMysqlDatabase
	err := ctx.ReadResource("yandex:index/mdbMysqlDatabase:mdbMysqlDatabase", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MdbMysqlDatabase resources.
type mdbMysqlDatabaseState struct {
	ClusterId *string `pulumi:"clusterId"`
	// The name of the database.
	Name *string `pulumi:"name"`
}

type MdbMysqlDatabaseState struct {
	ClusterId pulumi.StringPtrInput
	// The name of the database.
	Name pulumi.StringPtrInput
}

func (MdbMysqlDatabaseState) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbMysqlDatabaseState)(nil)).Elem()
}

type mdbMysqlDatabaseArgs struct {
	ClusterId string `pulumi:"clusterId"`
	// The name of the database.
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a MdbMysqlDatabase resource.
type MdbMysqlDatabaseArgs struct {
	ClusterId pulumi.StringInput
	// The name of the database.
	Name pulumi.StringPtrInput
}

func (MdbMysqlDatabaseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbMysqlDatabaseArgs)(nil)).Elem()
}

type MdbMysqlDatabaseInput interface {
	pulumi.Input

	ToMdbMysqlDatabaseOutput() MdbMysqlDatabaseOutput
	ToMdbMysqlDatabaseOutputWithContext(ctx context.Context) MdbMysqlDatabaseOutput
}

func (*MdbMysqlDatabase) ElementType() reflect.Type {
	return reflect.TypeOf((**MdbMysqlDatabase)(nil)).Elem()
}

func (i *MdbMysqlDatabase) ToMdbMysqlDatabaseOutput() MdbMysqlDatabaseOutput {
	return i.ToMdbMysqlDatabaseOutputWithContext(context.Background())
}

func (i *MdbMysqlDatabase) ToMdbMysqlDatabaseOutputWithContext(ctx context.Context) MdbMysqlDatabaseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbMysqlDatabaseOutput)
}

// MdbMysqlDatabaseArrayInput is an input type that accepts MdbMysqlDatabaseArray and MdbMysqlDatabaseArrayOutput values.
// You can construct a concrete instance of `MdbMysqlDatabaseArrayInput` via:
//
//          MdbMysqlDatabaseArray{ MdbMysqlDatabaseArgs{...} }
type MdbMysqlDatabaseArrayInput interface {
	pulumi.Input

	ToMdbMysqlDatabaseArrayOutput() MdbMysqlDatabaseArrayOutput
	ToMdbMysqlDatabaseArrayOutputWithContext(context.Context) MdbMysqlDatabaseArrayOutput
}

type MdbMysqlDatabaseArray []MdbMysqlDatabaseInput

func (MdbMysqlDatabaseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MdbMysqlDatabase)(nil)).Elem()
}

func (i MdbMysqlDatabaseArray) ToMdbMysqlDatabaseArrayOutput() MdbMysqlDatabaseArrayOutput {
	return i.ToMdbMysqlDatabaseArrayOutputWithContext(context.Background())
}

func (i MdbMysqlDatabaseArray) ToMdbMysqlDatabaseArrayOutputWithContext(ctx context.Context) MdbMysqlDatabaseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbMysqlDatabaseArrayOutput)
}

// MdbMysqlDatabaseMapInput is an input type that accepts MdbMysqlDatabaseMap and MdbMysqlDatabaseMapOutput values.
// You can construct a concrete instance of `MdbMysqlDatabaseMapInput` via:
//
//          MdbMysqlDatabaseMap{ "key": MdbMysqlDatabaseArgs{...} }
type MdbMysqlDatabaseMapInput interface {
	pulumi.Input

	ToMdbMysqlDatabaseMapOutput() MdbMysqlDatabaseMapOutput
	ToMdbMysqlDatabaseMapOutputWithContext(context.Context) MdbMysqlDatabaseMapOutput
}

type MdbMysqlDatabaseMap map[string]MdbMysqlDatabaseInput

func (MdbMysqlDatabaseMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MdbMysqlDatabase)(nil)).Elem()
}

func (i MdbMysqlDatabaseMap) ToMdbMysqlDatabaseMapOutput() MdbMysqlDatabaseMapOutput {
	return i.ToMdbMysqlDatabaseMapOutputWithContext(context.Background())
}

func (i MdbMysqlDatabaseMap) ToMdbMysqlDatabaseMapOutputWithContext(ctx context.Context) MdbMysqlDatabaseMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbMysqlDatabaseMapOutput)
}

type MdbMysqlDatabaseOutput struct{ *pulumi.OutputState }

func (MdbMysqlDatabaseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MdbMysqlDatabase)(nil)).Elem()
}

func (o MdbMysqlDatabaseOutput) ToMdbMysqlDatabaseOutput() MdbMysqlDatabaseOutput {
	return o
}

func (o MdbMysqlDatabaseOutput) ToMdbMysqlDatabaseOutputWithContext(ctx context.Context) MdbMysqlDatabaseOutput {
	return o
}

func (o MdbMysqlDatabaseOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbMysqlDatabase) pulumi.StringOutput { return v.ClusterId }).(pulumi.StringOutput)
}

// The name of the database.
func (o MdbMysqlDatabaseOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbMysqlDatabase) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

type MdbMysqlDatabaseArrayOutput struct{ *pulumi.OutputState }

func (MdbMysqlDatabaseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MdbMysqlDatabase)(nil)).Elem()
}

func (o MdbMysqlDatabaseArrayOutput) ToMdbMysqlDatabaseArrayOutput() MdbMysqlDatabaseArrayOutput {
	return o
}

func (o MdbMysqlDatabaseArrayOutput) ToMdbMysqlDatabaseArrayOutputWithContext(ctx context.Context) MdbMysqlDatabaseArrayOutput {
	return o
}

func (o MdbMysqlDatabaseArrayOutput) Index(i pulumi.IntInput) MdbMysqlDatabaseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MdbMysqlDatabase {
		return vs[0].([]*MdbMysqlDatabase)[vs[1].(int)]
	}).(MdbMysqlDatabaseOutput)
}

type MdbMysqlDatabaseMapOutput struct{ *pulumi.OutputState }

func (MdbMysqlDatabaseMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MdbMysqlDatabase)(nil)).Elem()
}

func (o MdbMysqlDatabaseMapOutput) ToMdbMysqlDatabaseMapOutput() MdbMysqlDatabaseMapOutput {
	return o
}

func (o MdbMysqlDatabaseMapOutput) ToMdbMysqlDatabaseMapOutputWithContext(ctx context.Context) MdbMysqlDatabaseMapOutput {
	return o
}

func (o MdbMysqlDatabaseMapOutput) MapIndex(k pulumi.StringInput) MdbMysqlDatabaseOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MdbMysqlDatabase {
		return vs[0].(map[string]*MdbMysqlDatabase)[vs[1].(string)]
	}).(MdbMysqlDatabaseOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MdbMysqlDatabaseInput)(nil)).Elem(), &MdbMysqlDatabase{})
	pulumi.RegisterInputType(reflect.TypeOf((*MdbMysqlDatabaseArrayInput)(nil)).Elem(), MdbMysqlDatabaseArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MdbMysqlDatabaseMapInput)(nil)).Elem(), MdbMysqlDatabaseMap{})
	pulumi.RegisterOutputType(MdbMysqlDatabaseOutput{})
	pulumi.RegisterOutputType(MdbMysqlDatabaseArrayOutput{})
	pulumi.RegisterOutputType(MdbMysqlDatabaseMapOutput{})
}
