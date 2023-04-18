namespace Luck.Asa.Dto.Segments;

public class TraceBaseDto
{
    public string TraceId { get; set; } = default!;

    /// <summary>
    /// 应用实例Id
    /// </summary>
    public string AppId { get; set; } = default!;

    /// <summary>
    /// 应用实例Id
    /// </summary>
    public string AppInstanceId { get; set; } = default!;

    /// <summary>
    /// Segment 中的详细数据，如请求参数、响应结果等。
    /// </summary>
    public string Data { get; set; } = default!;

    /// <summary>
    /// 跨度层
    /// </summary>
    public IList<SpanInputDto> Spans { get; set; } = new List<SpanInputDto>();
}