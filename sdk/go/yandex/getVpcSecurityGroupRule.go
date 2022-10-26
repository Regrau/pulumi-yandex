// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupVpcSecurityGroupRule(ctx *pulumi.Context, args *LookupVpcSecurityGroupRuleArgs, opts ...pulumi.InvokeOption) (*LookupVpcSecurityGroupRuleResult, error) {
	var rv LookupVpcSecurityGroupRuleResult
	err := ctx.Invoke("yandex:index/getVpcSecurityGroupRule:getVpcSecurityGroupRule", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getVpcSecurityGroupRule.
type LookupVpcSecurityGroupRuleArgs struct {
	RuleId               string `pulumi:"ruleId"`
	SecurityGroupBinding string `pulumi:"securityGroupBinding"`
}

// A collection of values returned by getVpcSecurityGroupRule.
type LookupVpcSecurityGroupRuleResult struct {
	Description string `pulumi:"description"`
	Direction   string `pulumi:"direction"`
	FromPort    int    `pulumi:"fromPort"`
	// The provider-assigned unique ID for this managed resource.
	Id                   string            `pulumi:"id"`
	Labels               map[string]string `pulumi:"labels"`
	Port                 int               `pulumi:"port"`
	PredefinedTarget     string            `pulumi:"predefinedTarget"`
	Protocol             string            `pulumi:"protocol"`
	RuleId               string            `pulumi:"ruleId"`
	SecurityGroupBinding string            `pulumi:"securityGroupBinding"`
	SecurityGroupId      string            `pulumi:"securityGroupId"`
	ToPort               int               `pulumi:"toPort"`
	V4CidrBlocks         []string          `pulumi:"v4CidrBlocks"`
	V6CidrBlocks         []string          `pulumi:"v6CidrBlocks"`
}

func LookupVpcSecurityGroupRuleOutput(ctx *pulumi.Context, args LookupVpcSecurityGroupRuleOutputArgs, opts ...pulumi.InvokeOption) LookupVpcSecurityGroupRuleResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupVpcSecurityGroupRuleResult, error) {
			args := v.(LookupVpcSecurityGroupRuleArgs)
			r, err := LookupVpcSecurityGroupRule(ctx, &args, opts...)
			var s LookupVpcSecurityGroupRuleResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupVpcSecurityGroupRuleResultOutput)
}

// A collection of arguments for invoking getVpcSecurityGroupRule.
type LookupVpcSecurityGroupRuleOutputArgs struct {
	RuleId               pulumi.StringInput `pulumi:"ruleId"`
	SecurityGroupBinding pulumi.StringInput `pulumi:"securityGroupBinding"`
}

func (LookupVpcSecurityGroupRuleOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVpcSecurityGroupRuleArgs)(nil)).Elem()
}

// A collection of values returned by getVpcSecurityGroupRule.
type LookupVpcSecurityGroupRuleResultOutput struct{ *pulumi.OutputState }

func (LookupVpcSecurityGroupRuleResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVpcSecurityGroupRuleResult)(nil)).Elem()
}

func (o LookupVpcSecurityGroupRuleResultOutput) ToLookupVpcSecurityGroupRuleResultOutput() LookupVpcSecurityGroupRuleResultOutput {
	return o
}

func (o LookupVpcSecurityGroupRuleResultOutput) ToLookupVpcSecurityGroupRuleResultOutputWithContext(ctx context.Context) LookupVpcSecurityGroupRuleResultOutput {
	return o
}

func (o LookupVpcSecurityGroupRuleResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupVpcSecurityGroupRuleResultOutput) Direction() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) string { return v.Direction }).(pulumi.StringOutput)
}

func (o LookupVpcSecurityGroupRuleResultOutput) FromPort() pulumi.IntOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) int { return v.FromPort }).(pulumi.IntOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupVpcSecurityGroupRuleResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupVpcSecurityGroupRuleResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupVpcSecurityGroupRuleResultOutput) Port() pulumi.IntOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) int { return v.Port }).(pulumi.IntOutput)
}

func (o LookupVpcSecurityGroupRuleResultOutput) PredefinedTarget() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) string { return v.PredefinedTarget }).(pulumi.StringOutput)
}

func (o LookupVpcSecurityGroupRuleResultOutput) Protocol() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) string { return v.Protocol }).(pulumi.StringOutput)
}

func (o LookupVpcSecurityGroupRuleResultOutput) RuleId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) string { return v.RuleId }).(pulumi.StringOutput)
}

func (o LookupVpcSecurityGroupRuleResultOutput) SecurityGroupBinding() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) string { return v.SecurityGroupBinding }).(pulumi.StringOutput)
}

func (o LookupVpcSecurityGroupRuleResultOutput) SecurityGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) string { return v.SecurityGroupId }).(pulumi.StringOutput)
}

func (o LookupVpcSecurityGroupRuleResultOutput) ToPort() pulumi.IntOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) int { return v.ToPort }).(pulumi.IntOutput)
}

func (o LookupVpcSecurityGroupRuleResultOutput) V4CidrBlocks() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) []string { return v.V4CidrBlocks }).(pulumi.StringArrayOutput)
}

func (o LookupVpcSecurityGroupRuleResultOutput) V6CidrBlocks() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupVpcSecurityGroupRuleResult) []string { return v.V6CidrBlocks }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupVpcSecurityGroupRuleResultOutput{})
}