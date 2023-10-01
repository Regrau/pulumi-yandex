// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Get information about Yandex Cloud Lockbox secret. For more information,
 * see [the official documentation](https://cloud.yandex.com/en/docs/lockbox/).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const mySecret = yandex.getLockBoxSecret({
 *     secretId: "some ID",
 * });
 * export const mySecretCreatedAt = mySecret.then(mySecret => mySecret.createdAt);
 * ```
 */
export function getLockBoxSecret(args?: GetLockBoxSecretArgs, opts?: pulumi.InvokeOptions): Promise<GetLockBoxSecretResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getLockBoxSecret:getLockBoxSecret", {
        "folderId": args.folderId,
        "name": args.name,
        "secretId": args.secretId,
    }, opts);
}

/**
 * A collection of arguments for invoking getLockBoxSecret.
 */
export interface GetLockBoxSecretArgs {
    /**
     * Folder that the secret belongs to. If value is omitted, the default provider folder is used.
     */
    folderId?: string;
    /**
     * Name of the Lockbox secret.
     */
    name?: string;
    /**
     * The Yandex Cloud Lockbox secret ID.
     */
    secretId?: string;
}

/**
 * A collection of values returned by getLockBoxSecret.
 */
export interface GetLockBoxSecretResult {
    /**
     * The version creation timestamp.
     */
    readonly createdAt: string;
    /**
     * Information about the current version of the Yandex Cloud Lockbox secret.
     */
    readonly currentVersions: outputs.GetLockBoxSecretCurrentVersion[];
    /**
     * Whether the Yandex Cloud Lockbox secret is protected from deletion.
     */
    readonly deletionProtection: boolean;
    /**
     * The version description.
     */
    readonly description: string;
    /**
     * ID of the folder that the Yandex Cloud Lockbox secret belongs to.
     */
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The KMS key used to encrypt the Yandex Cloud Lockbox secret (if an explicit key was used).
     */
    readonly kmsKeyId: string;
    /**
     * A set of key/value label pairs assigned to the Yandex Cloud Lockbox secret.
     */
    readonly labels: {[key: string]: string};
    /**
     * The Yandex Cloud Lockbox secret name.
     */
    readonly name: string;
    /**
     * The secret ID the version belongs to (it's the same as the `secretId` argument indicated above)
     */
    readonly secretId?: string;
    /**
     * The version status.
     */
    readonly status: string;
}

export function getLockBoxSecretOutput(args?: GetLockBoxSecretOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLockBoxSecretResult> {
    return pulumi.output(args).apply(a => getLockBoxSecret(a, opts))
}

/**
 * A collection of arguments for invoking getLockBoxSecret.
 */
export interface GetLockBoxSecretOutputArgs {
    /**
     * Folder that the secret belongs to. If value is omitted, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * Name of the Lockbox secret.
     */
    name?: pulumi.Input<string>;
    /**
     * The Yandex Cloud Lockbox secret ID.
     */
    secretId?: pulumi.Input<string>;
}
