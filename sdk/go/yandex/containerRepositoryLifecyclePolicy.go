// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a new container repository lifecycle policy. For more information, see
// [the official documentation](https://cloud.yandex.com/en-ru/docs/container-registry/concepts/lifecycle-policy)
//
// ## Example Usage
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
//			_, err := yandex.NewContainerRegistry(ctx, "myRegistry", nil)
//			if err != nil {
//				return err
//			}
//			myRepository, err := yandex.NewContainerRepository(ctx, "myRepository", nil)
//			if err != nil {
//				return err
//			}
//			_, err = yandex.NewcontainerRepositoryLifecyclePolicy(ctx, "myLifecyclePolicy", &yandex.containerRepositoryLifecyclePolicyArgs{
//				Status:       pulumi.String("active"),
//				RepositoryId: myRepository.ID(),
//				Rules: ContainerRepositoryLifecyclePolicyRuleArray{
//					&ContainerRepositoryLifecyclePolicyRuleArgs{
//						Description: pulumi.String("my description"),
//						Untagged:    pulumi.Bool(true),
//						TagRegexp:   pulumi.String(".*"),
//						RetainedTop: pulumi.Int(1),
//					},
//				},
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
// A lifecycle policy can be imported using the `id` of the resource, e.g. bash
//
// ```sh
//
//	$ pulumi import yandex:index/containerRepositoryLifecyclePolicy:containerRepositoryLifecyclePolicy my_lifecycle_policy lifecycle_policy_id
//
// ```
type ContainerRepositoryLifecyclePolicy struct {
	pulumi.CustomResourceState

	// Creation timestamp of the instance.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// Description of the lifecycle policy.
	Description pulumi.StringOutput `pulumi:"description"`
	// Lifecycle policy name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the repository that the resource belongs to.
	RepositoryId pulumi.StringOutput                               `pulumi:"repositoryId"`
	Rules        ContainerRepositoryLifecyclePolicyRuleArrayOutput `pulumi:"rules"`
	// The status of lifecycle policy. Must be `active` or `disabled`.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewContainerRepositoryLifecyclePolicy registers a new resource with the given unique name, arguments, and options.
func NewContainerRepositoryLifecyclePolicy(ctx *pulumi.Context,
	name string, args *ContainerRepositoryLifecyclePolicyArgs, opts ...pulumi.ResourceOption) (*ContainerRepositoryLifecyclePolicy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.RepositoryId == nil {
		return nil, errors.New("invalid value for required argument 'RepositoryId'")
	}
	if args.Status == nil {
		return nil, errors.New("invalid value for required argument 'Status'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource ContainerRepositoryLifecyclePolicy
	err := ctx.RegisterResource("yandex:index/containerRepositoryLifecyclePolicy:containerRepositoryLifecyclePolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetContainerRepositoryLifecyclePolicy gets an existing ContainerRepositoryLifecyclePolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetContainerRepositoryLifecyclePolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ContainerRepositoryLifecyclePolicyState, opts ...pulumi.ResourceOption) (*ContainerRepositoryLifecyclePolicy, error) {
	var resource ContainerRepositoryLifecyclePolicy
	err := ctx.ReadResource("yandex:index/containerRepositoryLifecyclePolicy:containerRepositoryLifecyclePolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ContainerRepositoryLifecyclePolicy resources.
type containerRepositoryLifecyclePolicyState struct {
	// Creation timestamp of the instance.
	CreatedAt *string `pulumi:"createdAt"`
	// Description of the lifecycle policy.
	Description *string `pulumi:"description"`
	// Lifecycle policy name.
	Name *string `pulumi:"name"`
	// The ID of the repository that the resource belongs to.
	RepositoryId *string                                  `pulumi:"repositoryId"`
	Rules        []ContainerRepositoryLifecyclePolicyRule `pulumi:"rules"`
	// The status of lifecycle policy. Must be `active` or `disabled`.
	Status *string `pulumi:"status"`
}

type ContainerRepositoryLifecyclePolicyState struct {
	// Creation timestamp of the instance.
	CreatedAt pulumi.StringPtrInput
	// Description of the lifecycle policy.
	Description pulumi.StringPtrInput
	// Lifecycle policy name.
	Name pulumi.StringPtrInput
	// The ID of the repository that the resource belongs to.
	RepositoryId pulumi.StringPtrInput
	Rules        ContainerRepositoryLifecyclePolicyRuleArrayInput
	// The status of lifecycle policy. Must be `active` or `disabled`.
	Status pulumi.StringPtrInput
}

func (ContainerRepositoryLifecyclePolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*containerRepositoryLifecyclePolicyState)(nil)).Elem()
}

type containerRepositoryLifecyclePolicyArgs struct {
	// Description of the lifecycle policy.
	Description *string `pulumi:"description"`
	// Lifecycle policy name.
	Name *string `pulumi:"name"`
	// The ID of the repository that the resource belongs to.
	RepositoryId string                                   `pulumi:"repositoryId"`
	Rules        []ContainerRepositoryLifecyclePolicyRule `pulumi:"rules"`
	// The status of lifecycle policy. Must be `active` or `disabled`.
	Status string `pulumi:"status"`
}

// The set of arguments for constructing a ContainerRepositoryLifecyclePolicy resource.
type ContainerRepositoryLifecyclePolicyArgs struct {
	// Description of the lifecycle policy.
	Description pulumi.StringPtrInput
	// Lifecycle policy name.
	Name pulumi.StringPtrInput
	// The ID of the repository that the resource belongs to.
	RepositoryId pulumi.StringInput
	Rules        ContainerRepositoryLifecyclePolicyRuleArrayInput
	// The status of lifecycle policy. Must be `active` or `disabled`.
	Status pulumi.StringInput
}

func (ContainerRepositoryLifecyclePolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*containerRepositoryLifecyclePolicyArgs)(nil)).Elem()
}

type ContainerRepositoryLifecyclePolicyInput interface {
	pulumi.Input

	ToContainerRepositoryLifecyclePolicyOutput() ContainerRepositoryLifecyclePolicyOutput
	ToContainerRepositoryLifecyclePolicyOutputWithContext(ctx context.Context) ContainerRepositoryLifecyclePolicyOutput
}

func (*ContainerRepositoryLifecyclePolicy) ElementType() reflect.Type {
	return reflect.TypeOf((**ContainerRepositoryLifecyclePolicy)(nil)).Elem()
}

func (i *ContainerRepositoryLifecyclePolicy) ToContainerRepositoryLifecyclePolicyOutput() ContainerRepositoryLifecyclePolicyOutput {
	return i.ToContainerRepositoryLifecyclePolicyOutputWithContext(context.Background())
}

func (i *ContainerRepositoryLifecyclePolicy) ToContainerRepositoryLifecyclePolicyOutputWithContext(ctx context.Context) ContainerRepositoryLifecyclePolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerRepositoryLifecyclePolicyOutput)
}

