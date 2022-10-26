// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Allows management of [Yandex.Cloud Message Queue](https://cloud.yandex.com/docs/message-queue).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const exampleDeadletterQueue = new yandex.MessageQueue("exampleDeadletterQueue", {});
 * const exampleQueue = new yandex.MessageQueue("exampleQueue", {
 *     visibilityTimeoutSeconds: 600,
 *     receiveWaitTimeSeconds: 20,
 *     messageRetentionSeconds: 1209600,
 *     redrivePolicy: exampleDeadletterQueue.arn.apply(arn => JSON.stringify({
 *         deadLetterTargetArn: arn,
 *         maxReceiveCount: 3,
 *     })),
 * });
 * ```
 * ## FIFO queue
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const exampleFifoQueue = new yandex.MessageQueue("example_fifo_queue", {
 *     contentBasedDeduplication: true,
 *     fifoQueue: true,
 * });
 * ```
 *
 * ## Import
 *
 * Yandex Message Queues can be imported using its `queue url`, e.g.
 *
 * ```sh
 *  $ pulumi import yandex:index/messageQueue:MessageQueue example_import_queue https://message-queue.api.cloud.yandex.net/abcdefghijklmn123456/opqrstuvwxyz87654321/ymq_terraform_import_example
 * ```
 */
export class MessageQueue extends pulumi.CustomResource {
    /**
     * Get an existing MessageQueue resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MessageQueueState, opts?: pulumi.CustomResourceOptions): MessageQueue {
        return new MessageQueue(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/messageQueue:MessageQueue';

    /**
     * Returns true if the given object is an instance of MessageQueue.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MessageQueue {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MessageQueue.__pulumiType;
    }

    /**
     * The [access key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqAccessKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
     */
    public readonly accessKey!: pulumi.Output<string | undefined>;
    /**
     * ARN of the Yandex Message Queue. It is used for setting up a [redrive policy](https://cloud.yandex.com/docs/message-queue/concepts/dlq). See [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/SetQueueAttributes).
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * Enables [content-based deduplication](https://cloud.yandex.com/docs/message-queue/concepts/deduplication#content-based-deduplication). Can be used only if queue is [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues).
     */
    public readonly contentBasedDeduplication!: pulumi.Output<boolean | undefined>;
    /**
     * Number of seconds to [delay the message from being available for processing](https://cloud.yandex.com/docs/message-queue/concepts/delay-queues#delay-queues). Valid values: from 0 to 900 seconds (15 minutes). Default: 0.
     */
    public readonly delaySeconds!: pulumi.Output<number | undefined>;
    /**
     * Is this queue [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues). If this parameter is not used, a standard queue is created. You cannot change the parameter value for a created queue.
     */
    public readonly fifoQueue!: pulumi.Output<boolean | undefined>;
    /**
     * Maximum message size in bytes. Valid values: from 1024 bytes (1 KB) to 262144 bytes (256 KB). Default: 262144 (256 KB). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
     */
    public readonly maxMessageSize!: pulumi.Output<number | undefined>;
    /**
     * The length of time in seconds to retain a message. Valid values: from 60 seconds (1 minute) to 1209600 seconds (14 days). Default: 345600 (4 days). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
     */
    public readonly messageRetentionSeconds!: pulumi.Output<number | undefined>;
    /**
     * Queue name. The maximum length is 80 characters. You can use numbers, letters, underscores, and hyphens in the name. The name of a FIFO queue must end with the `.fifo` suffix. If not specified, random name will be generated. Conflicts with `namePrefix`. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Generates random name with the specified prefix. Conflicts with `name`.
     */
    public readonly namePrefix!: pulumi.Output<string | undefined>;
    /**
     * Wait time for the [ReceiveMessage](https://cloud.yandex.com/docs/message-queue/api-ref/message/ReceiveMessage) method (for long polling), in seconds. Valid values: from 0 to 20 seconds. Default: 0. For more information about long polling see [documentation](https://cloud.yandex.com/docs/message-queue/concepts/long-polling).
     */
    public readonly receiveWaitTimeSeconds!: pulumi.Output<number | undefined>;
    /**
     * Message redrive policy in [Dead Letter Queue](https://cloud.yandex.com/docs/message-queue/concepts/dlq). The source queue and DLQ must be the same type: for FIFO queues, the DLQ must also be a FIFO queue. For more information about redrive policy see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue). Also you can use example in this page.
     */
    public readonly redrivePolicy!: pulumi.Output<string | undefined>;
    /**
     * ID of the region where the message queue is located at.
     * The default is 'ru-central1'.
     */
    public readonly regionId!: pulumi.Output<string | undefined>;
    /**
     * The [secret key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqSecretKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
     */
    public readonly secretKey!: pulumi.Output<string | undefined>;
    /**
     * [Visibility timeout](https://cloud.yandex.com/docs/message-queue/concepts/visibility-timeout) for messages in a queue, specified in seconds. Valid values: from 0 to 43200 seconds (12 hours). Default: 30.
     */
    public readonly visibilityTimeoutSeconds!: pulumi.Output<number | undefined>;

