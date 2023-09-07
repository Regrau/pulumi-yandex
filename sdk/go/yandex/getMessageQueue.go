// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about a Yandex Message Queue. For more information about Yandex Message Queue, see
// [Yandex.Cloud Message Queue](https://cloud.yandex.com/docs/message-queue).
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
// 		_, err = yandex.LookupMessageQueue(ctx, &GetMessageQueueArgs{
// 			Name: "ymq_terraform_example",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupMessageQueue(ctx *pulumi.Context, args *LookupMessageQueueArgs, opts ...pulumi.InvokeOption) (*LookupMessageQueueResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupMessageQueueResult
	err := ctx.Invoke("yandex:index/getMessageQueue:getMessageQueue", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMessageQueue.
type LookupMessageQueueArgs struct {
	AccessKey *string `pulumi:"accessKey"`
	// Queue name.
	Name string `pulumi:"name"`
	// The region ID where the message queue is located.
	RegionId  *string `pulumi:"regionId"`
	SecretKey *string `pulumi:"secretKey"`
}

// A collection of values returned by getMessageQueue.
type LookupMessageQueueResult struct {
	AccessKey *string `pulumi:"accessKey"`
	// ARN of the queue. It is used for setting up a [redrive policy](https://cloud.yandex.com/docs/message-queue/concepts/dlq). See [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/SetQueueAttributes).
	Arn string `pulumi:"arn"`
	// The provider-assigned unique ID for this managed resource.
	Id        string  `pulumi:"id"`
	Name      string  `pulumi:"name"`
	RegionId  *string `pulumi:"regionId"`
	SecretKey *string `pulumi:"secretKey"`
	// URL of the queue.
	Url string `pulumi:"url"`
}

func LookupMessageQueueOutput(ctx *pulumi.Context, args LookupMessageQueueOutputArgs, opts ...pulumi.InvokeOption) LookupMessageQueueResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupMessageQueueResult, error) {
			args := v.(LookupMessageQueueArgs)
			r, err := LookupMessageQueue(ctx, &args, opts...)
			var s LookupMessageQueueResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupMessageQueueResultOutput)
}

// A collection of arguments for invoking getMessageQueue.
type LookupMessageQueueOutputArgs struct {
	AccessKey pulumi.StringPtrInput `pulumi:"accessKey"`
	// Queue name.
	Name pulumi.StringInput `pulumi:"name"`
	// The region ID where the message queue is located.
	RegionId  pulumi.StringPtrInput `pulumi:"regionId"`
	SecretKey pulumi.StringPtrInput `pulumi:"secretKey"`
}

func (LookupMessageQueueOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMessageQueueArgs)(nil)).Elem()
}

// A collection of values returned by getMessageQueue.
type LookupMessageQueueResultOutput struct{ *pulumi.OutputState }

func (LookupMessageQueueResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMessageQueueResult)(nil)).Elem()
}

func (o LookupMessageQueueResultOutput) ToLookupMessageQueueResultOutput() LookupMessageQueueResultOutput {
	return o
}

func (o LookupMessageQueueResultOutput) ToLookupMessageQueueResultOutputWithContext(ctx context.Context) LookupMessageQueueResultOutput {
	return o
}

func (o LookupMessageQueueResultOutput) AccessKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMessageQueueResult) *string { return v.AccessKey }).(pulumi.StringPtrOutput)
}

// ARN of the queue. It is used for setting up a [redrive policy](https://cloud.yandex.com/docs/message-queue/concepts/dlq). See [documentation](https://cloud.yandex.com/docs/message-queue/api-ref/queue/SetQueueAttributes).
func (o LookupMessageQueueResultOutput) Arn() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMessageQueueResult) string { return v.Arn }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupMessageQueueResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMessageQueueResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupMessageQueueResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMessageQueueResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupMessageQueueResultOutput) RegionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMessageQueueResult) *string { return v.RegionId }).(pulumi.StringPtrOutput)
}

func (o LookupMessageQueueResultOutput) SecretKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMessageQueueResult) *string { return v.SecretKey }).(pulumi.StringPtrOutput)
}

// URL of the queue.
func (o LookupMessageQueueResultOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMessageQueueResult) string { return v.Url }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupMessageQueueResultOutput{})
}
