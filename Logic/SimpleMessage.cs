using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Logic
{
    public class SimpleMessage
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Identification { get; set; }
        public string User { get; set; }
        public string Text { get; set; }

        public SimpleMessage(string id, string username, string text)
        {
            this.Identification = id;
            this.User = username;
            this.Text = text;
        }
    }
}