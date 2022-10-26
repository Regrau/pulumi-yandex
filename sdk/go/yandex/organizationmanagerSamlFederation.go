// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type OrganizationmanagerSamlFederation struct {
	pulumi.CustomResourceState

	AutoCreateAccountOnLogin pulumi.BoolOutput                                       `pulumi:"autoCreateAccountOnLogin"`
	CaseInsensitiveNameIds   pulumi.BoolOutput                                       `pulumi:"caseInsensitiveNameIds"`
	CookieMaxAge             pulumi.StringOutput                                     `pulumi:"cookieMaxAge"`
	CreatedAt                pulumi.StringOutput                                     `pulumi:"createdAt"`
	Description              pulumi.StringPtrOutput                                  `pulumi:"description"`
	Issuer                   pulumi.StringOutput                                     `pulumi:"issuer"`
	Labels                   pulumi.StringMapOutput                                  `pulumi:"labels"`
	Name                     pulumi.StringOutput                                     `pulumi:"name"`
	OrganizationId           pulumi.StringOutput                                     `pulumi:"organizationId"`
	SecuritySettings         OrganizationmanagerSamlFederationSecuritySettingsOutput `pulumi:"securitySettings"`
	SsoBinding               pulumi.StringOutput                                     `pulumi:"ssoBinding"`
	SsoUrl                   pulumi.StringOutput                                     `pulumi:"ssoUrl"`
}

