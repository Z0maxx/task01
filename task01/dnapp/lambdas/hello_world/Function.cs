using System.Collections.Generic;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SimpleLambdaFunction;

public class Function
{
    public Dictionary<string, object> FunctionHandler(APIGatewayProxyRequest request, ILambdaContext context)
    {
        return new Dictionary<string, object>()
        {
            { "statusCode", 200 },
            { "message", "Hello from Lambda" },
        };
    }
}
