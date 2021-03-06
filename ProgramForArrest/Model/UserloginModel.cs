﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ProgramForArrest.Model;
//
//    var userloginModel = UserloginModel.FromJson(jsonString);

namespace ProgramForArrest.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class UserloginModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("admincard")]
        public object Admincard { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("birthday")]
        public Birthday Birthday { get; set; }

        [JsonProperty("date")]
        public object Date { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public partial class Birthday
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("bsonType")]
        public string BsonType { get; set; }

        [JsonProperty("inc")]
        public long Inc { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("double")]
        public bool Double { get; set; }

        [JsonProperty("binary")]
        public bool Binary { get; set; }

        [JsonProperty("string")]
        public bool String { get; set; }

        [JsonProperty("int32")]
        public bool Int32 { get; set; }

        [JsonProperty("int64")]
        public bool Int64 { get; set; }

        [JsonProperty("decimal128")]
        public bool Decimal128 { get; set; }

        [JsonProperty("objectId")]
        public bool ObjectId { get; set; }

        [JsonProperty("dbpointer")]
        public bool Dbpointer { get; set; }

        [JsonProperty("timestamp")]
        public bool Timestamp { get; set; }

        [JsonProperty("dateTime")]
        public bool DateTime { get; set; }

        [JsonProperty("symbol")]
        public bool Symbol { get; set; }

        [JsonProperty("regularExpression")]
        public bool RegularExpression { get; set; }

        [JsonProperty("javaScript")]
        public bool JavaScript { get; set; }

        [JsonProperty("javaScriptWithScope")]
        public bool JavaScriptWithScope { get; set; }

        [JsonProperty("number")]
        public bool Number { get; set; }

        [JsonProperty("document")]
        public bool Document { get; set; }

        [JsonProperty("boolean")]
        public bool Boolean { get; set; }

        [JsonProperty("array")]
        public bool Array { get; set; }

        [JsonProperty("null")]
        public bool Null { get; set; }
    }

    public partial class UserloginModel
    {
        public static UserloginModel FromJson(string json) => JsonConvert.DeserializeObject<UserloginModel>(json, ProgramForArrest.Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this UserloginModel self) => JsonConvert.SerializeObject(self, ProgramForArrest.Model.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

