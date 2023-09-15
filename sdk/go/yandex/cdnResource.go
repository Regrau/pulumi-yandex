// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Allows management of [Yandex.Cloud CDN Resource](https://cloud.yandex.ru/docs/cdn/concepts/resource).
//
// > **_NOTE:_**  CDN provider must be activated prior usage of CDN resources, either via UI console or via yc cli command: ```yc cdn provider activate --folder-id <folder-id> --type gcore```
//
// ## Import
//
// # A origin group can be imported using any of these accepted formats
//
// ```sh
//
//	$ pulumi import yandex:index/cdnResource:CdnResource default origin_group_id
//
// ```
type CdnResource struct {
	pulumi.CustomResourceState

	// Flag to create Resource either in active or disabled state. True - the content from CDN is available to clients.
	Active pulumi.BoolPtrOutput `pulumi:"active"`
	// CDN endpoint CNAME, must be unique among resources.
	Cname pulumi.StringOutput `pulumi:"cname"`
	// Creation timestamp of the IoT Core Device
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	FolderId  pulumi.StringOutput `pulumi:"folderId"`
	// CDN Resource settings and options to tune CDN edge behavior.
	Options         CdnResourceOptionsOutput `pulumi:"options"`
	OriginGroupId   pulumi.IntPtrOutput      `pulumi:"originGroupId"`
	OriginGroupName pulumi.StringPtrOutput   `pulumi:"originGroupName"`
	OriginProtocol  pulumi.StringPtrOutput   `pulumi:"originProtocol"`
	// list of secondary hostname strings.
	SecondaryHostnames pulumi.StringArrayOutput `pulumi:"secondaryHostnames"`
	// SSL certificate of CDN resource.
	// ---
	SslCertificate CdnResourceSslCertificateOutput `pulumi:"sslCertificate"`
	UpdatedAt      pulumi.StringOutput             `pulumi:"updatedAt"`
}