    /**
     * Create a MessageQueue resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: MessageQueueArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MessageQueueArgs | MessageQueueState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MessageQueueState | undefined;
            resourceInputs["accessKey"] = state ? state.accessKey : undefined;
            resourceInputs["arn"] = state ? state.arn : undefined;
            resourceInputs["contentBasedDeduplication"] = state ? state.contentBasedDeduplication : undefined;
            resourceInputs["delaySeconds"] = state ? state.delaySeconds : undefined;
            resourceInputs["fifoQueue"] = state ? state.fifoQueue : undefined;
            resourceInputs["maxMessageSize"] = state ? state.maxMessageSize : undefined;
            resourceInputs["messageRetentionSeconds"] = state ? state.messageRetentionSeconds : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["namePrefix"] = state ? state.namePrefix : undefined;
            resourceInputs["receiveWaitTimeSeconds"] = state ? state.receiveWaitTimeSeconds : undefined;
            resourceInputs["redrivePolicy"] = state ? state.redrivePolicy : undefined;
            resourceInputs["regionId"] = state ? state.regionId : undefined;
            resourceInputs["secretKey"] = state ? state.secretKey : undefined;
            resourceInputs["visibilityTimeoutSeconds"] = state ? state.visibilityTimeoutSeconds : undefined;
        } else {
            const args = argsOrState as MessageQueueArgs | undefined;
            resourceInputs["accessKey"] = args ? args.accessKey : undefined;
            resourceInputs["contentBasedDeduplication"] = args ? args.contentBasedDeduplication : undefined;
            resourceInputs["delaySeconds"] = args ? args.delaySeconds : undefined;
            resourceInputs["fifoQueue"] = args ? args.fifoQueue : undefined;
            resourceInputs["maxMessageSize"] = args ? args.maxMessageSize : undefined;
            resourceInputs["messageRetentionSeconds"] = args ? args.messageRetentionSeconds : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["namePrefix"] = args ? args.namePrefix : undefined;
            resourceInputs["receiveWaitTimeSeconds"] = args ? args.receiveWaitTimeSeconds : undefined;
            resourceInputs["redrivePolicy"] = args ? args.redrivePolicy : undefined;
            resourceInputs["regionId"] = args ? args.regionId : undefined;
            resourceInputs["secretKey"] = args ? args.secretKey : undefined;
            resourceInputs["visibilityTimeoutSeconds"] = args ? args.visibilityTimeoutSeconds : undefined;
            resourceInputs["arn"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(MessageQueue.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MessageQueue resources.
 */
export interface MessageQueueState {
    /**
     * The [access key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqAccessKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
     */
    accessKey?: pulumi.Input<string>;
    /**
     * ARN of the Yandex Message Queue. It is used for setting up a [redrive policy](https://cloud.yandex.com/docs/message-queue/concepts/dlq). See [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/SetQueueAttributes).
     */
    arn?: pulumi.Input<string>;
    /**
     * Enables [content-based deduplication](https://cloud.yandex.com/docs/message-queue/concepts/deduplication#content-based-deduplication). Can be used only if queue is [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues).
     */
    contentBasedDeduplication?: pulumi.Input<boolean>;
    /**
     * Number of seconds to [delay the message from being available for processing](https://cloud.yandex.com/docs/message-queue/concepts/delay-queues#delay-queues). Valid values: from 0 to 900 seconds (15 minutes). Default: 0.
     */
    delaySeconds?: pulumi.Input<number>;
    /**
     * Is this queue [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues). If this parameter is not used, a standard queue is created. You cannot change the parameter value for a created queue.
     */
    fifoQueue?: pulumi.Input<boolean>;
    /**
     * Maximum message size in bytes. Valid values: from 1024 bytes (1 KB) to 262144 bytes (256 KB). Default: 262144 (256 KB). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
     */
    maxMessageSize?: pulumi.Input<number>;
    /**
     * The length of time in seconds to retain a message. Valid values: from 60 seconds (1 minute) to 1209600 seconds (14 days). Default: 345600 (4 days). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
     */
    messageRetentionSeconds?: pulumi.Input<number>;
    /**
     * Queue name. The maximum length is 80 characters. You can use numbers, letters, underscores, and hyphens in the name. The name of a FIFO queue must end with the `.fifo` suffix. If not specified, random name will be generated. Conflicts with `namePrefix`. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
     */
    name?: pulumi.Input<string>;
    /**
     * Generates random name with the specified prefix. Conflicts with `name`.
     */
    namePrefix?: pulumi.Input<string>;
    /**
     * Wait time for the [ReceiveMessage](https://cloud.yandex.com/docs/message-queue/api-ref/message/ReceiveMessage) method (for long polling), in seconds. Valid values: from 0 to 20 seconds. Default: 0. For more information about long polling see [documentation](https://cloud.yandex.com/docs/message-queue/concepts/long-polling).
     */
    receiveWaitTimeSeconds?: pulumi.Input<number>;
    /**
     * Message redrive policy in [Dead Letter Queue](https://cloud.yandex.com/docs/message-queue/concepts/dlq). The source queue and DLQ must be the same type: for FIFO queues, the DLQ must also be a FIFO queue. For more information about redrive policy see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue). Also you can use example in this page.
     */
    redrivePolicy?: pulumi.Input<string>;
    /**
     * ID of the region where the message queue is located at.
     * The default is 'ru-central1'.
     */
    regionId?: pulumi.Input<string>;
    /**
     * The [secret key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqSecretKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
     */
    secretKey?: pulumi.Input<string>;
    /**
     * [Visibility timeout](https://cloud.yandex.com/docs/message-queue/concepts/visibility-timeout) for messages in a queue, specified in seconds. Valid values: from 0 to 43200 seconds (12 hours). Default: 30.
     */
    visibilityTimeoutSeconds?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a MessageQueue resource.
 */
export interface MessageQueueArgs {
    /**
     * The [access key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqAccessKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
     */
    accessKey?: pulumi.Input<string>;
    /**
     * Enables [content-based deduplication](https://cloud.yandex.com/docs/message-queue/concepts/deduplication#content-based-deduplication). Can be used only if queue is [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues).
     */
    contentBasedDeduplication?: pulumi.Input<boolean>;
    /**
     * Number of seconds to [delay the message from being available for processing](https://cloud.yandex.com/docs/message-queue/concepts/delay-queues#delay-queues). Valid values: from 0 to 900 seconds (15 minutes). Default: 0.
     */
    delaySeconds?: pulumi.Input<number>;
    /**
     * Is this queue [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues). If this parameter is not used, a standard queue is created. You cannot change the parameter value for a created queue.
     */
    fifoQueue?: pulumi.Input<boolean>;
    /**
     * Maximum message size in bytes. Valid values: from 1024 bytes (1 KB) to 262144 bytes (256 KB). Default: 262144 (256 KB). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
     */
    maxMessageSize?: pulumi.Input<number>;
    /**
     * The length of time in seconds to retain a message. Valid values: from 60 seconds (1 minute) to 1209600 seconds (14 days). Default: 345600 (4 days). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
     */
    messageRetentionSeconds?: pulumi.Input<number>;
    /**
     * Queue name. The maximum length is 80 characters. You can use numbers, letters, underscores, and hyphens in the name. The name of a FIFO queue must end with the `.fifo` suffix. If not specified, random name will be generated. Conflicts with `namePrefix`. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
     */
    name?: pulumi.Input<string>;
    /**
     * Generates random name with the specified prefix. Conflicts with `name`.
     */
    namePrefix?: pulumi.Input<string>;
    /**
     * Wait time for the [ReceiveMessage](https://cloud.yandex.com/docs/message-queue/api-ref/message/ReceiveMessage) method (for long polling), in seconds. Valid values: from 0 to 20 seconds. Default: 0. For more information about long polling see [documentation](https://cloud.yandex.com/docs/message-queue/concepts/long-polling).
     */
    receiveWaitTimeSeconds?: pulumi.Input<number>;
    /**
     * Message redrive policy in [Dead Letter Queue](https://cloud.yandex.com/docs/message-queue/concepts/dlq). The source queue and DLQ must be the same type: for FIFO queues, the DLQ must also be a FIFO queue. For more information about redrive policy see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue). Also you can use example in this page.
     */
    redrivePolicy?: pulumi.Input<string>;
    /**
     * ID of the region where the message queue is located at.
     * The default is 'ru-central1'.
     */
    regionId?: pulumi.Input<string>;
    /**
     * The [secret key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqSecretKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
     */
    secretKey?: pulumi.Input<string>;
    /**
     * [Visibility timeout](https://cloud.yandex.com/docs/message-queue/concepts/visibility-timeout) for messages in a queue, specified in seconds. Valid values: from 0 to 43200 seconds (12 hours). Default: 30.
     */
    visibilityTimeoutSeconds?: pulumi.Input<number>;
}
