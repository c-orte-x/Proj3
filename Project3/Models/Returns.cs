using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Project3.Models
{
    public class Returns
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Returned { get; set; }

        [BsonElement("Order ID")]
        public string OrderID { get; set; }

        public string Region { get; set; }
    }
}
