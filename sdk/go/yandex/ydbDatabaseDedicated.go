// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type YdbDatabaseDedicated struct {
	pulumi.CustomResourceState

	AssignPublicIps    pulumi.BoolPtrOutput                    `pulumi:"assignPublicIps"`
	CreatedAt          pulumi.StringOutput                     `pulumi:"createdAt"`
	DatabasePath       pulumi.StringOutput                     `pulumi:"databasePath"`
	DeletionProtection pulumi.BoolPtrOutput                    `pulumi:"deletionProtection"`
	Description        pulumi.StringPtrOutput                  `pulumi:"description"`
	FolderId           pulumi.StringOutput                     `pulumi:"folderId"`
	Labels             pulumi.StringMapOutput                  `pulumi:"labels"`
	Location           YdbDatabaseDedicatedLocationPtrOutput   `pulumi:"location"`
	LocationId         pulumi.StringOutput                     `pulumi:"locationId"`
	Name               pulumi.StringOutput                     `pulumi:"name"`
	NetworkId          pulumi.StringOutput                     `pulumi:"networkId"`
	ResourcePresetId   pulumi.StringOutput                     `pulumi:"resourcePresetId"`
	ScalePolicy        YdbDatabaseDedicatedScalePolicyOutput   `pulumi:"scalePolicy"`
	Status             pulumi.StringOutput                     `pulumi:"status"`
	StorageConfig      YdbDatabaseDedicatedStorageConfigOutput `pulumi:"storageConfig"`
	SubnetIds          pulumi.StringArrayOutput                `pulumi:"subnetIds"`
	TlsEnabled         pulumi.BoolOutput                       `pulumi:"tlsEnabled"`
	YdbApiEndpoint     pulumi.StringOutput                     `pulumi:"ydbApiEndpoint"`
	YdbFullEndpoint    pulumi.StringOutput                     `pulumi:"ydbFullEndpoint"`
}

