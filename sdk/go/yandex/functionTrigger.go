// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Allows management of [Yandex Cloud Functions Trigger](https://cloud.yandex.com/docs/functions/)
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-yandex/sdk/go/yandex"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := yandex.NewFunctionTrigger(ctx, "myTrigger", &yandex.FunctionTriggerArgs{
// 			Description: pulumi.String("any description"),
// 			Function: &FunctionTriggerFunctionArgs{
// 				Id: pulumi.String("tf-test"),
// 			},
// 			Timer: &FunctionTriggerTimerArgs{
// 				CronExpression: pulumi.String("* * * * ? *"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type FunctionTrigger struct {
	pulumi.CustomResourceState

	// Creation timestamp of the Yandex Cloud Functions Trigger
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// Description of the Yandex Cloud Functions Trigger
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Dead Letter Queue settings definition for Yandex Cloud Functions Trigger
	// * `dlq.0.queue_id` - ID of Dead Letter Queue for Trigger (Queue ARN)
	// * `dlq.0.service_account_id` - Service Account ID for Dead Letter Queue for Yandex Cloud Functions Trigger
	Dlq FunctionTriggerDlqPtrOutput `pulumi:"dlq"`
	// Folder ID for the Yandex Cloud Functions Trigger
	FolderId pulumi.StringOutput `pulumi:"folderId"`
	// [Yandex.Cloud Function](https://cloud.yandex.com/docs/functions/concepts/function) settings definition for Yandex Cloud Functions Trigger
	// * `function.0.id` - Yandex.Cloud Function ID for Yandex Cloud Functions Trigger
	// * `function.0.service_account_id` - Service account ID for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.tag` - Tag for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.retry_attempts` - Retry attempts for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.retry_interval` - Retry interval in seconds for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	Function FunctionTriggerFunctionOutput `pulumi:"function"`
	// [IoT](https://cloud.yandex.com/docs/functions/concepts/trigger/iot-core-trigger) settings definition for Yandex Cloud Functions Trigger, if present. Only one section `iot` or `messageQueue` or `objectStorage` or `timer` can be defined.
	// * `iot.0.registry_id` - IoT Registry ID for Yandex Cloud Functions Trigger
	// * `iot.0.device_id` - IoT Device ID for Yandex Cloud Functions Trigger
	// * `iot.0.topic` - IoT Topic for Yandex Cloud Functions Trigger
	Iot FunctionTriggerIotPtrOutput `pulumi:"iot"`
	// A set of key/value label pairs to assign to the Yandex Cloud Functions Trigger
	Labels   pulumi.StringMapOutput           `pulumi:"labels"`
	LogGroup FunctionTriggerLogGroupPtrOutput `pulumi:"logGroup"`
	// [Logging](https://cloud.yandex.com/docs/functions/concepts/trigger/logging) settings definition for Yandex Cloud Functions Trigger, if present
	// * `logging.0.group_id` - Logging group ID for Yandex Cloud Functions Trigger
	// * `logging.0.resource_ids` - Resource ID filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.resource_types` - Resource type filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.levels` - Logging level filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.batch_cutoff` - Batch Duration in seconds for Yandex Cloud Functions Trigger
	// * `logging.0.batch_size` - Batch Size for Yandex Cloud Functions Trigger
	Logging FunctionTriggerLoggingPtrOutput `pulumi:"logging"`
	// [Message Queue](https://cloud.yandex.com/docs/functions/concepts/trigger/ymq-trigger) settings definition for Yandex Cloud Functions Trigger, if present
	// * `message_queue.0.queue_id` - Message Queue ID for Yandex Cloud Functions Trigger
	// * `message_queue.0.service_account_id` - Message Queue Service Account ID for Yandex Cloud Functions Trigger
	// * `message_queue.0.batch_cutoff` - Batch Duration in seconds for Yandex Cloud Functions Trigger
	// * `message_queue.0.batch_size` - Batch Size for Yandex Cloud Functions Trigger
	// * `message_queue.0.visibility_timeout` - Visibility timeout for Yandex Cloud Functions Trigger
	MessageQueue FunctionTriggerMessageQueuePtrOutput `pulumi:"messageQueue"`
	// Yandex Cloud Functions Trigger name used to define trigger
	Name pulumi.StringOutput `pulumi:"name"`
	// [Object Storage](https://cloud.yandex.com/docs/functions/concepts/trigger/os-trigger) settings definition for Yandex Cloud Functions Trigger, if present
	// * `object_storage.0.bucket_id` - Object Storage Bucket ID for Yandex Cloud Functions Trigger
	// * `object_storage.0.prefix` - Prefix for Object Storage for Yandex Cloud Functions Trigger
	// * `object_storage.0.suffix` - Suffix for Object Storage for Yandex Cloud Functions Trigger
	// * `object_storage.0.create` - Boolean flag for setting create event for Yandex Cloud Functions Trigger
	// * `object_storage.0.update` - Boolean flag for setting update event for Yandex Cloud Functions Trigger
	// * `object_storage.0.delete` - Boolean flag for setting delete event for Yandex Cloud Functions Trigger
	ObjectStorage FunctionTriggerObjectStoragePtrOutput `pulumi:"objectStorage"`
	// [Timer](https://cloud.yandex.com/docs/functions/concepts/trigger/timer) settings definition for Yandex Cloud Functions Trigger, if present
	// * `timer.0.cron_expression` - Cron expression for timer for Yandex Cloud Functions Trigger
	Timer FunctionTriggerTimerPtrOutput `pulumi:"timer"`
}

