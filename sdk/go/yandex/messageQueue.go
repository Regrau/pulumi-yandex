// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Allows management of [Yandex.Cloud Message Queue](https://cloud.yandex.com/docs/message-queue).
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"encoding/json"
//
//	"github.com/pulumi/pulumi-yandex/sdk/go/yandex"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			exampleDeadletterQueue, err := yandex.NewMessageQueue(ctx, "exampleDeadletterQueue", nil)
//			if err != nil {
//				return err
//			}
//			_, err = yandex.NewMessageQueue(ctx, "exampleQueue", &yandex.MessageQueueArgs{
//				VisibilityTimeoutSeconds: pulumi.Int(600),
//				ReceiveWaitTimeSeconds:   pulumi.Int(20),
//				MessageRetentionSeconds:  pulumi.Int(1209600),
//				RedrivePolicy: exampleDeadletterQueue.Arn.ApplyT(func(arn string) (pulumi.String, error) {
//					var _zero pulumi.String
//					tmpJSON0, err := json.Marshal(map[string]interface{}{
//						"deadLetterTargetArn": arn,
//						"maxReceiveCount":     3,
//					})
//					if err != nil {
//						return _zero, err
//					}
//					json0 := string(tmpJSON0)
//					return pulumi.String(json0), nil
//				}).(pulumi.StringOutput),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// ## FIFO queue
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-yandex/sdk/go/yandex"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := yandex.NewMessageQueue(ctx, "exampleFifoQueue", &yandex.MessageQueueArgs{
//				ContentBasedDeduplication: pulumi.Bool(true),
//				FifoQueue:                 pulumi.Bool(true),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
//
// ## Import
//
// Yandex Message Queues can be imported using its `queue url`, e.g.
//
// ```sh
//
//	$ pulumi import yandex:index/messageQueue:MessageQueue example_import_queue https://message-queue.api.cloud.yandex.net/abcdefghijklmn123456/opqrstuvwxyz87654321/ymq_terraform_import_example
//
// ```
type MessageQueue struct {
	pulumi.CustomResourceState

	// The [access key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqAccessKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
	AccessKey pulumi.StringPtrOutput `pulumi:"accessKey"`
	// ARN of the Yandex Message Queue. It is used for setting up a [redrive policy](https://cloud.yandex.com/docs/message-queue/concepts/dlq). See [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/SetQueueAttributes).
	Arn pulumi.StringOutput `pulumi:"arn"`
	// Enables [content-based deduplication](https://cloud.yandex.com/docs/message-queue/concepts/deduplication#content-based-deduplication). Can be used only if queue is [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues).
	ContentBasedDeduplication pulumi.BoolPtrOutput `pulumi:"contentBasedDeduplication"`
	// Number of seconds to [delay the message from being available for processing](https://cloud.yandex.com/docs/message-queue/concepts/delay-queues#delay-queues). Valid values: from 0 to 900 seconds (15 minutes). Default: 0.
	DelaySeconds pulumi.IntPtrOutput `pulumi:"delaySeconds"`
	// Is this queue [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues). If this parameter is not used, a standard queue is created. You cannot change the parameter value for a created queue.
	FifoQueue pulumi.BoolPtrOutput `pulumi:"fifoQueue"`
	// Maximum message size in bytes. Valid values: from 1024 bytes (1 KB) to 262144 bytes (256 KB). Default: 262144 (256 KB). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	MaxMessageSize pulumi.IntPtrOutput `pulumi:"maxMessageSize"`
	// The length of time in seconds to retain a message. Valid values: from 60 seconds (1 minute) to 1209600 seconds (14 days). Default: 345600 (4 days). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	MessageRetentionSeconds pulumi.IntPtrOutput `pulumi:"messageRetentionSeconds"`
	// Queue name. The maximum length is 80 characters. You can use numbers, letters, underscores, and hyphens in the name. The name of a FIFO queue must end with the `.fifo` suffix. If not specified, random name will be generated. Conflicts with `namePrefix`. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	Name pulumi.StringOutput `pulumi:"name"`
	// Generates random name with the specified prefix. Conflicts with `name`.
	NamePrefix pulumi.StringPtrOutput `pulumi:"namePrefix"`
	// Wait time for the [ReceiveMessage](https://cloud.yandex.com/docs/message-queue/api-ref/message/ReceiveMessage) method (for long polling), in seconds. Valid values: from 0 to 20 seconds. Default: 0. For more information about long polling see [documentation](https://cloud.yandex.com/docs/message-queue/concepts/long-polling).
	ReceiveWaitTimeSeconds pulumi.IntPtrOutput `pulumi:"receiveWaitTimeSeconds"`
	// Message redrive policy in [Dead Letter Queue](https://cloud.yandex.com/docs/message-queue/concepts/dlq). The source queue and DLQ must be the same type: for FIFO queues, the DLQ must also be a FIFO queue. For more information about redrive policy see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue). Also you can use example in this page.
	RedrivePolicy pulumi.StringPtrOutput `pulumi:"redrivePolicy"`
	// ID of the region where the message queue is located at.
	// The default is 'ru-central1'.
	RegionId pulumi.StringPtrOutput `pulumi:"regionId"`
	// The [secret key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqSecretKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
	SecretKey pulumi.StringPtrOutput `pulumi:"secretKey"`
	// [Visibility timeout](https://cloud.yandex.com/docs/message-queue/concepts/visibility-timeout) for messages in a queue, specified in seconds. Valid values: from 0 to 43200 seconds (12 hours). Default: 30.
	VisibilityTimeoutSeconds pulumi.IntPtrOutput `pulumi:"visibilityTimeoutSeconds"`
}

