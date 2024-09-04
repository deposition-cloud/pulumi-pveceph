using System.Collections.Generic;
using System.Linq;
using Pulumi;
using pveceph = Pulumi.pveceph;

return await Deployment.RunAsync(() => 
{
    var myRandomResource = new pveceph.Random("myRandomResource", new()
    {
        Length = 24,
    });

    return new Dictionary<string, object?>
    {
        ["output"] = 
        {
            { "value", myRandomResource.Result },
        },
    };
});

