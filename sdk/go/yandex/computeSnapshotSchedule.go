// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a new snapshot schedule. For more information, see
// [the official documentation](https://cloud.yandex.ru/docs/compute/concepts/snapshot-schedule).
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
// 		_, err := yandex.NewcomputeSnapshotSchedule(ctx, "default", &yandex.computeSnapshotScheduleArgs{
// 			DiskIds: pulumi.StringArray{
// 				pulumi.String("test_disk_id"),
// 				pulumi.String("another_test_disk_id"),
// 			},
// 			Labels: pulumi.StringMap{
// 				"my-label": pulumi.String("my-label-value"),
// 			},
// 			SchedulePolicy: &ComputeSnapshotScheduleSchedulePolicyArgs{
// 				Expression: pulumi.String("0 0 * * *"),
// 			},
// 			SnapshotCount: pulumi.Int(1),
// 			SnapshotSpec: &ComputeSnapshotScheduleSnapshotSpecArgs{
// 				Description: pulumi.String("snapshot-description"),
// 				Labels: pulumi.StringMap{
// 					"snapshot-label": pulumi.String("my-snapshot-label-value"),
// 				},
// 			},
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
// A snapshot schedule can be imported using the `id` of the resource, e.g.
//
// ```sh
//  $ pulumi import yandex:index/computeSnapshotSchedule:computeSnapshotSchedule my-schedule snapshot_schedule_id
// ```
type ComputeSnapshotSchedule struct {
	pulumi.CustomResourceState

	// Creation timestamp of the snapshot schedule.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// Description of the resource.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// IDs of the disk for snapshot schedule.
	DiskIds pulumi.StringArrayOutput `pulumi:"diskIds"`
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId pulumi.StringOutput `pulumi:"folderId"`
	// A set of key/value label pairs to assign to the snapshot schedule.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// A name for the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// Retention period applied to snapshots created by this snapshot schedule.
	RetentionPeriod pulumi.StringPtrOutput `pulumi:"retentionPeriod"`
	// Schedule policy of the snapshot schedule.
	SchedulePolicy ComputeSnapshotScheduleSchedulePolicyOutput `pulumi:"schedulePolicy"`
	// Maximum number of snapshots for every disk of the snapshot schedule.
	SnapshotCount pulumi.IntPtrOutput `pulumi:"snapshotCount"`
	// Additional attributes for snapshots created by this snapshot schedule.
	SnapshotSpec ComputeSnapshotScheduleSnapshotSpecOutput `pulumi:"snapshotSpec"`
	// The status of the snapshot schedule.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewComputeSnapshotSchedule registers a new resource with the given unique name, arguments, and options.
func NewComputeSnapshotSchedule(ctx *pulumi.Context,
	name string, args *ComputeSnapshotScheduleArgs, opts ...pulumi.ResourceOption) (*ComputeSnapshotSchedule, error) {
	if args == nil {
		args = &ComputeSnapshotScheduleArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource ComputeSnapshotSchedule
	err := ctx.RegisterResource("yandex:index/computeSnapshotSchedule:computeSnapshotSchedule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetComputeSnapshotSchedule gets an existing ComputeSnapshotSchedule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetComputeSnapshotSchedule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ComputeSnapshotScheduleState, opts ...pulumi.ResourceOption) (*ComputeSnapshotSchedule, error) {
	var resource ComputeSnapshotSchedule
	err := ctx.ReadResource("yandex:index/computeSnapshotSchedule:computeSnapshotSchedule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ComputeSnapshotSchedule resources.
type computeSnapshotScheduleState struct {
	// Creation timestamp of the snapshot schedule.
	CreatedAt *string `pulumi:"createdAt"`
	// Description of the resource.
	Description *string `pulumi:"description"`
	// IDs of the disk for snapshot schedule.
	DiskIds []string `pulumi:"diskIds"`
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// A set of key/value label pairs to assign to the snapshot schedule.
	Labels map[string]string `pulumi:"labels"`
	// A name for the resource.
	Name *string `pulumi:"name"`
	// Retention period applied to snapshots created by this snapshot schedule.
	RetentionPeriod *string `pulumi:"retentionPeriod"`
	// Schedule policy of the snapshot schedule.
	SchedulePolicy *ComputeSnapshotScheduleSchedulePolicy `pulumi:"schedulePolicy"`
	// Maximum number of snapshots for every disk of the snapshot schedule.
	SnapshotCount *int `pulumi:"snapshotCount"`
	// Additional attributes for snapshots created by this snapshot schedule.
	SnapshotSpec *ComputeSnapshotScheduleSnapshotSpec `pulumi:"snapshotSpec"`
	// The status of the snapshot schedule.
	Status *string `pulumi:"status"`
}

type ComputeSnapshotScheduleState struct {
	// Creation timestamp of the snapshot schedule.
	CreatedAt pulumi.StringPtrInput
	// Description of the resource.
	Description pulumi.StringPtrInput
	// IDs of the disk for snapshot schedule.
	DiskIds pulumi.StringArrayInput
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// A set of key/value label pairs to assign to the snapshot schedule.
	Labels pulumi.StringMapInput
	// A name for the resource.
	Name pulumi.StringPtrInput
	// Retention period applied to snapshots created by this snapshot schedule.
	RetentionPeriod pulumi.StringPtrInput
	// Schedule policy of the snapshot schedule.
	SchedulePolicy ComputeSnapshotScheduleSchedulePolicyPtrInput
	// Maximum number of snapshots for every disk of the snapshot schedule.
	SnapshotCount pulumi.IntPtrInput
	// Additional attributes for snapshots created by this snapshot schedule.
	SnapshotSpec ComputeSnapshotScheduleSnapshotSpecPtrInput
	// The status of the snapshot schedule.
	Status pulumi.StringPtrInput
}

func (ComputeSnapshotScheduleState) ElementType() reflect.Type {
	return reflect.TypeOf((*computeSnapshotScheduleState)(nil)).Elem()
}

type computeSnapshotScheduleArgs struct {
	// Description of the resource.
	Description *string `pulumi:"description"`
	// IDs of the disk for snapshot schedule.
	DiskIds []string `pulumi:"diskIds"`
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// A set of key/value label pairs to assign to the snapshot schedule.
	Labels map[string]string `pulumi:"labels"`
	// A name for the resource.
	Name *string `pulumi:"name"`
	// Retention period applied to snapshots created by this snapshot schedule.
	RetentionPeriod *string `pulumi:"retentionPeriod"`
	// Schedule policy of the snapshot schedule.
	SchedulePolicy *ComputeSnapshotScheduleSchedulePolicy `pulumi:"schedulePolicy"`
	// Maximum number of snapshots for every disk of the snapshot schedule.
	SnapshotCount *int `pulumi:"snapshotCount"`
	// Additional attributes for snapshots created by this snapshot schedule.
	SnapshotSpec *ComputeSnapshotScheduleSnapshotSpec `pulumi:"snapshotSpec"`
}

// The set of arguments for constructing a ComputeSnapshotSchedule resource.
type ComputeSnapshotScheduleArgs struct {
	// Description of the resource.
	Description pulumi.StringPtrInput
	// IDs of the disk for snapshot schedule.
	DiskIds pulumi.StringArrayInput
	// The ID of the folder that the resource belongs to. If it
	// is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// A set of key/value label pairs to assign to the snapshot schedule.
	Labels pulumi.StringMapInput
	// A name for the resource.
	Name pulumi.StringPtrInput
	// Retention period applied to snapshots created by this snapshot schedule.
	RetentionPeriod pulumi.StringPtrInput
	// Schedule policy of the snapshot schedule.
	SchedulePolicy ComputeSnapshotScheduleSchedulePolicyPtrInput
	// Maximum number of snapshots for every disk of the snapshot schedule.
	SnapshotCount pulumi.IntPtrInput
	// Additional attributes for snapshots created by this snapshot schedule.
	SnapshotSpec ComputeSnapshotScheduleSnapshotSpecPtrInput
}

func (ComputeSnapshotScheduleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*computeSnapshotScheduleArgs)(nil)).Elem()
}

type ComputeSnapshotScheduleInput interface {
	pulumi.Input

	ToComputeSnapshotScheduleOutput() ComputeSnapshotScheduleOutput
	ToComputeSnapshotScheduleOutputWithContext(ctx context.Context) ComputeSnapshotScheduleOutput
}

func (*ComputeSnapshotSchedule) ElementType() reflect.Type {
	return reflect.TypeOf((**ComputeSnapshotSchedule)(nil)).Elem()
}

func (i *ComputeSnapshotSchedule) ToComputeSnapshotScheduleOutput() ComputeSnapshotScheduleOutput {
	return i.ToComputeSnapshotScheduleOutputWithContext(context.Background())
}

func (i *ComputeSnapshotSchedule) ToComputeSnapshotScheduleOutputWithContext(ctx context.Context) ComputeSnapshotScheduleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputeSnapshotScheduleOutput)
}

// ComputeSnapshotScheduleArrayInput is an input type that accepts ComputeSnapshotScheduleArray and ComputeSnapshotScheduleArrayOutput values.
// You can construct a concrete instance of `ComputeSnapshotScheduleArrayInput` via:
//
//          ComputeSnapshotScheduleArray{ ComputeSnapshotScheduleArgs{...} }
type ComputeSnapshotScheduleArrayInput interface {
	pulumi.Input

	ToComputeSnapshotScheduleArrayOutput() ComputeSnapshotScheduleArrayOutput
	ToComputeSnapshotScheduleArrayOutputWithContext(context.Context) ComputeSnapshotScheduleArrayOutput
}

type ComputeSnapshotScheduleArray []ComputeSnapshotScheduleInput

func (ComputeSnapshotScheduleArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ComputeSnapshotSchedule)(nil)).Elem()
}