// NewFunctionTrigger registers a new resource with the given unique name, arguments, and options.
func NewFunctionTrigger(ctx *pulumi.Context,
	name string, args *FunctionTriggerArgs, opts ...pulumi.ResourceOption) (*FunctionTrigger, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Function == nil {
		return nil, errors.New("invalid value for required argument 'Function'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource FunctionTrigger
	err := ctx.RegisterResource("yandex:index/functionTrigger:FunctionTrigger", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFunctionTrigger gets an existing FunctionTrigger resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFunctionTrigger(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FunctionTriggerState, opts ...pulumi.ResourceOption) (*FunctionTrigger, error) {
	var resource FunctionTrigger
	err := ctx.ReadResource("yandex:index/functionTrigger:FunctionTrigger", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FunctionTrigger resources.
type functionTriggerState struct {
	// Creation timestamp of the Yandex Cloud Functions Trigger
	CreatedAt *string `pulumi:"createdAt"`
	// Description of the Yandex Cloud Functions Trigger
	Description *string `pulumi:"description"`
	// Dead Letter Queue settings definition for Yandex Cloud Functions Trigger
	// * `dlq.0.queue_id` - ID of Dead Letter Queue for Trigger (Queue ARN)
	// * `dlq.0.service_account_id` - Service Account ID for Dead Letter Queue for Yandex Cloud Functions Trigger
	Dlq *FunctionTriggerDlq `pulumi:"dlq"`
	// Folder ID for the Yandex Cloud Functions Trigger
	FolderId *string `pulumi:"folderId"`
	// [Yandex.Cloud Function](https://cloud.yandex.com/docs/functions/concepts/function) settings definition for Yandex Cloud Functions Trigger
	// * `function.0.id` - Yandex.Cloud Function ID for Yandex Cloud Functions Trigger
	// * `function.0.service_account_id` - Service account ID for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.tag` - Tag for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.retry_attempts` - Retry attempts for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.retry_interval` - Retry interval in seconds for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	Function *FunctionTriggerFunction `pulumi:"function"`
	// [IoT](https://cloud.yandex.com/docs/functions/concepts/trigger/iot-core-trigger) settings definition for Yandex Cloud Functions Trigger, if present. Only one section `iot` or `messageQueue` or `objectStorage` or `timer` can be defined.
	// * `iot.0.registry_id` - IoT Registry ID for Yandex Cloud Functions Trigger
	// * `iot.0.device_id` - IoT Device ID for Yandex Cloud Functions Trigger
	// * `iot.0.topic` - IoT Topic for Yandex Cloud Functions Trigger
	Iot *FunctionTriggerIot `pulumi:"iot"`
	// A set of key/value label pairs to assign to the Yandex Cloud Functions Trigger
	Labels   map[string]string        `pulumi:"labels"`
	LogGroup *FunctionTriggerLogGroup `pulumi:"logGroup"`
	// [Logging](https://cloud.yandex.com/docs/functions/concepts/trigger/logging) settings definition for Yandex Cloud Functions Trigger, if present
	// * `logging.0.group_id` - Logging group ID for Yandex Cloud Functions Trigger
	// * `logging.0.resource_ids` - Resource ID filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.resource_types` - Resource type filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.levels` - Logging level filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.batch_cutoff` - Batch Duration in seconds for Yandex Cloud Functions Trigger
	// * `logging.0.batch_size` - Batch Size for Yandex Cloud Functions Trigger
	Logging *FunctionTriggerLogging `pulumi:"logging"`
	// [Message Queue](https://cloud.yandex.com/docs/functions/concepts/trigger/ymq-trigger) settings definition for Yandex Cloud Functions Trigger, if present
	// * `message_queue.0.queue_id` - Message Queue ID for Yandex Cloud Functions Trigger
	// * `message_queue.0.service_account_id` - Message Queue Service Account ID for Yandex Cloud Functions Trigger
	// * `message_queue.0.batch_cutoff` - Batch Duration in seconds for Yandex Cloud Functions Trigger
	// * `message_queue.0.batch_size` - Batch Size for Yandex Cloud Functions Trigger
	// * `message_queue.0.visibility_timeout` - Visibility timeout for Yandex Cloud Functions Trigger
	MessageQueue *FunctionTriggerMessageQueue `pulumi:"messageQueue"`
	// Yandex Cloud Functions Trigger name used to define trigger
	Name *string `pulumi:"name"`
	// [Object Storage](https://cloud.yandex.com/docs/functions/concepts/trigger/os-trigger) settings definition for Yandex Cloud Functions Trigger, if present
	// * `object_storage.0.bucket_id` - Object Storage Bucket ID for Yandex Cloud Functions Trigger
	// * `object_storage.0.prefix` - Prefix for Object Storage for Yandex Cloud Functions Trigger
	// * `object_storage.0.suffix` - Suffix for Object Storage for Yandex Cloud Functions Trigger
	// * `object_storage.0.create` - Boolean flag for setting create event for Yandex Cloud Functions Trigger
	// * `object_storage.0.update` - Boolean flag for setting update event for Yandex Cloud Functions Trigger
	// * `object_storage.0.delete` - Boolean flag for setting delete event for Yandex Cloud Functions Trigger
	ObjectStorage *FunctionTriggerObjectStorage `pulumi:"objectStorage"`
	// [Timer](https://cloud.yandex.com/docs/functions/concepts/trigger/timer) settings definition for Yandex Cloud Functions Trigger, if present
	// * `timer.0.cron_expression` - Cron expression for timer for Yandex Cloud Functions Trigger
	Timer *FunctionTriggerTimer `pulumi:"timer"`
}

type FunctionTriggerState struct {
	// Creation timestamp of the Yandex Cloud Functions Trigger
	CreatedAt pulumi.StringPtrInput
	// Description of the Yandex Cloud Functions Trigger
	Description pulumi.StringPtrInput
	// Dead Letter Queue settings definition for Yandex Cloud Functions Trigger
	// * `dlq.0.queue_id` - ID of Dead Letter Queue for Trigger (Queue ARN)
	// * `dlq.0.service_account_id` - Service Account ID for Dead Letter Queue for Yandex Cloud Functions Trigger
	Dlq FunctionTriggerDlqPtrInput
	// Folder ID for the Yandex Cloud Functions Trigger
	FolderId pulumi.StringPtrInput
	// [Yandex.Cloud Function](https://cloud.yandex.com/docs/functions/concepts/function) settings definition for Yandex Cloud Functions Trigger
	// * `function.0.id` - Yandex.Cloud Function ID for Yandex Cloud Functions Trigger
	// * `function.0.service_account_id` - Service account ID for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.tag` - Tag for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.retry_attempts` - Retry attempts for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.retry_interval` - Retry interval in seconds for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	Function FunctionTriggerFunctionPtrInput
	// [IoT](https://cloud.yandex.com/docs/functions/concepts/trigger/iot-core-trigger) settings definition for Yandex Cloud Functions Trigger, if present. Only one section `iot` or `messageQueue` or `objectStorage` or `timer` can be defined.
	// * `iot.0.registry_id` - IoT Registry ID for Yandex Cloud Functions Trigger
	// * `iot.0.device_id` - IoT Device ID for Yandex Cloud Functions Trigger
	// * `iot.0.topic` - IoT Topic for Yandex Cloud Functions Trigger
	Iot FunctionTriggerIotPtrInput
	// A set of key/value label pairs to assign to the Yandex Cloud Functions Trigger
	Labels   pulumi.StringMapInput
	LogGroup FunctionTriggerLogGroupPtrInput
	// [Logging](https://cloud.yandex.com/docs/functions/concepts/trigger/logging) settings definition for Yandex Cloud Functions Trigger, if present
	// * `logging.0.group_id` - Logging group ID for Yandex Cloud Functions Trigger
	// * `logging.0.resource_ids` - Resource ID filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.resource_types` - Resource type filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.levels` - Logging level filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.batch_cutoff` - Batch Duration in seconds for Yandex Cloud Functions Trigger
	// * `logging.0.batch_size` - Batch Size for Yandex Cloud Functions Trigger
	Logging FunctionTriggerLoggingPtrInput
	// [Message Queue](https://cloud.yandex.com/docs/functions/concepts/trigger/ymq-trigger) settings definition for Yandex Cloud Functions Trigger, if present
	// * `message_queue.0.queue_id` - Message Queue ID for Yandex Cloud Functions Trigger
	// * `message_queue.0.service_account_id` - Message Queue Service Account ID for Yandex Cloud Functions Trigger
	// * `message_queue.0.batch_cutoff` - Batch Duration in seconds for Yandex Cloud Functions Trigger
	// * `message_queue.0.batch_size` - Batch Size for Yandex Cloud Functions Trigger
	// * `message_queue.0.visibility_timeout` - Visibility timeout for Yandex Cloud Functions Trigger
	MessageQueue FunctionTriggerMessageQueuePtrInput
	// Yandex Cloud Functions Trigger name used to define trigger
	Name pulumi.StringPtrInput
	// [Object Storage](https://cloud.yandex.com/docs/functions/concepts/trigger/os-trigger) settings definition for Yandex Cloud Functions Trigger, if present
	// * `object_storage.0.bucket_id` - Object Storage Bucket ID for Yandex Cloud Functions Trigger
	// * `object_storage.0.prefix` - Prefix for Object Storage for Yandex Cloud Functions Trigger
	// * `object_storage.0.suffix` - Suffix for Object Storage for Yandex Cloud Functions Trigger
	// * `object_storage.0.create` - Boolean flag for setting create event for Yandex Cloud Functions Trigger
	// * `object_storage.0.update` - Boolean flag for setting update event for Yandex Cloud Functions Trigger
	// * `object_storage.0.delete` - Boolean flag for setting delete event for Yandex Cloud Functions Trigger
	ObjectStorage FunctionTriggerObjectStoragePtrInput
	// [Timer](https://cloud.yandex.com/docs/functions/concepts/trigger/timer) settings definition for Yandex Cloud Functions Trigger, if present
	// * `timer.0.cron_expression` - Cron expression for timer for Yandex Cloud Functions Trigger
	Timer FunctionTriggerTimerPtrInput
}

func (FunctionTriggerState) ElementType() reflect.Type {
	return reflect.TypeOf((*functionTriggerState)(nil)).Elem()
}

type functionTriggerArgs struct {
	// Description of the Yandex Cloud Functions Trigger
	Description *string `pulumi:"description"`
	// Dead Letter Queue settings definition for Yandex Cloud Functions Trigger
	// * `dlq.0.queue_id` - ID of Dead Letter Queue for Trigger (Queue ARN)
	// * `dlq.0.service_account_id` - Service Account ID for Dead Letter Queue for Yandex Cloud Functions Trigger
	Dlq *FunctionTriggerDlq `pulumi:"dlq"`
	// Folder ID for the Yandex Cloud Functions Trigger
	FolderId *string `pulumi:"folderId"`
	// [Yandex.Cloud Function](https://cloud.yandex.com/docs/functions/concepts/function) settings definition for Yandex Cloud Functions Trigger
	// * `function.0.id` - Yandex.Cloud Function ID for Yandex Cloud Functions Trigger
	// * `function.0.service_account_id` - Service account ID for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.tag` - Tag for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.retry_attempts` - Retry attempts for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.retry_interval` - Retry interval in seconds for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	Function FunctionTriggerFunction `pulumi:"function"`
	// [IoT](https://cloud.yandex.com/docs/functions/concepts/trigger/iot-core-trigger) settings definition for Yandex Cloud Functions Trigger, if present. Only one section `iot` or `messageQueue` or `objectStorage` or `timer` can be defined.
	// * `iot.0.registry_id` - IoT Registry ID for Yandex Cloud Functions Trigger
	// * `iot.0.device_id` - IoT Device ID for Yandex Cloud Functions Trigger
	// * `iot.0.topic` - IoT Topic for Yandex Cloud Functions Trigger
	Iot *FunctionTriggerIot `pulumi:"iot"`
	// A set of key/value label pairs to assign to the Yandex Cloud Functions Trigger
	Labels   map[string]string        `pulumi:"labels"`
	LogGroup *FunctionTriggerLogGroup `pulumi:"logGroup"`
	// [Logging](https://cloud.yandex.com/docs/functions/concepts/trigger/logging) settings definition for Yandex Cloud Functions Trigger, if present
	// * `logging.0.group_id` - Logging group ID for Yandex Cloud Functions Trigger
	// * `logging.0.resource_ids` - Resource ID filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.resource_types` - Resource type filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.levels` - Logging level filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.batch_cutoff` - Batch Duration in seconds for Yandex Cloud Functions Trigger
	// * `logging.0.batch_size` - Batch Size for Yandex Cloud Functions Trigger
	Logging *FunctionTriggerLogging `pulumi:"logging"`
	// [Message Queue](https://cloud.yandex.com/docs/functions/concepts/trigger/ymq-trigger) settings definition for Yandex Cloud Functions Trigger, if present
	// * `message_queue.0.queue_id` - Message Queue ID for Yandex Cloud Functions Trigger
	// * `message_queue.0.service_account_id` - Message Queue Service Account ID for Yandex Cloud Functions Trigger
	// * `message_queue.0.batch_cutoff` - Batch Duration in seconds for Yandex Cloud Functions Trigger
	// * `message_queue.0.batch_size` - Batch Size for Yandex Cloud Functions Trigger
	// * `message_queue.0.visibility_timeout` - Visibility timeout for Yandex Cloud Functions Trigger
	MessageQueue *FunctionTriggerMessageQueue `pulumi:"messageQueue"`
	// Yandex Cloud Functions Trigger name used to define trigger
	Name *string `pulumi:"name"`
	// [Object Storage](https://cloud.yandex.com/docs/functions/concepts/trigger/os-trigger) settings definition for Yandex Cloud Functions Trigger, if present
	// * `object_storage.0.bucket_id` - Object Storage Bucket ID for Yandex Cloud Functions Trigger
	// * `object_storage.0.prefix` - Prefix for Object Storage for Yandex Cloud Functions Trigger
	// * `object_storage.0.suffix` - Suffix for Object Storage for Yandex Cloud Functions Trigger
	// * `object_storage.0.create` - Boolean flag for setting create event for Yandex Cloud Functions Trigger
	// * `object_storage.0.update` - Boolean flag for setting update event for Yandex Cloud Functions Trigger
	// * `object_storage.0.delete` - Boolean flag for setting delete event for Yandex Cloud Functions Trigger
	ObjectStorage *FunctionTriggerObjectStorage `pulumi:"objectStorage"`
	// [Timer](https://cloud.yandex.com/docs/functions/concepts/trigger/timer) settings definition for Yandex Cloud Functions Trigger, if present
	// * `timer.0.cron_expression` - Cron expression for timer for Yandex Cloud Functions Trigger
	Timer *FunctionTriggerTimer `pulumi:"timer"`
}

// The set of arguments for constructing a FunctionTrigger resource.
type FunctionTriggerArgs struct {
	// Description of the Yandex Cloud Functions Trigger
	Description pulumi.StringPtrInput
	// Dead Letter Queue settings definition for Yandex Cloud Functions Trigger
	// * `dlq.0.queue_id` - ID of Dead Letter Queue for Trigger (Queue ARN)
	// * `dlq.0.service_account_id` - Service Account ID for Dead Letter Queue for Yandex Cloud Functions Trigger
	Dlq FunctionTriggerDlqPtrInput
	// Folder ID for the Yandex Cloud Functions Trigger
	FolderId pulumi.StringPtrInput
	// [Yandex.Cloud Function](https://cloud.yandex.com/docs/functions/concepts/function) settings definition for Yandex Cloud Functions Trigger
	// * `function.0.id` - Yandex.Cloud Function ID for Yandex Cloud Functions Trigger
	// * `function.0.service_account_id` - Service account ID for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.tag` - Tag for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.retry_attempts` - Retry attempts for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	// * `function.0.retry_interval` - Retry interval in seconds for Yandex.Cloud Function for Yandex Cloud Functions Trigger
	Function FunctionTriggerFunctionInput
	// [IoT](https://cloud.yandex.com/docs/functions/concepts/trigger/iot-core-trigger) settings definition for Yandex Cloud Functions Trigger, if present. Only one section `iot` or `messageQueue` or `objectStorage` or `timer` can be defined.
	// * `iot.0.registry_id` - IoT Registry ID for Yandex Cloud Functions Trigger
	// * `iot.0.device_id` - IoT Device ID for Yandex Cloud Functions Trigger
	// * `iot.0.topic` - IoT Topic for Yandex Cloud Functions Trigger
	Iot FunctionTriggerIotPtrInput
	// A set of key/value label pairs to assign to the Yandex Cloud Functions Trigger
	Labels   pulumi.StringMapInput
	LogGroup FunctionTriggerLogGroupPtrInput
	// [Logging](https://cloud.yandex.com/docs/functions/concepts/trigger/logging) settings definition for Yandex Cloud Functions Trigger, if present
	// * `logging.0.group_id` - Logging group ID for Yandex Cloud Functions Trigger
	// * `logging.0.resource_ids` - Resource ID filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.resource_types` - Resource type filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.levels` - Logging level filter setting for Yandex Cloud Functions Trigger
	// * `logging.0.batch_cutoff` - Batch Duration in seconds for Yandex Cloud Functions Trigger
	// * `logging.0.batch_size` - Batch Size for Yandex Cloud Functions Trigger
	Logging FunctionTriggerLoggingPtrInput
	// [Message Queue](https://cloud.yandex.com/docs/functions/concepts/trigger/ymq-trigger) settings definition for Yandex Cloud Functions Trigger, if present
	// * `message_queue.0.queue_id` - Message Queue ID for Yandex Cloud Functions Trigger
	// * `message_queue.0.service_account_id` - Message Queue Service Account ID for Yandex Cloud Functions Trigger
	// * `message_queue.0.batch_cutoff` - Batch Duration in seconds for Yandex Cloud Functions Trigger
	// * `message_queue.0.batch_size` - Batch Size for Yandex Cloud Functions Trigger
	// * `message_queue.0.visibility_timeout` - Visibility timeout for Yandex Cloud Functions Trigger
	MessageQueue FunctionTriggerMessageQueuePtrInput
	// Yandex Cloud Functions Trigger name used to define trigger
	Name pulumi.StringPtrInput
	// [Object Storage](https://cloud.yandex.com/docs/functions/concepts/trigger/os-trigger) settings definition for Yandex Cloud Functions Trigger, if present
	// * `object_storage.0.bucket_id` - Object Storage Bucket ID for Yandex Cloud Functions Trigger
	// * `object_storage.0.prefix` - Prefix for Object Storage for Yandex Cloud Functions Trigger
	// * `object_storage.0.suffix` - Suffix for Object Storage for Yandex Cloud Functions Trigger
	// * `object_storage.0.create` - Boolean flag for setting create event for Yandex Cloud Functions Trigger
	// * `object_storage.0.update` - Boolean flag for setting update event for Yandex Cloud Functions Trigger
	// * `object_storage.0.delete` - Boolean flag for setting delete event for Yandex Cloud Functions Trigger
	ObjectStorage FunctionTriggerObjectStoragePtrInput
	// [Timer](https://cloud.yandex.com/docs/functions/concepts/trigger/timer) settings definition for Yandex Cloud Functions Trigger, if present
	// * `timer.0.cron_expression` - Cron expression for timer for Yandex Cloud Functions Trigger
	Timer FunctionTriggerTimerPtrInput
}

func (FunctionTriggerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*functionTriggerArgs)(nil)).Elem()
}

type FunctionTriggerInput interface {
	pulumi.Input

	ToFunctionTriggerOutput() FunctionTriggerOutput
	ToFunctionTriggerOutputWithContext(ctx context.Context) FunctionTriggerOutput
}

func (*FunctionTrigger) ElementType() reflect.Type {
	return reflect.TypeOf((**FunctionTrigger)(nil)).Elem()
}

func (i *FunctionTrigger) ToFunctionTriggerOutput() FunctionTriggerOutput {
	return i.ToFunctionTriggerOutputWithContext(context.Background())
}

func (i *FunctionTrigger) ToFunctionTriggerOutputWithContext(ctx context.Context) FunctionTriggerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionTriggerOutput)
}

// FunctionTriggerArrayInput is an input type that accepts FunctionTriggerArray and FunctionTriggerArrayOutput values.
// You can construct a concrete instance of `FunctionTriggerArrayInput` via:
//
//          FunctionTriggerArray{ FunctionTriggerArgs{...} }
type FunctionTriggerArrayInput interface {
	pulumi.Input

	ToFunctionTriggerArrayOutput() FunctionTriggerArrayOutput
	ToFunctionTriggerArrayOutputWithContext(context.Context) FunctionTriggerArrayOutput
}

type FunctionTriggerArray []FunctionTriggerInput

func (FunctionTriggerArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FunctionTrigger)(nil)).Elem()
}