// NewMessageQueue registers a new resource with the given unique name, arguments, and options.
func NewMessageQueue(ctx *pulumi.Context,
	name string, args *MessageQueueArgs, opts ...pulumi.ResourceOption) (*MessageQueue, error) {
	if args == nil {
		args = &MessageQueueArgs{}
	}

	if args.SecretKey != nil {
		args.SecretKey = pulumi.ToSecret(args.SecretKey).(pulumi.StringPtrOutput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"secretKey",
	})
	opts = append(opts, secrets)
	opts = pkgResourceDefaultOpts(opts)
	var resource MessageQueue
	err := ctx.RegisterResource("yandex:index/messageQueue:MessageQueue", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMessageQueue gets an existing MessageQueue resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMessageQueue(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MessageQueueState, opts ...pulumi.ResourceOption) (*MessageQueue, error) {
	var resource MessageQueue
	err := ctx.ReadResource("yandex:index/messageQueue:MessageQueue", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MessageQueue resources.
type messageQueueState struct {
	// The [access key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqAccessKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
	AccessKey *string `pulumi:"accessKey"`
	// ARN of the Yandex Message Queue. It is used for setting up a [redrive policy](https://cloud.yandex.com/docs/message-queue/concepts/dlq). See [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/SetQueueAttributes).
	Arn *string `pulumi:"arn"`
	// Enables [content-based deduplication](https://cloud.yandex.com/docs/message-queue/concepts/deduplication#content-based-deduplication). Can be used only if queue is [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues).
	ContentBasedDeduplication *bool `pulumi:"contentBasedDeduplication"`
	// Number of seconds to [delay the message from being available for processing](https://cloud.yandex.com/docs/message-queue/concepts/delay-queues#delay-queues). Valid values: from 0 to 900 seconds (15 minutes). Default: 0.
	DelaySeconds *int `pulumi:"delaySeconds"`
	// Is this queue [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues). If this parameter is not used, a standard queue is created. You cannot change the parameter value for a created queue.
	FifoQueue *bool `pulumi:"fifoQueue"`
	// Maximum message size in bytes. Valid values: from 1024 bytes (1 KB) to 262144 bytes (256 KB). Default: 262144 (256 KB). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	MaxMessageSize *int `pulumi:"maxMessageSize"`
	// The length of time in seconds to retain a message. Valid values: from 60 seconds (1 minute) to 1209600 seconds (14 days). Default: 345600 (4 days). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	MessageRetentionSeconds *int `pulumi:"messageRetentionSeconds"`
	// Queue name. The maximum length is 80 characters. You can use numbers, letters, underscores, and hyphens in the name. The name of a FIFO queue must end with the `.fifo` suffix. If not specified, random name will be generated. Conflicts with `namePrefix`. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	Name *string `pulumi:"name"`
	// Generates random name with the specified prefix. Conflicts with `name`.
	NamePrefix *string `pulumi:"namePrefix"`
	// Wait time for the [ReceiveMessage](https://cloud.yandex.com/docs/message-queue/api-ref/message/ReceiveMessage) method (for long polling), in seconds. Valid values: from 0 to 20 seconds. Default: 0. For more information about long polling see [documentation](https://cloud.yandex.com/docs/message-queue/concepts/long-polling).
	ReceiveWaitTimeSeconds *int `pulumi:"receiveWaitTimeSeconds"`
	// Message redrive policy in [Dead Letter Queue](https://cloud.yandex.com/docs/message-queue/concepts/dlq). The source queue and DLQ must be the same type: for FIFO queues, the DLQ must also be a FIFO queue. For more information about redrive policy see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue). Also you can use example in this page.
	RedrivePolicy *string `pulumi:"redrivePolicy"`
	// ID of the region where the message queue is located at.
	// The default is 'ru-central1'.
	RegionId *string `pulumi:"regionId"`
	// The [secret key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqSecretKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
	SecretKey *string `pulumi:"secretKey"`
	// [Visibility timeout](https://cloud.yandex.com/docs/message-queue/concepts/visibility-timeout) for messages in a queue, specified in seconds. Valid values: from 0 to 43200 seconds (12 hours). Default: 30.
	VisibilityTimeoutSeconds *int `pulumi:"visibilityTimeoutSeconds"`
}

type MessageQueueState struct {
	// The [access key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqAccessKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
	AccessKey pulumi.StringPtrInput
	// ARN of the Yandex Message Queue. It is used for setting up a [redrive policy](https://cloud.yandex.com/docs/message-queue/concepts/dlq). See [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/SetQueueAttributes).
	Arn pulumi.StringPtrInput
	// Enables [content-based deduplication](https://cloud.yandex.com/docs/message-queue/concepts/deduplication#content-based-deduplication). Can be used only if queue is [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues).
	ContentBasedDeduplication pulumi.BoolPtrInput
	// Number of seconds to [delay the message from being available for processing](https://cloud.yandex.com/docs/message-queue/concepts/delay-queues#delay-queues). Valid values: from 0 to 900 seconds (15 minutes). Default: 0.
	DelaySeconds pulumi.IntPtrInput
	// Is this queue [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues). If this parameter is not used, a standard queue is created. You cannot change the parameter value for a created queue.
	FifoQueue pulumi.BoolPtrInput
	// Maximum message size in bytes. Valid values: from 1024 bytes (1 KB) to 262144 bytes (256 KB). Default: 262144 (256 KB). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	MaxMessageSize pulumi.IntPtrInput
	// The length of time in seconds to retain a message. Valid values: from 60 seconds (1 minute) to 1209600 seconds (14 days). Default: 345600 (4 days). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	MessageRetentionSeconds pulumi.IntPtrInput
	// Queue name. The maximum length is 80 characters. You can use numbers, letters, underscores, and hyphens in the name. The name of a FIFO queue must end with the `.fifo` suffix. If not specified, random name will be generated. Conflicts with `namePrefix`. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	Name pulumi.StringPtrInput
	// Generates random name with the specified prefix. Conflicts with `name`.
	NamePrefix pulumi.StringPtrInput
	// Wait time for the [ReceiveMessage](https://cloud.yandex.com/docs/message-queue/api-ref/message/ReceiveMessage) method (for long polling), in seconds. Valid values: from 0 to 20 seconds. Default: 0. For more information about long polling see [documentation](https://cloud.yandex.com/docs/message-queue/concepts/long-polling).
	ReceiveWaitTimeSeconds pulumi.IntPtrInput
	// Message redrive policy in [Dead Letter Queue](https://cloud.yandex.com/docs/message-queue/concepts/dlq). The source queue and DLQ must be the same type: for FIFO queues, the DLQ must also be a FIFO queue. For more information about redrive policy see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue). Also you can use example in this page.
	RedrivePolicy pulumi.StringPtrInput
	// ID of the region where the message queue is located at.
	// The default is 'ru-central1'.
	RegionId pulumi.StringPtrInput
	// The [secret key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqSecretKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
	SecretKey pulumi.StringPtrInput
	// [Visibility timeout](https://cloud.yandex.com/docs/message-queue/concepts/visibility-timeout) for messages in a queue, specified in seconds. Valid values: from 0 to 43200 seconds (12 hours). Default: 30.
	VisibilityTimeoutSeconds pulumi.IntPtrInput
}

func (MessageQueueState) ElementType() reflect.Type {
	return reflect.TypeOf((*messageQueueState)(nil)).Elem()
}

type messageQueueArgs struct {
	// The [access key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqAccessKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
	AccessKey *string `pulumi:"accessKey"`
	// Enables [content-based deduplication](https://cloud.yandex.com/docs/message-queue/concepts/deduplication#content-based-deduplication). Can be used only if queue is [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues).
	ContentBasedDeduplication *bool `pulumi:"contentBasedDeduplication"`
	// Number of seconds to [delay the message from being available for processing](https://cloud.yandex.com/docs/message-queue/concepts/delay-queues#delay-queues). Valid values: from 0 to 900 seconds (15 minutes). Default: 0.
	DelaySeconds *int `pulumi:"delaySeconds"`
	// Is this queue [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues). If this parameter is not used, a standard queue is created. You cannot change the parameter value for a created queue.
	FifoQueue *bool `pulumi:"fifoQueue"`
	// Maximum message size in bytes. Valid values: from 1024 bytes (1 KB) to 262144 bytes (256 KB). Default: 262144 (256 KB). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	MaxMessageSize *int `pulumi:"maxMessageSize"`
	// The length of time in seconds to retain a message. Valid values: from 60 seconds (1 minute) to 1209600 seconds (14 days). Default: 345600 (4 days). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	MessageRetentionSeconds *int `pulumi:"messageRetentionSeconds"`
	// Queue name. The maximum length is 80 characters. You can use numbers, letters, underscores, and hyphens in the name. The name of a FIFO queue must end with the `.fifo` suffix. If not specified, random name will be generated. Conflicts with `namePrefix`. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	Name *string `pulumi:"name"`
	// Generates random name with the specified prefix. Conflicts with `name`.
	NamePrefix *string `pulumi:"namePrefix"`
	// Wait time for the [ReceiveMessage](https://cloud.yandex.com/docs/message-queue/api-ref/message/ReceiveMessage) method (for long polling), in seconds. Valid values: from 0 to 20 seconds. Default: 0. For more information about long polling see [documentation](https://cloud.yandex.com/docs/message-queue/concepts/long-polling).
	ReceiveWaitTimeSeconds *int `pulumi:"receiveWaitTimeSeconds"`
	// Message redrive policy in [Dead Letter Queue](https://cloud.yandex.com/docs/message-queue/concepts/dlq). The source queue and DLQ must be the same type: for FIFO queues, the DLQ must also be a FIFO queue. For more information about redrive policy see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue). Also you can use example in this page.
	RedrivePolicy *string `pulumi:"redrivePolicy"`
	// ID of the region where the message queue is located at.
	// The default is 'ru-central1'.
	RegionId *string `pulumi:"regionId"`
	// The [secret key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqSecretKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
	SecretKey *string `pulumi:"secretKey"`
	// [Visibility timeout](https://cloud.yandex.com/docs/message-queue/concepts/visibility-timeout) for messages in a queue, specified in seconds. Valid values: from 0 to 43200 seconds (12 hours). Default: 30.
	VisibilityTimeoutSeconds *int `pulumi:"visibilityTimeoutSeconds"`
}

// The set of arguments for constructing a MessageQueue resource.
type MessageQueueArgs struct {
	// The [access key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqAccessKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
	AccessKey pulumi.StringPtrInput
	// Enables [content-based deduplication](https://cloud.yandex.com/docs/message-queue/concepts/deduplication#content-based-deduplication). Can be used only if queue is [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues).
	ContentBasedDeduplication pulumi.BoolPtrInput
	// Number of seconds to [delay the message from being available for processing](https://cloud.yandex.com/docs/message-queue/concepts/delay-queues#delay-queues). Valid values: from 0 to 900 seconds (15 minutes). Default: 0.
	DelaySeconds pulumi.IntPtrInput
	// Is this queue [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues). If this parameter is not used, a standard queue is created. You cannot change the parameter value for a created queue.
	FifoQueue pulumi.BoolPtrInput
	// Maximum message size in bytes. Valid values: from 1024 bytes (1 KB) to 262144 bytes (256 KB). Default: 262144 (256 KB). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	MaxMessageSize pulumi.IntPtrInput
	// The length of time in seconds to retain a message. Valid values: from 60 seconds (1 minute) to 1209600 seconds (14 days). Default: 345600 (4 days). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	MessageRetentionSeconds pulumi.IntPtrInput
	// Queue name. The maximum length is 80 characters. You can use numbers, letters, underscores, and hyphens in the name. The name of a FIFO queue must end with the `.fifo` suffix. If not specified, random name will be generated. Conflicts with `namePrefix`. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
	Name pulumi.StringPtrInput
	// Generates random name with the specified prefix. Conflicts with `name`.
	NamePrefix pulumi.StringPtrInput
	// Wait time for the [ReceiveMessage](https://cloud.yandex.com/docs/message-queue/api-ref/message/ReceiveMessage) method (for long polling), in seconds. Valid values: from 0 to 20 seconds. Default: 0. For more information about long polling see [documentation](https://cloud.yandex.com/docs/message-queue/concepts/long-polling).
	ReceiveWaitTimeSeconds pulumi.IntPtrInput
	// Message redrive policy in [Dead Letter Queue](https://cloud.yandex.com/docs/message-queue/concepts/dlq). The source queue and DLQ must be the same type: for FIFO queues, the DLQ must also be a FIFO queue. For more information about redrive policy see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue). Also you can use example in this page.
	RedrivePolicy pulumi.StringPtrInput
	// ID of the region where the message queue is located at.
	// The default is 'ru-central1'.
	RegionId pulumi.StringPtrInput
	// The [secret key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqSecretKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
	SecretKey pulumi.StringPtrInput
	// [Visibility timeout](https://cloud.yandex.com/docs/message-queue/concepts/visibility-timeout) for messages in a queue, specified in seconds. Valid values: from 0 to 43200 seconds (12 hours). Default: 30.
	VisibilityTimeoutSeconds pulumi.IntPtrInput
}

func (MessageQueueArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*messageQueueArgs)(nil)).Elem()
}

type MessageQueueInput interface {
	pulumi.Input

	ToMessageQueueOutput() MessageQueueOutput
	ToMessageQueueOutputWithContext(ctx context.Context) MessageQueueOutput
}

func (*MessageQueue) ElementType() reflect.Type {
	return reflect.TypeOf((**MessageQueue)(nil)).Elem()
}

func (i *MessageQueue) ToMessageQueueOutput() MessageQueueOutput {
	return i.ToMessageQueueOutputWithContext(context.Background())
}

func (i *MessageQueue) ToMessageQueueOutputWithContext(ctx context.Context) MessageQueueOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MessageQueueOutput)
}

