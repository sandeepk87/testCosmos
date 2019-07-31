using System;
using System.Security.Authentication;
using MongoDB.Driver;

namespace Projects{
public class MongoDbContext
{
private IMongoDatabase _database;
private IMongoClient _client;
public MongoDbContext()
{
string connectionString = 
  @"mongodb://test-cosmossan:PG9Zl3EvS8jkQetVsGChfjIZFMvgh9fSFYGaGzRgGMsmwoK7XVlIFoeBQDVmuCY4LrqaDbyDE0zIVz5exdsX4g==@test-cosmossan.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";

MongoClientSettings settings = MongoClientSettings.FromUrl(
  new MongoUrl(connectionString)
);
settings.SslSettings = 
  new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
var mongoClient = new MongoClient(settings);
_client=mongoClient;
_database=_client.GetDatabase("TestDb");


}

public IMongoCollection<T> GetCollection<T>(string name)
{

return _database.GetCollection<T>(name);
}
}
}