func (i FunctionTriggerArray) ToFunctionTriggerArrayOutput() FunctionTriggerArrayOutput {
	return i.ToFunctionTriggerArrayOutputWithContext(context.Background())
}

func (i FunctionTriggerArray) ToFunctionTriggerArrayOutputWithContext(ctx context.Context) FunctionTriggerArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionTriggerArrayOutput)
}

// FunctionTriggerMapInput is an input type that accepts FunctionTriggerMap and FunctionTriggerMapOutput values.
// You can construct a concrete instance of `FunctionTriggerMapInput` via:
//
//          FunctionTriggerMap{ "key": FunctionTriggerArgs{...} }
type FunctionTriggerMapInput interface {
	pulumi.Input

	ToFunctionTriggerMapOutput() FunctionTriggerMapOutput
	ToFunctionTriggerMapOutputWithContext(context.Context) FunctionTriggerMapOutput
}

type FunctionTriggerMap map[string]FunctionTriggerInput

func (FunctionTriggerMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FunctionTrigger)(nil)).Elem()
}

func (i FunctionTriggerMap) ToFunctionTriggerMapOutput() FunctionTriggerMapOutput {
	return i.ToFunctionTriggerMapOutputWithContext(context.Background())
}

func (i FunctionTriggerMap) ToFunctionTriggerMapOutputWithContext(ctx context.Context) FunctionTriggerMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionTriggerMapOutput)
}

