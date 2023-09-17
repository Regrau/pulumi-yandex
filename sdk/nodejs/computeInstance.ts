// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * A VM instance resource. For more information, see
 * [the official documentation](https://cloud.yandex.com/docs/compute/concepts/vm).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fs from "fs";
 * import * as yandex from "@pulumi/yandex";
 *
 * const fooVpcNetwork = new yandex.VpcNetwork("foo", {});
 * const fooVpcSubnet = new yandex.VpcSubnet("foo", {
 *     networkId: fooVpcNetwork.id,
 *     v4CidrBlocks: ["10.5.0.0/24"],
 *     zone: "ru-central1-a",
 * });
 * const defaultComputeInstance = new yandex.ComputeInstance("default", {
 *     bootDisk: {
 *         initializeParams: {
 *             imageId: "image_id",
 *         },
 *     },
 *     metadata: {
 *         foo: "bar",
 *         "ssh-keys": `ubuntu:${fs.readFileSync("~/.ssh/id_rsa.pub", "utf-8")}`,
 *     },
 *     networkInterfaces: [{
 *         subnetId: fooVpcSubnet.id,
 *     }],
 *     platformId: "standard-v1",
 *     resources: {
 *         cores: 2,
 *         memory: 4,
 *     },
 *     zone: "ru-central1-a",
 * });
 * ```
 *
 * ## Import
 *
 * Instances can be imported using the `ID` of an instance, e.g.
 *
 * ```sh
 *  $ pulumi import yandex:index/computeInstance:ComputeInstance default instance_id
 * ```
 */
export class ComputeInstance extends pulumi.CustomResource {
    /**
     * Get an existing ComputeInstance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ComputeInstanceState, opts?: pulumi.CustomResourceOptions): ComputeInstance {
        return new ComputeInstance(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/computeInstance:ComputeInstance';

    /**
     * Returns true if the given object is an instance of ComputeInstance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ComputeInstance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ComputeInstance.__pulumiType;
    }

    public readonly allowRecreate!: pulumi.Output<boolean | undefined>;
    public readonly allowStoppingForUpdate!: pulumi.Output<boolean | undefined>;
    /**
     * The boot disk for the instance. The structure is documented below.
     */
    public readonly bootDisk!: pulumi.Output<outputs.ComputeInstanceBootDisk>;
    /**
     * Creation timestamp of the instance.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * Description of the boot disk.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * List of filesystems that are attached to the instance. Structure is documented below.
     */
    public readonly filesystems!: pulumi.Output<outputs.ComputeInstanceFilesystem[] | undefined>;
    /**
     * The ID of the folder that the resource belongs to. If it
     * is not provided, the default provider folder is used.
     */
    public readonly folderId!: pulumi.Output<string>;
    /**
     * DNS record FQDN (must have a dot at the end).
     */
    public /*out*/ readonly fqdn!: pulumi.Output<string>;
    /**
     * ID of the GPU cluster to attach this instance to. The GPU cluster must exist in the same zone as the instance.
     */
    public readonly gpuClusterId!: pulumi.Output<string>;
    /**
     * Host name for the instance. This field is used to generate the instance `fqdn` value. 
     * The host name must be unique within the network and region. If not specified, the host name will be equal
     * to `id` of the instance and `fqdn` will be `<id>.auto.internal`.
     * Otherwise FQDN will be `<hostname>.<region_id>.internal`.
     */
    public readonly hostname!: pulumi.Output<string>;
    /**
     * A set of key/value label pairs to assign to the instance.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * List of local disks that are attached to the instance. Structure is documented below.
     */
    public readonly localDisks!: pulumi.Output<outputs.ComputeInstanceLocalDisk[] | undefined>;
    /**
     * Metadata key/value pairs to make available from
     * within the instance.
     */
    public readonly metadata!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Options allow user to configure access to instance's metadata
     */
    public readonly metadataOptions!: pulumi.Output<outputs.ComputeInstanceMetadataOptions>;
    /**
     * Name of the boot disk.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Type of network acceleration. The default is `standard`. Values: `standard`, `softwareAccelerated`
     */
    public readonly networkAccelerationType!: pulumi.Output<string | undefined>;
    /**
     * Networks to attach to the instance. This can
     * be specified multiple times. The structure is documented below.
     */
    public readonly networkInterfaces!: pulumi.Output<outputs.ComputeInstanceNetworkInterface[]>;
    /**
     * The placement policy configuration. The structure is documented below.
     */
    public readonly placementPolicy!: pulumi.Output<outputs.ComputeInstancePlacementPolicy>;
    /**
     * The type of virtual machine to create. The default is 'standard-v1'.
     */
    public readonly platformId!: pulumi.Output<string | undefined>;
    /**
     * Compute resources that are allocated for the instance. The structure is documented below.
     */
    public readonly resources!: pulumi.Output<outputs.ComputeInstanceResources>;
    /**
     * Scheduling policy configuration. The structure is documented below.
     */
    public readonly schedulingPolicy!: pulumi.Output<outputs.ComputeInstanceSchedulingPolicy>;
    /**
     * A list of disks to attach to the instance. The structure is documented below.
     * **Note**: The `allowStoppingForUpdate` property must be set to true in order to update this structure.
     */
    public readonly secondaryDisks!: pulumi.Output<outputs.ComputeInstanceSecondaryDisk[] | undefined>;
    /**
     * ID of the service account authorized for this instance.
     */
    public readonly serviceAccountId!: pulumi.Output<string>;
    /**
     * The status of this instance.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * The availability zone where the virtual machine will be created. If it is not provided,
     * the default provider folder is used.
     */
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a ComputeInstance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ComputeInstanceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ComputeInstanceArgs | ComputeInstanceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ComputeInstanceState | undefined;
            resourceInputs["allowRecreate"] = state ? state.allowRecreate : undefined;
            resourceInputs["allowStoppingForUpdate"] = state ? state.allowStoppingForUpdate : undefined;
            resourceInputs["bootDisk"] = state ? state.bootDisk : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["filesystems"] = state ? state.filesystems : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["fqdn"] = state ? state.fqdn : undefined;
            resourceInputs["gpuClusterId"] = state ? state.gpuClusterId : undefined;
            resourceInputs["hostname"] = state ? state.hostname : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["localDisks"] = state ? state.localDisks : undefined;
            resourceInputs["metadata"] = state ? state.metadata : undefined;
            resourceInputs["metadataOptions"] = state ? state.metadataOptions : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["networkAccelerationType"] = state ? state.networkAccelerationType : undefined;
            resourceInputs["networkInterfaces"] = state ? state.networkInterfaces : undefined;
            resourceInputs["placementPolicy"] = state ? state.placementPolicy : undefined;
            resourceInputs["platformId"] = state ? state.platformId : undefined;
            resourceInputs["resources"] = state ? state.resources : undefined;
            resourceInputs["schedulingPolicy"] = state ? state.schedulingPolicy : undefined;
            resourceInputs["secondaryDisks"] = state ? state.secondaryDisks : undefined;
            resourceInputs["serviceAccountId"] = state ? state.serviceAccountId : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as ComputeInstanceArgs | undefined;
            if ((!args || args.bootDisk === undefined) && !opts.urn) {
                throw new Error("Missing required property 'bootDisk'");
            }
            if ((!args || args.networkInterfaces === undefined) && !opts.urn) {
                throw new Error("Missing required property 'networkInterfaces'");
            }
            if ((!args || args.resources === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resources'");
            }
            resourceInputs["allowRecreate"] = args ? args.allowRecreate : undefined;
            resourceInputs["allowStoppingForUpdate"] = args ? args.allowStoppingForUpdate : undefined;
            resourceInputs["bootDisk"] = args ? args.bootDisk : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["filesystems"] = args ? args.filesystems : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["gpuClusterId"] = args ? args.gpuClusterId : undefined;
            resourceInputs["hostname"] = args ? args.hostname : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["localDisks"] = args ? args.localDisks : undefined;
            resourceInputs["metadata"] = args ? args.metadata : undefined;
            resourceInputs["metadataOptions"] = args ? args.metadataOptions : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["networkAccelerationType"] = args ? args.networkAccelerationType : undefined;
            resourceInputs["networkInterfaces"] = args ? args.networkInterfaces : undefined;
            resourceInputs["placementPolicy"] = args ? args.placementPolicy : undefined;
            resourceInputs["platformId"] = args ? args.platformId : undefined;
            resourceInputs["resources"] = args ? args.resources : undefined;
            resourceInputs["schedulingPolicy"] = args ? args.schedulingPolicy : undefined;
            resourceInputs["secondaryDisks"] = args ? args.secondaryDisks : undefined;
            resourceInputs["serviceAccountId"] = args ? args.serviceAccountId : undefined;
            resourceInputs["zone"] = args ? args.zone : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["fqdn"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ComputeInstance.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ComputeInstance resources.
 */
export interface ComputeInstanceState {
    allowRecreate?: pulumi.Input<boolean>;
    allowStoppingForUpdate?: pulumi.Input<boolean>;
    /**
     * The boot disk for the instance. The structure is documented below.
     */
    bootDisk?: pulumi.Input<inputs.ComputeInstanceBootDisk>;
    /**
     * Creation timestamp of the instance.
     */
    createdAt?: pulumi.Input<string>;
    /**
     * Description of the boot disk.
     */
    description?: pulumi.Input<string>;
    /**
     * List of filesystems that are attached to the instance. Structure is documented below.
     */
    filesystems?: pulumi.Input<pulumi.Input<inputs.ComputeInstanceFilesystem>[]>;
    /**
     * The ID of the folder that the resource belongs to. If it
     * is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * DNS record FQDN (must have a dot at the end).
     */
    fqdn?: pulumi.Input<string>;
    /**
     * ID of the GPU cluster to attach this instance to. The GPU cluster must exist in the same zone as the instance.
     */
    gpuClusterId?: pulumi.Input<string>;
    /**
     * Host name for the instance. This field is used to generate the instance `fqdn` value. 
     * The host name must be unique within the network and region. If not specified, the host name will be equal
     * to `id` of the instance and `fqdn` will be `<id>.auto.internal`.
     * Otherwise FQDN will be `<hostname>.<region_id>.internal`.
     */
    hostname?: pulumi.Input<string>;
    /**
     * A set of key/value label pairs to assign to the instance.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * List of local disks that are attached to the instance. Structure is documented below.
     */
    localDisks?: pulumi.Input<pulumi.Input<inputs.ComputeInstanceLocalDisk>[]>;
    /**
     * Metadata key/value pairs to make available from
     * within the instance.
     */
    metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Options allow user to configure access to instance's metadata
     */
    metadataOptions?: pulumi.Input<inputs.ComputeInstanceMetadataOptions>;
    /**
     * Name of the boot disk.
     */
    name?: pulumi.Input<string>;
    /**
     * Type of network acceleration. The default is `standard`. Values: `standard`, `softwareAccelerated`
     */
    networkAccelerationType?: pulumi.Input<string>;
    /**
     * Networks to attach to the instance. This can
     * be specified multiple times. The structure is documented below.
     */
    networkInterfaces?: pulumi.Input<pulumi.Input<inputs.ComputeInstanceNetworkInterface>[]>;
    /**
     * The placement policy configuration. The structure is documented below.
     */
    placementPolicy?: pulumi.Input<inputs.ComputeInstancePlacementPolicy>;
    /**
     * The type of virtual machine to create. The default is 'standard-v1'.
     */
    platformId?: pulumi.Input<string>;
    /**
     * Compute resources that are allocated for the instance. The structure is documented below.
     */
    resources?: pulumi.Input<inputs.ComputeInstanceResources>;
    /**
     * Scheduling policy configuration. The structure is documented below.
     */
    schedulingPolicy?: pulumi.Input<inputs.ComputeInstanceSchedulingPolicy>;
    /**
     * A list of disks to attach to the instance. The structure is documented below.
     * **Note**: The `allowStoppingForUpdate` property must be set to true in order to update this structure.
     */
    secondaryDisks?: pulumi.Input<pulumi.Input<inputs.ComputeInstanceSecondaryDisk>[]>;
    /**
     * ID of the service account authorized for this instance.
     */
    serviceAccountId?: pulumi.Input<string>;
    /**
     * The status of this instance.
     */
    status?: pulumi.Input<string>;
    /**
     * The availability zone where the virtual machine will be created. If it is not provided,
     * the default provider folder is used.
     */
    zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ComputeInstance resource.
 */
export interface ComputeInstanceArgs {
    allowRecreate?: pulumi.Input<boolean>;
    allowStoppingForUpdate?: pulumi.Input<boolean>;
    /**
     * The boot disk for the instance. The structure is documented below.
     */
    bootDisk: pulumi.Input<inputs.ComputeInstanceBootDisk>;
    /**
     * Description of the boot disk.
     */
    description?: pulumi.Input<string>;
    /**
     * List of filesystems that are attached to the instance. Structure is documented below.
     */
    filesystems?: pulumi.Input<pulumi.Input<inputs.ComputeInstanceFilesystem>[]>;
    /**
     * The ID of the folder that the resource belongs to. If it
     * is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * ID of the GPU cluster to attach this instance to. The GPU cluster must exist in the same zone as the instance.
     */
    gpuClusterId?: pulumi.Input<string>;
    /**
     * Host name for the instance. This field is used to generate the instance `fqdn` value. 
     * The host name must be unique within the network and region. If not specified, the host name will be equal
     * to `id` of the instance and `fqdn` will be `<id>.auto.internal`.
     * Otherwise FQDN will be `<hostname>.<region_id>.internal`.
     */
    hostname?: pulumi.Input<string>;
    /**
     * A set of key/value label pairs to assign to the instance.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * List of local disks that are attached to the instance. Structure is documented below.
     */
    localDisks?: pulumi.Input<pulumi.Input<inputs.ComputeInstanceLocalDisk>[]>;
    /**
     * Metadata key/value pairs to make available from
     * within the instance.
     */
    metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Options allow user to configure access to instance's metadata
     */
    metadataOptions?: pulumi.Input<inputs.ComputeInstanceMetadataOptions>;
    /**
     * Name of the boot disk.
     */
    name?: pulumi.Input<string>;
    /**
     * Type of network acceleration. The default is `standard`. Values: `standard`, `softwareAccelerated`
     */
    networkAccelerationType?: pulumi.Input<string>;
    /**
     * Networks to attach to the instance. This can
     * be specified multiple times. The structure is documented below.
     */
    networkInterfaces: pulumi.Input<pulumi.Input<inputs.ComputeInstanceNetworkInterface>[]>;
    /**
     * The placement policy configuration. The structure is documented below.
     */
    placementPolicy?: pulumi.Input<inputs.ComputeInstancePlacementPolicy>;
    /**
     * The type of virtual machine to create. The default is 'standard-v1'.
     */
    platformId?: pulumi.Input<string>;
    /**
     * Compute resources that are allocated for the instance. The structure is documented below.
     */
    resources: pulumi.Input<inputs.ComputeInstanceResources>;
    /**
     * Scheduling policy configuration. The structure is documented below.
     */
    schedulingPolicy?: pulumi.Input<inputs.ComputeInstanceSchedulingPolicy>;
    /**
     * A list of disks to attach to the instance. The structure is documented below.
     * **Note**: The `allowStoppingForUpdate` property must be set to true in order to update this structure.
     */
    secondaryDisks?: pulumi.Input<pulumi.Input<inputs.ComputeInstanceSecondaryDisk>[]>;
    /**
     * ID of the service account authorized for this instance.
     */
    serviceAccountId?: pulumi.Input<string>;
    /**
     * The availability zone where the virtual machine will be created. If it is not provided,
     * the default provider folder is used.
     */
    zone?: pulumi.Input<string>;
}
