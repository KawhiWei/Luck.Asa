using Grpc.Core;
using Luck.Asa.Domain.Shared.Enums;
using Luck.Asa.Dto.Segments;
using SkyWalking.NetworkProtocol.V3;

namespace Luck.Asa.Api.GrpcServices;

public class TraceSegmentService : TraceSegmentReportService.TraceSegmentReportServiceBase
{
    public override async Task<Commands> collect(IAsyncStreamReader<SegmentObject> requestStream, ServerCallContext context)
    {
        await Task.CompletedTask;
        while (await requestStream.MoveNext())
        {
            var segmentRequestInput = new SegmentRequestInputDto
            {
                TraceId = requestStream.Current.TraceId,
                Segment = new SegmentObjectRequestInputDto()
                {
                    SegmentId = requestStream.Current.TraceSegmentId,
                    AppId = requestStream.Current.Service,
                    AppInstanceId = requestStream.Current.ServiceInstance,
                    Spans = new List<SpanInputDto>(requestStream.Current.Spans.Select(GetSpans))
                },
            };
        }


        return await base.collect(requestStream, context);
    }

    private SpanInputDto GetSpans(SpanObject spanObject)
    {
        return new SpanInputDto()
        {
            SpanId = spanObject.SpanId,
            SpanType = GetSpanType(spanObject.SpanType),
            SpanLayer = GetSpanSpanLayer(spanObject.SpanLayer),
            ParentSpanId = spanObject.ParentSpanId,
            StartTime = spanObject.StartTime,
            EndTime = spanObject.EndTime,
            IsError = spanObject.IsError,
        };
    }

    private SpanTypeEnum GetSpanType(SpanType spanType) => spanType switch
    {
        SpanType.Entry => SpanTypeEnum.Entry,
        SpanType.Exit => SpanTypeEnum.Exit,
        SpanType.Local => SpanTypeEnum.Local,
        _ => SpanTypeEnum.Local
    };

    private SpanLayerEnum GetSpanSpanLayer(SpanLayer spanLayer) => spanLayer switch
    {
        SpanLayer.Unknown => SpanLayerEnum.Unknown,
        SpanLayer.Database => SpanLayerEnum.Database,
        SpanLayer.Rpcframework => SpanLayerEnum.RpcFramework,
        SpanLayer.Http => SpanLayerEnum.Http,
        SpanLayer.Mq => SpanLayerEnum.Mq,
        SpanLayer.Cache => SpanLayerEnum.Cache,
        SpanLayer.Faas => SpanLayerEnum.FaaS,
        _ => SpanLayerEnum.Unknown
    };

    private RefTypeEnum GetRefType(RefType refType) => refType switch
    {
        RefType.CrossProcess => RefTypeEnum.CrossProcess,
        RefType.CrossThread => RefTypeEnum.CrossThread,
        _ => RefTypeEnum.CrossProcess
    };
}