func (i ComputeSnapshotScheduleArray) ToComputeSnapshotScheduleArrayOutput() ComputeSnapshotScheduleArrayOutput {
	return i.ToComputeSnapshotScheduleArrayOutputWithContext(context.Background())
}

func (i ComputeSnapshotScheduleArray) ToComputeSnapshotScheduleArrayOutputWithContext(ctx context.Context) ComputeSnapshotScheduleArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputeSnapshotScheduleArrayOutput)
}

// ComputeSnapshotScheduleMapInput is an input type that accepts ComputeSnapshotScheduleMap and ComputeSnapshotScheduleMapOutput values.
// You can construct a concrete instance of `ComputeSnapshotScheduleMapInput` via:
//
//          ComputeSnapshotScheduleMap{ "key": ComputeSnapshotScheduleArgs{...} }
type ComputeSnapshotScheduleMapInput interface {
	pulumi.Input

	ToComputeSnapshotScheduleMapOutput() ComputeSnapshotScheduleMapOutput
	ToComputeSnapshotScheduleMapOutputWithContext(context.Context) ComputeSnapshotScheduleMapOutput
}

type ComputeSnapshotScheduleMap map[string]ComputeSnapshotScheduleInput

func (ComputeSnapshotScheduleMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ComputeSnapshotSchedule)(nil)).Elem()
}

