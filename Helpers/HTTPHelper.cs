using System;
using System.Collections.Generic;
using ScrumCentral.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace ScrumCentral.Helpers
{
    public class HTTPHelper
    {
        private static HTTPHelper instance;
        private static MongoDbHandler dbHandler = MongoDbHandler.Instance;
        
        public static HTTPHelper Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new HTTPHelper();
                }
                return instance;
            }
        }

        public void CreatePokerSession(string sessionName)
        {
            PokerSession newPokerSession = new PokerSession() {Name = sessionName};
            dbHandler.InsertPokerSession(newPokerSession);
        }

        public PokerSession GetCurrentSession(string sessionName)
        {
            PokerSession pokerSession = dbHandler.GetPokerSession(sessionName);
            return pokerSession;
        }
    }

}