// NewCdnResource registers a new resource with the given unique name, arguments, and options.
func NewCdnResource(ctx *pulumi.Context,
	name string, args *CdnResourceArgs, opts ...pulumi.ResourceOption) (*CdnResource, error) {
	if args == nil {
		args = &CdnResourceArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource CdnResource
	err := ctx.RegisterResource("yandex:index/cdnResource:CdnResource", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCdnResource gets an existing CdnResource resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCdnResource(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CdnResourceState, opts ...pulumi.ResourceOption) (*CdnResource, error) {
	var resource CdnResource
	err := ctx.ReadResource("yandex:index/cdnResource:CdnResource", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CdnResource resources.
type cdnResourceState struct {
	// Flag to create Resource either in active or disabled state. True - the content from CDN is available to clients.
	Active *bool `pulumi:"active"`
	// CDN endpoint CNAME, must be unique among resources.
	Cname *string `pulumi:"cname"`
	// Creation timestamp of the IoT Core Device
	CreatedAt *string `pulumi:"createdAt"`
	FolderId  *string `pulumi:"folderId"`
	// CDN Resource settings and options to tune CDN edge behavior.
	Options         *CdnResourceOptions `pulumi:"options"`
	OriginGroupId   *int                `pulumi:"originGroupId"`
	OriginGroupName *string             `pulumi:"originGroupName"`
	OriginProtocol  *string             `pulumi:"originProtocol"`
	// list of secondary hostname strings.
	SecondaryHostnames []string `pulumi:"secondaryHostnames"`
	// SSL certificate of CDN resource.
	// ---
	SslCertificate *CdnResourceSslCertificate `pulumi:"sslCertificate"`
	UpdatedAt      *string                    `pulumi:"updatedAt"`
}

type CdnResourceState struct {
	// Flag to create Resource either in active or disabled state. True - the content from CDN is available to clients.
	Active pulumi.BoolPtrInput
	// CDN endpoint CNAME, must be unique among resources.
	Cname pulumi.StringPtrInput
	// Creation timestamp of the IoT Core Device
	CreatedAt pulumi.StringPtrInput
	FolderId  pulumi.StringPtrInput
	// CDN Resource settings and options to tune CDN edge behavior.
	Options         CdnResourceOptionsPtrInput
	OriginGroupId   pulumi.IntPtrInput
	OriginGroupName pulumi.StringPtrInput
	OriginProtocol  pulumi.StringPtrInput
	// list of secondary hostname strings.
	SecondaryHostnames pulumi.StringArrayInput
	// SSL certificate of CDN resource.
	// ---
	SslCertificate CdnResourceSslCertificatePtrInput
	UpdatedAt      pulumi.StringPtrInput
}

func (CdnResourceState) ElementType() reflect.Type {
	return reflect.TypeOf((*cdnResourceState)(nil)).Elem()
}

type cdnResourceArgs struct {
	// Flag to create Resource either in active or disabled state. True - the content from CDN is available to clients.
	Active *bool `pulumi:"active"`
	// CDN endpoint CNAME, must be unique among resources.
	Cname    *string `pulumi:"cname"`
	FolderId *string `pulumi:"folderId"`
	// CDN Resource settings and options to tune CDN edge behavior.
	Options         *CdnResourceOptions `pulumi:"options"`
	OriginGroupId   *int                `pulumi:"originGroupId"`
	OriginGroupName *string             `pulumi:"originGroupName"`
	OriginProtocol  *string             `pulumi:"originProtocol"`
	// list of secondary hostname strings.
	SecondaryHostnames []string `pulumi:"secondaryHostnames"`
	// SSL certificate of CDN resource.
	// ---
	SslCertificate *CdnResourceSslCertificate `pulumi:"sslCertificate"`
	UpdatedAt      *string                    `pulumi:"updatedAt"`
}

// The set of arguments for constructing a CdnResource resource.
type CdnResourceArgs struct {
	// Flag to create Resource either in active or disabled state. True - the content from CDN is available to clients.
	Active pulumi.BoolPtrInput
	// CDN endpoint CNAME, must be unique among resources.
	Cname    pulumi.StringPtrInput
	FolderId pulumi.StringPtrInput
	// CDN Resource settings and options to tune CDN edge behavior.
	Options         CdnResourceOptionsPtrInput
	OriginGroupId   pulumi.IntPtrInput
	OriginGroupName pulumi.StringPtrInput
	OriginProtocol  pulumi.StringPtrInput
	// list of secondary hostname strings.
	SecondaryHostnames pulumi.StringArrayInput
	// SSL certificate of CDN resource.
	// ---
	SslCertificate CdnResourceSslCertificatePtrInput
	UpdatedAt      pulumi.StringPtrInput
}

func (CdnResourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*cdnResourceArgs)(nil)).Elem()
}

type CdnResourceInput interface {
	pulumi.Input

	ToCdnResourceOutput() CdnResourceOutput
	ToCdnResourceOutputWithContext(ctx context.Context) CdnResourceOutput
}

func (*CdnResource) ElementType() reflect.Type {
	return reflect.TypeOf((**CdnResource)(nil)).Elem()
}

func (i *CdnResource) ToCdnResourceOutput() CdnResourceOutput {
	return i.ToCdnResourceOutputWithContext(context.Background())
}

func (i *CdnResource) ToCdnResourceOutputWithContext(ctx context.Context) CdnResourceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CdnResourceOutput)
}

// CdnResourceArrayInput is an input type that accepts CdnResourceArray and CdnResourceArrayOutput values.
// You can construct a concrete instance of `CdnResourceArrayInput` via:
//
//	CdnResourceArray{ CdnResourceArgs{...} }
type CdnResourceArrayInput interface {
	pulumi.Input

	ToCdnResourceArrayOutput() CdnResourceArrayOutput
	ToCdnResourceArrayOutputWithContext(context.Context) CdnResourceArrayOutput
}

type CdnResourceArray []CdnResourceInput

func (CdnResourceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CdnResource)(nil)).Elem()
}

func (i CdnResourceArray) ToCdnResourceArrayOutput() CdnResourceArrayOutput {
	return i.ToCdnResourceArrayOutputWithContext(context.Background())
}

func (i CdnResourceArray) ToCdnResourceArrayOutputWithContext(ctx context.Context) CdnResourceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CdnResourceArrayOutput)
}

// CdnResourceMapInput is an input type that accepts CdnResourceMap and CdnResourceMapOutput values.
// You can construct a concrete instance of `CdnResourceMapInput` via:
//
//	CdnResourceMap{ "key": CdnResourceArgs{...} }
type CdnResourceMapInput interface {
	pulumi.Input

	ToCdnResourceMapOutput() CdnResourceMapOutput
	ToCdnResourceMapOutputWithContext(context.Context) CdnResourceMapOutput
}

type CdnResourceMap map[string]CdnResourceInput

func (CdnResourceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CdnResource)(nil)).Elem()
}

func (i CdnResourceMap) ToCdnResourceMapOutput() CdnResourceMapOutput {
	return i.ToCdnResourceMapOutputWithContext(context.Background())
}

