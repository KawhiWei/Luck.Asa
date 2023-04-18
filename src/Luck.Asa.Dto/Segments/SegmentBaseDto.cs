namespace Luck.Asa.Dto.Segments;

public class SegmentBaseDto
{
    /// <summary>
    /// 请求段Id
    /// </summary>
    public string SegmentId { get; set; } = default!;

    /// <summary>
    /// Id
    /// </summary>
    public string AppId { get; set; } = default!;

    /// <summary>
    /// 应用示例Id
    /// </summary>
    public string AppInstanceId { get; set; } = default!;


}