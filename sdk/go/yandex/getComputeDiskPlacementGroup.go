// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about a Yandex Compute Disk Placement group. For more information, see
// [the official documentation](https://cloud.yandex.com/docs/compute/concepts/disk#nr-disks).
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
// 		myGroup, err := yandex.LookupComputeDiskPlacementGroup(ctx, &GetComputeDiskPlacementGroupArgs{
// 			GroupId: pulumi.StringRef("some_group_id"),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		ctx.Export("placementGroupName", myGroup.Name)
// 		return nil
// 	})
// }
// ```
func LookupComputeDiskPlacementGroup(ctx *pulumi.Context, args *LookupComputeDiskPlacementGroupArgs, opts ...pulumi.InvokeOption) (*LookupComputeDiskPlacementGroupResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupComputeDiskPlacementGroupResult
	err := ctx.Invoke("yandex:index/getComputeDiskPlacementGroup:getComputeDiskPlacementGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getComputeDiskPlacementGroup.
type LookupComputeDiskPlacementGroupArgs struct {
	// Description of the Disk Placement Group.
	Description *string `pulumi:"description"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// The ID of a specific group.
	GroupId *string `pulumi:"groupId"`
	// A set of key/value label pairs assigned to the Disk Placement Group.
	Labels map[string]string `pulumi:"labels"`
	// Name of the group.
	Name *string `pulumi:"name"`
	// ID of the zone where the Disk Placement Group resides.
	Zone *string `pulumi:"zone"`
}

// A collection of values returned by getComputeDiskPlacementGroup.
type LookupComputeDiskPlacementGroupResult struct {
	// The creation timestamp of the Disk Placement Group.
	CreatedAt string `pulumi:"createdAt"`
	// Description of the Disk Placement Group.
	Description *string `pulumi:"description"`
	FolderId    string  `pulumi:"folderId"`
	GroupId     string  `pulumi:"groupId"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// A set of key/value label pairs assigned to the Disk Placement Group.
	Labels map[string]string `pulumi:"labels"`
	Name   *string           `pulumi:"name"`
	// Status of the Disk Placement Group.
	Status string `pulumi:"status"`
	// ID of the zone where the Disk Placement Group resides.
	Zone *string `pulumi:"zone"`
}

func LookupComputeDiskPlacementGroupOutput(ctx *pulumi.Context, args LookupComputeDiskPlacementGroupOutputArgs, opts ...pulumi.InvokeOption) LookupComputeDiskPlacementGroupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupComputeDiskPlacementGroupResult, error) {
			args := v.(LookupComputeDiskPlacementGroupArgs)
			r, err := LookupComputeDiskPlacementGroup(ctx, &args, opts...)
			var s LookupComputeDiskPlacementGroupResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupComputeDiskPlacementGroupResultOutput)
}

// A collection of arguments for invoking getComputeDiskPlacementGroup.
type LookupComputeDiskPlacementGroupOutputArgs struct {
	// Description of the Disk Placement Group.
	Description pulumi.StringPtrInput `pulumi:"description"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId pulumi.StringPtrInput `pulumi:"folderId"`
	// The ID of a specific group.
	GroupId pulumi.StringPtrInput `pulumi:"groupId"`
	// A set of key/value label pairs assigned to the Disk Placement Group.
	Labels pulumi.StringMapInput `pulumi:"labels"`
	// Name of the group.
	Name pulumi.StringPtrInput `pulumi:"name"`
	// ID of the zone where the Disk Placement Group resides.
	Zone pulumi.StringPtrInput `pulumi:"zone"`
}

func (LookupComputeDiskPlacementGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputeDiskPlacementGroupArgs)(nil)).Elem()
}

// A collection of values returned by getComputeDiskPlacementGroup.
type LookupComputeDiskPlacementGroupResultOutput struct{ *pulumi.OutputState }

func (LookupComputeDiskPlacementGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputeDiskPlacementGroupResult)(nil)).Elem()
}

func (o LookupComputeDiskPlacementGroupResultOutput) ToLookupComputeDiskPlacementGroupResultOutput() LookupComputeDiskPlacementGroupResultOutput {
	return o
}

func (o LookupComputeDiskPlacementGroupResultOutput) ToLookupComputeDiskPlacementGroupResultOutputWithContext(ctx context.Context) LookupComputeDiskPlacementGroupResultOutput {
	return o
}

// The creation timestamp of the Disk Placement Group.
func (o LookupComputeDiskPlacementGroupResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeDiskPlacementGroupResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

// Description of the Disk Placement Group.
func (o LookupComputeDiskPlacementGroupResultOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupComputeDiskPlacementGroupResult) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o LookupComputeDiskPlacementGroupResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeDiskPlacementGroupResult) string { return v.FolderId }).(pulumi.StringOutput)
}

func (o LookupComputeDiskPlacementGroupResultOutput) GroupId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeDiskPlacementGroupResult) string { return v.GroupId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupComputeDiskPlacementGroupResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeDiskPlacementGroupResult) string { return v.Id }).(pulumi.StringOutput)
}

// A set of key/value label pairs assigned to the Disk Placement Group.
func (o LookupComputeDiskPlacementGroupResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupComputeDiskPlacementGroupResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupComputeDiskPlacementGroupResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupComputeDiskPlacementGroupResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// Status of the Disk Placement Group.
func (o LookupComputeDiskPlacementGroupResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeDiskPlacementGroupResult) string { return v.Status }).(pulumi.StringOutput)
}

// ID of the zone where the Disk Placement Group resides.
func (o LookupComputeDiskPlacementGroupResultOutput) Zone() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupComputeDiskPlacementGroupResult) *string { return v.Zone }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupComputeDiskPlacementGroupResultOutput{})
}
