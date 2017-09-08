using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace ScrumCentral.Models
{
    public class PokerSession
    {
        public string Name {get; set;}
        public ObjectId Id {get; set;}
        public int TotalCount {get; set;}
        public float Average {get; set;}
        public int NumberOfVotes {get; set;}
        public List<string> Users {get; set;}
    }

}