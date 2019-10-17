using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using Project3.Models;

namespace Project3.Services
{
    public class OrdersService
    {
        private readonly IMongoCollection<Orders> _orders;

        public OrdersService(IConfiguration config)
        {
            //GEARHOST CONNECTION STRING mongodb://itrw324proj3:Fz2bg?_o0D15@den1.mongo1.gear.host:27001/itrw324proj3
            MongoClient client = new MongoClient(config.GetConnectionString("itrw324proj3")); 
            IMongoDatabase database = client.GetDatabase("Project3Db"); //itrw324proj3
            _orders = database.GetCollection<Orders>("Orders");
        }

        public List<Orders> Get()
        {
            return _orders.Find(orders => true).ToList();
        }

        public Orders Get(string id)
        {
            return _orders.Find(orders => orders.Id == id).FirstOrDefault();
        }

        public Orders Create(Orders orders)
        {
            _orders.InsertOne(orders);
            return orders;
        }

        public void Update(string id, Orders ordersIn)
        {
            _orders.ReplaceOne(orders => orders.Id == id, ordersIn);
        }

        public void Remove(Orders ordersIn)
        {
            _orders.DeleteOne(orders => orders.Id == ordersIn.Id);
        }

        public void Remove(string id)
        {
            _orders.DeleteOne(orders => orders.Id == id);
        }
    }
}
