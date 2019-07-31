using System;
using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json.Linq;
namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var context=new MongoDbContext();
            JObject tObject=new JObject();
            tObject["value"]="husband";
            tObject["age"]="32";

            var collection=context.GetCollection<Samples>("Samples");
            var sample=new Samples()
            {
                Email="Sample2@xmila.com",
                UserName="SampleUser",
                Address="Europe",
                Key=MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(tObject.ToString())
            };
            collection.InsertOne(sample);
            var results=collection.FindSync(a=>a.Address=="Europe").ToList();
 
        }   
    }
}
