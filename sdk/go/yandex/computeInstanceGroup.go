// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// An Instance group resource. For more information, see
// [the official documentation](https://cloud.yandex.com/docs/compute/concepts/instance-groups/).
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"fmt"
// 	"io/ioutil"
//
// 	"github.com/pulumi/pulumi-yandex/sdk/go/yandex"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func readFileOrPanic(path string) pulumi.StringPtrInput {
// 	data, err := ioutil.ReadFile(path)
// 	if err != nil {
// 		panic(err.Error())
// 	}
// 	return pulumi.String(string(data))
// }
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := yandex.NewComputeInstanceGroup(ctx, "group1", &yandex.ComputeInstanceGroupArgs{
// 			AllocationPolicy: &ComputeInstanceGroupAllocationPolicyArgs{
// 				Zones: pulumi.StringArray{
// 					pulumi.String("ru-central1-a"),
// 				},
// 			},
// 			DeletionProtection: pulumi.Bool(true),
// 			DeployPolicy: &ComputeInstanceGroupDeployPolicyArgs{
// 				MaxCreating:    pulumi.Int(2),
// 				MaxDeleting:    pulumi.Int(2),
// 				MaxExpansion:   pulumi.Int(2),
// 				MaxUnavailable: pulumi.Int(2),
// 			},
// 			FolderId: pulumi.Any(data.Yandex_resourcemanager_folder.Test_folder.Id),
// 			InstanceTemplate: &ComputeInstanceGroupInstanceTemplateArgs{
// 				BootDisk: &ComputeInstanceGroupInstanceTemplateBootDiskArgs{
// 					InitializeParams: &ComputeInstanceGroupInstanceTemplateBootDiskInitializeParamsArgs{
// 						ImageId: pulumi.Any(data.Yandex_compute_image.Ubuntu.Id),
// 						Size:    pulumi.Int(4),
// 					},
// 					Mode: pulumi.String("READ_WRITE"),
// 				},
// 				Labels: pulumi.StringMap{
// 					"label1": pulumi.String("label1-value"),
// 					"label2": pulumi.String("label2-value"),
// 				},
// 				Metadata: pulumi.StringMap{
// 					"foo":      pulumi.String("bar"),
// 					"ssh-keys": pulumi.String(fmt.Sprintf("ubuntu:%v", readFileOrPanic("~/.ssh/id_rsa.pub"))),
// 				},
// 				NetworkInterfaces: ComputeInstanceGroupInstanceTemplateNetworkInterfaceArray{
// 					&ComputeInstanceGroupInstanceTemplateNetworkInterfaceArgs{
// 						NetworkId: pulumi.Any(yandex_vpc_network.MyInstGroupNetwork.Id),
// 						SubnetIds: pulumi.StringArray{
// 							pulumi.Any(yandex_vpc_subnet.MyInstGroupSubnet.Id),
// 						},
// 					},
// 				},
// 				NetworkSettings: ComputeInstanceGroupInstanceTemplateNetworkSettingArray{
// 					&ComputeInstanceGroupInstanceTemplateNetworkSettingArgs{
// 						Type: pulumi.String("STANDARD"),
// 					},
// 				},
// 				PlatformId: pulumi.String("standard-v1"),
// 				Resources: &ComputeInstanceGroupInstanceTemplateResourcesArgs{
// 					Cores:  pulumi.Int(2),
// 					Memory: pulumi.Float64(2),
// 				},
// 			},
// 			ScalePolicy: &ComputeInstanceGroupScalePolicyArgs{
// 				FixedScale: &ComputeInstanceGroupScalePolicyFixedScaleArgs{
// 					Size: pulumi.Int(3),
// 				},
// 			},
// 			ServiceAccountId: pulumi.Any(yandex_iam_service_account.Test_account.Id),
// 			Variables: pulumi.StringMap{
// 				"test_key1": pulumi.String("test_value1"),
// 				"test_key2": pulumi.String("test_value2"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type ComputeInstanceGroup struct {
	pulumi.CustomResourceState

	// The allocation policy of the instance group by zone and region. The structure is documented below.
	AllocationPolicy ComputeInstanceGroupAllocationPolicyOutput `pulumi:"allocationPolicy"`
	// Application Load balancing (L7) specifications. The structure is documented below.
	ApplicationLoadBalancer ComputeInstanceGroupApplicationLoadBalancerPtrOutput `pulumi:"applicationLoadBalancer"`
	// The instance group creation timestamp.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// Flag that protects the instance group from accidental deletion.
	DeletionProtection pulumi.BoolPtrOutput `pulumi:"deletionProtection"`
	// The deployment policy of the instance group. The structure is documented below.
	DeployPolicy ComputeInstanceGroupDeployPolicyOutput `pulumi:"deployPolicy"`
	// A description of the boot disk.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Folder ID of custom metric in Yandex Monitoring that should be used for scaling.
	FolderId pulumi.StringOutput `pulumi:"folderId"`
	// Health check specifications. The structure is documented below.
	HealthChecks ComputeInstanceGroupHealthCheckArrayOutput `pulumi:"healthChecks"`
	// The template for creating new instances. The structure is documented below.
	InstanceTemplate ComputeInstanceGroupInstanceTemplateOutput `pulumi:"instanceTemplate"`
	Instances        ComputeInstanceGroupInstanceArrayOutput    `pulumi:"instances"`
	// A map of labels of metric.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Load balancing specifications. The structure is documented below.
	LoadBalancer ComputeInstanceGroupLoadBalancerPtrOutput `pulumi:"loadBalancer"`
	// Timeout for waiting for the VM to become healthy. If the timeout is exceeded, the VM will be turned off based on the deployment policy. Specified in seconds.
	MaxCheckingHealthDuration pulumi.IntPtrOutput `pulumi:"maxCheckingHealthDuration"`
	// Name template of the instance.\
	// In order to be unique it must contain at least one of instance unique placeholders:
	// {instance.short_id}
	// {instance.index}
	// combination of {instance.zone_id} and {instance.index_in_zone}
	// Example: my-instance-{instance.index}
	// If not set, default is used: {instance_group.id}-{instance.short_id}
	// It may also contain another placeholders, see metadata doc for full list.
	Name pulumi.StringOutput `pulumi:"name"`
	// The scaling policy of the instance group. The structure is documented below.
	ScalePolicy ComputeInstanceGroupScalePolicyOutput `pulumi:"scalePolicy"`
	// The ID of the service account authorized for this instance.
	ServiceAccountId pulumi.StringOutput `pulumi:"serviceAccountId"`
	// The status of the instance.
	Status pulumi.StringOutput `pulumi:"status"`
	// A set of key/value  variables pairs to assign to the instance group.
	Variables pulumi.StringMapOutput `pulumi:"variables"`
}

// NewComputeInstanceGroup registers a new resource with the given unique name, arguments, and options.
func NewComputeInstanceGroup(ctx *pulumi.Context,
	name string, args *ComputeInstanceGroupArgs, opts ...pulumi.ResourceOption) (*ComputeInstanceGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AllocationPolicy == nil {
		return nil, errors.New("invalid value for required argument 'AllocationPolicy'")
	}
	if args.DeployPolicy == nil {
		return nil, errors.New("invalid value for required argument 'DeployPolicy'")
	}
	if args.InstanceTemplate == nil {
		return nil, errors.New("invalid value for required argument 'InstanceTemplate'")
	}
	if args.ScalePolicy == nil {
		return nil, errors.New("invalid value for required argument 'ScalePolicy'")
	}
	if args.ServiceAccountId == nil {
		return nil, errors.New("invalid value for required argument 'ServiceAccountId'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource ComputeInstanceGroup
	err := ctx.RegisterResource("yandex:index/computeInstanceGroup:ComputeInstanceGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetComputeInstanceGroup gets an existing ComputeInstanceGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetComputeInstanceGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ComputeInstanceGroupState, opts ...pulumi.ResourceOption) (*ComputeInstanceGroup, error) {
	var resource ComputeInstanceGroup
	err := ctx.ReadResource("yandex:index/computeInstanceGroup:ComputeInstanceGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ComputeInstanceGroup resources.
type computeInstanceGroupState struct {
	// The allocation policy of the instance group by zone and region. The structure is documented below.
	AllocationPolicy *ComputeInstanceGroupAllocationPolicy `pulumi:"allocationPolicy"`
	// Application Load balancing (L7) specifications. The structure is documented below.
	ApplicationLoadBalancer *ComputeInstanceGroupApplicationLoadBalancer `pulumi:"applicationLoadBalancer"`
	// The instance group creation timestamp.
	CreatedAt *string `pulumi:"createdAt"`
	// Flag that protects the instance group from accidental deletion.
	DeletionProtection *bool `pulumi:"deletionProtection"`
	// The deployment policy of the instance group. The structure is documented below.
	DeployPolicy *ComputeInstanceGroupDeployPolicy `pulumi:"deployPolicy"`
	// A description of the boot disk.
	Description *string `pulumi:"description"`
	// Folder ID of custom metric in Yandex Monitoring that should be used for scaling.
	FolderId *string `pulumi:"folderId"`
	// Health check specifications. The structure is documented below.
	HealthChecks []ComputeInstanceGroupHealthCheck `pulumi:"healthChecks"`
	// The template for creating new instances. The structure is documented below.
	InstanceTemplate *ComputeInstanceGroupInstanceTemplate `pulumi:"instanceTemplate"`
	Instances        []ComputeInstanceGroupInstance        `pulumi:"instances"`
	// A map of labels of metric.
	Labels map[string]string `pulumi:"labels"`
	// Load balancing specifications. The structure is documented below.
	LoadBalancer *ComputeInstanceGroupLoadBalancer `pulumi:"loadBalancer"`
	// Timeout for waiting for the VM to become healthy. If the timeout is exceeded, the VM will be turned off based on the deployment policy. Specified in seconds.
	MaxCheckingHealthDuration *int `pulumi:"maxCheckingHealthDuration"`
	// Name template of the instance.\
	// In order to be unique it must contain at least one of instance unique placeholders:
	// {instance.short_id}
	// {instance.index}
	// combination of {instance.zone_id} and {instance.index_in_zone}
	// Example: my-instance-{instance.index}
	// If not set, default is used: {instance_group.id}-{instance.short_id}
	// It may also contain another placeholders, see metadata doc for full list.
	Name *string `pulumi:"name"`
	// The scaling policy of the instance group. The structure is documented below.
	ScalePolicy *ComputeInstanceGroupScalePolicy `pulumi:"scalePolicy"`
	// The ID of the service account authorized for this instance.
	ServiceAccountId *string `pulumi:"serviceAccountId"`
	// The status of the instance.
	Status *string `pulumi:"status"`
	// A set of key/value  variables pairs to assign to the instance group.
	Variables map[string]string `pulumi:"variables"`
}

type ComputeInstanceGroupState struct {
	// The allocation policy of the instance group by zone and region. The structure is documented below.
	AllocationPolicy ComputeInstanceGroupAllocationPolicyPtrInput
	// Application Load balancing (L7) specifications. The structure is documented below.
	ApplicationLoadBalancer ComputeInstanceGroupApplicationLoadBalancerPtrInput
	// The instance group creation timestamp.
	CreatedAt pulumi.StringPtrInput
	// Flag that protects the instance group from accidental deletion.
	DeletionProtection pulumi.BoolPtrInput
	// The deployment policy of the instance group. The structure is documented below.
	DeployPolicy ComputeInstanceGroupDeployPolicyPtrInput
	// A description of the boot disk.
	Description pulumi.StringPtrInput
	// Folder ID of custom metric in Yandex Monitoring that should be used for scaling.
	FolderId pulumi.StringPtrInput
	// Health check specifications. The structure is documented below.
	HealthChecks ComputeInstanceGroupHealthCheckArrayInput
	// The template for creating new instances. The structure is documented below.
	InstanceTemplate ComputeInstanceGroupInstanceTemplatePtrInput
	Instances        ComputeInstanceGroupInstanceArrayInput
	// A map of labels of metric.
	Labels pulumi.StringMapInput
	// Load balancing specifications. The structure is documented below.
	LoadBalancer ComputeInstanceGroupLoadBalancerPtrInput
	// Timeout for waiting for the VM to become healthy. If the timeout is exceeded, the VM will be turned off based on the deployment policy. Specified in seconds.
	MaxCheckingHealthDuration pulumi.IntPtrInput
	// Name template of the instance.\
	// In order to be unique it must contain at least one of instance unique placeholders:
	// {instance.short_id}
	// {instance.index}
	// combination of {instance.zone_id} and {instance.index_in_zone}
	// Example: my-instance-{instance.index}
	// If not set, default is used: {instance_group.id}-{instance.short_id}
	// It may also contain another placeholders, see metadata doc for full list.
	Name pulumi.StringPtrInput
	// The scaling policy of the instance group. The structure is documented below.
	ScalePolicy ComputeInstanceGroupScalePolicyPtrInput
	// The ID of the service account authorized for this instance.
	ServiceAccountId pulumi.StringPtrInput
	// The status of the instance.
	Status pulumi.StringPtrInput
	// A set of key/value  variables pairs to assign to the instance group.
	Variables pulumi.StringMapInput
}

func (ComputeInstanceGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*computeInstanceGroupState)(nil)).Elem()
}

type computeInstanceGroupArgs struct {
	// The allocation policy of the instance group by zone and region. The structure is documented below.
	AllocationPolicy ComputeInstanceGroupAllocationPolicy `pulumi:"allocationPolicy"`
	// Application Load balancing (L7) specifications. The structure is documented below.
	ApplicationLoadBalancer *ComputeInstanceGroupApplicationLoadBalancer `pulumi:"applicationLoadBalancer"`
	// Flag that protects the instance group from accidental deletion.
	DeletionProtection *bool `pulumi:"deletionProtection"`
	// The deployment policy of the instance group. The structure is documented below.
	DeployPolicy ComputeInstanceGroupDeployPolicy `pulumi:"deployPolicy"`
	// A description of the boot disk.
	Description *string `pulumi:"description"`
	// Folder ID of custom metric in Yandex Monitoring that should be used for scaling.
	FolderId *string `pulumi:"folderId"`
	// Health check specifications. The structure is documented below.
	HealthChecks []ComputeInstanceGroupHealthCheck `pulumi:"healthChecks"`
	// The template for creating new instances. The structure is documented below.
	InstanceTemplate ComputeInstanceGroupInstanceTemplate `pulumi:"instanceTemplate"`
	// A map of labels of metric.
	Labels map[string]string `pulumi:"labels"`
	// Load balancing specifications. The structure is documented below.
	LoadBalancer *ComputeInstanceGroupLoadBalancer `pulumi:"loadBalancer"`
	// Timeout for waiting for the VM to become healthy. If the timeout is exceeded, the VM will be turned off based on the deployment policy. Specified in seconds.
	MaxCheckingHealthDuration *int `pulumi:"maxCheckingHealthDuration"`
	// Name template of the instance.\
	// In order to be unique it must contain at least one of instance unique placeholders:
	// {instance.short_id}
	// {instance.index}
	// combination of {instance.zone_id} and {instance.index_in_zone}
	// Example: my-instance-{instance.index}
	// If not set, default is used: {instance_group.id}-{instance.short_id}
	// It may also contain another placeholders, see metadata doc for full list.
	Name *string `pulumi:"name"`
	// The scaling policy of the instance group. The structure is documented below.
	ScalePolicy ComputeInstanceGroupScalePolicy `pulumi:"scalePolicy"`
	// The ID of the service account authorized for this instance.
	ServiceAccountId string `pulumi:"serviceAccountId"`
	// A set of key/value  variables pairs to assign to the instance group.
	Variables map[string]string `pulumi:"variables"`
}

// The set of arguments for constructing a ComputeInstanceGroup resource.
type ComputeInstanceGroupArgs struct {
	// The allocation policy of the instance group by zone and region. The structure is documented below.
	AllocationPolicy ComputeInstanceGroupAllocationPolicyInput
	// Application Load balancing (L7) specifications. The structure is documented below.
	ApplicationLoadBalancer ComputeInstanceGroupApplicationLoadBalancerPtrInput
	// Flag that protects the instance group from accidental deletion.
	DeletionProtection pulumi.BoolPtrInput
	// The deployment policy of the instance group. The structure is documented below.
	DeployPolicy ComputeInstanceGroupDeployPolicyInput
	// A description of the boot disk.
	Description pulumi.StringPtrInput
	// Folder ID of custom metric in Yandex Monitoring that should be used for scaling.
	FolderId pulumi.StringPtrInput
	// Health check specifications. The structure is documented below.
	HealthChecks ComputeInstanceGroupHealthCheckArrayInput
	// The template for creating new instances. The structure is documented below.
	InstanceTemplate ComputeInstanceGroupInstanceTemplateInput
	// A map of labels of metric.
	Labels pulumi.StringMapInput
	// Load balancing specifications. The structure is documented below.
	LoadBalancer ComputeInstanceGroupLoadBalancerPtrInput
	// Timeout for waiting for the VM to become healthy. If the timeout is exceeded, the VM will be turned off based on the deployment policy. Specified in seconds.
	MaxCheckingHealthDuration pulumi.IntPtrInput
	// Name template of the instance.\
	// In order to be unique it must contain at least one of instance unique placeholders:
	// {instance.short_id}
	// {instance.index}
	// combination of {instance.zone_id} and {instance.index_in_zone}
	// Example: my-instance-{instance.index}
	// If not set, default is used: {instance_group.id}-{instance.short_id}
	// It may also contain another placeholders, see metadata doc for full list.
	Name pulumi.StringPtrInput
	// The scaling policy of the instance group. The structure is documented below.
	ScalePolicy ComputeInstanceGroupScalePolicyInput
	// The ID of the service account authorized for this instance.
	ServiceAccountId pulumi.StringInput
	// A set of key/value  variables pairs to assign to the instance group.
	Variables pulumi.StringMapInput
}

func (ComputeInstanceGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*computeInstanceGroupArgs)(nil)).Elem()
}

type ComputeInstanceGroupInput interface {
	pulumi.Input

	ToComputeInstanceGroupOutput() ComputeInstanceGroupOutput
	ToComputeInstanceGroupOutputWithContext(ctx context.Context) ComputeInstanceGroupOutput
}

func (*ComputeInstanceGroup) ElementType() reflect.Type {
	return reflect.TypeOf((**ComputeInstanceGroup)(nil)).Elem()
}

func (i *ComputeInstanceGroup) ToComputeInstanceGroupOutput() ComputeInstanceGroupOutput {
	return i.ToComputeInstanceGroupOutputWithContext(context.Background())
}

func (i *ComputeInstanceGroup) ToComputeInstanceGroupOutputWithContext(ctx context.Context) ComputeInstanceGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputeInstanceGroupOutput)
}

