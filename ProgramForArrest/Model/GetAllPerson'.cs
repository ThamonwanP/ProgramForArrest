
public class GetAllPerson
{
    public GetAllPerson_data[] Property1 { get; set; }
}

public class GetAllPerson_data
{
    public string id { get; set; }
    public object admincard { get; set; }
    public string card { get; set; }
    public string title { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }
    public object date { get; set; }
    public GetAllPerson_Birthday birthday { get; set; }
    public string phone { get; set; }
    public string address { get; set; }
    public string image_url { get; set; }
    public string group { get; set; }
    public string fid { get; set; }
    public object notes { get; set; }
}

public class GetAllPerson_Birthday
{
    public long value { get; set; }
    public int inc { get; set; }
    public string bsonType { get; set; }
    public int time { get; set; }
    public bool _double { get; set; }
    public bool binary { get; set; }
    public bool number { get; set; }
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
    public bool document { get; set; }
    public bool boolean { get; set; }
    public bool array { get; set; }
    public bool _null { get; set; }
}
