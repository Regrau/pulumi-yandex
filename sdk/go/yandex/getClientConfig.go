// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get attributes used by provider to configure client connection.
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
	// The ID of the cloud that the provider is connecting to.
	CloudId string `pulumi:"cloudId"`
	// The ID of the folder in which we operate.
	FolderId string `pulumi:"folderId"`
	// A short-lived token that can be used for authentication in a Kubernetes cluster.
	IamToken string `pulumi:"iamToken"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The default availability zone.
	Zone string `pulumi:"zone"`
}