func (i ComputeSnapshotScheduleMap) ToComputeSnapshotScheduleMapOutput() ComputeSnapshotScheduleMapOutput {
	return i.ToComputeSnapshotScheduleMapOutputWithContext(context.Background())
}

func (i ComputeSnapshotScheduleMap) ToComputeSnapshotScheduleMapOutputWithContext(ctx context.Context) ComputeSnapshotScheduleMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputeSnapshotScheduleMapOutput)
}

type ComputeSnapshotScheduleOutput struct{ *pulumi.OutputState }

func (ComputeSnapshotScheduleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ComputeSnapshotSchedule)(nil)).Elem()
}

func (o ComputeSnapshotScheduleOutput) ToComputeSnapshotScheduleOutput() ComputeSnapshotScheduleOutput {
	return o
}

func (o ComputeSnapshotScheduleOutput) ToComputeSnapshotScheduleOutputWithContext(ctx context.Context) ComputeSnapshotScheduleOutput {
	return o
}

// Creation timestamp of the snapshot schedule.
func (o ComputeSnapshotScheduleOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeSnapshotSchedule) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// Description of the resource.
func (o ComputeSnapshotScheduleOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ComputeSnapshotSchedule) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// IDs of the disk for snapshot schedule.
func (o ComputeSnapshotScheduleOutput) DiskIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ComputeSnapshotSchedule) pulumi.StringArrayOutput { return v.DiskIds }).(pulumi.StringArrayOutput)
}

// The ID of the folder that the resource belongs to. If it
// is not provided, the default provider folder is used.
func (o ComputeSnapshotScheduleOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeSnapshotSchedule) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

