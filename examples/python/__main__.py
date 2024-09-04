import pulumi
import pulumi_pveceph as pveceph

my_random_resource = pveceph.Random("myRandomResource", length=24)
pulumi.export("output", {
    "value": my_random_resource.result,
})
