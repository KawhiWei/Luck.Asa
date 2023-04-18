using Luck.Asa.Domain.Shared.Enums;

namespace Luck.Asa.Domain.Spans;

/// <summary>
/// Span 表用于存储 Segment 中的一个应用中的调用链节点，可以理解为一次服务间调用或一个本地操作。
/// </summary>
public class Span : FullAggregateRoot
{
    /// <summary>
    /// 应用实例Id
    /// </summary>
    public string AppId { get; set; } = default!;

    /// <summary>
    /// 应用实例Id
    /// </summary>
    public string AppInstanceId { get; set; } = default!;
    
    /// <summary>
    /// 应用实例Id
    /// </summary>
    public string TraceId { get; set; } = default!;
    
    /// <summary>
    /// 跟踪Id
    /// </summary>
    public string AgentTraceId { get; set; } = default!;
    
    /// <summary>
    /// 用于标识一个 Span 的唯一 ID
    /// </summary>
    public int SpanId { get; set; } = default!;

    /// <summary>
    /// Span 的父节点 ID
    /// </summary>
    public int ParentSpanId { get; set; } = default!;

    /// <summary>
    /// 开始时间
    /// </summary>
    public string StartTime { get; set; } = default!;

    /// <summary>
    /// 结束时间
    /// </summary>
    public string EndTime { get; set; } = default!;

    /// <summary>
    /// 当前Span的耗时
    /// </summary>
    public double Duration { get; set; } = default!;

    /// <summary>
    ///  跨层类型
    /// </summary>
    public SpanTypeEnum SpanType { get; set; } = default!;

    /// <summary>
    /// 操作类型
    /// </summary>
    public SpanLayerEnum SpanLayer { get; set; }

    /// <summary>+
    /// 操作名称
    /// </summary>
    public string OperationName { get; set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public string Tags { get; set; } = default!;

    /// <summary>
    /// 在当前记录中是否异常
    /// </summary>
    public bool IsError { get; set; } = default!;
}