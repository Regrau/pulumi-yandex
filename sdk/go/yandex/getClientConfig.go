// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetClientConfig(ctx *pulumi.Context, opts ...pulumi.InvokeOption) (*GetClientConfigResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetClientConfigResult
	err := ctx.Invoke("yandex:index/getClientConfig:getClientConfig", nil, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of values returned by getClientConfig.
type GetClientConfigResult struct {
	CloudId  string `pulumi:"cloudId"`
	FolderId string `pulumi:"folderId"`
	IamToken string `pulumi:"iamToken"`
	// The provider-assigned unique ID for this managed resource.
	Id   string `pulumi:"id"`
	Zone string `pulumi:"zone"`
}
