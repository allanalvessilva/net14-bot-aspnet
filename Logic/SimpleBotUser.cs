using MongoDB.Driver;
using SimpleBot.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Logic
{
    public class SimpleBotUser
    {
        public string Reply(SimpleMessage message)
        {
            string userId = message.Identification;

            var profile = GetProfile(userId);

            long contador = profile.Contador + 1;
            profile.Contador = contador;

            SetProfile(userId, profile);

            return $"{message.User} disse '{message.Text}";
        }

        void SetProfile(string userId, UserProfile profile)
        {
            var connection = new MongoConnection();

            var construtor = Builders<UserProfile>.Filter;
            var condicao = construtor.Eq(x => x.UserId, userId);

            //connection.access.UpdateOne(condicao, UpdateDefinition<UserProfile> { profile }, new UpdateOptions { IsUpsert = true });
        }

        UserProfile GetProfile(string userId)
        {
            var connection = new MongoConnection();

            var construtor = Builders<UserProfile>.Filter;
            var condicao = construtor.Eq(x => x.UserId, userId);

            var access = connection.access.Find(condicao).FirstOrDefault();

            return access;
        }

    }
}