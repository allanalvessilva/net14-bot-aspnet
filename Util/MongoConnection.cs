using MongoDB.Driver;
using SimpleBot.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Util
{
    public class MongoConnection
    {
        public const string STRING_DE_CONEXAO = "mongodb://localhost:27017";
        public const string NOME_DA_BASE = "Fiap";
        public const string COLECAO_MESSAGES = "Messages";
        public const string COLECAO_CONTADOR = "Acessos";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static MongoConnection()
        {
            _client = new MongoClient(STRING_DE_CONEXAO);
            _database = _client.GetDatabase(NOME_DA_BASE);
        }

        public IMongoClient client
        {
            get { return _client; }
        }

        public IMongoCollection<SimpleMessage> messages
        {
            get { return _database.GetCollection<SimpleMessage>(COLECAO_MESSAGES); }
        }

        public IMongoCollection<UserProfile> access
        {
            get { return _database.GetCollection<UserProfile>(COLECAO_CONTADOR); }
        }
    }
}