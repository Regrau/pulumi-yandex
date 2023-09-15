// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Allows members management of a single Yandex.Cloud Organization Manager Group. For more information, see [the official documentation](https://cloud.yandex.com/en-ru/docs/organization/manage-groups#add-member).
//
// > **Note:** Multiple `yandexOrganizationmanagerGroupIamBinding` resources with the same group id will produce inconsistent behavior!
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
//			_, err := yandex.NeworganizationmanagerGroupMembership(ctx, "group", &yandex.organizationmanagerGroupMembershipArgs{
//				GroupId: pulumi.String("sdf4*********3fr"),
//				Members: pulumi.StringArray{
//					pulumi.String("xdf********123"),
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
type OrganizationmanagerGroupMembership struct {
	pulumi.CustomResourceState

	// The Group to add/remove members to/from.
	GroupId pulumi.StringOutput `pulumi:"groupId"`
	// A set of members of the Group. Each member is represented by an id.
	Members pulumi.StringArrayOutput `pulumi:"members"`
}

// NewOrganizationmanagerGroupMembership registers a new resource with the given unique name, arguments, and options.
func NewOrganizationmanagerGroupMembership(ctx *pulumi.Context,
	name string, args *OrganizationmanagerGroupMembershipArgs, opts ...pulumi.ResourceOption) (*OrganizationmanagerGroupMembership, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.GroupId == nil {
		return nil, errors.New("invalid value for required argument 'GroupId'")
	}
	if args.Members == nil {
		return nil, errors.New("invalid value for required argument 'Members'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource OrganizationmanagerGroupMembership
	err := ctx.RegisterResource("yandex:index/organizationmanagerGroupMembership:organizationmanagerGroupMembership", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOrganizationmanagerGroupMembership gets an existing OrganizationmanagerGroupMembership resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOrganizationmanagerGroupMembership(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OrganizationmanagerGroupMembershipState, opts ...pulumi.ResourceOption) (*OrganizationmanagerGroupMembership, error) {
	var resource OrganizationmanagerGroupMembership
	err := ctx.ReadResource("yandex:index/organizationmanagerGroupMembership:organizationmanagerGroupMembership", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OrganizationmanagerGroupMembership resources.
type organizationmanagerGroupMembershipState struct {
	// The Group to add/remove members to/from.
	GroupId *string `pulumi:"groupId"`
	// A set of members of the Group. Each member is represented by an id.
	Members []string `pulumi:"members"`
}

type OrganizationmanagerGroupMembershipState struct {
	// The Group to add/remove members to/from.
	GroupId pulumi.StringPtrInput
	// A set of members of the Group. Each member is represented by an id.
	Members pulumi.StringArrayInput
}

func (OrganizationmanagerGroupMembershipState) ElementType() reflect.Type {
	return reflect.TypeOf((*organizationmanagerGroupMembershipState)(nil)).Elem()
}

type organizationmanagerGroupMembershipArgs struct {
	// The Group to add/remove members to/from.
	GroupId string `pulumi:"groupId"`
	// A set of members of the Group. Each member is represented by an id.
	Members []string `pulumi:"members"`
}

// The set of arguments for constructing a OrganizationmanagerGroupMembership resource.
type OrganizationmanagerGroupMembershipArgs struct {
	// The Group to add/remove members to/from.
	GroupId pulumi.StringInput
	// A set of members of the Group. Each member is represented by an id.
	Members pulumi.StringArrayInput
}

func (OrganizationmanagerGroupMembershipArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*organizationmanagerGroupMembershipArgs)(nil)).Elem()
}

type OrganizationmanagerGroupMembershipInput interface {
	pulumi.Input

	ToOrganizationmanagerGroupMembershipOutput() OrganizationmanagerGroupMembershipOutput
	ToOrganizationmanagerGroupMembershipOutputWithContext(ctx context.Context) OrganizationmanagerGroupMembershipOutput
}

func (*OrganizationmanagerGroupMembership) ElementType() reflect.Type {
	return reflect.TypeOf((**OrganizationmanagerGroupMembership)(nil)).Elem()
}

func (i *OrganizationmanagerGroupMembership) ToOrganizationmanagerGroupMembershipOutput() OrganizationmanagerGroupMembershipOutput {
	return i.ToOrganizationmanagerGroupMembershipOutputWithContext(context.Background())
}

func (i *OrganizationmanagerGroupMembership) ToOrganizationmanagerGroupMembershipOutputWithContext(ctx context.Context) OrganizationmanagerGroupMembershipOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationmanagerGroupMembershipOutput)
}

// OrganizationmanagerGroupMembershipArrayInput is an input type that accepts OrganizationmanagerGroupMembershipArray and OrganizationmanagerGroupMembershipArrayOutput values.
// You can construct a concrete instance of `OrganizationmanagerGroupMembershipArrayInput` via:
//
//	OrganizationmanagerGroupMembershipArray{ OrganizationmanagerGroupMembershipArgs{...} }
type OrganizationmanagerGroupMembershipArrayInput interface {
	pulumi.Input

	ToOrganizationmanagerGroupMembershipArrayOutput() OrganizationmanagerGroupMembershipArrayOutput
	ToOrganizationmanagerGroupMembershipArrayOutputWithContext(context.Context) OrganizationmanagerGroupMembershipArrayOutput
}

type OrganizationmanagerGroupMembershipArray []OrganizationmanagerGroupMembershipInput

func (OrganizationmanagerGroupMembershipArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OrganizationmanagerGroupMembership)(nil)).Elem()
}

func (i OrganizationmanagerGroupMembershipArray) ToOrganizationmanagerGroupMembershipArrayOutput() OrganizationmanagerGroupMembershipArrayOutput {
	return i.ToOrganizationmanagerGroupMembershipArrayOutputWithContext(context.Background())
}

