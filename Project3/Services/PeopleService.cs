using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using Project3.Models;

namespace Project3.Services
{
    public class PeopleService
    {
        private readonly IMongoCollection<People> _people;

        public PeopleService(IConfiguration config)
        {
            //GEARHOST CONNECTION STRING mongodb://itrw324proj3:Fz2bg?_o0D15@den1.mongo1.gear.host:27001/itrw324proj3
            MongoClient client = new MongoClient(config.GetConnectionString("itrw324proj3"));
            IMongoDatabase database = client.GetDatabase("Project3Db"); //itrw324proj3
            _people = database.GetCollection<People>("People");
        }

        public List<People> Get()
        {
            return _people.Find(people => true).ToList();
        }

        public People Get(string id)
        {
            return _people.Find(people => people.Id == id).FirstOrDefault();
        }

        public People Create(People people)
        {
            _people.InsertOne(people);
            return people;
        }

        public void Update(string id, People peopleIn)
        {
            _people.ReplaceOne(people => people.Id == id, peopleIn);
        }

        public void Remove(People peopleIn)
        {
            _people.DeleteOne(people => people.Id == peopleIn.Id);
        }

        public void Remove(string id)
        {
            _people.DeleteOne(people => people.Id == id);
        }
    }
}
