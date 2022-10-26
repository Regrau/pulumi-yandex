// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export function getVpcSecurityGroupRule(args: GetVpcSecurityGroupRuleArgs, opts?: pulumi.InvokeOptions): Promise<GetVpcSecurityGroupRuleResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getVpcSecurityGroupRule:getVpcSecurityGroupRule", {
        "ruleId": args.ruleId,
        "securityGroupBinding": args.securityGroupBinding,
    }, opts);
}

/**
 * A collection of arguments for invoking getVpcSecurityGroupRule.
 */
export interface GetVpcSecurityGroupRuleArgs {
    ruleId: string;
    securityGroupBinding: string;
}

/**
 * A collection of values returned by getVpcSecurityGroupRule.
 */
export interface GetVpcSecurityGroupRuleResult {
    readonly description: string;
    readonly direction: string;
    readonly fromPort: number;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly port: number;
    readonly predefinedTarget: string;
    readonly protocol: string;
    readonly ruleId: string;
    readonly securityGroupBinding: string;
    readonly securityGroupId: string;
    readonly toPort: number;
    readonly v4CidrBlocks: string[];
    readonly v6CidrBlocks: string[];
}

export function getVpcSecurityGroupRuleOutput(args: GetVpcSecurityGroupRuleOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetVpcSecurityGroupRuleResult> {
    return pulumi.output(args).apply(a => getVpcSecurityGroupRule(a, opts))
}

/**
 * A collection of arguments for invoking getVpcSecurityGroupRule.
 */
export interface GetVpcSecurityGroupRuleOutputArgs {
    ruleId: pulumi.Input<string>;
    securityGroupBinding: pulumi.Input<string>;
}
