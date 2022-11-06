// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Manages a PostgreSQL user within the Yandex.Cloud. For more information, see
// [the official documentation](https://cloud.yandex.com/docs/managed-postgresql/).
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
//			fooVpcNetwork, err := yandex.NewVpcNetwork(ctx, "fooVpcNetwork", nil)
//			if err != nil {
//				return err
//			}
//			fooVpcSubnet, err := yandex.NewVpcSubnet(ctx, "fooVpcSubnet", &yandex.VpcSubnetArgs{
//				Zone:      pulumi.String("ru-central1-a"),
//				NetworkId: fooVpcNetwork.ID(),
//				V4CidrBlocks: pulumi.StringArray{
//					pulumi.String("10.5.0.0/24"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			fooMdbPostgresqlCluster, err := yandex.NewMdbPostgresqlCluster(ctx, "fooMdbPostgresqlCluster", &yandex.MdbPostgresqlClusterArgs{
//				Environment: pulumi.String("PRESTABLE"),
//				NetworkId:   fooVpcNetwork.ID(),
//				Config: &MdbPostgresqlClusterConfigArgs{
//					Version: pulumi.String("14"),
//					Resources: &MdbPostgresqlClusterConfigResourcesArgs{
//						ResourcePresetId: pulumi.String("s2.micro"),
//						DiskTypeId:       pulumi.String("network-ssd"),
//						DiskSize:         pulumi.Int(16),
//					},
//				},
//				Hosts: MdbPostgresqlClusterHostArray{
//					&MdbPostgresqlClusterHostArgs{
//						Zone:     pulumi.String("ru-central1-a"),
//						SubnetId: fooVpcSubnet.ID(),
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			_, err = yandex.NewmdbPostgresqlUser(ctx, "foomdbPostgresqlUser", &yandex.mdbPostgresqlUserArgs{
//				ClusterId: fooMdbPostgresqlCluster.ID(),
//				Password:  pulumi.String("password"),
//				ConnLimit: pulumi.Int(50),
//				Settings: pulumi.StringMap{
//					"default_transaction_isolation": pulumi.String("read committed"),
//					"log_min_duration_statement":    pulumi.String("5000"),
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
// # A PostgreSQL user can be imported using the following format
//
// ```sh
//
//	$ pulumi import yandex:index/mdbPostgresqlUser:mdbPostgresqlUser foo {{cluster_id}}:{{username}}
//
// ```
type MdbPostgresqlUser struct {
	pulumi.CustomResourceState

	ClusterId pulumi.StringOutput `pulumi:"clusterId"`
	// The maximum number of connections per user. (Default 50)
	ConnLimit pulumi.IntOutput `pulumi:"connLimit"`
	// List of the user's grants.
	Grants pulumi.StringArrayOutput `pulumi:"grants"`
	// User's ability to login.
	Login pulumi.BoolPtrOutput `pulumi:"login"`
	// The name of the user.
	Name pulumi.StringOutput `pulumi:"name"`
	// The password of the user.
	Password pulumi.StringOutput `pulumi:"password"`
	// Set of permissions granted to the user. The structure is documented below.
	Permissions MdbPostgresqlUserPermissionArrayOutput `pulumi:"permissions"`
	// Map of user settings. List of settings is documented below.
	Settings pulumi.StringMapOutput `pulumi:"settings"`
}

// NewMdbPostgresqlUser registers a new resource with the given unique name, arguments, and options.
func NewMdbPostgresqlUser(ctx *pulumi.Context,
	name string, args *MdbPostgresqlUserArgs, opts ...pulumi.ResourceOption) (*MdbPostgresqlUser, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClusterId == nil {
		return nil, errors.New("invalid value for required argument 'ClusterId'")
	}
	if args.Password == nil {
		return nil, errors.New("invalid value for required argument 'Password'")
	}
	if args.Password != nil {
		args.Password = pulumi.ToSecret(args.Password).(pulumi.StringOutput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"password",
	})
	opts = append(opts, secrets)
	opts = pkgResourceDefaultOpts(opts)
	var resource MdbPostgresqlUser
	err := ctx.RegisterResource("yandex:index/mdbPostgresqlUser:mdbPostgresqlUser", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMdbPostgresqlUser gets an existing MdbPostgresqlUser resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMdbPostgresqlUser(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MdbPostgresqlUserState, opts ...pulumi.ResourceOption) (*MdbPostgresqlUser, error) {
	var resource MdbPostgresqlUser
	err := ctx.ReadResource("yandex:index/mdbPostgresqlUser:mdbPostgresqlUser", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MdbPostgresqlUser resources.
type mdbPostgresqlUserState struct {
	ClusterId *string `pulumi:"clusterId"`
	// The maximum number of connections per user. (Default 50)
	ConnLimit *int `pulumi:"connLimit"`
	// List of the user's grants.
	Grants []string `pulumi:"grants"`
	// User's ability to login.
	Login *bool `pulumi:"login"`
	// The name of the user.
	Name *string `pulumi:"name"`
	// The password of the user.
	Password *string `pulumi:"password"`
	// Set of permissions granted to the user. The structure is documented below.
	Permissions []MdbPostgresqlUserPermission `pulumi:"permissions"`
	// Map of user settings. List of settings is documented below.
	Settings map[string]string `pulumi:"settings"`
}

type MdbPostgresqlUserState struct {
	ClusterId pulumi.StringPtrInput
	// The maximum number of connections per user. (Default 50)
	ConnLimit pulumi.IntPtrInput
	// List of the user's grants.
	Grants pulumi.StringArrayInput
	// User's ability to login.
	Login pulumi.BoolPtrInput
	// The name of the user.
	Name pulumi.StringPtrInput
	// The password of the user.
	Password pulumi.StringPtrInput
	// Set of permissions granted to the user. The structure is documented below.
	Permissions MdbPostgresqlUserPermissionArrayInput
	// Map of user settings. List of settings is documented below.
	Settings pulumi.StringMapInput
}

func (MdbPostgresqlUserState) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbPostgresqlUserState)(nil)).Elem()
}

type mdbPostgresqlUserArgs struct {
	ClusterId string `pulumi:"clusterId"`
	// The maximum number of connections per user. (Default 50)
	ConnLimit *int `pulumi:"connLimit"`
	// List of the user's grants.
	Grants []string `pulumi:"grants"`
	// User's ability to login.
	Login *bool `pulumi:"login"`
	// The name of the user.
	Name *string `pulumi:"name"`
	// The password of the user.
	Password string `pulumi:"password"`
	// Set of permissions granted to the user. The structure is documented below.
	Permissions []MdbPostgresqlUserPermission `pulumi:"permissions"`
	// Map of user settings. List of settings is documented below.
	Settings map[string]string `pulumi:"settings"`
}

// The set of arguments for constructing a MdbPostgresqlUser resource.
type MdbPostgresqlUserArgs struct {
	ClusterId pulumi.StringInput
	// The maximum number of connections per user. (Default 50)
	ConnLimit pulumi.IntPtrInput
	// List of the user's grants.
	Grants pulumi.StringArrayInput
	// User's ability to login.
	Login pulumi.BoolPtrInput
	// The name of the user.
	Name pulumi.StringPtrInput
	// The password of the user.
	Password pulumi.StringInput
	// Set of permissions granted to the user. The structure is documented below.
	Permissions MdbPostgresqlUserPermissionArrayInput
	// Map of user settings. List of settings is documented below.
	Settings pulumi.StringMapInput
}

func (MdbPostgresqlUserArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbPostgresqlUserArgs)(nil)).Elem()
}

type MdbPostgresqlUserInput interface {
	pulumi.Input

	ToMdbPostgresqlUserOutput() MdbPostgresqlUserOutput
	ToMdbPostgresqlUserOutputWithContext(ctx context.Context) MdbPostgresqlUserOutput
}

func (*MdbPostgresqlUser) ElementType() reflect.Type {
	return reflect.TypeOf((**MdbPostgresqlUser)(nil)).Elem()
}

func (i *MdbPostgresqlUser) ToMdbPostgresqlUserOutput() MdbPostgresqlUserOutput {
	return i.ToMdbPostgresqlUserOutputWithContext(context.Background())
}

func (i *MdbPostgresqlUser) ToMdbPostgresqlUserOutputWithContext(ctx context.Context) MdbPostgresqlUserOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbPostgresqlUserOutput)
}

