using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDataAccess.Models
{
    internal class SubModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public string Id { get; set; }
        public string subtext { get; set; }

        public string bday {  get; set; }

        public UserModel? tothe {  get; set; }

        public DateTime? Lastday { get; set; } 
    }
}
