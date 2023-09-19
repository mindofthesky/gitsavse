using MongoDB.Driver;
using MongoDBTEST;

string conectionString = "mongodb://127.0.0.1:27017";
string databasename = "test";
string collectionname = "test";
var client = new MongoClient(conectionString);
var db = client.GetDatabase(databasename);
var collection = db.GetCollection<MongoDBtes>(collectionname);

var person = new MongoDBtes { name = "안형진", job = "백수" };
// 몽고디비의 insert 
await collection.InsertOneAsync(person);

var results = await collection.FindAsync(_ => true);

foreach (var result in results.ToList())
{
    Console.WriteLine(value: $"{result.id} {result.name} {result.job}");
}