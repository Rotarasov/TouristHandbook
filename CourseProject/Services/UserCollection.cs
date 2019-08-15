using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using MongoDB.Driver;

namespace CourseProject.Services
{
    public class UserCollection : IUserCollection
    {
        private readonly IMongoCollection<User> _users;


        public List<User> Users
        {
            get => _users.Find(_ => true).ToList();
        }

        public UserCollection(string conStr)
        {
            var client = new MongoClient(conStr);
            var database = client.GetDatabase("TouristHandbook");
            _users = database.GetCollection<User>("Users");
        }

        public void Add(User item)
        {
            _users.InsertOne(item);
        }

        public void Delete(User item)
        {
            _users.DeleteOne(x => x.Id == item.Id);
        }

        public void Update(User item)
        {
            _users.ReplaceOne(x => x.Id == item.Id, item);
        }
    }
}
