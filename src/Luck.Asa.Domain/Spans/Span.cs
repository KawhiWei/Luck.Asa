using Luck.Asa.Domain.Shared.Enums;
using Luck.Dapper.Attributes;
namespace Luck.Asa.Domain.Spans;

/// <summary>
/// Span 表用于存储 Segment 中的一个应用中的调用链节点，可以理解为一次服务间调用或一个本地操作。
/// </summary>
[LuckTable("spans")]
public class Span : FullAggregateRoot
{
    /// <summary>
    /// 应用实例Id
    /// </summary>
    [LuckColumnName("app_id")]
    public string AppId { get; set; } = default!;

    /// <summary>
    /// 应用实例Id
    /// </summary>
    [LuckColumnName("app_instance_id")]
    public string AppInstanceId { get; set; } = default!;

    /// <summary>
    /// 应用实例Id
    /// </summary>
    [LuckColumnName("trace_id")]
    public string TraceId { get; set; } = default!;

    /// <summary>
    /// 跟踪Id
    /// </summary>
    [LuckColumnName("agent_trace_id")]
    public string AgentTraceId { get; set; } = default!;

    /// <summary>
    /// 用于标识一个 Span 的唯一 ID
    /// </summary>
    [LuckColumnName("span_id")]
    public int SpanId { get; set; } = default!;

    /// <summary>
    /// Span 的父节点 ID
    /// </summary>
    [LuckColumnName("parent_span_id")]
    public int ParentSpanId { get; set; } = default!;

    /// <summary>
    /// 开始时间
    /// </summary>
    [LuckColumnName("start_time")]
    public string StartTime { get; set; } = default!;

    /// <summary>
    /// 结束时间
    /// </summary>
    [LuckColumnName("end_time")]
    public string EndTime { get; set; } = default!;

    /// <summary>
    /// 当前Span的耗时
    /// </summary>
    [LuckColumnName("duration")]
    public double Duration { get; set; } = default!;

    /// <summary>
    ///  跨层类型
    /// </summary>
    [LuckColumnName("span_type")]
    public SpanTypeEnum SpanType { get; set; } = default!;

    /// <summary>
    /// 操作类型
    /// </summary>
    [LuckColumnName("span_layer")]
    public int SpanLayer { get; set; }

    /// <summary>
    /// 操作名称
    /// </summary>
    [LuckColumnName("operation_name")]
    public string OperationName { get; set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    [LuckColumnName("tags")]
    public string Tags { get; set; } = default!;

    /// <summary>
    /// 在当前记录中是否异常
    /// </summary>
    [LuckColumnName("is_error")]
    public bool IsError { get; set; } = default!;
}