// MessageQueueArrayInput is an input type that accepts MessageQueueArray and MessageQueueArrayOutput values.
// You can construct a concrete instance of `MessageQueueArrayInput` via:
//
//	MessageQueueArray{ MessageQueueArgs{...} }
type MessageQueueArrayInput interface {
	pulumi.Input

	ToMessageQueueArrayOutput() MessageQueueArrayOutput
	ToMessageQueueArrayOutputWithContext(context.Context) MessageQueueArrayOutput
}

type MessageQueueArray []MessageQueueInput

func (MessageQueueArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MessageQueue)(nil)).Elem()
}

func (i MessageQueueArray) ToMessageQueueArrayOutput() MessageQueueArrayOutput {
	return i.ToMessageQueueArrayOutputWithContext(context.Background())
}

func (i MessageQueueArray) ToMessageQueueArrayOutputWithContext(ctx context.Context) MessageQueueArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MessageQueueArrayOutput)
}

// MessageQueueMapInput is an input type that accepts MessageQueueMap and MessageQueueMapOutput values.
// You can construct a concrete instance of `MessageQueueMapInput` via:
//
//	MessageQueueMap{ "key": MessageQueueArgs{...} }
type MessageQueueMapInput interface {
	pulumi.Input

	ToMessageQueueMapOutput() MessageQueueMapOutput
	ToMessageQueueMapOutputWithContext(context.Context) MessageQueueMapOutput
}

