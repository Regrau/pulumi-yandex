// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Persistent disks are used for data storage and function similarly to physical hard and solid state drives.
//
// A disk can be attached or detached from the virtual machine and can be located locally. A disk can be moved between virtual machines within the same availability zone. Each disk can be attached to only one virtual machine at a time.
//
// For more information about disks in Yandex.Cloud, see:
//
// * [Documentation](https://cloud.yandex.com/docs/compute/concepts/disk)
// * How-to Guides
//   - [Attach and detach a disk](https://cloud.yandex.com/docs/compute/concepts/disk#attach-detach)
//   - [Backup operation](https://cloud.yandex.com/docs/compute/concepts/disk#backup)
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-yandex/sdk/go/yandex"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := yandex.NewComputeDisk(ctx, "default", &yandex.ComputeDiskArgs{
//				ImageId: pulumi.String("ubuntu-16.04-v20180727"),
//				Labels: pulumi.StringMap{
//					"environment": pulumi.String("test"),
//				},
//				Type: pulumi.String("network-ssd"),
//				Zone: pulumi.String("ru-central1-a"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// ### Non-Replicated Disk
//
// **Note**: Non-replicated disks are at the [Preview](https://cloud.yandex.com/docs/overview/concepts/launch-stages)
//
//	stage.
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-yandex/sdk/go/yandex"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			this, err := yandex.NewComputeDiskPlacementGroup(ctx, "this", &yandex.ComputeDiskPlacementGroupArgs{
//				Zone: pulumi.String("ru-central1-b"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = yandex.NewComputeDisk(ctx, "nr", &yandex.ComputeDiskArgs{
//				Size: pulumi.Int(93),
//				Type: pulumi.String("network-ssd-nonreplicated"),
//				Zone: pulumi.String("ru-central1-b"),
//				DiskPlacementPolicy: &ComputeDiskDiskPlacementPolicyArgs{
//					DiskPlacementGroupId: this.ID(),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
//
// ## Import
//
// # A disk can be imported using any of these accepted formats
//
// ```sh
//
//	$ pulumi import yandex:index/computeDisk:ComputeDisk default disk_id
//
// ```
type ComputeDisk struct {
	pulumi.CustomResourceState

	AllowRecreate pulumi.BoolPtrOutput `pulumi:"allowRecreate"`
	// Block size of the disk, specified in bytes.
	BlockSize pulumi.IntPtrOutput `pulumi:"blockSize"`
	// Creation timestamp of the disk.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// -
	// (Optional) Description of the disk. Provide this property when
	// you create a resource.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Disk placement policy configuration. The structure is documented below.
	DiskPlacementPolicy ComputeDiskDiskPlacementPolicyOutput `pulumi:"diskPlacementPolicy"`
	// (Optional) The ID of the folder that the disk belongs to.
	// If it is not provided, the default provider folder is used.
	FolderId pulumi.StringOutput `pulumi:"folderId"`
	// The source image to use for disk creation.
	ImageId pulumi.StringPtrOutput `pulumi:"imageId"`
	// Labels to assign to this disk. A list of key/value pairs.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Name of the disk. Provide this property when
	// you create a resource.
	Name       pulumi.StringOutput      `pulumi:"name"`
	ProductIds pulumi.StringArrayOutput `pulumi:"productIds"`
	// Size of the persistent disk, specified in GB. You can specify this
	// field when creating a persistent disk using the `imageId` or `snapshotId`
	// parameter, or specify it alone to create an empty persistent disk.
	// If you specify this field along with `imageId` or `snapshotId`,
	// the size value must not be less than the size of the source image
	// or the size of the snapshot.
	Size pulumi.IntPtrOutput `pulumi:"size"`
	// The source snapshot to use for disk creation.
	SnapshotId pulumi.StringPtrOutput `pulumi:"snapshotId"`
	// The status of the disk.
	Status pulumi.StringOutput `pulumi:"status"`
	// Type of disk to create. Provide this when creating a disk.
	Type pulumi.StringPtrOutput `pulumi:"type"`
	// Availability zone where the disk will reside.
	Zone pulumi.StringOutput `pulumi:"zone"`
}

