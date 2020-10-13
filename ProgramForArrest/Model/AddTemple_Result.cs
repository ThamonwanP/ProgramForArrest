
public class AddTemple_Result
{
    public string id { get; set; }
    public string key { get; set; }
    public Value value { get; set; }
}

public class Value
{
    public string fingerid { get; set; }
    public int fingerindex { get; set; }
    public string fingergroup { get; set; }
    public string fingertemplate { get; set; }
}
