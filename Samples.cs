using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
namespace Projects{
public class Samples
{
[BsonId]
public ObjectId _id {get;set;} 
public string  UserName { get; set; }
public string Email {get;set;}
public BsonDocument Key {get;set;}
public string Address {get;set;}

}

}