type FunctionTriggerOutput struct{ *pulumi.OutputState }

func (FunctionTriggerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**FunctionTrigger)(nil)).Elem()
}

func (o FunctionTriggerOutput) ToFunctionTriggerOutput() FunctionTriggerOutput {
	return o
}

func (o FunctionTriggerOutput) ToFunctionTriggerOutputWithContext(ctx context.Context) FunctionTriggerOutput {
	return o
}

// Creation timestamp of the Yandex Cloud Functions Trigger
func (o FunctionTriggerOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *FunctionTrigger) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// Description of the Yandex Cloud Functions Trigger
func (o FunctionTriggerOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *FunctionTrigger) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Dead Letter Queue settings definition for Yandex Cloud Functions Trigger
// * `dlq.0.queue_id` - ID of Dead Letter Queue for Trigger (Queue ARN)
// * `dlq.0.service_account_id` - Service Account ID for Dead Letter Queue for Yandex Cloud Functions Trigger
func (o FunctionTriggerOutput) Dlq() FunctionTriggerDlqPtrOutput {
	return o.ApplyT(func(v *FunctionTrigger) FunctionTriggerDlqPtrOutput { return v.Dlq }).(FunctionTriggerDlqPtrOutput)
}

// Folder ID for the Yandex Cloud Functions Trigger
func (o FunctionTriggerOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *FunctionTrigger) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