// ComputeInstanceGroupArrayInput is an input type that accepts ComputeInstanceGroupArray and ComputeInstanceGroupArrayOutput values.
// You can construct a concrete instance of `ComputeInstanceGroupArrayInput` via:
//
//          ComputeInstanceGroupArray{ ComputeInstanceGroupArgs{...} }
type ComputeInstanceGroupArrayInput interface {
	pulumi.Input

	ToComputeInstanceGroupArrayOutput() ComputeInstanceGroupArrayOutput
	ToComputeInstanceGroupArrayOutputWithContext(context.Context) ComputeInstanceGroupArrayOutput
}

type ComputeInstanceGroupArray []ComputeInstanceGroupInput

func (ComputeInstanceGroupArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ComputeInstanceGroup)(nil)).Elem()
}

func (i ComputeInstanceGroupArray) ToComputeInstanceGroupArrayOutput() ComputeInstanceGroupArrayOutput {
	return i.ToComputeInstanceGroupArrayOutputWithContext(context.Background())
}

func (i ComputeInstanceGroupArray) ToComputeInstanceGroupArrayOutputWithContext(ctx context.Context) ComputeInstanceGroupArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputeInstanceGroupArrayOutput)
}

// ComputeInstanceGroupMapInput is an input type that accepts ComputeInstanceGroupMap and ComputeInstanceGroupMapOutput values.
// You can construct a concrete instance of `ComputeInstanceGroupMapInput` via:
//
//          ComputeInstanceGroupMap{ "key": ComputeInstanceGroupArgs{...} }
type ComputeInstanceGroupMapInput interface {
	pulumi.Input

	ToComputeInstanceGroupMapOutput() ComputeInstanceGroupMapOutput
	ToComputeInstanceGroupMapOutputWithContext(context.Context) ComputeInstanceGroupMapOutput
}

