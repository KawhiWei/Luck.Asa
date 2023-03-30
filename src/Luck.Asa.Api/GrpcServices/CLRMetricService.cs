using Grpc.Core;
using SkyWalking.NetworkProtocol.V3;

namespace Luck.Asa.Api.GrpcServices;

public class ClrMetricService:CLRMetricReportService.CLRMetricReportServiceBase
{
    public override Task<Commands> collect(CLRMetricCollection request, ServerCallContext context)
    {

        foreach (var metric in request.Metrics)
        {
            
        }

        
        return base.collect(request, context);
    }
}