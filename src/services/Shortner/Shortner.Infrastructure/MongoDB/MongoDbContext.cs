﻿using Microsoft.Extensions.Options;

using MongoDB.Driver;

using Shortner.Application.Interface;
using Shortner.Domain.Entities;

namespace Shortner.Infrastructure.MongoDB;

public class MongoDbContext : IURLShortnerContext
{
    private readonly IMongoDatabase _mongoDatabase;

    public MongoDbContext(IMongoClient mongoClient, IOptions<MongoSettings> options)
    {
        _mongoDatabase = mongoClient.GetDatabase(options.Value.DatabaseName);

        CustomURLs = GetMongoCollection<CustomURL>(options.Value.CustomURLCollectionName);
    }

    public IMongoCollection<CustomURL> CustomURLs { get; set; }

    private IMongoCollection<T> GetMongoCollection<T>(string collectionName)
    {
        return _mongoDatabase.GetCollection<T>(collectionName);
    }
}