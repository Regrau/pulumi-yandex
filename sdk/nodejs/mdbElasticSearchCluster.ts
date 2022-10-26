// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Manages a Elasticsearch cluster within the Yandex.Cloud. For more information, see
 * [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/concepts).
 *
 * ## Import
 *
 * A cluster can be imported using the `id` of the resource, e.g.
 *
 * ```sh
 *  $ pulumi import yandex:index/mdbElasticSearchCluster:MdbElasticSearchCluster foo cluster_id
 * ```
 */
export class MdbElasticSearchCluster extends pulumi.CustomResource {
    /**
     * Get an existing MdbElasticSearchCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MdbElasticSearchClusterState, opts?: pulumi.CustomResourceOptions): MdbElasticSearchCluster {
        return new MdbElasticSearchCluster(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/mdbElasticSearchCluster:MdbElasticSearchCluster';

    /**
     * Returns true if the given object is an instance of MdbElasticSearchCluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MdbElasticSearchCluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MdbElasticSearchCluster.__pulumiType;
    }

    /**
     * Configuration of the Elasticsearch cluster. The structure is documented below.
     */
    public readonly config!: pulumi.Output<outputs.MdbElasticSearchClusterConfig>;
    /**
     * Creation timestamp of the key.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * Inhibits deletion of the cluster.  Can be either `true` or `false`.
     */
    public readonly deletionProtection!: pulumi.Output<boolean>;
    /**
     * Description of the Elasticsearch cluster.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Deployment environment of the Elasticsearch cluster. Can be either `PRESTABLE` or `PRODUCTION`.
     */
    public readonly environment!: pulumi.Output<string>;
    /**
     * The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
     */
    public readonly folderId!: pulumi.Output<string>;
    /**
     * Aggregated health of the cluster. Can be either `ALIVE`, `DEGRADED`, `DEAD` or `HEALTH_UNKNOWN`.
     * For more information see `health` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
     */
    public /*out*/ readonly health!: pulumi.Output<string>;
    /**
     * A host of the Elasticsearch cluster. The structure is documented below.
     */
    public readonly hosts!: pulumi.Output<outputs.MdbElasticSearchClusterHost[]>;
    /**
     * A set of key/value label pairs to assign to the Elasticsearch cluster.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly maintenanceWindow!: pulumi.Output<outputs.MdbElasticSearchClusterMaintenanceWindow>;
    /**
     * User defined host name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * ID of the network, to which the Elasticsearch cluster belongs.
     */
    public readonly networkId!: pulumi.Output<string>;
    /**
     * A set of ids of security groups assigned to hosts of the cluster.
     */
    public readonly securityGroupIds!: pulumi.Output<string[] | undefined>;
    /**
     * ID of the service account authorized for this cluster.
     */
    public readonly serviceAccountId!: pulumi.Output<string | undefined>;
    /**
     * Status of the cluster. Can be either `CREATING`, `STARTING`, `RUNNING`, `UPDATING`, `STOPPING`, `STOPPED`, `ERROR` or `STATUS_UNKNOWN`.
     * For more information see `status` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
     */
    public /*out*/ readonly status!: pulumi.Output<string>;