func (i CdnResourceMap) ToCdnResourceMapOutputWithContext(ctx context.Context) CdnResourceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CdnResourceMapOutput)
}

type CdnResourceOutput struct{ *pulumi.OutputState }

func (CdnResourceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CdnResource)(nil)).Elem()
}

func (o CdnResourceOutput) ToCdnResourceOutput() CdnResourceOutput {
	return o
}

func (o CdnResourceOutput) ToCdnResourceOutputWithContext(ctx context.Context) CdnResourceOutput {
	return o
}

// Flag to create Resource either in active or disabled state. True - the content from CDN is available to clients.
func (o CdnResourceOutput) Active() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *CdnResource) pulumi.BoolPtrOutput { return v.Active }).(pulumi.BoolPtrOutput)
}

// CDN endpoint CNAME, must be unique among resources.
func (o CdnResourceOutput) Cname() pulumi.StringOutput {
	return o.ApplyT(func(v *CdnResource) pulumi.StringOutput { return v.Cname }).(pulumi.StringOutput)
}

// Creation timestamp of the IoT Core Device
func (o CdnResourceOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *CdnResource) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o CdnResourceOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *CdnResource) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

// CDN Resource settings and options to tune CDN edge behavior.
func (o CdnResourceOutput) Options() CdnResourceOptionsOutput {
	return o.ApplyT(func(v *CdnResource) CdnResourceOptionsOutput { return v.Options }).(CdnResourceOptionsOutput)
}

func (o CdnResourceOutput) OriginGroupId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *CdnResource) pulumi.IntPtrOutput { return v.OriginGroupId }).(pulumi.IntPtrOutput)
}

func (o CdnResourceOutput) OriginGroupName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CdnResource) pulumi.StringPtrOutput { return v.OriginGroupName }).(pulumi.StringPtrOutput)
}

func (o CdnResourceOutput) OriginProtocol() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CdnResource) pulumi.StringPtrOutput { return v.OriginProtocol }).(pulumi.StringPtrOutput)
}

// list of secondary hostname strings.
func (o CdnResourceOutput) SecondaryHostnames() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *CdnResource) pulumi.StringArrayOutput { return v.SecondaryHostnames }).(pulumi.StringArrayOutput)
}

// SSL certificate of CDN resource.
// ---
func (o CdnResourceOutput) SslCertificate() CdnResourceSslCertificateOutput {
	return o.ApplyT(func(v *CdnResource) CdnResourceSslCertificateOutput { return v.SslCertificate }).(CdnResourceSslCertificateOutput)
}

func (o CdnResourceOutput) UpdatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *CdnResource) pulumi.StringOutput { return v.UpdatedAt }).(pulumi.StringOutput)
}

type CdnResourceArrayOutput struct{ *pulumi.OutputState }

func (CdnResourceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CdnResource)(nil)).Elem()
}

func (o CdnResourceArrayOutput) ToCdnResourceArrayOutput() CdnResourceArrayOutput {
	return o
}

func (o CdnResourceArrayOutput) ToCdnResourceArrayOutputWithContext(ctx context.Context) CdnResourceArrayOutput {
	return o
}

func (o CdnResourceArrayOutput) Index(i pulumi.IntInput) CdnResourceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CdnResource {
		return vs[0].([]*CdnResource)[vs[1].(int)]
	}).(CdnResourceOutput)
}

type CdnResourceMapOutput struct{ *pulumi.OutputState }

func (CdnResourceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CdnResource)(nil)).Elem()
}

func (o CdnResourceMapOutput) ToCdnResourceMapOutput() CdnResourceMapOutput {
	return o
}

func (o CdnResourceMapOutput) ToCdnResourceMapOutputWithContext(ctx context.Context) CdnResourceMapOutput {
	return o
}

func (o CdnResourceMapOutput) MapIndex(k pulumi.StringInput) CdnResourceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CdnResource {
		return vs[0].(map[string]*CdnResource)[vs[1].(string)]
	}).(CdnResourceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CdnResourceInput)(nil)).Elem(), &CdnResource{})
	pulumi.RegisterInputType(reflect.TypeOf((*CdnResourceArrayInput)(nil)).Elem(), CdnResourceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CdnResourceMapInput)(nil)).Elem(), CdnResourceMap{})
	pulumi.RegisterOutputType(CdnResourceOutput{})
	pulumi.RegisterOutputType(CdnResourceArrayOutput{})
	pulumi.RegisterOutputType(CdnResourceMapOutput{})
}