// [Yandex.Cloud Function](https://cloud.yandex.com/docs/functions/concepts/function) settings definition for Yandex Cloud Functions Trigger
// * `function.0.id` - Yandex.Cloud Function ID for Yandex Cloud Functions Trigger
// * `function.0.service_account_id` - Service account ID for Yandex.Cloud Function for Yandex Cloud Functions Trigger
// * `function.0.tag` - Tag for Yandex.Cloud Function for Yandex Cloud Functions Trigger
// * `function.0.retry_attempts` - Retry attempts for Yandex.Cloud Function for Yandex Cloud Functions Trigger
// * `function.0.retry_interval` - Retry interval in seconds for Yandex.Cloud Function for Yandex Cloud Functions Trigger
func (o FunctionTriggerOutput) Function() FunctionTriggerFunctionOutput {
	return o.ApplyT(func(v *FunctionTrigger) FunctionTriggerFunctionOutput { return v.Function }).(FunctionTriggerFunctionOutput)
}

// [IoT](https://cloud.yandex.com/docs/functions/concepts/trigger/iot-core-trigger) settings definition for Yandex Cloud Functions Trigger, if present. Only one section `iot` or `messageQueue` or `objectStorage` or `timer` can be defined.
// * `iot.0.registry_id` - IoT Registry ID for Yandex Cloud Functions Trigger
// * `iot.0.device_id` - IoT Device ID for Yandex Cloud Functions Trigger
// * `iot.0.topic` - IoT Topic for Yandex Cloud Functions Trigger
func (o FunctionTriggerOutput) Iot() FunctionTriggerIotPtrOutput {
	return o.ApplyT(func(v *FunctionTrigger) FunctionTriggerIotPtrOutput { return v.Iot }).(FunctionTriggerIotPtrOutput)
}