// NewYdbDatabaseDedicated registers a new resource with the given unique name, arguments, and options.
func NewYdbDatabaseDedicated(ctx *pulumi.Context,
	name string, args *YdbDatabaseDedicatedArgs, opts ...pulumi.ResourceOption) (*YdbDatabaseDedicated, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.NetworkId == nil {
		return nil, errors.New("invalid value for required argument 'NetworkId'")
	}
	if args.ResourcePresetId == nil {
		return nil, errors.New("invalid value for required argument 'ResourcePresetId'")
	}
	if args.ScalePolicy == nil {
		return nil, errors.New("invalid value for required argument 'ScalePolicy'")
	}
	if args.StorageConfig == nil {
		return nil, errors.New("invalid value for required argument 'StorageConfig'")
	}
	if args.SubnetIds == nil {
		return nil, errors.New("invalid value for required argument 'SubnetIds'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource YdbDatabaseDedicated
	err := ctx.RegisterResource("yandex:index/ydbDatabaseDedicated:YdbDatabaseDedicated", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetYdbDatabaseDedicated gets an existing YdbDatabaseDedicated resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetYdbDatabaseDedicated(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *YdbDatabaseDedicatedState, opts ...pulumi.ResourceOption) (*YdbDatabaseDedicated, error) {
	var resource YdbDatabaseDedicated
	err := ctx.ReadResource("yandex:index/ydbDatabaseDedicated:YdbDatabaseDedicated", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering YdbDatabaseDedicated resources.
type ydbDatabaseDedicatedState struct {
	AssignPublicIps    *bool                              `pulumi:"assignPublicIps"`
	CreatedAt          *string                            `pulumi:"createdAt"`
	DatabasePath       *string                            `pulumi:"databasePath"`
	DeletionProtection *bool                              `pulumi:"deletionProtection"`
	Description        *string                            `pulumi:"description"`
	FolderId           *string                            `pulumi:"folderId"`
	Labels             map[string]string                  `pulumi:"labels"`
	Location           *YdbDatabaseDedicatedLocation      `pulumi:"location"`
	LocationId         *string                            `pulumi:"locationId"`
	Name               *string                            `pulumi:"name"`
	NetworkId          *string                            `pulumi:"networkId"`
	ResourcePresetId   *string                            `pulumi:"resourcePresetId"`
	ScalePolicy        *YdbDatabaseDedicatedScalePolicy   `pulumi:"scalePolicy"`
	Status             *string                            `pulumi:"status"`
	StorageConfig      *YdbDatabaseDedicatedStorageConfig `pulumi:"storageConfig"`
	SubnetIds          []string                           `pulumi:"subnetIds"`
	TlsEnabled         *bool                              `pulumi:"tlsEnabled"`
	YdbApiEndpoint     *string                            `pulumi:"ydbApiEndpoint"`
	YdbFullEndpoint    *string                            `pulumi:"ydbFullEndpoint"`
}

type YdbDatabaseDedicatedState struct {
	AssignPublicIps    pulumi.BoolPtrInput
	CreatedAt          pulumi.StringPtrInput
	DatabasePath       pulumi.StringPtrInput
	DeletionProtection pulumi.BoolPtrInput
	Description        pulumi.StringPtrInput
	FolderId           pulumi.StringPtrInput
	Labels             pulumi.StringMapInput
	Location           YdbDatabaseDedicatedLocationPtrInput
	LocationId         pulumi.StringPtrInput
	Name               pulumi.StringPtrInput
	NetworkId          pulumi.StringPtrInput
	ResourcePresetId   pulumi.StringPtrInput
	ScalePolicy        YdbDatabaseDedicatedScalePolicyPtrInput
	Status             pulumi.StringPtrInput
	StorageConfig      YdbDatabaseDedicatedStorageConfigPtrInput
	SubnetIds          pulumi.StringArrayInput
	TlsEnabled         pulumi.BoolPtrInput
	YdbApiEndpoint     pulumi.StringPtrInput
	YdbFullEndpoint    pulumi.StringPtrInput
}

func (YdbDatabaseDedicatedState) ElementType() reflect.Type {
	return reflect.TypeOf((*ydbDatabaseDedicatedState)(nil)).Elem()
}

type ydbDatabaseDedicatedArgs struct {
	AssignPublicIps    *bool                             `pulumi:"assignPublicIps"`
	DeletionProtection *bool                             `pulumi:"deletionProtection"`
	Description        *string                           `pulumi:"description"`
	FolderId           *string                           `pulumi:"folderId"`
	Labels             map[string]string                 `pulumi:"labels"`
	Location           *YdbDatabaseDedicatedLocation     `pulumi:"location"`
	LocationId         *string                           `pulumi:"locationId"`
	Name               *string                           `pulumi:"name"`
	NetworkId          string                            `pulumi:"networkId"`
	ResourcePresetId   string                            `pulumi:"resourcePresetId"`
	ScalePolicy        YdbDatabaseDedicatedScalePolicy   `pulumi:"scalePolicy"`
	StorageConfig      YdbDatabaseDedicatedStorageConfig `pulumi:"storageConfig"`
	SubnetIds          []string                          `pulumi:"subnetIds"`
}

// The set of arguments for constructing a YdbDatabaseDedicated resource.
type YdbDatabaseDedicatedArgs struct {
	AssignPublicIps    pulumi.BoolPtrInput
	DeletionProtection pulumi.BoolPtrInput
	Description        pulumi.StringPtrInput
	FolderId           pulumi.StringPtrInput
	Labels             pulumi.StringMapInput
	Location           YdbDatabaseDedicatedLocationPtrInput
	LocationId         pulumi.StringPtrInput
	Name               pulumi.StringPtrInput
	NetworkId          pulumi.StringInput
	ResourcePresetId   pulumi.StringInput
	ScalePolicy        YdbDatabaseDedicatedScalePolicyInput
	StorageConfig      YdbDatabaseDedicatedStorageConfigInput
	SubnetIds          pulumi.StringArrayInput
}

func (YdbDatabaseDedicatedArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ydbDatabaseDedicatedArgs)(nil)).Elem()
}

type YdbDatabaseDedicatedInput interface {
	pulumi.Input

	ToYdbDatabaseDedicatedOutput() YdbDatabaseDedicatedOutput
	ToYdbDatabaseDedicatedOutputWithContext(ctx context.Context) YdbDatabaseDedicatedOutput
}

func (*YdbDatabaseDedicated) ElementType() reflect.Type {
	return reflect.TypeOf((**YdbDatabaseDedicated)(nil)).Elem()
}

func (i *YdbDatabaseDedicated) ToYdbDatabaseDedicatedOutput() YdbDatabaseDedicatedOutput {
	return i.ToYdbDatabaseDedicatedOutputWithContext(context.Background())
}

func (i *YdbDatabaseDedicated) ToYdbDatabaseDedicatedOutputWithContext(ctx context.Context) YdbDatabaseDedicatedOutput {
	return pulumi.ToOutputWithContext(ctx, i).(YdbDatabaseDedicatedOutput)
}

// YdbDatabaseDedicatedArrayInput is an input type that accepts YdbDatabaseDedicatedArray and YdbDatabaseDedicatedArrayOutput values.
// You can construct a concrete instance of `YdbDatabaseDedicatedArrayInput` via:
//
//	YdbDatabaseDedicatedArray{ YdbDatabaseDedicatedArgs{...} }
type YdbDatabaseDedicatedArrayInput interface {
	pulumi.Input

	ToYdbDatabaseDedicatedArrayOutput() YdbDatabaseDedicatedArrayOutput
	ToYdbDatabaseDedicatedArrayOutputWithContext(context.Context) YdbDatabaseDedicatedArrayOutput
}

type YdbDatabaseDedicatedArray []YdbDatabaseDedicatedInput

func (YdbDatabaseDedicatedArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*YdbDatabaseDedicated)(nil)).Elem()
}

func (i YdbDatabaseDedicatedArray) ToYdbDatabaseDedicatedArrayOutput() YdbDatabaseDedicatedArrayOutput {
	return i.ToYdbDatabaseDedicatedArrayOutputWithContext(context.Background())
}

func (i YdbDatabaseDedicatedArray) ToYdbDatabaseDedicatedArrayOutputWithContext(ctx context.Context) YdbDatabaseDedicatedArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(YdbDatabaseDedicatedArrayOutput)
}

// YdbDatabaseDedicatedMapInput is an input type that accepts YdbDatabaseDedicatedMap and YdbDatabaseDedicatedMapOutput values.
// You can construct a concrete instance of `YdbDatabaseDedicatedMapInput` via:
//
//	YdbDatabaseDedicatedMap{ "key": YdbDatabaseDedicatedArgs{...} }
type YdbDatabaseDedicatedMapInput interface {
	pulumi.Input

	ToYdbDatabaseDedicatedMapOutput() YdbDatabaseDedicatedMapOutput
	ToYdbDatabaseDedicatedMapOutputWithContext(context.Context) YdbDatabaseDedicatedMapOutput
}

type YdbDatabaseDedicatedMap map[string]YdbDatabaseDedicatedInput

func (YdbDatabaseDedicatedMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*YdbDatabaseDedicated)(nil)).Elem()
}

