// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Manages a Greenplum cluster within the Yandex.Cloud. For more information, see
 * [the official documentation](https://cloud.yandex.ru/docs/managed-greenplum/).
 *
 * Please read [Pricing for Managed Service for Greenplum](https://cloud.yandex.ru/docs/managed-greenplum/) before using Greenplum cluster.
 *
 * Yandex Managed Service for Greenplum® is now in preview
 *
 * ## Greenplum cluster settings
 *
 * | Setting name and type \ Greenplum version | 6.17 | 6.19 |
 * | ------------------------------------------| ---- | ---- |
 * | maxConnections : integer | supported | supported |
 * | maxPreparedTransactions : integer | supported | supported |
 * | gpWorkfileLimitPerQuery : integer | supported | supported |
 * | gpWorkfileLimitFilesPerQuery : integer | supported | supported |
 * | maxSlotWalKeepSize : integer | supported | supported |
 * | gpWorkfileLimitPerSegment : integer | supported | supported |
 * | gpWorkfileCompression : boolean | supported | supported |
 * | maxStatementMem : integer | - | supported |
 * | logStatement : one of<br>  - 0: " LOG_STATEMENT_UNSPECIFIED"<br>  - 1: " LOG_STATEMENT_NONE"<br>  - 2: " LOG_STATEMENT_DDL"<er>  - 3: " LOG_STATEMENT_MOD"<br>  - 4: " LOG_STATEMENT_ALL"  | - | supported |
 *
 * ## Import
 *
 * A cluster can be imported using the `id` of the resource, e.g.
 *
 * ```sh
 *  $ pulumi import yandex:index/mdbGreenplumCluster:MdbGreenplumCluster foo cluster_id
 * ```
 */
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

    /**
     * Access policy to the Greenplum cluster. The structure is documented below.
     */
    public readonly access!: pulumi.Output<outputs.MdbGreenplumClusterAccess>;
    /**
     * Sets whether the master hosts should get a public IP address on creation. Changing this parameter for an existing host is not supported at the moment.
     */
    public readonly assignPublicIp!: pulumi.Output<boolean>;
    /**
     * Time to start the daily backup, in the UTC timezone. The structure is documented below.
     */
    public readonly backupWindowStart!: pulumi.Output<outputs.MdbGreenplumClusterBackupWindowStart>;
    /**
     * Creation timestamp of the cluster.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * Inhibits deletion of the cluster.  Can be either `true` or `false`.
     */
    public readonly deletionProtection!: pulumi.Output<boolean>;
    /**
     * Description of the Greenplum cluster.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Deployment environment of the Greenplum cluster. (PRODUCTION, PRESTABLE)
     */
    public readonly environment!: pulumi.Output<string>;
    /**
     * The ID of the folder that the resource belongs to. If it
     * is not provided, the default provider folder is used.
     */
    public readonly folderId!: pulumi.Output<string>;
    /**
     * Greenplum cluster config. Detail info in "Greenplum cluster settings" section (documented below).
     */
    public readonly greenplumConfig!: pulumi.Output<{[key: string]: string}>;
    /**
     * Aggregated health of the cluster.
     */
    public /*out*/ readonly health!: pulumi.Output<string>;
    /**
     * A set of key/value label pairs to assign to the Greenplum cluster.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Maintenance policy of the Greenplum cluster. The structure is documented below.
     */
    public readonly maintenanceWindow!: pulumi.Output<outputs.MdbGreenplumClusterMaintenanceWindow>;
    /**
     * Number of hosts in master subcluster (1 or 2).
     */
    public readonly masterHostCount!: pulumi.Output<number>;
    /**
     * (Computed) Info about hosts in master subcluster. The structure is documented below.
     */
    public /*out*/ readonly masterHosts!: pulumi.Output<outputs.MdbGreenplumClusterMasterHost[]>;
    /**
     * Settings for master subcluster. The structure is documented below.
     */
    public readonly masterSubcluster!: pulumi.Output<outputs.MdbGreenplumClusterMasterSubcluster>;
    /**
     * Name of the Greenplum cluster. Provided by the client when the cluster is created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * ID of the network, to which the Greenplum cluster uses.
     */
    public readonly networkId!: pulumi.Output<string>;
    /**
     * Configuration of the connection pooler. The structure is documented below.
     */
    public readonly poolerConfig!: pulumi.Output<outputs.MdbGreenplumClusterPoolerConfig | undefined>;
    /**
     * A set of ids of security groups assigned to hosts of the cluster.
     */
    public readonly securityGroupIds!: pulumi.Output<string[] | undefined>;
    /**
     * Number of hosts in segment subcluster (from 1 to 32).
     */
    public readonly segmentHostCount!: pulumi.Output<number>;
    /**
     * (Computed) Info about hosts in segment subcluster. The structure is documented below.
     */
    public /*out*/ readonly segmentHosts!: pulumi.Output<outputs.MdbGreenplumClusterSegmentHost[]>;
    /**
     * Number of segments on segment host (not more then 1 + RAM/8).
     */
    public readonly segmentInHost!: pulumi.Output<number>;
    /**
     * Settings for segment subcluster. The structure is documented below.
     */
    public readonly segmentSubcluster!: pulumi.Output<outputs.MdbGreenplumClusterSegmentSubcluster>;
    /**
     * Status of the cluster.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * The ID of the subnet, to which the hosts belongs. The subnet must be a part of the network to which the cluster belongs.
     */
    public readonly subnetId!: pulumi.Output<string>;
    /**
     * Greenplum cluster admin user name.
     */
    public readonly userName!: pulumi.Output<string>;
    /**
     * Greenplum cluster admin password name.
     */
    public readonly userPassword!: pulumi.Output<string>;
    /**
     * Version of the Greenplum cluster. (6.19)
     */
    public readonly version!: pulumi.Output<string>;
    /**
     * The availability zone where the Greenplum hosts will be created.
     */
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
    /**
     * Access policy to the Greenplum cluster. The structure is documented below.
     */
    access?: pulumi.Input<inputs.MdbGreenplumClusterAccess>;
    /**
     * Sets whether the master hosts should get a public IP address on creation. Changing this parameter for an existing host is not supported at the moment.
     */
    assignPublicIp?: pulumi.Input<boolean>;
    /**
     * Time to start the daily backup, in the UTC timezone. The structure is documented below.
     */
    backupWindowStart?: pulumi.Input<inputs.MdbGreenplumClusterBackupWindowStart>;
    /**
     * Creation timestamp of the cluster.
     */
    createdAt?: pulumi.Input<string>;
    /**
     * Inhibits deletion of the cluster.  Can be either `true` or `false`.
     */
    deletionProtection?: pulumi.Input<boolean>;
    /**
     * Description of the Greenplum cluster.
     */
    description?: pulumi.Input<string>;
    /**
     * Deployment environment of the Greenplum cluster. (PRODUCTION, PRESTABLE)
     */
    environment?: pulumi.Input<string>;
    /**
     * The ID of the folder that the resource belongs to. If it
     * is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * Greenplum cluster config. Detail info in "Greenplum cluster settings" section (documented below).
     */
    greenplumConfig?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Aggregated health of the cluster.
     */
    health?: pulumi.Input<string>;
    /**
     * A set of key/value label pairs to assign to the Greenplum cluster.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Maintenance policy of the Greenplum cluster. The structure is documented below.
     */
    maintenanceWindow?: pulumi.Input<inputs.MdbGreenplumClusterMaintenanceWindow>;
    /**
     * Number of hosts in master subcluster (1 or 2).
     */
    masterHostCount?: pulumi.Input<number>;
    /**
     * (Computed) Info about hosts in master subcluster. The structure is documented below.
     */
    masterHosts?: pulumi.Input<pulumi.Input<inputs.MdbGreenplumClusterMasterHost>[]>;
    /**
     * Settings for master subcluster. The structure is documented below.
     */
    masterSubcluster?: pulumi.Input<inputs.MdbGreenplumClusterMasterSubcluster>;
    /**
     * Name of the Greenplum cluster. Provided by the client when the cluster is created.
     */
    name?: pulumi.Input<string>;
    /**
     * ID of the network, to which the Greenplum cluster uses.
     */
    networkId?: pulumi.Input<string>;
    /**
     * Configuration of the connection pooler. The structure is documented below.
     */
    poolerConfig?: pulumi.Input<inputs.MdbGreenplumClusterPoolerConfig>;
    /**
     * A set of ids of security groups assigned to hosts of the cluster.
     */
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Number of hosts in segment subcluster (from 1 to 32).
     */
    segmentHostCount?: pulumi.Input<number>;
    /**
     * (Computed) Info about hosts in segment subcluster. The structure is documented below.
     */
    segmentHosts?: pulumi.Input<pulumi.Input<inputs.MdbGreenplumClusterSegmentHost>[]>;
    /**
     * Number of segments on segment host (not more then 1 + RAM/8).
     */
    segmentInHost?: pulumi.Input<number>;
    /**
     * Settings for segment subcluster. The structure is documented below.
     */
    segmentSubcluster?: pulumi.Input<inputs.MdbGreenplumClusterSegmentSubcluster>;
    /**
     * Status of the cluster.
     */
    status?: pulumi.Input<string>;
    /**
     * The ID of the subnet, to which the hosts belongs. The subnet must be a part of the network to which the cluster belongs.
     */
    subnetId?: pulumi.Input<string>;
    /**
     * Greenplum cluster admin user name.
     */
    userName?: pulumi.Input<string>;
    /**
     * Greenplum cluster admin password name.
     */
    userPassword?: pulumi.Input<string>;
    /**
     * Version of the Greenplum cluster. (6.19)
     */
    version?: pulumi.Input<string>;
    /**
     * The availability zone where the Greenplum hosts will be created.
     */
    zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MdbGreenplumCluster resource.
 */
export interface MdbGreenplumClusterArgs {
    /**
     * Access policy to the Greenplum cluster. The structure is documented below.
     */
    access?: pulumi.Input<inputs.MdbGreenplumClusterAccess>;
    /**
     * Sets whether the master hosts should get a public IP address on creation. Changing this parameter for an existing host is not supported at the moment.
     */
    assignPublicIp: pulumi.Input<boolean>;
    /**
     * Time to start the daily backup, in the UTC timezone. The structure is documented below.
     */
    backupWindowStart?: pulumi.Input<inputs.MdbGreenplumClusterBackupWindowStart>;
    /**
     * Inhibits deletion of the cluster.  Can be either `true` or `false`.
     */
    deletionProtection?: pulumi.Input<boolean>;
    /**
     * Description of the Greenplum cluster.
     */
    description?: pulumi.Input<string>;
    /**
     * Deployment environment of the Greenplum cluster. (PRODUCTION, PRESTABLE)
     */
    environment: pulumi.Input<string>;
    /**
     * The ID of the folder that the resource belongs to. If it
     * is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * Greenplum cluster config. Detail info in "Greenplum cluster settings" section (documented below).
     */
    greenplumConfig?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A set of key/value label pairs to assign to the Greenplum cluster.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Maintenance policy of the Greenplum cluster. The structure is documented below.
     */
    maintenanceWindow?: pulumi.Input<inputs.MdbGreenplumClusterMaintenanceWindow>;
    /**
     * Number of hosts in master subcluster (1 or 2).
     */
    masterHostCount: pulumi.Input<number>;
    /**
     * Settings for master subcluster. The structure is documented below.
     */
    masterSubcluster: pulumi.Input<inputs.MdbGreenplumClusterMasterSubcluster>;
    /**
     * Name of the Greenplum cluster. Provided by the client when the cluster is created.
     */
    name?: pulumi.Input<string>;
    /**
     * ID of the network, to which the Greenplum cluster uses.
     */
    networkId: pulumi.Input<string>;
    /**
     * Configuration of the connection pooler. The structure is documented below.
     */
    poolerConfig?: pulumi.Input<inputs.MdbGreenplumClusterPoolerConfig>;
    /**
     * A set of ids of security groups assigned to hosts of the cluster.
     */
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Number of hosts in segment subcluster (from 1 to 32).
     */
    segmentHostCount: pulumi.Input<number>;
    /**
     * Number of segments on segment host (not more then 1 + RAM/8).
     */
    segmentInHost: pulumi.Input<number>;
    /**
     * Settings for segment subcluster. The structure is documented below.
     */
    segmentSubcluster: pulumi.Input<inputs.MdbGreenplumClusterSegmentSubcluster>;
    /**
     * The ID of the subnet, to which the hosts belongs. The subnet must be a part of the network to which the cluster belongs.
     */
    subnetId: pulumi.Input<string>;
    /**
     * Greenplum cluster admin user name.
     */
    userName: pulumi.Input<string>;
    /**
     * Greenplum cluster admin password name.
     */
    userPassword: pulumi.Input<string>;
    /**
     * Version of the Greenplum cluster. (6.19)
     */
    version: pulumi.Input<string>;
    /**
     * The availability zone where the Greenplum hosts will be created.
     */
    zone: pulumi.Input<string>;
}
