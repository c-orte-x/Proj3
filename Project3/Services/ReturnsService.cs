using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using Project3.Models;

namespace Project3.Services
{
    public class ReturnsService
    {
        private readonly IMongoCollection<Returns> _returns;

        public ReturnsService(IConfiguration config)
        {
            //GEARHOST CONNECTION STRING mongodb://itrw324proj3:Fz2bg?_o0D15@den1.mongo1.gear.host:27001/itrw324proj3
            MongoClient client = new MongoClient(config.GetConnectionString("itrw324proj3"));
            IMongoDatabase database = client.GetDatabase("Project3Db"); //itrw324proj3
            _returns = database.GetCollection<Returns>("Returns");
        }

        public List<Returns> Get()
        {
            return _returns.Find(returns => true).ToList();
        }

        public Returns Get(string id)
        {
            return _returns.Find(returns => returns.Id == id).FirstOrDefault();
        }

        public Returns Create(Returns returns)
        {
            _returns.InsertOne(returns);
            return returns;
        }

        public void Update(string id, Returns returnsIn)
        {
            _returns.ReplaceOne(returns => returns.Id == id, returnsIn);
        }

        public void Remove(Returns returnsIn)
        {
            _returns.DeleteOne(returns => returns.Id == returnsIn.Id);
        }

        public void Remove(string id)
        {
            _returns.DeleteOne(returns => returns.Id == id);
        }
    }
}