// NewComputeDisk registers a new resource with the given unique name, arguments, and options.
func NewComputeDisk(ctx *pulumi.Context,
	name string, args *ComputeDiskArgs, opts ...pulumi.ResourceOption) (*ComputeDisk, error) {
	if args == nil {
		args = &ComputeDiskArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource ComputeDisk
	err := ctx.RegisterResource("yandex:index/computeDisk:ComputeDisk", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetComputeDisk gets an existing ComputeDisk resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetComputeDisk(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ComputeDiskState, opts ...pulumi.ResourceOption) (*ComputeDisk, error) {
	var resource ComputeDisk
	err := ctx.ReadResource("yandex:index/computeDisk:ComputeDisk", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ComputeDisk resources.
type computeDiskState struct {
	AllowRecreate *bool `pulumi:"allowRecreate"`
	// Block size of the disk, specified in bytes.
	BlockSize *int `pulumi:"blockSize"`
	// Creation timestamp of the disk.
	CreatedAt *string `pulumi:"createdAt"`
	// -
	// (Optional) Description of the disk. Provide this property when
	// you create a resource.
	Description *string `pulumi:"description"`
	// Disk placement policy configuration. The structure is documented below.
	DiskPlacementPolicy *ComputeDiskDiskPlacementPolicy `pulumi:"diskPlacementPolicy"`
	// (Optional) The ID of the folder that the disk belongs to.
	// If it is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// The source image to use for disk creation.
	ImageId *string `pulumi:"imageId"`
	// Labels to assign to this disk. A list of key/value pairs.
	Labels map[string]string `pulumi:"labels"`
	// Name of the disk. Provide this property when
	// you create a resource.
	Name       *string  `pulumi:"name"`
	ProductIds []string `pulumi:"productIds"`
	// Size of the persistent disk, specified in GB. You can specify this
	// field when creating a persistent disk using the `imageId` or `snapshotId`
	// parameter, or specify it alone to create an empty persistent disk.
	// If you specify this field along with `imageId` or `snapshotId`,
	// the size value must not be less than the size of the source image
	// or the size of the snapshot.
	Size *int `pulumi:"size"`
	// The source snapshot to use for disk creation.
	SnapshotId *string `pulumi:"snapshotId"`
	// The status of the disk.
	Status *string `pulumi:"status"`
	// Type of disk to create. Provide this when creating a disk.
	Type *string `pulumi:"type"`
	// Availability zone where the disk will reside.
	Zone *string `pulumi:"zone"`
}

type ComputeDiskState struct {
	AllowRecreate pulumi.BoolPtrInput
	// Block size of the disk, specified in bytes.
	BlockSize pulumi.IntPtrInput
	// Creation timestamp of the disk.
	CreatedAt pulumi.StringPtrInput
	// -
	// (Optional) Description of the disk. Provide this property when
	// you create a resource.
	Description pulumi.StringPtrInput
	// Disk placement policy configuration. The structure is documented below.
	DiskPlacementPolicy ComputeDiskDiskPlacementPolicyPtrInput
	// (Optional) The ID of the folder that the disk belongs to.
	// If it is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// The source image to use for disk creation.
	ImageId pulumi.StringPtrInput
	// Labels to assign to this disk. A list of key/value pairs.
	Labels pulumi.StringMapInput
	// Name of the disk. Provide this property when
	// you create a resource.
	Name       pulumi.StringPtrInput
	ProductIds pulumi.StringArrayInput
	// Size of the persistent disk, specified in GB. You can specify this
	// field when creating a persistent disk using the `imageId` or `snapshotId`
	// parameter, or specify it alone to create an empty persistent disk.
	// If you specify this field along with `imageId` or `snapshotId`,
	// the size value must not be less than the size of the source image
	// or the size of the snapshot.
	Size pulumi.IntPtrInput
	// The source snapshot to use for disk creation.
	SnapshotId pulumi.StringPtrInput
	// The status of the disk.
	Status pulumi.StringPtrInput
	// Type of disk to create. Provide this when creating a disk.
	Type pulumi.StringPtrInput
	// Availability zone where the disk will reside.
	Zone pulumi.StringPtrInput
}

func (ComputeDiskState) ElementType() reflect.Type {
	return reflect.TypeOf((*computeDiskState)(nil)).Elem()
}

type computeDiskArgs struct {
	AllowRecreate *bool `pulumi:"allowRecreate"`
	// Block size of the disk, specified in bytes.
	BlockSize *int `pulumi:"blockSize"`
	// -
	// (Optional) Description of the disk. Provide this property when
	// you create a resource.
	Description *string `pulumi:"description"`
	// Disk placement policy configuration. The structure is documented below.
	DiskPlacementPolicy *ComputeDiskDiskPlacementPolicy `pulumi:"diskPlacementPolicy"`
	// (Optional) The ID of the folder that the disk belongs to.
	// If it is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// The source image to use for disk creation.
	ImageId *string `pulumi:"imageId"`
	// Labels to assign to this disk. A list of key/value pairs.
	Labels map[string]string `pulumi:"labels"`
	// Name of the disk. Provide this property when
	// you create a resource.
	Name *string `pulumi:"name"`
	// Size of the persistent disk, specified in GB. You can specify this
	// field when creating a persistent disk using the `imageId` or `snapshotId`
	// parameter, or specify it alone to create an empty persistent disk.
	// If you specify this field along with `imageId` or `snapshotId`,
	// the size value must not be less than the size of the source image
	// or the size of the snapshot.
	Size *int `pulumi:"size"`
	// The source snapshot to use for disk creation.
	SnapshotId *string `pulumi:"snapshotId"`
	// Type of disk to create. Provide this when creating a disk.
	Type *string `pulumi:"type"`
	// Availability zone where the disk will reside.
	Zone *string `pulumi:"zone"`
}

// The set of arguments for constructing a ComputeDisk resource.
type ComputeDiskArgs struct {
	AllowRecreate pulumi.BoolPtrInput
	// Block size of the disk, specified in bytes.
	BlockSize pulumi.IntPtrInput
	// -
	// (Optional) Description of the disk. Provide this property when
	// you create a resource.
	Description pulumi.StringPtrInput
	// Disk placement policy configuration. The structure is documented below.
	DiskPlacementPolicy ComputeDiskDiskPlacementPolicyPtrInput
	// (Optional) The ID of the folder that the disk belongs to.
	// If it is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// The source image to use for disk creation.
	ImageId pulumi.StringPtrInput
	// Labels to assign to this disk. A list of key/value pairs.
	Labels pulumi.StringMapInput
	// Name of the disk. Provide this property when
	// you create a resource.
	Name pulumi.StringPtrInput
	// Size of the persistent disk, specified in GB. You can specify this
	// field when creating a persistent disk using the `imageId` or `snapshotId`
	// parameter, or specify it alone to create an empty persistent disk.
	// If you specify this field along with `imageId` or `snapshotId`,
	// the size value must not be less than the size of the source image
	// or the size of the snapshot.
	Size pulumi.IntPtrInput
	// The source snapshot to use for disk creation.
	SnapshotId pulumi.StringPtrInput
	// Type of disk to create. Provide this when creating a disk.
	Type pulumi.StringPtrInput
	// Availability zone where the disk will reside.
	Zone pulumi.StringPtrInput
}

func (ComputeDiskArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*computeDiskArgs)(nil)).Elem()
}

type ComputeDiskInput interface {
	pulumi.Input

	ToComputeDiskOutput() ComputeDiskOutput
	ToComputeDiskOutputWithContext(ctx context.Context) ComputeDiskOutput
}

func (*ComputeDisk) ElementType() reflect.Type {
	return reflect.TypeOf((**ComputeDisk)(nil)).Elem()
}

func (i *ComputeDisk) ToComputeDiskOutput() ComputeDiskOutput {
	return i.ToComputeDiskOutputWithContext(context.Background())
}

func (i *ComputeDisk) ToComputeDiskOutputWithContext(ctx context.Context) ComputeDiskOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputeDiskOutput)
}

// ComputeDiskArrayInput is an input type that accepts ComputeDiskArray and ComputeDiskArrayOutput values.
// You can construct a concrete instance of `ComputeDiskArrayInput` via:
//
//	ComputeDiskArray{ ComputeDiskArgs{...} }
type ComputeDiskArrayInput interface {
	pulumi.Input

	ToComputeDiskArrayOutput() ComputeDiskArrayOutput
	ToComputeDiskArrayOutputWithContext(context.Context) ComputeDiskArrayOutput
}

type ComputeDiskArray []ComputeDiskInput

func (ComputeDiskArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ComputeDisk)(nil)).Elem()
}

