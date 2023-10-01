// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class YandexYdbTopicIndex extends pulumi.CustomResource {
    /**
     * Get an existing YandexYdbTopicIndex resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: YandexYdbTopicIndexState, opts?: pulumi.CustomResourceOptions): YandexYdbTopicIndex {
        return new YandexYdbTopicIndex(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/yandexYdbTopicIndex:yandexYdbTopicIndex';

    /**
     * Returns true if the given object is an instance of YandexYdbTopicIndex.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is YandexYdbTopicIndex {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === YandexYdbTopicIndex.__pulumiType;
    }

    public readonly columns!: pulumi.Output<string[]>;
    public readonly connectionString!: pulumi.Output<string>;
    public readonly covers!: pulumi.Output<string[] | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly tableId!: pulumi.Output<string>;
    public readonly tablePath!: pulumi.Output<string>;
    public readonly type!: pulumi.Output<string>;

    /**
     * Create a YandexYdbTopicIndex resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: YandexYdbTopicIndexArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: YandexYdbTopicIndexArgs | YandexYdbTopicIndexState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as YandexYdbTopicIndexState | undefined;
            resourceInputs["columns"] = state ? state.columns : undefined;
            resourceInputs["connectionString"] = state ? state.connectionString : undefined;
            resourceInputs["covers"] = state ? state.covers : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["tableId"] = state ? state.tableId : undefined;
            resourceInputs["tablePath"] = state ? state.tablePath : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
        } else {
            const args = argsOrState as YandexYdbTopicIndexArgs | undefined;
            if ((!args || args.columns === undefined) && !opts.urn) {
                throw new Error("Missing required property 'columns'");
            }
            if ((!args || args.type === undefined) && !opts.urn) {
                throw new Error("Missing required property 'type'");
            }
            resourceInputs["columns"] = args ? args.columns : undefined;
            resourceInputs["connectionString"] = args ? args.connectionString : undefined;
            resourceInputs["covers"] = args ? args.covers : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["tableId"] = args ? args.tableId : undefined;
            resourceInputs["tablePath"] = args ? args.tablePath : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(YandexYdbTopicIndex.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering yandexYdbTopicIndex resources.
 */
export interface YandexYdbTopicIndexState {
    columns?: pulumi.Input<pulumi.Input<string>[]>;
    connectionString?: pulumi.Input<string>;
    covers?: pulumi.Input<pulumi.Input<string>[]>;
    name?: pulumi.Input<string>;
    tableId?: pulumi.Input<string>;
    tablePath?: pulumi.Input<string>;
    type?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a YandexYdbTopicIndex resource.
 */
export interface YandexYdbTopicIndexArgs {
    columns: pulumi.Input<pulumi.Input<string>[]>;
    connectionString?: pulumi.Input<string>;
    covers?: pulumi.Input<pulumi.Input<string>[]>;
    name?: pulumi.Input<string>;
    tableId?: pulumi.Input<string>;
    tablePath?: pulumi.Input<string>;
    type: pulumi.Input<string>;
}