type ComputeInstanceGroupMap map[string]ComputeInstanceGroupInput

func (ComputeInstanceGroupMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ComputeInstanceGroup)(nil)).Elem()
}

func (i ComputeInstanceGroupMap) ToComputeInstanceGroupMapOutput() ComputeInstanceGroupMapOutput {
	return i.ToComputeInstanceGroupMapOutputWithContext(context.Background())
}

func (i ComputeInstanceGroupMap) ToComputeInstanceGroupMapOutputWithContext(ctx context.Context) ComputeInstanceGroupMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputeInstanceGroupMapOutput)
}

type ComputeInstanceGroupOutput struct{ *pulumi.OutputState }

func (ComputeInstanceGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ComputeInstanceGroup)(nil)).Elem()
}

func (o ComputeInstanceGroupOutput) ToComputeInstanceGroupOutput() ComputeInstanceGroupOutput {
	return o
}

func (o ComputeInstanceGroupOutput) ToComputeInstanceGroupOutputWithContext(ctx context.Context) ComputeInstanceGroupOutput {
	return o
}

// The allocation policy of the instance group by zone and region. The structure is documented below.
func (o ComputeInstanceGroupOutput) AllocationPolicy() ComputeInstanceGroupAllocationPolicyOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) ComputeInstanceGroupAllocationPolicyOutput { return v.AllocationPolicy }).(ComputeInstanceGroupAllocationPolicyOutput)
}

