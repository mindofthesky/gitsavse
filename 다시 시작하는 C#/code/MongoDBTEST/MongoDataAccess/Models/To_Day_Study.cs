using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDataAccess.Models
{
    internal class To_Day_Study
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public string Id { get; set; }
        public string Subject_Matter { get; set; }

        public string Subject_Matter2 { get; set; }
        public DateTime DateDay { get; set; }
        public UserModel whoStudy { get; set; } // AssigndTo 
        public To_Day_Study() { 
        }
        public To_Day_Study(SubModel subModel)
        {
            Subject_Matter = subModel.Id;
            DateDay = subModel.Lastday ?? DateTime.Now;
            whoStudy = subModel.tothe;
            Subject_Matter = subModel.subtext;
        }
    }
}
