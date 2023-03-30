namespace Luck.Asa.Dto.Segments;

public class SegmentRequestBaseDto
{
    public string TraceId { get; set; } = default!;

    public SegmentObjectRequestInputDto Segment { get; set; } = default!;
}