// A set of key/value label pairs to assign to the Yandex Cloud Functions Trigger
func (o FunctionTriggerOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *FunctionTrigger) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o FunctionTriggerOutput) LogGroup() FunctionTriggerLogGroupPtrOutput {
	return o.ApplyT(func(v *FunctionTrigger) FunctionTriggerLogGroupPtrOutput { return v.LogGroup }).(FunctionTriggerLogGroupPtrOutput)
}

// [Logging](https://cloud.yandex.com/docs/functions/concepts/trigger/logging) settings definition for Yandex Cloud Functions Trigger, if present
// * `logging.0.group_id` - Logging group ID for Yandex Cloud Functions Trigger
// * `logging.0.resource_ids` - Resource ID filter setting for Yandex Cloud Functions Trigger
// * `logging.0.resource_types` - Resource type filter setting for Yandex Cloud Functions Trigger
// * `logging.0.levels` - Logging level filter setting for Yandex Cloud Functions Trigger
// * `logging.0.batch_cutoff` - Batch Duration in seconds for Yandex Cloud Functions Trigger
// * `logging.0.batch_size` - Batch Size for Yandex Cloud Functions Trigger
func (o FunctionTriggerOutput) Logging() FunctionTriggerLoggingPtrOutput {
	return o.ApplyT(func(v *FunctionTrigger) FunctionTriggerLoggingPtrOutput { return v.Logging }).(FunctionTriggerLoggingPtrOutput)
}