type MessageQueueMap map[string]MessageQueueInput

func (MessageQueueMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MessageQueue)(nil)).Elem()
}

func (i MessageQueueMap) ToMessageQueueMapOutput() MessageQueueMapOutput {
	return i.ToMessageQueueMapOutputWithContext(context.Background())
}

func (i MessageQueueMap) ToMessageQueueMapOutputWithContext(ctx context.Context) MessageQueueMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MessageQueueMapOutput)
}

type MessageQueueOutput struct{ *pulumi.OutputState }

func (MessageQueueOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MessageQueue)(nil)).Elem()
}

func (o MessageQueueOutput) ToMessageQueueOutput() MessageQueueOutput {
	return o
}

func (o MessageQueueOutput) ToMessageQueueOutputWithContext(ctx context.Context) MessageQueueOutput {
	return o
}

// The [access key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqAccessKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
func (o MessageQueueOutput) AccessKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.StringPtrOutput { return v.AccessKey }).(pulumi.StringPtrOutput)
}

// ARN of the Yandex Message Queue. It is used for setting up a [redrive policy](https://cloud.yandex.com/docs/message-queue/concepts/dlq). See [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/SetQueueAttributes).
func (o MessageQueueOutput) Arn() pulumi.StringOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.StringOutput { return v.Arn }).(pulumi.StringOutput)
}

