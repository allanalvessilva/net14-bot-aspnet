using MongoDB.Bson;
using SimpleBot.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SimpleBot.Util
{
    public static class MongoHelper
    {
        public static void SaveMessage(SimpleMessage message)
        {
            try
            {
                var connection = new MongoConnection();

                connection.messages.InsertOne(message);
            }
            catch (Exception ex)
            {

            }
        }
    }
}