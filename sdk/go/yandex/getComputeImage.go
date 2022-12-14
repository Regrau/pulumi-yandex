// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupComputeImage(ctx *pulumi.Context, args *LookupComputeImageArgs, opts ...pulumi.InvokeOption) (*LookupComputeImageResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupComputeImageResult
	err := ctx.Invoke("yandex:index/getComputeImage:getComputeImage", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getComputeImage.
type LookupComputeImageArgs struct {
	// The family name of an image. Used to search the latest image in a family.
	Family *string `pulumi:"family"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// The ID of a specific image.
	ImageId *string `pulumi:"imageId"`
	// The name of the image.
	Name *string `pulumi:"name"`
}

// A collection of values returned by getComputeImage.
type LookupComputeImageResult struct {
	// Image creation timestamp.
	CreatedAt string `pulumi:"createdAt"`
	// An optional description of this image.
	Description string `pulumi:"description"`
	// The OS family name of the image.
	Family   string `pulumi:"family"`
	FolderId string `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id      string `pulumi:"id"`
	ImageId string `pulumi:"imageId"`
	// A map of labels applied to this image.
	Labels map[string]string `pulumi:"labels"`
	// Minimum size of the disk which is created from this image.
	MinDiskSize int    `pulumi:"minDiskSize"`
	Name        string `pulumi:"name"`
	// Operating system type that the image contains.
	OsType string `pulumi:"osType"`
	// Optimize the image to create a disk.
	Pooled bool `pulumi:"pooled"`
	// License IDs that indicate which licenses are attached to this image.
	ProductIds []string `pulumi:"productIds"`
	// The size of the image, specified in Gb.
	Size int `pulumi:"size"`
	// The status of the image.
	Status string `pulumi:"status"`
}

func LookupComputeImageOutput(ctx *pulumi.Context, args LookupComputeImageOutputArgs, opts ...pulumi.InvokeOption) LookupComputeImageResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupComputeImageResult, error) {
			args := v.(LookupComputeImageArgs)
			r, err := LookupComputeImage(ctx, &args, opts...)
			var s LookupComputeImageResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupComputeImageResultOutput)
}

// A collection of arguments for invoking getComputeImage.
type LookupComputeImageOutputArgs struct {
	// The family name of an image. Used to search the latest image in a family.
	Family pulumi.StringPtrInput `pulumi:"family"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId pulumi.StringPtrInput `pulumi:"folderId"`
	// The ID of a specific image.
	ImageId pulumi.StringPtrInput `pulumi:"imageId"`
	// The name of the image.
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupComputeImageOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputeImageArgs)(nil)).Elem()
}

// A collection of values returned by getComputeImage.
type LookupComputeImageResultOutput struct{ *pulumi.OutputState }

func (LookupComputeImageResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputeImageResult)(nil)).Elem()
}

func (o LookupComputeImageResultOutput) ToLookupComputeImageResultOutput() LookupComputeImageResultOutput {
	return o
}

func (o LookupComputeImageResultOutput) ToLookupComputeImageResultOutputWithContext(ctx context.Context) LookupComputeImageResultOutput {
	return o
}

// Image creation timestamp.
func (o LookupComputeImageResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeImageResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

// An optional description of this image.
func (o LookupComputeImageResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeImageResult) string { return v.Description }).(pulumi.StringOutput)
}

// The OS family name of the image.
func (o LookupComputeImageResultOutput) Family() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeImageResult) string { return v.Family }).(pulumi.StringOutput)
}

func (o LookupComputeImageResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeImageResult) string { return v.FolderId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupComputeImageResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeImageResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupComputeImageResultOutput) ImageId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeImageResult) string { return v.ImageId }).(pulumi.StringOutput)
}

// A map of labels applied to this image.
func (o LookupComputeImageResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupComputeImageResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

// Minimum size of the disk which is created from this image.
func (o LookupComputeImageResultOutput) MinDiskSize() pulumi.IntOutput {
	return o.ApplyT(func(v LookupComputeImageResult) int { return v.MinDiskSize }).(pulumi.IntOutput)
}

func (o LookupComputeImageResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeImageResult) string { return v.Name }).(pulumi.StringOutput)
}

// Operating system type that the image contains.
func (o LookupComputeImageResultOutput) OsType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeImageResult) string { return v.OsType }).(pulumi.StringOutput)
}

// Optimize the image to create a disk.
func (o LookupComputeImageResultOutput) Pooled() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupComputeImageResult) bool { return v.Pooled }).(pulumi.BoolOutput)
}

// License IDs that indicate which licenses are attached to this image.
func (o LookupComputeImageResultOutput) ProductIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupComputeImageResult) []string { return v.ProductIds }).(pulumi.StringArrayOutput)
}

// The size of the image, specified in Gb.
func (o LookupComputeImageResultOutput) Size() pulumi.IntOutput {
	return o.ApplyT(func(v LookupComputeImageResult) int { return v.Size }).(pulumi.IntOutput)
}

// The status of the image.
func (o LookupComputeImageResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeImageResult) string { return v.Status }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupComputeImageResultOutput{})
}