// MdbPostgresqlUserArrayInput is an input type that accepts MdbPostgresqlUserArray and MdbPostgresqlUserArrayOutput values.
// You can construct a concrete instance of `MdbPostgresqlUserArrayInput` via:
//
//	MdbPostgresqlUserArray{ MdbPostgresqlUserArgs{...} }
type MdbPostgresqlUserArrayInput interface {
	pulumi.Input

	ToMdbPostgresqlUserArrayOutput() MdbPostgresqlUserArrayOutput
	ToMdbPostgresqlUserArrayOutputWithContext(context.Context) MdbPostgresqlUserArrayOutput
}

type MdbPostgresqlUserArray []MdbPostgresqlUserInput

func (MdbPostgresqlUserArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MdbPostgresqlUser)(nil)).Elem()
}

func (i MdbPostgresqlUserArray) ToMdbPostgresqlUserArrayOutput() MdbPostgresqlUserArrayOutput {
	return i.ToMdbPostgresqlUserArrayOutputWithContext(context.Background())
}

func (i MdbPostgresqlUserArray) ToMdbPostgresqlUserArrayOutputWithContext(ctx context.Context) MdbPostgresqlUserArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbPostgresqlUserArrayOutput)
}

// MdbPostgresqlUserMapInput is an input type that accepts MdbPostgresqlUserMap and MdbPostgresqlUserMapOutput values.
// You can construct a concrete instance of `MdbPostgresqlUserMapInput` via:
//
//	MdbPostgresqlUserMap{ "key": MdbPostgresqlUserArgs{...} }
type MdbPostgresqlUserMapInput interface {
	pulumi.Input

	ToMdbPostgresqlUserMapOutput() MdbPostgresqlUserMapOutput
	ToMdbPostgresqlUserMapOutputWithContext(context.Context) MdbPostgresqlUserMapOutput
}