// Enables [content-based deduplication](https://cloud.yandex.com/docs/message-queue/concepts/deduplication#content-based-deduplication). Can be used only if queue is [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues).
func (o MessageQueueOutput) ContentBasedDeduplication() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.BoolPtrOutput { return v.ContentBasedDeduplication }).(pulumi.BoolPtrOutput)
}

// Number of seconds to [delay the message from being available for processing](https://cloud.yandex.com/docs/message-queue/concepts/delay-queues#delay-queues). Valid values: from 0 to 900 seconds (15 minutes). Default: 0.
func (o MessageQueueOutput) DelaySeconds() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.IntPtrOutput { return v.DelaySeconds }).(pulumi.IntPtrOutput)
}

// Is this queue [FIFO](https://cloud.yandex.com/docs/message-queue/concepts/queue#fifo-queues). If this parameter is not used, a standard queue is created. You cannot change the parameter value for a created queue.
func (o MessageQueueOutput) FifoQueue() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.BoolPtrOutput { return v.FifoQueue }).(pulumi.BoolPtrOutput)
}

// Maximum message size in bytes. Valid values: from 1024 bytes (1 KB) to 262144 bytes (256 KB). Default: 262144 (256 KB). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
func (o MessageQueueOutput) MaxMessageSize() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.IntPtrOutput { return v.MaxMessageSize }).(pulumi.IntPtrOutput)
}