func (i OrganizationmanagerGroupMembershipArray) ToOrganizationmanagerGroupMembershipArrayOutputWithContext(ctx context.Context) OrganizationmanagerGroupMembershipArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationmanagerGroupMembershipArrayOutput)
}

// OrganizationmanagerGroupMembershipMapInput is an input type that accepts OrganizationmanagerGroupMembershipMap and OrganizationmanagerGroupMembershipMapOutput values.
// You can construct a concrete instance of `OrganizationmanagerGroupMembershipMapInput` via:
//
//	OrganizationmanagerGroupMembershipMap{ "key": OrganizationmanagerGroupMembershipArgs{...} }
type OrganizationmanagerGroupMembershipMapInput interface {
	pulumi.Input

	ToOrganizationmanagerGroupMembershipMapOutput() OrganizationmanagerGroupMembershipMapOutput
	ToOrganizationmanagerGroupMembershipMapOutputWithContext(context.Context) OrganizationmanagerGroupMembershipMapOutput
}

type OrganizationmanagerGroupMembershipMap map[string]OrganizationmanagerGroupMembershipInput

func (OrganizationmanagerGroupMembershipMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OrganizationmanagerGroupMembership)(nil)).Elem()
}

func (i OrganizationmanagerGroupMembershipMap) ToOrganizationmanagerGroupMembershipMapOutput() OrganizationmanagerGroupMembershipMapOutput {
	return i.ToOrganizationmanagerGroupMembershipMapOutputWithContext(context.Background())
}

func (i OrganizationmanagerGroupMembershipMap) ToOrganizationmanagerGroupMembershipMapOutputWithContext(ctx context.Context) OrganizationmanagerGroupMembershipMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationmanagerGroupMembershipMapOutput)
}

type OrganizationmanagerGroupMembershipOutput struct{ *pulumi.OutputState }

func (OrganizationmanagerGroupMembershipOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OrganizationmanagerGroupMembership)(nil)).Elem()
}

func (o OrganizationmanagerGroupMembershipOutput) ToOrganizationmanagerGroupMembershipOutput() OrganizationmanagerGroupMembershipOutput {
	return o
}

func (o OrganizationmanagerGroupMembershipOutput) ToOrganizationmanagerGroupMembershipOutputWithContext(ctx context.Context) OrganizationmanagerGroupMembershipOutput {
	return o
}

// The Group to add/remove members to/from.
func (o OrganizationmanagerGroupMembershipOutput) GroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerGroupMembership) pulumi.StringOutput { return v.GroupId }).(pulumi.StringOutput)
}

// A set of members of the Group. Each member is represented by an id.
func (o OrganizationmanagerGroupMembershipOutput) Members() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *OrganizationmanagerGroupMembership) pulumi.StringArrayOutput { return v.Members }).(pulumi.StringArrayOutput)
}

type OrganizationmanagerGroupMembershipArrayOutput struct{ *pulumi.OutputState }

func (OrganizationmanagerGroupMembershipArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OrganizationmanagerGroupMembership)(nil)).Elem()
}

func (o OrganizationmanagerGroupMembershipArrayOutput) ToOrganizationmanagerGroupMembershipArrayOutput() OrganizationmanagerGroupMembershipArrayOutput {
	return o
}

func (o OrganizationmanagerGroupMembershipArrayOutput) ToOrganizationmanagerGroupMembershipArrayOutputWithContext(ctx context.Context) OrganizationmanagerGroupMembershipArrayOutput {
	return o
}

func (o OrganizationmanagerGroupMembershipArrayOutput) Index(i pulumi.IntInput) OrganizationmanagerGroupMembershipOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *OrganizationmanagerGroupMembership {
		return vs[0].([]*OrganizationmanagerGroupMembership)[vs[1].(int)]
	}).(OrganizationmanagerGroupMembershipOutput)
}

type OrganizationmanagerGroupMembershipMapOutput struct{ *pulumi.OutputState }

func (OrganizationmanagerGroupMembershipMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OrganizationmanagerGroupMembership)(nil)).Elem()
}

func (o OrganizationmanagerGroupMembershipMapOutput) ToOrganizationmanagerGroupMembershipMapOutput() OrganizationmanagerGroupMembershipMapOutput {
	return o
}

func (o OrganizationmanagerGroupMembershipMapOutput) ToOrganizationmanagerGroupMembershipMapOutputWithContext(ctx context.Context) OrganizationmanagerGroupMembershipMapOutput {
	return o
}

func (o OrganizationmanagerGroupMembershipMapOutput) MapIndex(k pulumi.StringInput) OrganizationmanagerGroupMembershipOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *OrganizationmanagerGroupMembership {
		return vs[0].(map[string]*OrganizationmanagerGroupMembership)[vs[1].(string)]
	}).(OrganizationmanagerGroupMembershipOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OrganizationmanagerGroupMembershipInput)(nil)).Elem(), &OrganizationmanagerGroupMembership{})
	pulumi.RegisterInputType(reflect.TypeOf((*OrganizationmanagerGroupMembershipArrayInput)(nil)).Elem(), OrganizationmanagerGroupMembershipArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OrganizationmanagerGroupMembershipMapInput)(nil)).Elem(), OrganizationmanagerGroupMembershipMap{})
	pulumi.RegisterOutputType(OrganizationmanagerGroupMembershipOutput{})
	pulumi.RegisterOutputType(OrganizationmanagerGroupMembershipArrayOutput{})
	pulumi.RegisterOutputType(OrganizationmanagerGroupMembershipMapOutput{})
}
