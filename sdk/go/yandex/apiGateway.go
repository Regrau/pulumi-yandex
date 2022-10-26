// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type ApiGateway struct {
	pulumi.CustomResourceState

	CreatedAt   pulumi.StringOutput      `pulumi:"createdAt"`
	Description pulumi.StringPtrOutput   `pulumi:"description"`
	Domain      pulumi.StringOutput      `pulumi:"domain"`
	FolderId    pulumi.StringOutput      `pulumi:"folderId"`
	Labels      pulumi.StringMapOutput   `pulumi:"labels"`
	LogGroupId  pulumi.StringOutput      `pulumi:"logGroupId"`
	Name        pulumi.StringOutput      `pulumi:"name"`
	Spec        pulumi.StringOutput      `pulumi:"spec"`
	Status      pulumi.StringOutput      `pulumi:"status"`
	UserDomains pulumi.StringArrayOutput `pulumi:"userDomains"`
}

// NewApiGateway registers a new resource with the given unique name, arguments, and options.
func NewApiGateway(ctx *pulumi.Context,
	name string, args *ApiGatewayArgs, opts ...pulumi.ResourceOption) (*ApiGateway, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Spec == nil {
		return nil, errors.New("invalid value for required argument 'Spec'")
	}
	var resource ApiGateway
	err := ctx.RegisterResource("yandex:index/apiGateway:ApiGateway", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApiGateway gets an existing ApiGateway resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApiGateway(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApiGatewayState, opts ...pulumi.ResourceOption) (*ApiGateway, error) {
	var resource ApiGateway
	err := ctx.ReadResource("yandex:index/apiGateway:ApiGateway", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApiGateway resources.
type apiGatewayState struct {
	CreatedAt   *string           `pulumi:"createdAt"`
	Description *string           `pulumi:"description"`
	Domain      *string           `pulumi:"domain"`
	FolderId    *string           `pulumi:"folderId"`
	Labels      map[string]string `pulumi:"labels"`
	LogGroupId  *string           `pulumi:"logGroupId"`
	Name        *string           `pulumi:"name"`
	Spec        *string           `pulumi:"spec"`
	Status      *string           `pulumi:"status"`
	UserDomains []string          `pulumi:"userDomains"`
}

type ApiGatewayState struct {
	CreatedAt   pulumi.StringPtrInput
	Description pulumi.StringPtrInput
	Domain      pulumi.StringPtrInput
	FolderId    pulumi.StringPtrInput
	Labels      pulumi.StringMapInput
	LogGroupId  pulumi.StringPtrInput
	Name        pulumi.StringPtrInput
	Spec        pulumi.StringPtrInput
	Status      pulumi.StringPtrInput
	UserDomains pulumi.StringArrayInput
}

func (ApiGatewayState) ElementType() reflect.Type {
	return reflect.TypeOf((*apiGatewayState)(nil)).Elem()
}

type apiGatewayArgs struct {
	Description *string           `pulumi:"description"`
	FolderId    *string           `pulumi:"folderId"`
	Labels      map[string]string `pulumi:"labels"`
	Name        *string           `pulumi:"name"`
	Spec        string            `pulumi:"spec"`
}

// The set of arguments for constructing a ApiGateway resource.
type ApiGatewayArgs struct {
	Description pulumi.StringPtrInput
	FolderId    pulumi.StringPtrInput
	Labels      pulumi.StringMapInput
	Name        pulumi.StringPtrInput
	Spec        pulumi.StringInput
}

func (ApiGatewayArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*apiGatewayArgs)(nil)).Elem()
}

type ApiGatewayInput interface {
	pulumi.Input

	ToApiGatewayOutput() ApiGatewayOutput
	ToApiGatewayOutputWithContext(ctx context.Context) ApiGatewayOutput
}

func (*ApiGateway) ElementType() reflect.Type {
	return reflect.TypeOf((**ApiGateway)(nil)).Elem()
}

func (i *ApiGateway) ToApiGatewayOutput() ApiGatewayOutput {
	return i.ToApiGatewayOutputWithContext(context.Background())
}

func (i *ApiGateway) ToApiGatewayOutputWithContext(ctx context.Context) ApiGatewayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApiGatewayOutput)
}

// ApiGatewayArrayInput is an input type that accepts ApiGatewayArray and ApiGatewayArrayOutput values.
// You can construct a concrete instance of `ApiGatewayArrayInput` via:
//
//	ApiGatewayArray{ ApiGatewayArgs{...} }
type ApiGatewayArrayInput interface {
	pulumi.Input

	ToApiGatewayArrayOutput() ApiGatewayArrayOutput
	ToApiGatewayArrayOutputWithContext(context.Context) ApiGatewayArrayOutput
}

type ApiGatewayArray []ApiGatewayInput