// [Message Queue](https://cloud.yandex.com/docs/functions/concepts/trigger/ymq-trigger) settings definition for Yandex Cloud Functions Trigger, if present
// * `message_queue.0.queue_id` - Message Queue ID for Yandex Cloud Functions Trigger
// * `message_queue.0.service_account_id` - Message Queue Service Account ID for Yandex Cloud Functions Trigger
// * `message_queue.0.batch_cutoff` - Batch Duration in seconds for Yandex Cloud Functions Trigger
// * `message_queue.0.batch_size` - Batch Size for Yandex Cloud Functions Trigger
// * `message_queue.0.visibility_timeout` - Visibility timeout for Yandex Cloud Functions Trigger
func (o FunctionTriggerOutput) MessageQueue() FunctionTriggerMessageQueuePtrOutput {
	return o.ApplyT(func(v *FunctionTrigger) FunctionTriggerMessageQueuePtrOutput { return v.MessageQueue }).(FunctionTriggerMessageQueuePtrOutput)
}

// Yandex Cloud Functions Trigger name used to define trigger
func (o FunctionTriggerOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *FunctionTrigger) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// [Object Storage](https://cloud.yandex.com/docs/functions/concepts/trigger/os-trigger) settings definition for Yandex Cloud Functions Trigger, if present
// * `object_storage.0.bucket_id` - Object Storage Bucket ID for Yandex Cloud Functions Trigger
// * `object_storage.0.prefix` - Prefix for Object Storage for Yandex Cloud Functions Trigger
// * `object_storage.0.suffix` - Suffix for Object Storage for Yandex Cloud Functions Trigger
// * `object_storage.0.create` - Boolean flag for setting create event for Yandex Cloud Functions Trigger
// * `object_storage.0.update` - Boolean flag for setting update event for Yandex Cloud Functions Trigger
// * `object_storage.0.delete` - Boolean flag for setting delete event for Yandex Cloud Functions Trigger
func (o FunctionTriggerOutput) ObjectStorage() FunctionTriggerObjectStoragePtrOutput {
	return o.ApplyT(func(v *FunctionTrigger) FunctionTriggerObjectStoragePtrOutput { return v.ObjectStorage }).(FunctionTriggerObjectStoragePtrOutput)
}