// Application Load balancing (L7) specifications. The structure is documented below.
func (o ComputeInstanceGroupOutput) ApplicationLoadBalancer() ComputeInstanceGroupApplicationLoadBalancerPtrOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) ComputeInstanceGroupApplicationLoadBalancerPtrOutput {
		return v.ApplicationLoadBalancer
	}).(ComputeInstanceGroupApplicationLoadBalancerPtrOutput)
}

// The instance group creation timestamp.
func (o ComputeInstanceGroupOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// Flag that protects the instance group from accidental deletion.
func (o ComputeInstanceGroupOutput) DeletionProtection() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) pulumi.BoolPtrOutput { return v.DeletionProtection }).(pulumi.BoolPtrOutput)
}

// The deployment policy of the instance group. The structure is documented below.
func (o ComputeInstanceGroupOutput) DeployPolicy() ComputeInstanceGroupDeployPolicyOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) ComputeInstanceGroupDeployPolicyOutput { return v.DeployPolicy }).(ComputeInstanceGroupDeployPolicyOutput)
}

// A description of the boot disk.
func (o ComputeInstanceGroupOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Folder ID of custom metric in Yandex Monitoring that should be used for scaling.
func (o ComputeInstanceGroupOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

// Health check specifications. The structure is documented below.
func (o ComputeInstanceGroupOutput) HealthChecks() ComputeInstanceGroupHealthCheckArrayOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) ComputeInstanceGroupHealthCheckArrayOutput { return v.HealthChecks }).(ComputeInstanceGroupHealthCheckArrayOutput)
}

