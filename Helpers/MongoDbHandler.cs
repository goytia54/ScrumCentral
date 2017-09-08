using System;
using System.Collections.Generic;
using ScrumCentral.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;

namespace ScrumCentral.Helpers
{
    public class MongoDbHandler
    {
        private static MongoDbHandler instance;
        private IMongoClient _client;
        private IMongoDatabase _database;
        private static string db = "mongodb://localhost:27017";
        public static MongoDbHandler Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new MongoDbHandler();
                }
                return instance;
            }
        }

        public void InsertPokerSession(PokerSession session)
        {
            _client = new MongoClient(db);
            _database = _client.GetDatabase("local");
            var collection = _database.GetCollection<PokerSession>("test");
            collection.InsertOne(session);
        }


        


    }

}