func (i ComputeDiskArray) ToComputeDiskArrayOutput() ComputeDiskArrayOutput {
	return i.ToComputeDiskArrayOutputWithContext(context.Background())
}

func (i ComputeDiskArray) ToComputeDiskArrayOutputWithContext(ctx context.Context) ComputeDiskArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputeDiskArrayOutput)
}

// ComputeDiskMapInput is an input type that accepts ComputeDiskMap and ComputeDiskMapOutput values.
// You can construct a concrete instance of `ComputeDiskMapInput` via:
//
//	ComputeDiskMap{ "key": ComputeDiskArgs{...} }
type ComputeDiskMapInput interface {
	pulumi.Input

	ToComputeDiskMapOutput() ComputeDiskMapOutput
	ToComputeDiskMapOutputWithContext(context.Context) ComputeDiskMapOutput
}

type ComputeDiskMap map[string]ComputeDiskInput

func (ComputeDiskMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ComputeDisk)(nil)).Elem()
}

func (i ComputeDiskMap) ToComputeDiskMapOutput() ComputeDiskMapOutput {
	return i.ToComputeDiskMapOutputWithContext(context.Background())
}

func (i ComputeDiskMap) ToComputeDiskMapOutputWithContext(ctx context.Context) ComputeDiskMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputeDiskMapOutput)
}

type ComputeDiskOutput struct{ *pulumi.OutputState }

func (ComputeDiskOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ComputeDisk)(nil)).Elem()
}

