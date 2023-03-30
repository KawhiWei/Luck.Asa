using System.ComponentModel;

namespace Luck.Asa.Domain.Shared.Enums;

public enum RefTypeEnum
{
    /// <summary>
    /// 交叉进程
    /// </summary>
    [Description("")] CrossProcess = 0,

    /// <summary>
    /// 交叉线程
    /// </summary>
    [Description("")] CrossThread = 1,
}