// [Timer](https://cloud.yandex.com/docs/functions/concepts/trigger/timer) settings definition for Yandex Cloud Functions Trigger, if present
// * `timer.0.cron_expression` - Cron expression for timer for Yandex Cloud Functions Trigger
func (o FunctionTriggerOutput) Timer() FunctionTriggerTimerPtrOutput {
	return o.ApplyT(func(v *FunctionTrigger) FunctionTriggerTimerPtrOutput { return v.Timer }).(FunctionTriggerTimerPtrOutput)
}

type FunctionTriggerArrayOutput struct{ *pulumi.OutputState }

func (FunctionTriggerArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FunctionTrigger)(nil)).Elem()
}

func (o FunctionTriggerArrayOutput) ToFunctionTriggerArrayOutput() FunctionTriggerArrayOutput {
	return o
}

func (o FunctionTriggerArrayOutput) ToFunctionTriggerArrayOutputWithContext(ctx context.Context) FunctionTriggerArrayOutput {
	return o
}

func (o FunctionTriggerArrayOutput) Index(i pulumi.IntInput) FunctionTriggerOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *FunctionTrigger {
		return vs[0].([]*FunctionTrigger)[vs[1].(int)]
	}).(FunctionTriggerOutput)
}

type FunctionTriggerMapOutput struct{ *pulumi.OutputState }

func (FunctionTriggerMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FunctionTrigger)(nil)).Elem()
}

func (o FunctionTriggerMapOutput) ToFunctionTriggerMapOutput() FunctionTriggerMapOutput {
	return o
}

func (o FunctionTriggerMapOutput) ToFunctionTriggerMapOutputWithContext(ctx context.Context) FunctionTriggerMapOutput {
	return o
}

func (o FunctionTriggerMapOutput) MapIndex(k pulumi.StringInput) FunctionTriggerOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *FunctionTrigger {
		return vs[0].(map[string]*FunctionTrigger)[vs[1].(string)]
	}).(FunctionTriggerOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionTriggerInput)(nil)).Elem(), &FunctionTrigger{})
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionTriggerArrayInput)(nil)).Elem(), FunctionTriggerArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionTriggerMapInput)(nil)).Elem(), FunctionTriggerMap{})
	pulumi.RegisterOutputType(FunctionTriggerOutput{})
	pulumi.RegisterOutputType(FunctionTriggerArrayOutput{})
	pulumi.RegisterOutputType(FunctionTriggerMapOutput{})
}
