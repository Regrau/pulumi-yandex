// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Get information about a connector of the Yandex Managed Kafka cluster. For more information, see
 * [the official documentation](https://cloud.yandex.com/docs/managed-kafka/concepts).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const foo = pulumi.output(yandex.getMdbKafkaConnector({
 *     clusterId: "some_cluster_id",
 *     name: "test",
 * }));
 *
 * export const tasksMax = foo.tasksMax;
 * ```
 */
export function getMdbKafkaConnector(args: GetMdbKafkaConnectorArgs, opts?: pulumi.InvokeOptions): Promise<GetMdbKafkaConnectorResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getMdbKafkaConnector:getMdbKafkaConnector", {
        "clusterId": args.clusterId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getMdbKafkaConnector.
 */
export interface GetMdbKafkaConnectorArgs {
    /**
     * The ID of the Kafka cluster.
     */
    clusterId: string;
    /**
     * The name of the Kafka connector.
     */
    name: string;
}

/**
 * A collection of values returned by getMdbKafkaConnector.
 */
export interface GetMdbKafkaConnectorResult {
    readonly clusterId: string;
    /**
     * Params for MirrorMaker2 connector. The structure is documented below.
     */
    readonly connectorConfigMirrormakers: outputs.GetMdbKafkaConnectorConnectorConfigMirrormaker[];
    /**
     * Params for S3 Sink connector. The structure is documented below.
     */
    readonly connectorConfigS3Sinks: outputs.GetMdbKafkaConnectorConnectorConfigS3Sink[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
    /**
     * Additional properties for connector.
     */
    readonly properties: {[key: string]: string};
    /**
     * The number of the connector's parallel working tasks. Default is the number of brokers
     */
    readonly tasksMax: number;
}

export function getMdbKafkaConnectorOutput(args: GetMdbKafkaConnectorOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMdbKafkaConnectorResult> {
    return pulumi.output(args).apply(a => getMdbKafkaConnector(a, opts))
}

/**
 * A collection of arguments for invoking getMdbKafkaConnector.
 */
export interface GetMdbKafkaConnectorOutputArgs {
    /**
     * The ID of the Kafka cluster.
     */
    clusterId: pulumi.Input<string>;
    /**
     * The name of the Kafka connector.
     */
    name: pulumi.Input<string>;
}