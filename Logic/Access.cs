using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Logic
{
    public class Access
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string User { get; set; }
        public long Count { get; set; }
    }
}