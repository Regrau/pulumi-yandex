// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupComputeInstanceGroup(ctx *pulumi.Context, args *LookupComputeInstanceGroupArgs, opts ...pulumi.InvokeOption) (*LookupComputeInstanceGroupResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupComputeInstanceGroupResult
	err := ctx.Invoke("yandex:index/getComputeInstanceGroup:getComputeInstanceGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getComputeInstanceGroup.
type LookupComputeInstanceGroupArgs struct {
	InstanceGroupId string `pulumi:"instanceGroupId"`
}

// A collection of values returned by getComputeInstanceGroup.
type LookupComputeInstanceGroupResult struct {
	AllocationPolicies        []GetComputeInstanceGroupAllocationPolicy         `pulumi:"allocationPolicies"`
	ApplicationBalancerStates []GetComputeInstanceGroupApplicationBalancerState `pulumi:"applicationBalancerStates"`
	ApplicationLoadBalancers  []GetComputeInstanceGroupApplicationLoadBalancer  `pulumi:"applicationLoadBalancers"`
	CreatedAt                 string                                            `pulumi:"createdAt"`
	DeletionProtection        bool                                              `pulumi:"deletionProtection"`
	DeployPolicies            []GetComputeInstanceGroupDeployPolicy             `pulumi:"deployPolicies"`
	Description               string                                            `pulumi:"description"`
	FolderId                  string                                            `pulumi:"folderId"`
	HealthChecks              []GetComputeInstanceGroupHealthCheck              `pulumi:"healthChecks"`
	// The provider-assigned unique ID for this managed resource.
	Id                        string                                     `pulumi:"id"`
	InstanceGroupId           string                                     `pulumi:"instanceGroupId"`
	InstanceTemplates         []GetComputeInstanceGroupInstanceTemplate  `pulumi:"instanceTemplates"`
	Instances                 []GetComputeInstanceGroupInstance          `pulumi:"instances"`
	Labels                    map[string]string                          `pulumi:"labels"`
	LoadBalancerStates        []GetComputeInstanceGroupLoadBalancerState `pulumi:"loadBalancerStates"`
	LoadBalancers             []GetComputeInstanceGroupLoadBalancer      `pulumi:"loadBalancers"`
	MaxCheckingHealthDuration int                                        `pulumi:"maxCheckingHealthDuration"`
	Name                      string                                     `pulumi:"name"`
	ScalePolicies             []GetComputeInstanceGroupScalePolicy       `pulumi:"scalePolicies"`
	ServiceAccountId          string                                     `pulumi:"serviceAccountId"`
	Status                    string                                     `pulumi:"status"`
	Variables                 map[string]string                          `pulumi:"variables"`
}

func LookupComputeInstanceGroupOutput(ctx *pulumi.Context, args LookupComputeInstanceGroupOutputArgs, opts ...pulumi.InvokeOption) LookupComputeInstanceGroupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupComputeInstanceGroupResult, error) {
			args := v.(LookupComputeInstanceGroupArgs)
			r, err := LookupComputeInstanceGroup(ctx, &args, opts...)
			var s LookupComputeInstanceGroupResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupComputeInstanceGroupResultOutput)
}

// A collection of arguments for invoking getComputeInstanceGroup.
type LookupComputeInstanceGroupOutputArgs struct {
	InstanceGroupId pulumi.StringInput `pulumi:"instanceGroupId"`
}

func (LookupComputeInstanceGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputeInstanceGroupArgs)(nil)).Elem()
}

// A collection of values returned by getComputeInstanceGroup.
type LookupComputeInstanceGroupResultOutput struct{ *pulumi.OutputState }

func (LookupComputeInstanceGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputeInstanceGroupResult)(nil)).Elem()
}

func (o LookupComputeInstanceGroupResultOutput) ToLookupComputeInstanceGroupResultOutput() LookupComputeInstanceGroupResultOutput {
	return o
}

func (o LookupComputeInstanceGroupResultOutput) ToLookupComputeInstanceGroupResultOutputWithContext(ctx context.Context) LookupComputeInstanceGroupResultOutput {
	return o
}