func (i YdbDatabaseDedicatedMap) ToYdbDatabaseDedicatedMapOutput() YdbDatabaseDedicatedMapOutput {
	return i.ToYdbDatabaseDedicatedMapOutputWithContext(context.Background())
}

func (i YdbDatabaseDedicatedMap) ToYdbDatabaseDedicatedMapOutputWithContext(ctx context.Context) YdbDatabaseDedicatedMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(YdbDatabaseDedicatedMapOutput)
}

type YdbDatabaseDedicatedOutput struct{ *pulumi.OutputState }

func (YdbDatabaseDedicatedOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**YdbDatabaseDedicated)(nil)).Elem()
}

func (o YdbDatabaseDedicatedOutput) ToYdbDatabaseDedicatedOutput() YdbDatabaseDedicatedOutput {
	return o
}

func (o YdbDatabaseDedicatedOutput) ToYdbDatabaseDedicatedOutputWithContext(ctx context.Context) YdbDatabaseDedicatedOutput {
	return o
}

func (o YdbDatabaseDedicatedOutput) AssignPublicIps() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.BoolPtrOutput { return v.AssignPublicIps }).(pulumi.BoolPtrOutput)
}

func (o YdbDatabaseDedicatedOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o YdbDatabaseDedicatedOutput) DatabasePath() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringOutput { return v.DatabasePath }).(pulumi.StringOutput)
}

func (o YdbDatabaseDedicatedOutput) DeletionProtection() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.BoolPtrOutput { return v.DeletionProtection }).(pulumi.BoolPtrOutput)
}

func (o YdbDatabaseDedicatedOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

func (o YdbDatabaseDedicatedOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

func (o YdbDatabaseDedicatedOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o YdbDatabaseDedicatedOutput) Location() YdbDatabaseDedicatedLocationPtrOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) YdbDatabaseDedicatedLocationPtrOutput { return v.Location }).(YdbDatabaseDedicatedLocationPtrOutput)
}

