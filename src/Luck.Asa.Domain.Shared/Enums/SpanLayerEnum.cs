using System.ComponentModel;

namespace Luck.Asa.Domain.Shared.Enums;

/// <summary>
/// 跨层调用
/// </summary>
public enum SpanLayerEnum
{
    [Description("未知")] Unknown = 0,

    [Description("数据库")] Database = 1,

    [Description("RPC调用")] RpcFramework = 2,

    [Description("Http请求")] Http = 3,

    [Description("消息队列")] Mq = 4,

    [Description("缓存")] Cache = 5,

    [Description("FaaS")] FaaS = 6,
}