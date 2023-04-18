namespace Luck.Asa.Domain.Traces;

/// <summary>
/// Trace 表用于存储一条完整的请求链路，包含了整个分布式系统中的所有调用和操作，以及其产生的所有日志和事件。
/// </summary>
public class Trace : FullAggregateRoot
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
    /// 跟踪Id
    /// </summary>
    public string AgentTraceId { get; set; } = default!;

    /// <summary>
    /// Segment 中的详细数据，如请求参数、响应结果等。
    /// </summary>
    public string Data { get; set; } = default!;
}