namespace Luck.Asa.Domain.Spans;

/// <summary>
/// Span 表用于存储 Segment 中的一个应用中的调用链节点，可以理解为一次服务间调用或一个本地操作。
/// </summary>
public class SpanReference
{
    /// <summary>
    /// 追踪Id
    /// </summary>
    public string TraceId { get; set; } = default!;

    /// <summary>
    /// 跟踪Id
    /// </summary>
    public string AgentTraceId { get; set; } = default!;
    
    /// <summary>
    /// 用于标识一个 Span 的唯一 ID
    /// </summary>
    public string SpanId { get; set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public int RefType { get; set; } = default!;
    
}