func (ApiGatewayArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ApiGateway)(nil)).Elem()
}

func (i ApiGatewayArray) ToApiGatewayArrayOutput() ApiGatewayArrayOutput {
	return i.ToApiGatewayArrayOutputWithContext(context.Background())
}

func (i ApiGatewayArray) ToApiGatewayArrayOutputWithContext(ctx context.Context) ApiGatewayArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApiGatewayArrayOutput)
}

// ApiGatewayMapInput is an input type that accepts ApiGatewayMap and ApiGatewayMapOutput values.
// You can construct a concrete instance of `ApiGatewayMapInput` via:
//
//	ApiGatewayMap{ "key": ApiGatewayArgs{...} }
type ApiGatewayMapInput interface {
	pulumi.Input

	ToApiGatewayMapOutput() ApiGatewayMapOutput
	ToApiGatewayMapOutputWithContext(context.Context) ApiGatewayMapOutput
}

type ApiGatewayMap map[string]ApiGatewayInput

func (ApiGatewayMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ApiGateway)(nil)).Elem()
}

func (i ApiGatewayMap) ToApiGatewayMapOutput() ApiGatewayMapOutput {
	return i.ToApiGatewayMapOutputWithContext(context.Background())
}

func (i ApiGatewayMap) ToApiGatewayMapOutputWithContext(ctx context.Context) ApiGatewayMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApiGatewayMapOutput)
}

type ApiGatewayOutput struct{ *pulumi.OutputState }

func (ApiGatewayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ApiGateway)(nil)).Elem()
}

func (o ApiGatewayOutput) ToApiGatewayOutput() ApiGatewayOutput {
	return o
}

func (o ApiGatewayOutput) ToApiGatewayOutputWithContext(ctx context.Context) ApiGatewayOutput {
	return o
}

func (o ApiGatewayOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ApiGateway) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o ApiGatewayOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ApiGateway) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

func (o ApiGatewayOutput) Domain() pulumi.StringOutput {
	return o.ApplyT(func(v *ApiGateway) pulumi.StringOutput { return v.Domain }).(pulumi.StringOutput)
}

func (o ApiGatewayOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *ApiGateway) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

func (o ApiGatewayOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *ApiGateway) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o ApiGatewayOutput) LogGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *ApiGateway) pulumi.StringOutput { return v.LogGroupId }).(pulumi.StringOutput)
}

func (o ApiGatewayOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ApiGateway) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o ApiGatewayOutput) Spec() pulumi.StringOutput {
	return o.ApplyT(func(v *ApiGateway) pulumi.StringOutput { return v.Spec }).(pulumi.StringOutput)
}

func (o ApiGatewayOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *ApiGateway) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

func (o ApiGatewayOutput) UserDomains() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ApiGateway) pulumi.StringArrayOutput { return v.UserDomains }).(pulumi.StringArrayOutput)
}

type ApiGatewayArrayOutput struct{ *pulumi.OutputState }

func (ApiGatewayArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ApiGateway)(nil)).Elem()
}

func (o ApiGatewayArrayOutput) ToApiGatewayArrayOutput() ApiGatewayArrayOutput {
	return o
}

func (o ApiGatewayArrayOutput) ToApiGatewayArrayOutputWithContext(ctx context.Context) ApiGatewayArrayOutput {
	return o
}

func (o ApiGatewayArrayOutput) Index(i pulumi.IntInput) ApiGatewayOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ApiGateway {
		return vs[0].([]*ApiGateway)[vs[1].(int)]
	}).(ApiGatewayOutput)
}

type ApiGatewayMapOutput struct{ *pulumi.OutputState }

func (ApiGatewayMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ApiGateway)(nil)).Elem()
}

func (o ApiGatewayMapOutput) ToApiGatewayMapOutput() ApiGatewayMapOutput {
	return o
}

func (o ApiGatewayMapOutput) ToApiGatewayMapOutputWithContext(ctx context.Context) ApiGatewayMapOutput {
	return o
}

func (o ApiGatewayMapOutput) MapIndex(k pulumi.StringInput) ApiGatewayOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ApiGateway {
		return vs[0].(map[string]*ApiGateway)[vs[1].(string)]
	}).(ApiGatewayOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ApiGatewayInput)(nil)).Elem(), &ApiGateway{})
	pulumi.RegisterInputType(reflect.TypeOf((*ApiGatewayArrayInput)(nil)).Elem(), ApiGatewayArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ApiGatewayMapInput)(nil)).Elem(), ApiGatewayMap{})
	pulumi.RegisterOutputType(ApiGatewayOutput{})
	pulumi.RegisterOutputType(ApiGatewayArrayOutput{})
	pulumi.RegisterOutputType(ApiGatewayMapOutput{})
}