type MdbPostgresqlUserMap map[string]MdbPostgresqlUserInput

func (MdbPostgresqlUserMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MdbPostgresqlUser)(nil)).Elem()
}

func (i MdbPostgresqlUserMap) ToMdbPostgresqlUserMapOutput() MdbPostgresqlUserMapOutput {
	return i.ToMdbPostgresqlUserMapOutputWithContext(context.Background())
}

func (i MdbPostgresqlUserMap) ToMdbPostgresqlUserMapOutputWithContext(ctx context.Context) MdbPostgresqlUserMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbPostgresqlUserMapOutput)
}

type MdbPostgresqlUserOutput struct{ *pulumi.OutputState }

func (MdbPostgresqlUserOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MdbPostgresqlUser)(nil)).Elem()
}

func (o MdbPostgresqlUserOutput) ToMdbPostgresqlUserOutput() MdbPostgresqlUserOutput {
	return o
}

func (o MdbPostgresqlUserOutput) ToMdbPostgresqlUserOutputWithContext(ctx context.Context) MdbPostgresqlUserOutput {
	return o
}

func (o MdbPostgresqlUserOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbPostgresqlUser) pulumi.StringOutput { return v.ClusterId }).(pulumi.StringOutput)
}

// The maximum number of connections per user. (Default 50)
func (o MdbPostgresqlUserOutput) ConnLimit() pulumi.IntOutput {
	return o.ApplyT(func(v *MdbPostgresqlUser) pulumi.IntOutput { return v.ConnLimit }).(pulumi.IntOutput)
}