// The template for creating new instances. The structure is documented below.
func (o ComputeInstanceGroupOutput) InstanceTemplate() ComputeInstanceGroupInstanceTemplateOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) ComputeInstanceGroupInstanceTemplateOutput { return v.InstanceTemplate }).(ComputeInstanceGroupInstanceTemplateOutput)
}

func (o ComputeInstanceGroupOutput) Instances() ComputeInstanceGroupInstanceArrayOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) ComputeInstanceGroupInstanceArrayOutput { return v.Instances }).(ComputeInstanceGroupInstanceArrayOutput)
}

// A map of labels of metric.
func (o ComputeInstanceGroupOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// Load balancing specifications. The structure is documented below.
func (o ComputeInstanceGroupOutput) LoadBalancer() ComputeInstanceGroupLoadBalancerPtrOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) ComputeInstanceGroupLoadBalancerPtrOutput { return v.LoadBalancer }).(ComputeInstanceGroupLoadBalancerPtrOutput)
}

// Timeout for waiting for the VM to become healthy. If the timeout is exceeded, the VM will be turned off based on the deployment policy. Specified in seconds.
func (o ComputeInstanceGroupOutput) MaxCheckingHealthDuration() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) pulumi.IntPtrOutput { return v.MaxCheckingHealthDuration }).(pulumi.IntPtrOutput)
}

