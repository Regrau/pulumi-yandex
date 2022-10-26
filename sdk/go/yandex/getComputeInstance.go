// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupComputeInstance(ctx *pulumi.Context, args *LookupComputeInstanceArgs, opts ...pulumi.InvokeOption) (*LookupComputeInstanceResult, error) {
	var rv LookupComputeInstanceResult
	err := ctx.Invoke("yandex:index/getComputeInstance:getComputeInstance", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getComputeInstance.
type LookupComputeInstanceArgs struct {
	FolderId        *string                            `pulumi:"folderId"`
	InstanceId      *string                            `pulumi:"instanceId"`
	LocalDisks      []GetComputeInstanceLocalDisk      `pulumi:"localDisks"`
	Name            *string                            `pulumi:"name"`
	PlacementPolicy *GetComputeInstancePlacementPolicy `pulumi:"placementPolicy"`
}

// A collection of values returned by getComputeInstance.
type LookupComputeInstanceResult struct {
	BootDisks   []GetComputeInstanceBootDisk `pulumi:"bootDisks"`
	CreatedAt   string                       `pulumi:"createdAt"`
	Description string                       `pulumi:"description"`
	FolderId    string                       `pulumi:"folderId"`
	Fqdn        string                       `pulumi:"fqdn"`
	// The provider-assigned unique ID for this managed resource.
	Id                      string                               `pulumi:"id"`
	InstanceId              string                               `pulumi:"instanceId"`
	Labels                  map[string]string                    `pulumi:"labels"`
	LocalDisks              []GetComputeInstanceLocalDisk        `pulumi:"localDisks"`
	Metadata                map[string]string                    `pulumi:"metadata"`
	Name                    string                               `pulumi:"name"`
	NetworkAccelerationType string                               `pulumi:"networkAccelerationType"`
	NetworkInterfaces       []GetComputeInstanceNetworkInterface `pulumi:"networkInterfaces"`
	PlacementPolicy         *GetComputeInstancePlacementPolicy   `pulumi:"placementPolicy"`
	PlatformId              string                               `pulumi:"platformId"`
	Resources               []GetComputeInstanceResource         `pulumi:"resources"`
	SchedulingPolicies      []GetComputeInstanceSchedulingPolicy `pulumi:"schedulingPolicies"`
	SecondaryDisks          []GetComputeInstanceSecondaryDisk    `pulumi:"secondaryDisks"`
	ServiceAccountId        string                               `pulumi:"serviceAccountId"`
	Status                  string                               `pulumi:"status"`
	Zone                    string                               `pulumi:"zone"`
}

func LookupComputeInstanceOutput(ctx *pulumi.Context, args LookupComputeInstanceOutputArgs, opts ...pulumi.InvokeOption) LookupComputeInstanceResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupComputeInstanceResult, error) {
			args := v.(LookupComputeInstanceArgs)
			r, err := LookupComputeInstance(ctx, &args, opts...)
			var s LookupComputeInstanceResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupComputeInstanceResultOutput)
}

// A collection of arguments for invoking getComputeInstance.
type LookupComputeInstanceOutputArgs struct {
	FolderId        pulumi.StringPtrInput                     `pulumi:"folderId"`
	InstanceId      pulumi.StringPtrInput                     `pulumi:"instanceId"`
	LocalDisks      GetComputeInstanceLocalDiskArrayInput     `pulumi:"localDisks"`
	Name            pulumi.StringPtrInput                     `pulumi:"name"`
	PlacementPolicy GetComputeInstancePlacementPolicyPtrInput `pulumi:"placementPolicy"`
}

func (LookupComputeInstanceOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputeInstanceArgs)(nil)).Elem()
}

// A collection of values returned by getComputeInstance.
type LookupComputeInstanceResultOutput struct{ *pulumi.OutputState }

func (LookupComputeInstanceResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputeInstanceResult)(nil)).Elem()
}

func (o LookupComputeInstanceResultOutput) ToLookupComputeInstanceResultOutput() LookupComputeInstanceResultOutput {
	return o
}

func (o LookupComputeInstanceResultOutput) ToLookupComputeInstanceResultOutputWithContext(ctx context.Context) LookupComputeInstanceResultOutput {
	return o
}

func (o LookupComputeInstanceResultOutput) BootDisks() GetComputeInstanceBootDiskArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) []GetComputeInstanceBootDisk { return v.BootDisks }).(GetComputeInstanceBootDiskArrayOutput)
}

func (o LookupComputeInstanceResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) string { return v.FolderId }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceResultOutput) Fqdn() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) string { return v.Fqdn }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupComputeInstanceResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupComputeInstanceResultOutput) LocalDisks() GetComputeInstanceLocalDiskArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) []GetComputeInstanceLocalDisk { return v.LocalDisks }).(GetComputeInstanceLocalDiskArrayOutput)
}

func (o LookupComputeInstanceResultOutput) Metadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) map[string]string { return v.Metadata }).(pulumi.StringMapOutput)
}

func (o LookupComputeInstanceResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceResultOutput) NetworkAccelerationType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) string { return v.NetworkAccelerationType }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceResultOutput) NetworkInterfaces() GetComputeInstanceNetworkInterfaceArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) []GetComputeInstanceNetworkInterface { return v.NetworkInterfaces }).(GetComputeInstanceNetworkInterfaceArrayOutput)
}

func (o LookupComputeInstanceResultOutput) PlacementPolicy() GetComputeInstancePlacementPolicyPtrOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) *GetComputeInstancePlacementPolicy { return v.PlacementPolicy }).(GetComputeInstancePlacementPolicyPtrOutput)
}

func (o LookupComputeInstanceResultOutput) PlatformId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) string { return v.PlatformId }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceResultOutput) Resources() GetComputeInstanceResourceArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) []GetComputeInstanceResource { return v.Resources }).(GetComputeInstanceResourceArrayOutput)
}

func (o LookupComputeInstanceResultOutput) SchedulingPolicies() GetComputeInstanceSchedulingPolicyArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) []GetComputeInstanceSchedulingPolicy { return v.SchedulingPolicies }).(GetComputeInstanceSchedulingPolicyArrayOutput)
}

func (o LookupComputeInstanceResultOutput) SecondaryDisks() GetComputeInstanceSecondaryDiskArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) []GetComputeInstanceSecondaryDisk { return v.SecondaryDisks }).(GetComputeInstanceSecondaryDiskArrayOutput)
}

func (o LookupComputeInstanceResultOutput) ServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) string { return v.ServiceAccountId }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) string { return v.Status }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceResultOutput) Zone() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceResult) string { return v.Zone }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupComputeInstanceResultOutput{})
}