func (o YdbDatabaseDedicatedOutput) LocationId() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringOutput { return v.LocationId }).(pulumi.StringOutput)
}

func (o YdbDatabaseDedicatedOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o YdbDatabaseDedicatedOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringOutput { return v.NetworkId }).(pulumi.StringOutput)
}

func (o YdbDatabaseDedicatedOutput) ResourcePresetId() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringOutput { return v.ResourcePresetId }).(pulumi.StringOutput)
}

func (o YdbDatabaseDedicatedOutput) ScalePolicy() YdbDatabaseDedicatedScalePolicyOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) YdbDatabaseDedicatedScalePolicyOutput { return v.ScalePolicy }).(YdbDatabaseDedicatedScalePolicyOutput)
}

func (o YdbDatabaseDedicatedOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

func (o YdbDatabaseDedicatedOutput) StorageConfig() YdbDatabaseDedicatedStorageConfigOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) YdbDatabaseDedicatedStorageConfigOutput { return v.StorageConfig }).(YdbDatabaseDedicatedStorageConfigOutput)
}

func (o YdbDatabaseDedicatedOutput) SubnetIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringArrayOutput { return v.SubnetIds }).(pulumi.StringArrayOutput)
}

func (o YdbDatabaseDedicatedOutput) TlsEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.BoolOutput { return v.TlsEnabled }).(pulumi.BoolOutput)
}

func (o YdbDatabaseDedicatedOutput) YdbApiEndpoint() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringOutput { return v.YdbApiEndpoint }).(pulumi.StringOutput)
}

func (o YdbDatabaseDedicatedOutput) YdbFullEndpoint() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbDatabaseDedicated) pulumi.StringOutput { return v.YdbFullEndpoint }).(pulumi.StringOutput)
}

type YdbDatabaseDedicatedArrayOutput struct{ *pulumi.OutputState }

func (YdbDatabaseDedicatedArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*YdbDatabaseDedicated)(nil)).Elem()
}

func (o YdbDatabaseDedicatedArrayOutput) ToYdbDatabaseDedicatedArrayOutput() YdbDatabaseDedicatedArrayOutput {
	return o
}

func (o YdbDatabaseDedicatedArrayOutput) ToYdbDatabaseDedicatedArrayOutputWithContext(ctx context.Context) YdbDatabaseDedicatedArrayOutput {
	return o
}

func (o YdbDatabaseDedicatedArrayOutput) Index(i pulumi.IntInput) YdbDatabaseDedicatedOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *YdbDatabaseDedicated {
		return vs[0].([]*YdbDatabaseDedicated)[vs[1].(int)]
	}).(YdbDatabaseDedicatedOutput)
}

type YdbDatabaseDedicatedMapOutput struct{ *pulumi.OutputState }

func (YdbDatabaseDedicatedMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*YdbDatabaseDedicated)(nil)).Elem()
}

func (o YdbDatabaseDedicatedMapOutput) ToYdbDatabaseDedicatedMapOutput() YdbDatabaseDedicatedMapOutput {
	return o
}

func (o YdbDatabaseDedicatedMapOutput) ToYdbDatabaseDedicatedMapOutputWithContext(ctx context.Context) YdbDatabaseDedicatedMapOutput {
	return o
}

func (o YdbDatabaseDedicatedMapOutput) MapIndex(k pulumi.StringInput) YdbDatabaseDedicatedOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *YdbDatabaseDedicated {
		return vs[0].(map[string]*YdbDatabaseDedicated)[vs[1].(string)]
	}).(YdbDatabaseDedicatedOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*YdbDatabaseDedicatedInput)(nil)).Elem(), &YdbDatabaseDedicated{})
	pulumi.RegisterInputType(reflect.TypeOf((*YdbDatabaseDedicatedArrayInput)(nil)).Elem(), YdbDatabaseDedicatedArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*YdbDatabaseDedicatedMapInput)(nil)).Elem(), YdbDatabaseDedicatedMap{})
	pulumi.RegisterOutputType(YdbDatabaseDedicatedOutput{})
	pulumi.RegisterOutputType(YdbDatabaseDedicatedArrayOutput{})
	pulumi.RegisterOutputType(YdbDatabaseDedicatedMapOutput{})
}
