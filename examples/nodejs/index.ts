import * as pulumi from "@pulumi/pulumi";
import * as pveceph from "@deposition.cloud/pulumi-pveceph";

const myRandomResource = new pveceph.Random("myRandomResource", {length: 24});
export const output = {
    value: myRandomResource.result,
};