func (o LookupComputeInstanceGroupResultOutput) AllocationPolicies() GetComputeInstanceGroupAllocationPolicyArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) []GetComputeInstanceGroupAllocationPolicy {
		return v.AllocationPolicies
	}).(GetComputeInstanceGroupAllocationPolicyArrayOutput)
}

func (o LookupComputeInstanceGroupResultOutput) ApplicationBalancerStates() GetComputeInstanceGroupApplicationBalancerStateArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) []GetComputeInstanceGroupApplicationBalancerState {
		return v.ApplicationBalancerStates
	}).(GetComputeInstanceGroupApplicationBalancerStateArrayOutput)
}

func (o LookupComputeInstanceGroupResultOutput) ApplicationLoadBalancers() GetComputeInstanceGroupApplicationLoadBalancerArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) []GetComputeInstanceGroupApplicationLoadBalancer {
		return v.ApplicationLoadBalancers
	}).(GetComputeInstanceGroupApplicationLoadBalancerArrayOutput)
}

func (o LookupComputeInstanceGroupResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceGroupResultOutput) DeletionProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) bool { return v.DeletionProtection }).(pulumi.BoolOutput)
}

func (o LookupComputeInstanceGroupResultOutput) DeployPolicies() GetComputeInstanceGroupDeployPolicyArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) []GetComputeInstanceGroupDeployPolicy {
		return v.DeployPolicies
	}).(GetComputeInstanceGroupDeployPolicyArrayOutput)
}

func (o LookupComputeInstanceGroupResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceGroupResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) string { return v.FolderId }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceGroupResultOutput) HealthChecks() GetComputeInstanceGroupHealthCheckArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) []GetComputeInstanceGroupHealthCheck { return v.HealthChecks }).(GetComputeInstanceGroupHealthCheckArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupComputeInstanceGroupResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceGroupResultOutput) InstanceGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) string { return v.InstanceGroupId }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceGroupResultOutput) InstanceTemplates() GetComputeInstanceGroupInstanceTemplateArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) []GetComputeInstanceGroupInstanceTemplate {
		return v.InstanceTemplates
	}).(GetComputeInstanceGroupInstanceTemplateArrayOutput)
}

func (o LookupComputeInstanceGroupResultOutput) Instances() GetComputeInstanceGroupInstanceArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) []GetComputeInstanceGroupInstance { return v.Instances }).(GetComputeInstanceGroupInstanceArrayOutput)
}

func (o LookupComputeInstanceGroupResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupComputeInstanceGroupResultOutput) LoadBalancerStates() GetComputeInstanceGroupLoadBalancerStateArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) []GetComputeInstanceGroupLoadBalancerState {
		return v.LoadBalancerStates
	}).(GetComputeInstanceGroupLoadBalancerStateArrayOutput)
}

func (o LookupComputeInstanceGroupResultOutput) LoadBalancers() GetComputeInstanceGroupLoadBalancerArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) []GetComputeInstanceGroupLoadBalancer { return v.LoadBalancers }).(GetComputeInstanceGroupLoadBalancerArrayOutput)
}

func (o LookupComputeInstanceGroupResultOutput) MaxCheckingHealthDuration() pulumi.IntOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) int { return v.MaxCheckingHealthDuration }).(pulumi.IntOutput)
}

func (o LookupComputeInstanceGroupResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceGroupResultOutput) ScalePolicies() GetComputeInstanceGroupScalePolicyArrayOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) []GetComputeInstanceGroupScalePolicy { return v.ScalePolicies }).(GetComputeInstanceGroupScalePolicyArrayOutput)
}

func (o LookupComputeInstanceGroupResultOutput) ServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) string { return v.ServiceAccountId }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceGroupResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) string { return v.Status }).(pulumi.StringOutput)
}

func (o LookupComputeInstanceGroupResultOutput) Variables() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupComputeInstanceGroupResult) map[string]string { return v.Variables }).(pulumi.StringMapOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupComputeInstanceGroupResultOutput{})
}