// NewOrganizationmanagerSamlFederation registers a new resource with the given unique name, arguments, and options.
func NewOrganizationmanagerSamlFederation(ctx *pulumi.Context,
	name string, args *OrganizationmanagerSamlFederationArgs, opts ...pulumi.ResourceOption) (*OrganizationmanagerSamlFederation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Issuer == nil {
		return nil, errors.New("invalid value for required argument 'Issuer'")
	}
	if args.OrganizationId == nil {
		return nil, errors.New("invalid value for required argument 'OrganizationId'")
	}
	if args.SsoBinding == nil {
		return nil, errors.New("invalid value for required argument 'SsoBinding'")
	}
	if args.SsoUrl == nil {
		return nil, errors.New("invalid value for required argument 'SsoUrl'")
	}
	var resource OrganizationmanagerSamlFederation
	err := ctx.RegisterResource("yandex:index/organizationmanagerSamlFederation:OrganizationmanagerSamlFederation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOrganizationmanagerSamlFederation gets an existing OrganizationmanagerSamlFederation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOrganizationmanagerSamlFederation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OrganizationmanagerSamlFederationState, opts ...pulumi.ResourceOption) (*OrganizationmanagerSamlFederation, error) {
	var resource OrganizationmanagerSamlFederation
	err := ctx.ReadResource("yandex:index/organizationmanagerSamlFederation:OrganizationmanagerSamlFederation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OrganizationmanagerSamlFederation resources.
type organizationmanagerSamlFederationState struct {
	AutoCreateAccountOnLogin *bool                                              `pulumi:"autoCreateAccountOnLogin"`
	CaseInsensitiveNameIds   *bool                                              `pulumi:"caseInsensitiveNameIds"`
	CookieMaxAge             *string                                            `pulumi:"cookieMaxAge"`
	CreatedAt                *string                                            `pulumi:"createdAt"`
	Description              *string                                            `pulumi:"description"`
	Issuer                   *string                                            `pulumi:"issuer"`
	Labels                   map[string]string                                  `pulumi:"labels"`
	Name                     *string                                            `pulumi:"name"`
	OrganizationId           *string                                            `pulumi:"organizationId"`
	SecuritySettings         *OrganizationmanagerSamlFederationSecuritySettings `pulumi:"securitySettings"`
	SsoBinding               *string                                            `pulumi:"ssoBinding"`
	SsoUrl                   *string                                            `pulumi:"ssoUrl"`
}

type OrganizationmanagerSamlFederationState struct {
	AutoCreateAccountOnLogin pulumi.BoolPtrInput
	CaseInsensitiveNameIds   pulumi.BoolPtrInput
	CookieMaxAge             pulumi.StringPtrInput
	CreatedAt                pulumi.StringPtrInput
	Description              pulumi.StringPtrInput
	Issuer                   pulumi.StringPtrInput
	Labels                   pulumi.StringMapInput
	Name                     pulumi.StringPtrInput
	OrganizationId           pulumi.StringPtrInput
	SecuritySettings         OrganizationmanagerSamlFederationSecuritySettingsPtrInput
	SsoBinding               pulumi.StringPtrInput
	SsoUrl                   pulumi.StringPtrInput
}

func (OrganizationmanagerSamlFederationState) ElementType() reflect.Type {
	return reflect.TypeOf((*organizationmanagerSamlFederationState)(nil)).Elem()
}

type organizationmanagerSamlFederationArgs struct {
	AutoCreateAccountOnLogin *bool                                              `pulumi:"autoCreateAccountOnLogin"`
	CaseInsensitiveNameIds   *bool                                              `pulumi:"caseInsensitiveNameIds"`
	CookieMaxAge             *string                                            `pulumi:"cookieMaxAge"`
	Description              *string                                            `pulumi:"description"`
	Issuer                   string                                             `pulumi:"issuer"`
	Labels                   map[string]string                                  `pulumi:"labels"`
	Name                     *string                                            `pulumi:"name"`
	OrganizationId           string                                             `pulumi:"organizationId"`
	SecuritySettings         *OrganizationmanagerSamlFederationSecuritySettings `pulumi:"securitySettings"`
	SsoBinding               string                                             `pulumi:"ssoBinding"`
	SsoUrl                   string                                             `pulumi:"ssoUrl"`
}

// The set of arguments for constructing a OrganizationmanagerSamlFederation resource.
type OrganizationmanagerSamlFederationArgs struct {
	AutoCreateAccountOnLogin pulumi.BoolPtrInput
	CaseInsensitiveNameIds   pulumi.BoolPtrInput
	CookieMaxAge             pulumi.StringPtrInput
	Description              pulumi.StringPtrInput
	Issuer                   pulumi.StringInput
	Labels                   pulumi.StringMapInput
	Name                     pulumi.StringPtrInput
	OrganizationId           pulumi.StringInput
	SecuritySettings         OrganizationmanagerSamlFederationSecuritySettingsPtrInput
	SsoBinding               pulumi.StringInput
	SsoUrl                   pulumi.StringInput
}

func (OrganizationmanagerSamlFederationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*organizationmanagerSamlFederationArgs)(nil)).Elem()
}

type OrganizationmanagerSamlFederationInput interface {
	pulumi.Input

	ToOrganizationmanagerSamlFederationOutput() OrganizationmanagerSamlFederationOutput
	ToOrganizationmanagerSamlFederationOutputWithContext(ctx context.Context) OrganizationmanagerSamlFederationOutput
}

func (*OrganizationmanagerSamlFederation) ElementType() reflect.Type {
	return reflect.TypeOf((**OrganizationmanagerSamlFederation)(nil)).Elem()
}

func (i *OrganizationmanagerSamlFederation) ToOrganizationmanagerSamlFederationOutput() OrganizationmanagerSamlFederationOutput {
	return i.ToOrganizationmanagerSamlFederationOutputWithContext(context.Background())
}

func (i *OrganizationmanagerSamlFederation) ToOrganizationmanagerSamlFederationOutputWithContext(ctx context.Context) OrganizationmanagerSamlFederationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationmanagerSamlFederationOutput)
}

// OrganizationmanagerSamlFederationArrayInput is an input type that accepts OrganizationmanagerSamlFederationArray and OrganizationmanagerSamlFederationArrayOutput values.
// You can construct a concrete instance of `OrganizationmanagerSamlFederationArrayInput` via:
//
//	OrganizationmanagerSamlFederationArray{ OrganizationmanagerSamlFederationArgs{...} }
type OrganizationmanagerSamlFederationArrayInput interface {
	pulumi.Input

	ToOrganizationmanagerSamlFederationArrayOutput() OrganizationmanagerSamlFederationArrayOutput
	ToOrganizationmanagerSamlFederationArrayOutputWithContext(context.Context) OrganizationmanagerSamlFederationArrayOutput
}

