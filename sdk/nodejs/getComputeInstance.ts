// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Get information about a Yandex Compute instance. For more information, see
 * [the official documentation](https://cloud.yandex.com/docs/compute/concepts/vm).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const myInstance = pulumi.output(yandex.getComputeInstance({
 *     instanceId: "some_instance_id",
 * }));
 *
 * export const instanceExternalIp = myInstance.networkInterfaces[0].natIpAddress;
 * ```
 */
export function getComputeInstance(args?: GetComputeInstanceArgs, opts?: pulumi.InvokeOptions): Promise<GetComputeInstanceResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getComputeInstance:getComputeInstance", {
        "filesystems": args.filesystems,
        "folderId": args.folderId,
        "instanceId": args.instanceId,
        "localDisks": args.localDisks,
        "metadataOptions": args.metadataOptions,
        "name": args.name,
        "placementPolicy": args.placementPolicy,
    }, opts);
}

/**
 * A collection of arguments for invoking getComputeInstance.
 */
export interface GetComputeInstanceArgs {
    filesystems?: inputs.GetComputeInstanceFilesystem[];
    /**
     * Folder that the resource belongs to. If value is omitted, the default provider folder is used.
     */
    folderId?: string;
    /**
     * The ID of a specific instance.
     */
    instanceId?: string;
    /**
     * List of local disks that are attached to the instance. Structure is documented below.
     */
    localDisks?: inputs.GetComputeInstanceLocalDisk[];
    /**
     * Options allow user to configure access to instance's metadata
     */
    metadataOptions?: inputs.GetComputeInstanceMetadataOptions;
    /**
     * Name of the instance.
     */
    name?: string;
    /**
     * The placement policy configuration. The structure is documented below.
     */
    placementPolicy?: inputs.GetComputeInstancePlacementPolicy;
}

/**
 * A collection of values returned by getComputeInstance.
 */
export interface GetComputeInstanceResult {
    /**
     * The boot disk for the instance. Structure is documented below.
     */
    readonly bootDisks: outputs.GetComputeInstanceBootDisk[];
    /**
     * Instance creation timestamp.
     */
    readonly createdAt: string;
    /**
     * Description of the boot disk.
     */
    readonly description: string;
    readonly filesystems?: outputs.GetComputeInstanceFilesystem[];
    readonly folderId: string;
    /**
     * DNS record FQDN.
     */
    readonly fqdn: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    /**
     * A set of key/value label pairs assigned to the instance.
     */
    readonly labels: {[key: string]: string};
    /**
     * List of local disks that are attached to the instance. Structure is documented below.
     */
    readonly localDisks?: outputs.GetComputeInstanceLocalDisk[];
    /**
     * Metadata key/value pairs to make available from
     * within the instance.
     */
    readonly metadata: {[key: string]: string};
    /**
     * Options allow user to configure access to instance's metadata
     */
    readonly metadataOptions: outputs.GetComputeInstanceMetadataOptions;
    /**
     * Name of the boot disk.
     */
    readonly name: string;
    /**
     * Type of network acceleration. The default is `standard`. Values: `standard`, `softwareAccelerated`
     */
    readonly networkAccelerationType: string;
    /**
     * The networks attached to the instance. Structure is documented below.
     * * `network_interface.0.ip_address` - An internal IP address of the instance, either manually or dynamically assigned.
     * * `network_interface.0.nat_ip_address` - An assigned external IP address if the instance has NAT enabled.
     */
    readonly networkInterfaces: outputs.GetComputeInstanceNetworkInterface[];
    /**
     * The placement policy configuration. The structure is documented below.
     */
    readonly placementPolicy?: outputs.GetComputeInstancePlacementPolicy;
    /**
     * Type of virtual machine to create. Default is 'standard-v1'.
     */
    readonly platformId: string;
    readonly resources: outputs.GetComputeInstanceResource[];
    /**
     * Scheduling policy configuration. The structure is documented below.
     */
    readonly schedulingPolicies: outputs.GetComputeInstanceSchedulingPolicy[];
    /**
     * List of secondary disks attached to the instance. Structure is documented below.
     */
    readonly secondaryDisks: outputs.GetComputeInstanceSecondaryDisk[];
    /**
     * ID of the service account authorized for this instance.
     */
    readonly serviceAccountId: string;
    /**
     * Status of the instance.
     * * `resources.0.memory` - Memory size allocated for the instance.
     * * `resources.0.cores` - Number of CPU cores allocated for the instance.
     * * `resources.0.core_fraction` - Baseline performance for a core, set as a percent.
     * * `resources.0.gpus` - Number of GPU cores allocated for the instance.
     */
    readonly status: string;
    /**
     * Availability zone where the instance resides.
     */
    readonly zone: string;
}

export function getComputeInstanceOutput(args?: GetComputeInstanceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetComputeInstanceResult> {
    return pulumi.output(args).apply(a => getComputeInstance(a, opts))
}

/**
 * A collection of arguments for invoking getComputeInstance.
 */
export interface GetComputeInstanceOutputArgs {
    filesystems?: pulumi.Input<pulumi.Input<inputs.GetComputeInstanceFilesystemArgs>[]>;
    /**
     * Folder that the resource belongs to. If value is omitted, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * The ID of a specific instance.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * List of local disks that are attached to the instance. Structure is documented below.
     */
    localDisks?: pulumi.Input<pulumi.Input<inputs.GetComputeInstanceLocalDiskArgs>[]>;
    /**
     * Options allow user to configure access to instance's metadata
     */
    metadataOptions?: pulumi.Input<inputs.GetComputeInstanceMetadataOptionsArgs>;
    /**
     * Name of the instance.
     */
    name?: pulumi.Input<string>;
    /**
     * The placement policy configuration. The structure is documented below.
     */
    placementPolicy?: pulumi.Input<inputs.GetComputeInstancePlacementPolicyArgs>;
}