    /**
     * Create a MdbElasticSearchCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MdbElasticSearchClusterArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MdbElasticSearchClusterArgs | MdbElasticSearchClusterState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MdbElasticSearchClusterState | undefined;
            resourceInputs["config"] = state ? state.config : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["deletionProtection"] = state ? state.deletionProtection : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["environment"] = state ? state.environment : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["health"] = state ? state.health : undefined;
            resourceInputs["hosts"] = state ? state.hosts : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["maintenanceWindow"] = state ? state.maintenanceWindow : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["networkId"] = state ? state.networkId : undefined;
            resourceInputs["securityGroupIds"] = state ? state.securityGroupIds : undefined;
            resourceInputs["serviceAccountId"] = state ? state.serviceAccountId : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as MdbElasticSearchClusterArgs | undefined;
            if ((!args || args.config === undefined) && !opts.urn) {
                throw new Error("Missing required property 'config'");
            }
            if ((!args || args.environment === undefined) && !opts.urn) {
                throw new Error("Missing required property 'environment'");
            }
            if ((!args || args.networkId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'networkId'");
            }
            resourceInputs["config"] = args ? args.config : undefined;
            resourceInputs["deletionProtection"] = args ? args.deletionProtection : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["environment"] = args ? args.environment : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["hosts"] = args ? args.hosts : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["maintenanceWindow"] = args ? args.maintenanceWindow : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["networkId"] = args ? args.networkId : undefined;
            resourceInputs["securityGroupIds"] = args ? args.securityGroupIds : undefined;
            resourceInputs["serviceAccountId"] = args ? args.serviceAccountId : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["health"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(MdbElasticSearchCluster.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MdbElasticSearchCluster resources.
 */
export interface MdbElasticSearchClusterState {
    /**
     * Configuration of the Elasticsearch cluster. The structure is documented below.
     */
    config?: pulumi.Input<inputs.MdbElasticSearchClusterConfig>;
    /**
     * Creation timestamp of the key.
     */
    createdAt?: pulumi.Input<string>;
    /**
     * Inhibits deletion of the cluster.  Can be either `true` or `false`.
     */
    deletionProtection?: pulumi.Input<boolean>;
    /**
     * Description of the Elasticsearch cluster.
     */
    description?: pulumi.Input<string>;
    /**
     * Deployment environment of the Elasticsearch cluster. Can be either `PRESTABLE` or `PRODUCTION`.
     */
    environment?: pulumi.Input<string>;
    /**
     * The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * Aggregated health of the cluster. Can be either `ALIVE`, `DEGRADED`, `DEAD` or `HEALTH_UNKNOWN`.
     * For more information see `health` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
     */
    health?: pulumi.Input<string>;
    /**
     * A host of the Elasticsearch cluster. The structure is documented below.
     */
    hosts?: pulumi.Input<pulumi.Input<inputs.MdbElasticSearchClusterHost>[]>;
    /**
     * A set of key/value label pairs to assign to the Elasticsearch cluster.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    maintenanceWindow?: pulumi.Input<inputs.MdbElasticSearchClusterMaintenanceWindow>;
    /**
     * User defined host name.
     */
    name?: pulumi.Input<string>;
    /**
     * ID of the network, to which the Elasticsearch cluster belongs.
     */
    networkId?: pulumi.Input<string>;
    /**
     * A set of ids of security groups assigned to hosts of the cluster.
     */
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * ID of the service account authorized for this cluster.
     */
    serviceAccountId?: pulumi.Input<string>;
    /**
     * Status of the cluster. Can be either `CREATING`, `STARTING`, `RUNNING`, `UPDATING`, `STOPPING`, `STOPPED`, `ERROR` or `STATUS_UNKNOWN`.
     * For more information see `status` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
     */
    status?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MdbElasticSearchCluster resource.
 */
export interface MdbElasticSearchClusterArgs {
    /**
     * Configuration of the Elasticsearch cluster. The structure is documented below.
     */
    config: pulumi.Input<inputs.MdbElasticSearchClusterConfig>;
    /**
     * Inhibits deletion of the cluster.  Can be either `true` or `false`.
     */
    deletionProtection?: pulumi.Input<boolean>;
    /**
     * Description of the Elasticsearch cluster.
     */
    description?: pulumi.Input<string>;
    /**
     * Deployment environment of the Elasticsearch cluster. Can be either `PRESTABLE` or `PRODUCTION`.
     */
    environment: pulumi.Input<string>;
    /**
     * The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * A host of the Elasticsearch cluster. The structure is documented below.
     */
    hosts?: pulumi.Input<pulumi.Input<inputs.MdbElasticSearchClusterHost>[]>;
    /**
     * A set of key/value label pairs to assign to the Elasticsearch cluster.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    maintenanceWindow?: pulumi.Input<inputs.MdbElasticSearchClusterMaintenanceWindow>;
    /**
     * User defined host name.
     */
    name?: pulumi.Input<string>;
    /**
     * ID of the network, to which the Elasticsearch cluster belongs.
     */
    networkId: pulumi.Input<string>;
    /**
     * A set of ids of security groups assigned to hosts of the cluster.
     */
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * ID of the service account authorized for this cluster.
     */
    serviceAccountId?: pulumi.Input<string>;
}
