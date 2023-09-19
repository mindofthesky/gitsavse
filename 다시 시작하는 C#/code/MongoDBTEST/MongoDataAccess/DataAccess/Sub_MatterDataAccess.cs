using MongoDataAccess.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDataAccess.DataAccess
{
    public class Sub_MatterDataAccess
    {
        private const string ConnectionString = "mongodb://127.0.0.1:27017";
        private const string databaseName = "submarin";
        private const string todaystudy = "study";  // ChroneCollection
        private const string UserCollection = "users"; // UserCollection
        private const string daystuding = "";

        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(databaseName);
            return db.GetCollection<T>(collection); 
        }
        private async Task<List<UserModel>> GetAllUser(UserModel user)
        {
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            var results = await usersCollection.FindAsync(_ => true);
            return results.ToList();
        }
        public async Task<List<To_Day_Study>> GetAlltodayFor()
        {
            var toDaystudy = ConnectToMongo<To_Day_Study>(todaystudy);
            var results = await toDaystudy.FindAsync(_ => true); 
            return results.ToList();
        } 
        public async Task<List<To_Day_Study>> GetAlltodayForAuser(UserModel user)
        {
            var Studingdays = ConnectToMongo<To_Day_Study>(todaystudy);
            var results = await Studingdays.FindAsync(c => c.whoStudy.id == user.id);
            return results.ToList();
        }

        public Task CreateUser(UserModel user)
        {
            var userCollection = ConnectToMongo<UserModel>(UserCollection);
            return userCollection.InsertManyAsync((IEnumerable<UserModel>)user);
        }

        public Task CreateStuding(To_Day_Study to_Day_Study) 
        {
            var todaycollection = ConnectToMongo<To_Day_Study>(todaystudy);
            return todaycollection.InsertManyAsync((IEnumerable<To_Day_Study>)to_Day_Study);
        }
        public Task Updatestudy(To_Day_Study to_Day_Study)
        {
            var todaycollection = ConnectToMongo<To_Day_Study>(todaystudy);
            var filter = Builders<To_Day_Study>.Filter.Eq(field: "Id", to_Day_Study.Id);
            return todaycollection.ReplaceOneAsync(filter, to_Day_Study, options: new ReplaceOptions { IsUpsert = true});
        }

        public Task DeleteStudy(To_Day_Study to_Day_Study)
        {
            var todaycollection = ConnectToMongo<To_Day_Study>(todaystudy);
            return todaycollection.DeleteOneAsync(c => c.Id == to_Day_Study.Id);
        }

    }
}