type OrganizationmanagerSamlFederationArray []OrganizationmanagerSamlFederationInput

func (OrganizationmanagerSamlFederationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OrganizationmanagerSamlFederation)(nil)).Elem()
}

func (i OrganizationmanagerSamlFederationArray) ToOrganizationmanagerSamlFederationArrayOutput() OrganizationmanagerSamlFederationArrayOutput {
	return i.ToOrganizationmanagerSamlFederationArrayOutputWithContext(context.Background())
}

func (i OrganizationmanagerSamlFederationArray) ToOrganizationmanagerSamlFederationArrayOutputWithContext(ctx context.Context) OrganizationmanagerSamlFederationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationmanagerSamlFederationArrayOutput)
}

// OrganizationmanagerSamlFederationMapInput is an input type that accepts OrganizationmanagerSamlFederationMap and OrganizationmanagerSamlFederationMapOutput values.
// You can construct a concrete instance of `OrganizationmanagerSamlFederationMapInput` via:
//
//	OrganizationmanagerSamlFederationMap{ "key": OrganizationmanagerSamlFederationArgs{...} }
type OrganizationmanagerSamlFederationMapInput interface {
	pulumi.Input

	ToOrganizationmanagerSamlFederationMapOutput() OrganizationmanagerSamlFederationMapOutput
	ToOrganizationmanagerSamlFederationMapOutputWithContext(context.Context) OrganizationmanagerSamlFederationMapOutput
}

type OrganizationmanagerSamlFederationMap map[string]OrganizationmanagerSamlFederationInput

func (OrganizationmanagerSamlFederationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OrganizationmanagerSamlFederation)(nil)).Elem()
}

func (i OrganizationmanagerSamlFederationMap) ToOrganizationmanagerSamlFederationMapOutput() OrganizationmanagerSamlFederationMapOutput {
	return i.ToOrganizationmanagerSamlFederationMapOutputWithContext(context.Background())
}

func (i OrganizationmanagerSamlFederationMap) ToOrganizationmanagerSamlFederationMapOutputWithContext(ctx context.Context) OrganizationmanagerSamlFederationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationmanagerSamlFederationMapOutput)
}

type OrganizationmanagerSamlFederationOutput struct{ *pulumi.OutputState }

func (OrganizationmanagerSamlFederationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OrganizationmanagerSamlFederation)(nil)).Elem()
}

func (o OrganizationmanagerSamlFederationOutput) ToOrganizationmanagerSamlFederationOutput() OrganizationmanagerSamlFederationOutput {
	return o
}

func (o OrganizationmanagerSamlFederationOutput) ToOrganizationmanagerSamlFederationOutputWithContext(ctx context.Context) OrganizationmanagerSamlFederationOutput {
	return o
}

func (o OrganizationmanagerSamlFederationOutput) AutoCreateAccountOnLogin() pulumi.BoolOutput {
	return o.ApplyT(func(v *OrganizationmanagerSamlFederation) pulumi.BoolOutput { return v.AutoCreateAccountOnLogin }).(pulumi.BoolOutput)
}

func (o OrganizationmanagerSamlFederationOutput) CaseInsensitiveNameIds() pulumi.BoolOutput {
	return o.ApplyT(func(v *OrganizationmanagerSamlFederation) pulumi.BoolOutput { return v.CaseInsensitiveNameIds }).(pulumi.BoolOutput)
}

func (o OrganizationmanagerSamlFederationOutput) CookieMaxAge() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerSamlFederation) pulumi.StringOutput { return v.CookieMaxAge }).(pulumi.StringOutput)
}

func (o OrganizationmanagerSamlFederationOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerSamlFederation) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o OrganizationmanagerSamlFederationOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OrganizationmanagerSamlFederation) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

