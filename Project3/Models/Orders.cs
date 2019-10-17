using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Project3.Models
{
    public class Orders
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Row ID")]
        public int RowID { get; set; }

        [BsonElement("Order ID")]
        public string OrderID { get; set; }

        [BsonElement("Order Date")]
        public string OrderDate { get; set; }

        [BsonElement("Ship Date")]
        public string ShipDate { get; set; }

        [BsonElement("Ship Mode")]
        public string ShipMode { get; set; }

        [BsonElement("Customer ID")]
        public string CustomerID { get; set; }

        public string Segment { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        public string Market { get; set; }

        [BsonElement("Product ID")]
        public string ProductID { get; set; }

        public string Category { get; set; }

        [BsonElement("Sub-Category")]
        public string SubCategory { get; set; }

        [BsonElement("Product Name")]
        public string ProductName { get; set; }

        public string Sales { get; set; }

        public int Quantity { get; set; }

        public string Profit { get; set; }

        [BsonElement("Shipping Cost")]
        public double ShippingCost { get; set; }

        [BsonElement("Order Priority")]
        public string OrderPriority { get; set; }
    }
}