// Name template of the instance.\
// In order to be unique it must contain at least one of instance unique placeholders:
// {instance.short_id}
// {instance.index}
// combination of {instance.zone_id} and {instance.index_in_zone}
// Example: my-instance-{instance.index}
// If not set, default is used: {instance_group.id}-{instance.short_id}
// It may also contain another placeholders, see metadata doc for full list.
func (o ComputeInstanceGroupOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The scaling policy of the instance group. The structure is documented below.
func (o ComputeInstanceGroupOutput) ScalePolicy() ComputeInstanceGroupScalePolicyOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) ComputeInstanceGroupScalePolicyOutput { return v.ScalePolicy }).(ComputeInstanceGroupScalePolicyOutput)
}

// The ID of the service account authorized for this instance.
func (o ComputeInstanceGroupOutput) ServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) pulumi.StringOutput { return v.ServiceAccountId }).(pulumi.StringOutput)
}

// The status of the instance.
func (o ComputeInstanceGroupOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

// A set of key/value  variables pairs to assign to the instance group.
func (o ComputeInstanceGroupOutput) Variables() pulumi.StringMapOutput {
	return o.ApplyT(func(v *ComputeInstanceGroup) pulumi.StringMapOutput { return v.Variables }).(pulumi.StringMapOutput)
}

type ComputeInstanceGroupArrayOutput struct{ *pulumi.OutputState }

func (ComputeInstanceGroupArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ComputeInstanceGroup)(nil)).Elem()
}