// List of the user's grants.
func (o MdbPostgresqlUserOutput) Grants() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *MdbPostgresqlUser) pulumi.StringArrayOutput { return v.Grants }).(pulumi.StringArrayOutput)
}

// User's ability to login.
func (o MdbPostgresqlUserOutput) Login() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *MdbPostgresqlUser) pulumi.BoolPtrOutput { return v.Login }).(pulumi.BoolPtrOutput)
}

// The name of the user.
func (o MdbPostgresqlUserOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbPostgresqlUser) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The password of the user.
func (o MdbPostgresqlUserOutput) Password() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbPostgresqlUser) pulumi.StringOutput { return v.Password }).(pulumi.StringOutput)
}

// Set of permissions granted to the user. The structure is documented below.
func (o MdbPostgresqlUserOutput) Permissions() MdbPostgresqlUserPermissionArrayOutput {
	return o.ApplyT(func(v *MdbPostgresqlUser) MdbPostgresqlUserPermissionArrayOutput { return v.Permissions }).(MdbPostgresqlUserPermissionArrayOutput)
}

// Map of user settings. List of settings is documented below.
func (o MdbPostgresqlUserOutput) Settings() pulumi.StringMapOutput {
	return o.ApplyT(func(v *MdbPostgresqlUser) pulumi.StringMapOutput { return v.Settings }).(pulumi.StringMapOutput)
}

type MdbPostgresqlUserArrayOutput struct{ *pulumi.OutputState }

func (MdbPostgresqlUserArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MdbPostgresqlUser)(nil)).Elem()
}

func (o MdbPostgresqlUserArrayOutput) ToMdbPostgresqlUserArrayOutput() MdbPostgresqlUserArrayOutput {
	return o
}

func (o MdbPostgresqlUserArrayOutput) ToMdbPostgresqlUserArrayOutputWithContext(ctx context.Context) MdbPostgresqlUserArrayOutput {
	return o
}

func (o MdbPostgresqlUserArrayOutput) Index(i pulumi.IntInput) MdbPostgresqlUserOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MdbPostgresqlUser {
		return vs[0].([]*MdbPostgresqlUser)[vs[1].(int)]
	}).(MdbPostgresqlUserOutput)
}

type MdbPostgresqlUserMapOutput struct{ *pulumi.OutputState }

func (MdbPostgresqlUserMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MdbPostgresqlUser)(nil)).Elem()
}

func (o MdbPostgresqlUserMapOutput) ToMdbPostgresqlUserMapOutput() MdbPostgresqlUserMapOutput {
	return o
}

func (o MdbPostgresqlUserMapOutput) ToMdbPostgresqlUserMapOutputWithContext(ctx context.Context) MdbPostgresqlUserMapOutput {
	return o
}

func (o MdbPostgresqlUserMapOutput) MapIndex(k pulumi.StringInput) MdbPostgresqlUserOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MdbPostgresqlUser {
		return vs[0].(map[string]*MdbPostgresqlUser)[vs[1].(string)]
	}).(MdbPostgresqlUserOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MdbPostgresqlUserInput)(nil)).Elem(), &MdbPostgresqlUser{})
	pulumi.RegisterInputType(reflect.TypeOf((*MdbPostgresqlUserArrayInput)(nil)).Elem(), MdbPostgresqlUserArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MdbPostgresqlUserMapInput)(nil)).Elem(), MdbPostgresqlUserMap{})
	pulumi.RegisterOutputType(MdbPostgresqlUserOutput{})
	pulumi.RegisterOutputType(MdbPostgresqlUserArrayOutput{})
	pulumi.RegisterOutputType(MdbPostgresqlUserMapOutput{})
}