func (o OrganizationmanagerSamlFederationOutput) Issuer() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerSamlFederation) pulumi.StringOutput { return v.Issuer }).(pulumi.StringOutput)
}

func (o OrganizationmanagerSamlFederationOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *OrganizationmanagerSamlFederation) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o OrganizationmanagerSamlFederationOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerSamlFederation) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o OrganizationmanagerSamlFederationOutput) OrganizationId() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerSamlFederation) pulumi.StringOutput { return v.OrganizationId }).(pulumi.StringOutput)
}

func (o OrganizationmanagerSamlFederationOutput) SecuritySettings() OrganizationmanagerSamlFederationSecuritySettingsOutput {
	return o.ApplyT(func(v *OrganizationmanagerSamlFederation) OrganizationmanagerSamlFederationSecuritySettingsOutput {
		return v.SecuritySettings
	}).(OrganizationmanagerSamlFederationSecuritySettingsOutput)
}

func (o OrganizationmanagerSamlFederationOutput) SsoBinding() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerSamlFederation) pulumi.StringOutput { return v.SsoBinding }).(pulumi.StringOutput)
}

func (o OrganizationmanagerSamlFederationOutput) SsoUrl() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerSamlFederation) pulumi.StringOutput { return v.SsoUrl }).(pulumi.StringOutput)
}

type OrganizationmanagerSamlFederationArrayOutput struct{ *pulumi.OutputState }

func (OrganizationmanagerSamlFederationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OrganizationmanagerSamlFederation)(nil)).Elem()
}

func (o OrganizationmanagerSamlFederationArrayOutput) ToOrganizationmanagerSamlFederationArrayOutput() OrganizationmanagerSamlFederationArrayOutput {
	return o
}

func (o OrganizationmanagerSamlFederationArrayOutput) ToOrganizationmanagerSamlFederationArrayOutputWithContext(ctx context.Context) OrganizationmanagerSamlFederationArrayOutput {
	return o
}

func (o OrganizationmanagerSamlFederationArrayOutput) Index(i pulumi.IntInput) OrganizationmanagerSamlFederationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *OrganizationmanagerSamlFederation {
		return vs[0].([]*OrganizationmanagerSamlFederation)[vs[1].(int)]
	}).(OrganizationmanagerSamlFederationOutput)
}

type OrganizationmanagerSamlFederationMapOutput struct{ *pulumi.OutputState }

func (OrganizationmanagerSamlFederationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OrganizationmanagerSamlFederation)(nil)).Elem()
}

func (o OrganizationmanagerSamlFederationMapOutput) ToOrganizationmanagerSamlFederationMapOutput() OrganizationmanagerSamlFederationMapOutput {
	return o
}

func (o OrganizationmanagerSamlFederationMapOutput) ToOrganizationmanagerSamlFederationMapOutputWithContext(ctx context.Context) OrganizationmanagerSamlFederationMapOutput {
	return o
}

func (o OrganizationmanagerSamlFederationMapOutput) MapIndex(k pulumi.StringInput) OrganizationmanagerSamlFederationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *OrganizationmanagerSamlFederation {
		return vs[0].(map[string]*OrganizationmanagerSamlFederation)[vs[1].(string)]
	}).(OrganizationmanagerSamlFederationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OrganizationmanagerSamlFederationInput)(nil)).Elem(), &OrganizationmanagerSamlFederation{})
	pulumi.RegisterInputType(reflect.TypeOf((*OrganizationmanagerSamlFederationArrayInput)(nil)).Elem(), OrganizationmanagerSamlFederationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OrganizationmanagerSamlFederationMapInput)(nil)).Elem(), OrganizationmanagerSamlFederationMap{})
	pulumi.RegisterOutputType(OrganizationmanagerSamlFederationOutput{})
	pulumi.RegisterOutputType(OrganizationmanagerSamlFederationArrayOutput{})
	pulumi.RegisterOutputType(OrganizationmanagerSamlFederationMapOutput{})
}
