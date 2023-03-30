using Luck.Asa.Domain.Shared.Enums;

namespace Luck.Asa.Dto.TraceSegments;

public class SpanBaseDto
{
    public int SpanId { get; set; } = default!;

    public SpanTypeEnum SpanType { get; set; } = default!;

    public SpanLayerEnum SpanLayer { get; set; } = default!;

    public int ParentSpanId { get; set; } = default!;

    public long StartTime { get; set; } = default!;

    public long EndTime { get; set; } = default!;
    /// <summary>
    /// 
    /// </summary>
    public bool IsError { get; set; } = default!;
    
    /// <summary>
    /// 标签
    /// </summary>
    public IList<KeyValuePair<string, string>> Tags { get; } = new List<KeyValuePair<string, string>>();
    
    /// <summary>
    /// 
    /// </summary>
    public int RefType { get; set; }
}