// The length of time in seconds to retain a message. Valid values: from 60 seconds (1 minute) to 1209600 seconds (14 days). Default: 345600 (4 days). For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
func (o MessageQueueOutput) MessageRetentionSeconds() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.IntPtrOutput { return v.MessageRetentionSeconds }).(pulumi.IntPtrOutput)
}

// Queue name. The maximum length is 80 characters. You can use numbers, letters, underscores, and hyphens in the name. The name of a FIFO queue must end with the `.fifo` suffix. If not specified, random name will be generated. Conflicts with `namePrefix`. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue).
func (o MessageQueueOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Generates random name with the specified prefix. Conflicts with `name`.
func (o MessageQueueOutput) NamePrefix() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.StringPtrOutput { return v.NamePrefix }).(pulumi.StringPtrOutput)
}

// Wait time for the [ReceiveMessage](https://cloud.yandex.com/docs/message-queue/api-ref/message/ReceiveMessage) method (for long polling), in seconds. Valid values: from 0 to 20 seconds. Default: 0. For more information about long polling see [documentation](https://cloud.yandex.com/docs/message-queue/concepts/long-polling).
func (o MessageQueueOutput) ReceiveWaitTimeSeconds() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.IntPtrOutput { return v.ReceiveWaitTimeSeconds }).(pulumi.IntPtrOutput)
}

