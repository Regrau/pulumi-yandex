// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupIotCoreDevice(ctx *pulumi.Context, args *LookupIotCoreDeviceArgs, opts ...pulumi.InvokeOption) (*LookupIotCoreDeviceResult, error) {
	var rv LookupIotCoreDeviceResult
	err := ctx.Invoke("yandex:index/getIotCoreDevice:getIotCoreDevice", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getIotCoreDevice.
type LookupIotCoreDeviceArgs struct {
	DeviceId *string `pulumi:"deviceId"`
	Name     *string `pulumi:"name"`
}

// A collection of values returned by getIotCoreDevice.
type LookupIotCoreDeviceResult struct {
	Aliases      map[string]string `pulumi:"aliases"`
	Certificates []string          `pulumi:"certificates"`
	CreatedAt    string            `pulumi:"createdAt"`
	Description  string            `pulumi:"description"`
	DeviceId     *string           `pulumi:"deviceId"`
	// The provider-assigned unique ID for this managed resource.
	Id         string   `pulumi:"id"`
	Name       *string  `pulumi:"name"`
	Passwords  []string `pulumi:"passwords"`
	RegistryId string   `pulumi:"registryId"`
}

func LookupIotCoreDeviceOutput(ctx *pulumi.Context, args LookupIotCoreDeviceOutputArgs, opts ...pulumi.InvokeOption) LookupIotCoreDeviceResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupIotCoreDeviceResult, error) {
			args := v.(LookupIotCoreDeviceArgs)
			r, err := LookupIotCoreDevice(ctx, &args, opts...)
			var s LookupIotCoreDeviceResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupIotCoreDeviceResultOutput)
}

// A collection of arguments for invoking getIotCoreDevice.
type LookupIotCoreDeviceOutputArgs struct {
	DeviceId pulumi.StringPtrInput `pulumi:"deviceId"`
	Name     pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupIotCoreDeviceOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIotCoreDeviceArgs)(nil)).Elem()
}

// A collection of values returned by getIotCoreDevice.
type LookupIotCoreDeviceResultOutput struct{ *pulumi.OutputState }

func (LookupIotCoreDeviceResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIotCoreDeviceResult)(nil)).Elem()
}

func (o LookupIotCoreDeviceResultOutput) ToLookupIotCoreDeviceResultOutput() LookupIotCoreDeviceResultOutput {
	return o
}

func (o LookupIotCoreDeviceResultOutput) ToLookupIotCoreDeviceResultOutputWithContext(ctx context.Context) LookupIotCoreDeviceResultOutput {
	return o
}

func (o LookupIotCoreDeviceResultOutput) Aliases() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupIotCoreDeviceResult) map[string]string { return v.Aliases }).(pulumi.StringMapOutput)
}

func (o LookupIotCoreDeviceResultOutput) Certificates() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupIotCoreDeviceResult) []string { return v.Certificates }).(pulumi.StringArrayOutput)
}

func (o LookupIotCoreDeviceResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIotCoreDeviceResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupIotCoreDeviceResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIotCoreDeviceResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupIotCoreDeviceResultOutput) DeviceId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupIotCoreDeviceResult) *string { return v.DeviceId }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupIotCoreDeviceResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIotCoreDeviceResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupIotCoreDeviceResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupIotCoreDeviceResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o LookupIotCoreDeviceResultOutput) Passwords() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupIotCoreDeviceResult) []string { return v.Passwords }).(pulumi.StringArrayOutput)
}

func (o LookupIotCoreDeviceResultOutput) RegistryId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIotCoreDeviceResult) string { return v.RegistryId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupIotCoreDeviceResultOutput{})
}
