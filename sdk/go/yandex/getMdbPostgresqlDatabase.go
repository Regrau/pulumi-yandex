// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about a Yandex Managed PostgreSQL database. For more information, see
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
//			foo, err := yandex.LookupMdbPostgresqlDatabase(ctx, &GetMdbPostgresqlDatabaseArgs{
//				ClusterId: "some_cluster_id",
//				Name:      "test",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("owner", foo.Owner)
//			return nil
//		})
//	}
//
// ```
func LookupMdbPostgresqlDatabase(ctx *pulumi.Context, args *LookupMdbPostgresqlDatabaseArgs, opts ...pulumi.InvokeOption) (*LookupMdbPostgresqlDatabaseResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupMdbPostgresqlDatabaseResult
	err := ctx.Invoke("yandex:index/getMdbPostgresqlDatabase:getMdbPostgresqlDatabase", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMdbPostgresqlDatabase.
type LookupMdbPostgresqlDatabaseArgs struct {
	// The ID of the PostgreSQL cluster.
	ClusterId string `pulumi:"clusterId"`
	// Inhibits deletion of the database.
	DeletionProtection *string `pulumi:"deletionProtection"`
	// Set of database extensions. The structure is documented below
	Extensions []GetMdbPostgresqlDatabaseExtension `pulumi:"extensions"`
	// POSIX locale for string sorting order. Forbidden to change in an existing database.
	LcCollate *string `pulumi:"lcCollate"`
	// POSIX locale for character classification. Forbidden to change in an existing database.
	LcType *string `pulumi:"lcType"`
	// The name of the PostgreSQL cluster.
	Name string `pulumi:"name"`
	// Name of the user assigned as the owner of the database.
	Owner *string `pulumi:"owner"`
	// Name of the template database.
	TemplateDb *string `pulumi:"templateDb"`
}

// A collection of values returned by getMdbPostgresqlDatabase.
type LookupMdbPostgresqlDatabaseResult struct {
	ClusterId string `pulumi:"clusterId"`
	// Inhibits deletion of the database.
	DeletionProtection *string `pulumi:"deletionProtection"`
	// Set of database extensions. The structure is documented below
	Extensions []GetMdbPostgresqlDatabaseExtension `pulumi:"extensions"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// POSIX locale for string sorting order. Forbidden to change in an existing database.
	LcCollate string `pulumi:"lcCollate"`
	// POSIX locale for character classification. Forbidden to change in an existing database.
	LcType string `pulumi:"lcType"`
	// Name of the database extension. For more information on available extensions see [the official documentation](https://cloud.yandex.com/docs/managed-postgresql/operations/cluster-extensions).
	Name string `pulumi:"name"`
	// Name of the user assigned as the owner of the database.
	Owner string `pulumi:"owner"`
	// Name of the template database.
	TemplateDb string `pulumi:"templateDb"`
}

func LookupMdbPostgresqlDatabaseOutput(ctx *pulumi.Context, args LookupMdbPostgresqlDatabaseOutputArgs, opts ...pulumi.InvokeOption) LookupMdbPostgresqlDatabaseResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupMdbPostgresqlDatabaseResult, error) {
			args := v.(LookupMdbPostgresqlDatabaseArgs)
			r, err := LookupMdbPostgresqlDatabase(ctx, &args, opts...)
			var s LookupMdbPostgresqlDatabaseResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupMdbPostgresqlDatabaseResultOutput)
}

// A collection of arguments for invoking getMdbPostgresqlDatabase.
type LookupMdbPostgresqlDatabaseOutputArgs struct {
	// The ID of the PostgreSQL cluster.
	ClusterId pulumi.StringInput `pulumi:"clusterId"`
	// Inhibits deletion of the database.
	DeletionProtection pulumi.StringPtrInput `pulumi:"deletionProtection"`
	// Set of database extensions. The structure is documented below
	Extensions GetMdbPostgresqlDatabaseExtensionArrayInput `pulumi:"extensions"`
	// POSIX locale for string sorting order. Forbidden to change in an existing database.
	LcCollate pulumi.StringPtrInput `pulumi:"lcCollate"`
	// POSIX locale for character classification. Forbidden to change in an existing database.
	LcType pulumi.StringPtrInput `pulumi:"lcType"`
	// The name of the PostgreSQL cluster.
	Name pulumi.StringInput `pulumi:"name"`
	// Name of the user assigned as the owner of the database.
	Owner pulumi.StringPtrInput `pulumi:"owner"`
	// Name of the template database.
	TemplateDb pulumi.StringPtrInput `pulumi:"templateDb"`
}

func (LookupMdbPostgresqlDatabaseOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbPostgresqlDatabaseArgs)(nil)).Elem()
}

// A collection of values returned by getMdbPostgresqlDatabase.
type LookupMdbPostgresqlDatabaseResultOutput struct{ *pulumi.OutputState }

func (LookupMdbPostgresqlDatabaseResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbPostgresqlDatabaseResult)(nil)).Elem()
}

func (o LookupMdbPostgresqlDatabaseResultOutput) ToLookupMdbPostgresqlDatabaseResultOutput() LookupMdbPostgresqlDatabaseResultOutput {
	return o
}

func (o LookupMdbPostgresqlDatabaseResultOutput) ToLookupMdbPostgresqlDatabaseResultOutputWithContext(ctx context.Context) LookupMdbPostgresqlDatabaseResultOutput {
	return o
}

func (o LookupMdbPostgresqlDatabaseResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

// Inhibits deletion of the database.
func (o LookupMdbPostgresqlDatabaseResultOutput) DeletionProtection() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) *string { return v.DeletionProtection }).(pulumi.StringPtrOutput)
}

// Set of database extensions. The structure is documented below
func (o LookupMdbPostgresqlDatabaseResultOutput) Extensions() GetMdbPostgresqlDatabaseExtensionArrayOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) []GetMdbPostgresqlDatabaseExtension { return v.Extensions }).(GetMdbPostgresqlDatabaseExtensionArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupMdbPostgresqlDatabaseResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.Id }).(pulumi.StringOutput)
}

// POSIX locale for string sorting order. Forbidden to change in an existing database.
func (o LookupMdbPostgresqlDatabaseResultOutput) LcCollate() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.LcCollate }).(pulumi.StringOutput)
}

// POSIX locale for character classification. Forbidden to change in an existing database.
func (o LookupMdbPostgresqlDatabaseResultOutput) LcType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.LcType }).(pulumi.StringOutput)
}

// Name of the database extension. For more information on available extensions see [the official documentation](https://cloud.yandex.com/docs/managed-postgresql/operations/cluster-extensions).
func (o LookupMdbPostgresqlDatabaseResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.Name }).(pulumi.StringOutput)
}

// Name of the user assigned as the owner of the database.
func (o LookupMdbPostgresqlDatabaseResultOutput) Owner() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.Owner }).(pulumi.StringOutput)
}

// Name of the template database.
func (o LookupMdbPostgresqlDatabaseResultOutput) TemplateDb() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.TemplateDb }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupMdbPostgresqlDatabaseResultOutput{})
}