// Message redrive policy in [Dead Letter Queue](https://cloud.yandex.com/docs/message-queue/concepts/dlq). The source queue and DLQ must be the same type: for FIFO queues, the DLQ must also be a FIFO queue. For more information about redrive policy see [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/CreateQueue). Also you can use example in this page.
func (o MessageQueueOutput) RedrivePolicy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.StringPtrOutput { return v.RedrivePolicy }).(pulumi.StringPtrOutput)
}

// ID of the region where the message queue is located at.
// The default is 'ru-central1'.
func (o MessageQueueOutput) RegionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.StringPtrOutput { return v.RegionId }).(pulumi.StringPtrOutput)
}

// The [secret key](https://cloud.yandex.com/docs/iam/operations/sa/create-access-key) to use when applying changes. If omitted, `ymqSecretKey` specified in provider config is used. For more information see [documentation](https://cloud.yandex.com/docs/message-queue/quickstart).
func (o MessageQueueOutput) SecretKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.StringPtrOutput { return v.SecretKey }).(pulumi.StringPtrOutput)
}

// [Visibility timeout](https://cloud.yandex.com/docs/message-queue/concepts/visibility-timeout) for messages in a queue, specified in seconds. Valid values: from 0 to 43200 seconds (12 hours). Default: 30.
func (o MessageQueueOutput) VisibilityTimeoutSeconds() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *MessageQueue) pulumi.IntPtrOutput { return v.VisibilityTimeoutSeconds }).(pulumi.IntPtrOutput)
}

type MessageQueueArrayOutput struct{ *pulumi.OutputState }

func (MessageQueueArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MessageQueue)(nil)).Elem()
}

func (o MessageQueueArrayOutput) ToMessageQueueArrayOutput() MessageQueueArrayOutput {
	return o
}

func (o MessageQueueArrayOutput) ToMessageQueueArrayOutputWithContext(ctx context.Context) MessageQueueArrayOutput {
	return o
}

func (o MessageQueueArrayOutput) Index(i pulumi.IntInput) MessageQueueOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MessageQueue {
		return vs[0].([]*MessageQueue)[vs[1].(int)]
	}).(MessageQueueOutput)
}

type MessageQueueMapOutput struct{ *pulumi.OutputState }

func (MessageQueueMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MessageQueue)(nil)).Elem()
}

func (o MessageQueueMapOutput) ToMessageQueueMapOutput() MessageQueueMapOutput {
	return o
}

func (o MessageQueueMapOutput) ToMessageQueueMapOutputWithContext(ctx context.Context) MessageQueueMapOutput {
	return o
}

func (o MessageQueueMapOutput) MapIndex(k pulumi.StringInput) MessageQueueOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MessageQueue {
		return vs[0].(map[string]*MessageQueue)[vs[1].(string)]
	}).(MessageQueueOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MessageQueueInput)(nil)).Elem(), &MessageQueue{})
	pulumi.RegisterInputType(reflect.TypeOf((*MessageQueueArrayInput)(nil)).Elem(), MessageQueueArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MessageQueueMapInput)(nil)).Elem(), MessageQueueMap{})
	pulumi.RegisterOutputType(MessageQueueOutput{})
	pulumi.RegisterOutputType(MessageQueueArrayOutput{})
	pulumi.RegisterOutputType(MessageQueueMapOutput{})
}
