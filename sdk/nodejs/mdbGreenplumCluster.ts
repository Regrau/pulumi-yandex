// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export class MdbGreenplumCluster extends pulumi.CustomResource {
    /**
     * Get an existing MdbGreenplumCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MdbGreenplumClusterState, opts?: pulumi.CustomResourceOptions): MdbGreenplumCluster {
        return new MdbGreenplumCluster(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/mdbGreenplumCluster:MdbGreenplumCluster';

    /**
     * Returns true if the given object is an instance of MdbGreenplumCluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MdbGreenplumCluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MdbGreenplumCluster.__pulumiType;
    }

    public readonly access!: pulumi.Output<outputs.MdbGreenplumClusterAccess>;
    public readonly assignPublicIp!: pulumi.Output<boolean>;
    public readonly backupWindowStart!: pulumi.Output<outputs.MdbGreenplumClusterBackupWindowStart>;
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly deletionProtection!: pulumi.Output<boolean>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly environment!: pulumi.Output<string>;
    public readonly folderId!: pulumi.Output<string>;
    public readonly greenplumConfig!: pulumi.Output<{[key: string]: string}>;
    public /*out*/ readonly health!: pulumi.Output<string>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly maintenanceWindow!: pulumi.Output<outputs.MdbGreenplumClusterMaintenanceWindow>;
    public readonly masterHostCount!: pulumi.Output<number>;
    public /*out*/ readonly masterHosts!: pulumi.Output<outputs.MdbGreenplumClusterMasterHost[]>;
    public readonly masterSubcluster!: pulumi.Output<outputs.MdbGreenplumClusterMasterSubcluster>;
    public readonly name!: pulumi.Output<string>;
    public readonly networkId!: pulumi.Output<string>;
    public readonly poolerConfig!: pulumi.Output<outputs.MdbGreenplumClusterPoolerConfig | undefined>;
    public readonly securityGroupIds!: pulumi.Output<string[] | undefined>;
    public readonly segmentHostCount!: pulumi.Output<number>;
    public /*out*/ readonly segmentHosts!: pulumi.Output<outputs.MdbGreenplumClusterSegmentHost[]>;
    public readonly segmentInHost!: pulumi.Output<number>;
    public readonly segmentSubcluster!: pulumi.Output<outputs.MdbGreenplumClusterSegmentSubcluster>;
    public /*out*/ readonly status!: pulumi.Output<string>;
    public readonly subnetId!: pulumi.Output<string>;
    public readonly userName!: pulumi.Output<string>;
    public readonly userPassword!: pulumi.Output<string>;
    public readonly version!: pulumi.Output<string>;
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a MdbGreenplumCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MdbGreenplumClusterArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MdbGreenplumClusterArgs | MdbGreenplumClusterState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MdbGreenplumClusterState | undefined;
            resourceInputs["access"] = state ? state.access : undefined;
            resourceInputs["assignPublicIp"] = state ? state.assignPublicIp : undefined;
            resourceInputs["backupWindowStart"] = state ? state.backupWindowStart : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["deletionProtection"] = state ? state.deletionProtection : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["environment"] = state ? state.environment : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["greenplumConfig"] = state ? state.greenplumConfig : undefined;
            resourceInputs["health"] = state ? state.health : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["maintenanceWindow"] = state ? state.maintenanceWindow : undefined;
            resourceInputs["masterHostCount"] = state ? state.masterHostCount : undefined;
            resourceInputs["masterHosts"] = state ? state.masterHosts : undefined;
            resourceInputs["masterSubcluster"] = state ? state.masterSubcluster : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["networkId"] = state ? state.networkId : undefined;
            resourceInputs["poolerConfig"] = state ? state.poolerConfig : undefined;
            resourceInputs["securityGroupIds"] = state ? state.securityGroupIds : undefined;
            resourceInputs["segmentHostCount"] = state ? state.segmentHostCount : undefined;
            resourceInputs["segmentHosts"] = state ? state.segmentHosts : undefined;
            resourceInputs["segmentInHost"] = state ? state.segmentInHost : undefined;
            resourceInputs["segmentSubcluster"] = state ? state.segmentSubcluster : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["subnetId"] = state ? state.subnetId : undefined;
            resourceInputs["userName"] = state ? state.userName : undefined;
            resourceInputs["userPassword"] = state ? state.userPassword : undefined;
            resourceInputs["version"] = state ? state.version : undefined;
            resourceInputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as MdbGreenplumClusterArgs | undefined;
            if ((!args || args.assignPublicIp === undefined) && !opts.urn) {
                throw new Error("Missing required property 'assignPublicIp'");
            }
            if ((!args || args.environment === undefined) && !opts.urn) {
                throw new Error("Missing required property 'environment'");
            }
            if ((!args || args.masterHostCount === undefined) && !opts.urn) {
                throw new Error("Missing required property 'masterHostCount'");
            }
            if ((!args || args.masterSubcluster === undefined) && !opts.urn) {
                throw new Error("Missing required property 'masterSubcluster'");
            }
            if ((!args || args.networkId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'networkId'");
            }
            if ((!args || args.segmentHostCount === undefined) && !opts.urn) {
                throw new Error("Missing required property 'segmentHostCount'");
            }
            if ((!args || args.segmentInHost === undefined) && !opts.urn) {
                throw new Error("Missing required property 'segmentInHost'");
            }
            if ((!args || args.segmentSubcluster === undefined) && !opts.urn) {
                throw new Error("Missing required property 'segmentSubcluster'");
            }
            if ((!args || args.subnetId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'subnetId'");
            }
            if ((!args || args.userName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'userName'");
            }
            if ((!args || args.userPassword === undefined) && !opts.urn) {
                throw new Error("Missing required property 'userPassword'");
            }
            if ((!args || args.version === undefined) && !opts.urn) {
                throw new Error("Missing required property 'version'");
            }
            if ((!args || args.zone === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zone'");
            }
            resourceInputs["access"] = args ? args.access : undefined;
            resourceInputs["assignPublicIp"] = args ? args.assignPublicIp : undefined;
            resourceInputs["backupWindowStart"] = args ? args.backupWindowStart : undefined;
            resourceInputs["deletionProtection"] = args ? args.deletionProtection : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["environment"] = args ? args.environment : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["greenplumConfig"] = args ? args.greenplumConfig : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["maintenanceWindow"] = args ? args.maintenanceWindow : undefined;
            resourceInputs["masterHostCount"] = args ? args.masterHostCount : undefined;
            resourceInputs["masterSubcluster"] = args ? args.masterSubcluster : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["networkId"] = args ? args.networkId : undefined;
            resourceInputs["poolerConfig"] = args ? args.poolerConfig : undefined;
            resourceInputs["securityGroupIds"] = args ? args.securityGroupIds : undefined;
            resourceInputs["segmentHostCount"] = args ? args.segmentHostCount : undefined;
            resourceInputs["segmentInHost"] = args ? args.segmentInHost : undefined;
            resourceInputs["segmentSubcluster"] = args ? args.segmentSubcluster : undefined;
            resourceInputs["subnetId"] = args ? args.subnetId : undefined;
            resourceInputs["userName"] = args ? args.userName : undefined;
            resourceInputs["userPassword"] = args ? args.userPassword : undefined;
            resourceInputs["version"] = args ? args.version : undefined;
            resourceInputs["zone"] = args ? args.zone : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["health"] = undefined /*out*/;
            resourceInputs["masterHosts"] = undefined /*out*/;
            resourceInputs["segmentHosts"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(MdbGreenplumCluster.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MdbGreenplumCluster resources.
 */
export interface MdbGreenplumClusterState {
    access?: pulumi.Input<inputs.MdbGreenplumClusterAccess>;
    assignPublicIp?: pulumi.Input<boolean>;
    backupWindowStart?: pulumi.Input<inputs.MdbGreenplumClusterBackupWindowStart>;
    createdAt?: pulumi.Input<string>;
    deletionProtection?: pulumi.Input<boolean>;
    description?: pulumi.Input<string>;
    environment?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    greenplumConfig?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    health?: pulumi.Input<string>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    maintenanceWindow?: pulumi.Input<inputs.MdbGreenplumClusterMaintenanceWindow>;
    masterHostCount?: pulumi.Input<number>;
    masterHosts?: pulumi.Input<pulumi.Input<inputs.MdbGreenplumClusterMasterHost>[]>;
    masterSubcluster?: pulumi.Input<inputs.MdbGreenplumClusterMasterSubcluster>;
    name?: pulumi.Input<string>;
    networkId?: pulumi.Input<string>;
    poolerConfig?: pulumi.Input<inputs.MdbGreenplumClusterPoolerConfig>;
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    segmentHostCount?: pulumi.Input<number>;
    segmentHosts?: pulumi.Input<pulumi.Input<inputs.MdbGreenplumClusterSegmentHost>[]>;
    segmentInHost?: pulumi.Input<number>;
    segmentSubcluster?: pulumi.Input<inputs.MdbGreenplumClusterSegmentSubcluster>;
    status?: pulumi.Input<string>;
    subnetId?: pulumi.Input<string>;
    userName?: pulumi.Input<string>;
    userPassword?: pulumi.Input<string>;
    version?: pulumi.Input<string>;
    zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MdbGreenplumCluster resource.
 */
export interface MdbGreenplumClusterArgs {
    access?: pulumi.Input<inputs.MdbGreenplumClusterAccess>;
    assignPublicIp: pulumi.Input<boolean>;
    backupWindowStart?: pulumi.Input<inputs.MdbGreenplumClusterBackupWindowStart>;
    deletionProtection?: pulumi.Input<boolean>;
    description?: pulumi.Input<string>;
    environment: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    greenplumConfig?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    maintenanceWindow?: pulumi.Input<inputs.MdbGreenplumClusterMaintenanceWindow>;
    masterHostCount: pulumi.Input<number>;
    masterSubcluster: pulumi.Input<inputs.MdbGreenplumClusterMasterSubcluster>;
    name?: pulumi.Input<string>;
    networkId: pulumi.Input<string>;
    poolerConfig?: pulumi.Input<inputs.MdbGreenplumClusterPoolerConfig>;
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    segmentHostCount: pulumi.Input<number>;
    segmentInHost: pulumi.Input<number>;
    segmentSubcluster: pulumi.Input<inputs.MdbGreenplumClusterSegmentSubcluster>;
    subnetId: pulumi.Input<string>;
    userName: pulumi.Input<string>;
    userPassword: pulumi.Input<string>;
    version: pulumi.Input<string>;
    zone: pulumi.Input<string>;
}