func (o ComputeInstanceGroupArrayOutput) ToComputeInstanceGroupArrayOutput() ComputeInstanceGroupArrayOutput {
	return o
}

func (o ComputeInstanceGroupArrayOutput) ToComputeInstanceGroupArrayOutputWithContext(ctx context.Context) ComputeInstanceGroupArrayOutput {
	return o
}

func (o ComputeInstanceGroupArrayOutput) Index(i pulumi.IntInput) ComputeInstanceGroupOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ComputeInstanceGroup {
		return vs[0].([]*ComputeInstanceGroup)[vs[1].(int)]
	}).(ComputeInstanceGroupOutput)
}

type ComputeInstanceGroupMapOutput struct{ *pulumi.OutputState }

func (ComputeInstanceGroupMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ComputeInstanceGroup)(nil)).Elem()
}

func (o ComputeInstanceGroupMapOutput) ToComputeInstanceGroupMapOutput() ComputeInstanceGroupMapOutput {
	return o
}

func (o ComputeInstanceGroupMapOutput) ToComputeInstanceGroupMapOutputWithContext(ctx context.Context) ComputeInstanceGroupMapOutput {
	return o
}

func (o ComputeInstanceGroupMapOutput) MapIndex(k pulumi.StringInput) ComputeInstanceGroupOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ComputeInstanceGroup {
		return vs[0].(map[string]*ComputeInstanceGroup)[vs[1].(string)]
	}).(ComputeInstanceGroupOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ComputeInstanceGroupInput)(nil)).Elem(), &ComputeInstanceGroup{})
	pulumi.RegisterInputType(reflect.TypeOf((*ComputeInstanceGroupArrayInput)(nil)).Elem(), ComputeInstanceGroupArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ComputeInstanceGroupMapInput)(nil)).Elem(), ComputeInstanceGroupMap{})
	pulumi.RegisterOutputType(ComputeInstanceGroupOutput{})
	pulumi.RegisterOutputType(ComputeInstanceGroupArrayOutput{})
	pulumi.RegisterOutputType(ComputeInstanceGroupMapOutput{})
}
