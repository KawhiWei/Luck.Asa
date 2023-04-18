using Grpc.Core;
using SkyWalking.NetworkProtocol.V3;

namespace Luck.Asa.Api.GrpcServices;

public class RegisterAppService : ManagementService.ManagementServiceBase
{
    public override async Task<Commands> reportInstanceProperties(InstanceProperties request, ServerCallContext context)
    {
        return await base.reportInstanceProperties(request, context);
    }
}