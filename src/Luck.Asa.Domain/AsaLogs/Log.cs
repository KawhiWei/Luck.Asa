using Luck.Dapper.Attributes;

namespace Luck.Asa.Domain.AsaLogs;

/// <summary>
/// 
/// </summary>
[LuckTable("traces")]
public class Log : FullEntity
{
    public Log(string spanId, string content, string agentTraceId)
    {
        SpanId = spanId;
        Content = content;
        AgentTraceId = agentTraceId;
    }

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
    /// 跟踪Id
    /// </summary>
    [LuckColumnName("agent_trace_id")]
    public string AgentTraceId { get; set; } = default!;

    /// <summary>
    /// 应用实例Id
    /// </summary>
    [LuckColumnName("trace_id")]
    public string TraceId { get; set; } = default!;

    /// <summary>
    /// 用于标识一个 Span 的唯一 ID
    /// </summary>
    [LuckColumnName("span_id")]
    public string SpanId { get; set; } = default!;

    /// <summary>
    /// 日志内容
    /// </summary>
    [LuckColumnName("content")]
    public string Content { get; set; } = default!;

    /// <summary>
    /// 日志级别
    /// </summary>
    [LuckColumnName("level")]
    public int Level { get; set; } = default!;
}