func (o ComputeDiskOutput) ToComputeDiskOutput() ComputeDiskOutput {
	return o
}

func (o ComputeDiskOutput) ToComputeDiskOutputWithContext(ctx context.Context) ComputeDiskOutput {
	return o
}

func (o ComputeDiskOutput) AllowRecreate() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.BoolPtrOutput { return v.AllowRecreate }).(pulumi.BoolPtrOutput)
}

// Block size of the disk, specified in bytes.
func (o ComputeDiskOutput) BlockSize() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.IntPtrOutput { return v.BlockSize }).(pulumi.IntPtrOutput)
}

// Creation timestamp of the disk.
func (o ComputeDiskOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// -
// (Optional) Description of the disk. Provide this property when
// you create a resource.
func (o ComputeDiskOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Disk placement policy configuration. The structure is documented below.
func (o ComputeDiskOutput) DiskPlacementPolicy() ComputeDiskDiskPlacementPolicyOutput {
	return o.ApplyT(func(v *ComputeDisk) ComputeDiskDiskPlacementPolicyOutput { return v.DiskPlacementPolicy }).(ComputeDiskDiskPlacementPolicyOutput)
}

// (Optional) The ID of the folder that the disk belongs to.
// If it is not provided, the default provider folder is used.
func (o ComputeDiskOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

// The source image to use for disk creation.
func (o ComputeDiskOutput) ImageId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.StringPtrOutput { return v.ImageId }).(pulumi.StringPtrOutput)
}

// Labels to assign to this disk. A list of key/value pairs.
func (o ComputeDiskOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// Name of the disk. Provide this property when
// you create a resource.
func (o ComputeDiskOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o ComputeDiskOutput) ProductIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.StringArrayOutput { return v.ProductIds }).(pulumi.StringArrayOutput)
}

// Size of the persistent disk, specified in GB. You can specify this
// field when creating a persistent disk using the `imageId` or `snapshotId`
// parameter, or specify it alone to create an empty persistent disk.
// If you specify this field along with `imageId` or `snapshotId`,
// the size value must not be less than the size of the source image
// or the size of the snapshot.
func (o ComputeDiskOutput) Size() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.IntPtrOutput { return v.Size }).(pulumi.IntPtrOutput)
}

// The source snapshot to use for disk creation.
func (o ComputeDiskOutput) SnapshotId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.StringPtrOutput { return v.SnapshotId }).(pulumi.StringPtrOutput)
}

// The status of the disk.
func (o ComputeDiskOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

// Type of disk to create. Provide this when creating a disk.
func (o ComputeDiskOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.StringPtrOutput { return v.Type }).(pulumi.StringPtrOutput)
}

// Availability zone where the disk will reside.
func (o ComputeDiskOutput) Zone() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeDisk) pulumi.StringOutput { return v.Zone }).(pulumi.StringOutput)
}

type ComputeDiskArrayOutput struct{ *pulumi.OutputState }

func (ComputeDiskArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ComputeDisk)(nil)).Elem()
}

func (o ComputeDiskArrayOutput) ToComputeDiskArrayOutput() ComputeDiskArrayOutput {
	return o
}

func (o ComputeDiskArrayOutput) ToComputeDiskArrayOutputWithContext(ctx context.Context) ComputeDiskArrayOutput {
	return o
}

func (o ComputeDiskArrayOutput) Index(i pulumi.IntInput) ComputeDiskOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ComputeDisk {
		return vs[0].([]*ComputeDisk)[vs[1].(int)]
	}).(ComputeDiskOutput)
}

type ComputeDiskMapOutput struct{ *pulumi.OutputState }

func (ComputeDiskMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ComputeDisk)(nil)).Elem()
}

func (o ComputeDiskMapOutput) ToComputeDiskMapOutput() ComputeDiskMapOutput {
	return o
}

func (o ComputeDiskMapOutput) ToComputeDiskMapOutputWithContext(ctx context.Context) ComputeDiskMapOutput {
	return o
}

func (o ComputeDiskMapOutput) MapIndex(k pulumi.StringInput) ComputeDiskOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ComputeDisk {
		return vs[0].(map[string]*ComputeDisk)[vs[1].(string)]
	}).(ComputeDiskOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ComputeDiskInput)(nil)).Elem(), &ComputeDisk{})
	pulumi.RegisterInputType(reflect.TypeOf((*ComputeDiskArrayInput)(nil)).Elem(), ComputeDiskArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ComputeDiskMapInput)(nil)).Elem(), ComputeDiskMap{})
	pulumi.RegisterOutputType(ComputeDiskOutput{})
	pulumi.RegisterOutputType(ComputeDiskArrayOutput{})
	pulumi.RegisterOutputType(ComputeDiskMapOutput{})
}
