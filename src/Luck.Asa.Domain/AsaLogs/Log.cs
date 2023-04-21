namespace Luck.Asa.Domain.AsaLogs;

public class Log : FullEntity
{
    public Log(string spanId, string content, string agentTraceId)
    {
        SpanId = spanId;
        Content = content;
        AgentTraceId = agentTraceId;
    }

    /// <summary>
    /// 用于标识一个 Span 的唯一 ID
    /// </summary>
    public string SpanId { get; set; }


    /// <summary>
    /// 日志内容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 跟踪Id
    /// </summary>
    public string AgentTraceId { get; set; }
}