// A set of key/value label pairs to assign to the snapshot schedule.
func (o ComputeSnapshotScheduleOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *ComputeSnapshotSchedule) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// A name for the resource.
func (o ComputeSnapshotScheduleOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeSnapshotSchedule) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Retention period applied to snapshots created by this snapshot schedule.
func (o ComputeSnapshotScheduleOutput) RetentionPeriod() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ComputeSnapshotSchedule) pulumi.StringPtrOutput { return v.RetentionPeriod }).(pulumi.StringPtrOutput)
}

// Schedule policy of the snapshot schedule.
func (o ComputeSnapshotScheduleOutput) SchedulePolicy() ComputeSnapshotScheduleSchedulePolicyOutput {
	return o.ApplyT(func(v *ComputeSnapshotSchedule) ComputeSnapshotScheduleSchedulePolicyOutput { return v.SchedulePolicy }).(ComputeSnapshotScheduleSchedulePolicyOutput)
}

// Maximum number of snapshots for every disk of the snapshot schedule.
func (o ComputeSnapshotScheduleOutput) SnapshotCount() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ComputeSnapshotSchedule) pulumi.IntPtrOutput { return v.SnapshotCount }).(pulumi.IntPtrOutput)
}

// Additional attributes for snapshots created by this snapshot schedule.
func (o ComputeSnapshotScheduleOutput) SnapshotSpec() ComputeSnapshotScheduleSnapshotSpecOutput {
	return o.ApplyT(func(v *ComputeSnapshotSchedule) ComputeSnapshotScheduleSnapshotSpecOutput { return v.SnapshotSpec }).(ComputeSnapshotScheduleSnapshotSpecOutput)
}

// The status of the snapshot schedule.
func (o ComputeSnapshotScheduleOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeSnapshotSchedule) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type ComputeSnapshotScheduleArrayOutput struct{ *pulumi.OutputState }

func (ComputeSnapshotScheduleArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ComputeSnapshotSchedule)(nil)).Elem()
}

func (o ComputeSnapshotScheduleArrayOutput) ToComputeSnapshotScheduleArrayOutput() ComputeSnapshotScheduleArrayOutput {
	return o
}

func (o ComputeSnapshotScheduleArrayOutput) ToComputeSnapshotScheduleArrayOutputWithContext(ctx context.Context) ComputeSnapshotScheduleArrayOutput {
	return o
}

func (o ComputeSnapshotScheduleArrayOutput) Index(i pulumi.IntInput) ComputeSnapshotScheduleOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ComputeSnapshotSchedule {
		return vs[0].([]*ComputeSnapshotSchedule)[vs[1].(int)]
	}).(ComputeSnapshotScheduleOutput)
}

type ComputeSnapshotScheduleMapOutput struct{ *pulumi.OutputState }

func (ComputeSnapshotScheduleMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ComputeSnapshotSchedule)(nil)).Elem()
}

func (o ComputeSnapshotScheduleMapOutput) ToComputeSnapshotScheduleMapOutput() ComputeSnapshotScheduleMapOutput {
	return o
}

func (o ComputeSnapshotScheduleMapOutput) ToComputeSnapshotScheduleMapOutputWithContext(ctx context.Context) ComputeSnapshotScheduleMapOutput {
	return o
}

func (o ComputeSnapshotScheduleMapOutput) MapIndex(k pulumi.StringInput) ComputeSnapshotScheduleOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ComputeSnapshotSchedule {
		return vs[0].(map[string]*ComputeSnapshotSchedule)[vs[1].(string)]
	}).(ComputeSnapshotScheduleOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ComputeSnapshotScheduleInput)(nil)).Elem(), &ComputeSnapshotSchedule{})
	pulumi.RegisterInputType(reflect.TypeOf((*ComputeSnapshotScheduleArrayInput)(nil)).Elem(), ComputeSnapshotScheduleArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ComputeSnapshotScheduleMapInput)(nil)).Elem(), ComputeSnapshotScheduleMap{})
	pulumi.RegisterOutputType(ComputeSnapshotScheduleOutput{})
	pulumi.RegisterOutputType(ComputeSnapshotScheduleArrayOutput{})
	pulumi.RegisterOutputType(ComputeSnapshotScheduleMapOutput{})
}
