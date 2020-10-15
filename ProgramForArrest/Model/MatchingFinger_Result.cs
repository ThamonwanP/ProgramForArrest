public class MatchingFinger_Result
{
    public MatchingFinger_ResultData[] Property1 { get; set; }
}

public class MatchingFinger_ResultData
{
    public string key { get; set; }
    public string uid { get; set; }
    public string fingerid { get; set; }
    public int fingerindex { get; set; }
    public int groupid { get; set; }
    public float score { get; set; }
}
