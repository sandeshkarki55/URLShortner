﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Shortner.Domain.Entities;

public class BaseEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
}