// ContainerRepositoryLifecyclePolicyArrayInput is an input type that accepts ContainerRepositoryLifecyclePolicyArray and ContainerRepositoryLifecyclePolicyArrayOutput values.
// You can construct a concrete instance of `ContainerRepositoryLifecyclePolicyArrayInput` via:
//
//	ContainerRepositoryLifecyclePolicyArray{ ContainerRepositoryLifecyclePolicyArgs{...} }
type ContainerRepositoryLifecyclePolicyArrayInput interface {
	pulumi.Input

	ToContainerRepositoryLifecyclePolicyArrayOutput() ContainerRepositoryLifecyclePolicyArrayOutput
	ToContainerRepositoryLifecyclePolicyArrayOutputWithContext(context.Context) ContainerRepositoryLifecyclePolicyArrayOutput
}

type ContainerRepositoryLifecyclePolicyArray []ContainerRepositoryLifecyclePolicyInput

func (ContainerRepositoryLifecyclePolicyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ContainerRepositoryLifecyclePolicy)(nil)).Elem()
}

func (i ContainerRepositoryLifecyclePolicyArray) ToContainerRepositoryLifecyclePolicyArrayOutput() ContainerRepositoryLifecyclePolicyArrayOutput {
	return i.ToContainerRepositoryLifecyclePolicyArrayOutputWithContext(context.Background())
}

func (i ContainerRepositoryLifecyclePolicyArray) ToContainerRepositoryLifecyclePolicyArrayOutputWithContext(ctx context.Context) ContainerRepositoryLifecyclePolicyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerRepositoryLifecyclePolicyArrayOutput)
}

// ContainerRepositoryLifecyclePolicyMapInput is an input type that accepts ContainerRepositoryLifecyclePolicyMap and ContainerRepositoryLifecyclePolicyMapOutput values.
// You can construct a concrete instance of `ContainerRepositoryLifecyclePolicyMapInput` via:
//
//	ContainerRepositoryLifecyclePolicyMap{ "key": ContainerRepositoryLifecyclePolicyArgs{...} }
type ContainerRepositoryLifecyclePolicyMapInput interface {
	pulumi.Input

	ToContainerRepositoryLifecyclePolicyMapOutput() ContainerRepositoryLifecyclePolicyMapOutput
	ToContainerRepositoryLifecyclePolicyMapOutputWithContext(context.Context) ContainerRepositoryLifecyclePolicyMapOutput
}

type ContainerRepositoryLifecyclePolicyMap map[string]ContainerRepositoryLifecyclePolicyInput

func (ContainerRepositoryLifecyclePolicyMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ContainerRepositoryLifecyclePolicy)(nil)).Elem()
}

func (i ContainerRepositoryLifecyclePolicyMap) ToContainerRepositoryLifecyclePolicyMapOutput() ContainerRepositoryLifecyclePolicyMapOutput {
	return i.ToContainerRepositoryLifecyclePolicyMapOutputWithContext(context.Background())
}

