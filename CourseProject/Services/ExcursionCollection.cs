using CourseProject.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    public class ExcursionCollection : IExcursionCollection
    {
        private readonly IMongoCollection<Excursion> _excursions;

        public List<Excursion> Excursions
        {
            get => _excursions.Find(_ => true).ToList();
        }

        public ExcursionCollection(string conStr)
        {
            var client = new MongoClient(conStr);
            var database = client.GetDatabase("TouristHandbook");
            _excursions = database.GetCollection<Excursion>("Excursions");
        }

        public void Add(Excursion item)
        {
            _excursions.InsertOne(item);
        }

        public void Delete(Excursion item)
        {
            _excursions.DeleteOne(x => x.Id == item.Id);
        }

        public void Update(Excursion item)
        {
            _excursions.ReplaceOne(x => x.Id == item.Id, item);
        }
    }
}
