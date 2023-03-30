using System.ComponentModel;

namespace Luck.Asa.Domain.Shared.Enums;

/// <summary>
/// 跨层类型
/// </summary>
public enum SpanTypeEnum
{
    [Description("入口")] Entry = 0,

    [Description("出口")] Exit = 1,

    [Description("本地")] Local = 2,
}