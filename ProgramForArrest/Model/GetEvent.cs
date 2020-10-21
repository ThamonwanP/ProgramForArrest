
public class GetEvent
{
    public GetEventData[] Property1 { get; set; }
}

public class GetEventData
{
    public string id { get; set; }
    public Date date { get; set; }
    public string recorder { get; set; }
    public string personid { get; set; }
    public string casestr { get; set; }
    public object detail { get; set; }
    public string other { get; set; }
    public string place { get; set; }
    public string image { get; set; }
}

public class Date
{
    public int value { get; set; }
    public string bsonType { get; set; }
    public int inc { get; set; }
    public int time { get; set; }
    public bool _double { get; set; }
    public bool binary { get; set; }
    public bool _string { get; set; }
    public bool int32 { get; set; }
    public bool int64 { get; set; }
    public bool decimal128 { get; set; }
    public bool objectId { get; set; }
    public bool dbpointer { get; set; }
    public bool timestamp { get; set; }
    public bool dateTime { get; set; }
    public bool symbol { get; set; }
    public bool regularExpression { get; set; }
    public bool javaScript { get; set; }
    public bool javaScriptWithScope { get; set; }
    public bool number { get; set; }
    public bool document { get; set; }
    public bool boolean { get; set; }
    public bool array { get; set; }
    public bool _null { get; set; }
}

  