func (i ContainerRepositoryLifecyclePolicyMap) ToContainerRepositoryLifecyclePolicyMapOutputWithContext(ctx context.Context) ContainerRepositoryLifecyclePolicyMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerRepositoryLifecyclePolicyMapOutput)
}

type ContainerRepositoryLifecyclePolicyOutput struct{ *pulumi.OutputState }

func (ContainerRepositoryLifecyclePolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ContainerRepositoryLifecyclePolicy)(nil)).Elem()
}

func (o ContainerRepositoryLifecyclePolicyOutput) ToContainerRepositoryLifecyclePolicyOutput() ContainerRepositoryLifecyclePolicyOutput {
	return o
}

func (o ContainerRepositoryLifecyclePolicyOutput) ToContainerRepositoryLifecyclePolicyOutputWithContext(ctx context.Context) ContainerRepositoryLifecyclePolicyOutput {
	return o
}

// Creation timestamp of the instance.
func (o ContainerRepositoryLifecyclePolicyOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRepositoryLifecyclePolicy) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// Description of the lifecycle policy.
func (o ContainerRepositoryLifecyclePolicyOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRepositoryLifecyclePolicy) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

// Lifecycle policy name.
func (o ContainerRepositoryLifecyclePolicyOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRepositoryLifecyclePolicy) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The ID of the repository that the resource belongs to.
func (o ContainerRepositoryLifecyclePolicyOutput) RepositoryId() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRepositoryLifecyclePolicy) pulumi.StringOutput { return v.RepositoryId }).(pulumi.StringOutput)
}

func (o ContainerRepositoryLifecyclePolicyOutput) Rules() ContainerRepositoryLifecyclePolicyRuleArrayOutput {
	return o.ApplyT(func(v *ContainerRepositoryLifecyclePolicy) ContainerRepositoryLifecyclePolicyRuleArrayOutput {
		return v.Rules
	}).(ContainerRepositoryLifecyclePolicyRuleArrayOutput)
}

// The status of lifecycle policy. Must be `active` or `disabled`.
func (o ContainerRepositoryLifecyclePolicyOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRepositoryLifecyclePolicy) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type ContainerRepositoryLifecyclePolicyArrayOutput struct{ *pulumi.OutputState }

func (ContainerRepositoryLifecyclePolicyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ContainerRepositoryLifecyclePolicy)(nil)).Elem()
}

func (o ContainerRepositoryLifecyclePolicyArrayOutput) ToContainerRepositoryLifecyclePolicyArrayOutput() ContainerRepositoryLifecyclePolicyArrayOutput {
	return o
}

func (o ContainerRepositoryLifecyclePolicyArrayOutput) ToContainerRepositoryLifecyclePolicyArrayOutputWithContext(ctx context.Context) ContainerRepositoryLifecyclePolicyArrayOutput {
	return o
}

func (o ContainerRepositoryLifecyclePolicyArrayOutput) Index(i pulumi.IntInput) ContainerRepositoryLifecyclePolicyOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ContainerRepositoryLifecyclePolicy {
		return vs[0].([]*ContainerRepositoryLifecyclePolicy)[vs[1].(int)]
	}).(ContainerRepositoryLifecyclePolicyOutput)
}

type ContainerRepositoryLifecyclePolicyMapOutput struct{ *pulumi.OutputState }

func (ContainerRepositoryLifecyclePolicyMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ContainerRepositoryLifecyclePolicy)(nil)).Elem()
}

func (o ContainerRepositoryLifecyclePolicyMapOutput) ToContainerRepositoryLifecyclePolicyMapOutput() ContainerRepositoryLifecyclePolicyMapOutput {
	return o
}

func (o ContainerRepositoryLifecyclePolicyMapOutput) ToContainerRepositoryLifecyclePolicyMapOutputWithContext(ctx context.Context) ContainerRepositoryLifecyclePolicyMapOutput {
	return o
}

func (o ContainerRepositoryLifecyclePolicyMapOutput) MapIndex(k pulumi.StringInput) ContainerRepositoryLifecyclePolicyOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ContainerRepositoryLifecyclePolicy {
		return vs[0].(map[string]*ContainerRepositoryLifecyclePolicy)[vs[1].(string)]
	}).(ContainerRepositoryLifecyclePolicyOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerRepositoryLifecyclePolicyInput)(nil)).Elem(), &ContainerRepositoryLifecyclePolicy{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerRepositoryLifecyclePolicyArrayInput)(nil)).Elem(), ContainerRepositoryLifecyclePolicyArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerRepositoryLifecyclePolicyMapInput)(nil)).Elem(), ContainerRepositoryLifecyclePolicyMap{})
	pulumi.RegisterOutputType(ContainerRepositoryLifecyclePolicyOutput{})
	pulumi.RegisterOutputType(ContainerRepositoryLifecyclePolicyArrayOutput{})
	pulumi.RegisterOutputType(ContainerRepositoryLifecyclePolicyMapOutput{})
}
