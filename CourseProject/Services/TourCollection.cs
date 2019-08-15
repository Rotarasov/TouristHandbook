using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using MongoDB.Driver;

namespace CourseProject.Services
{
    public class TourCollection : ITourCollection
    {
        private readonly IMongoCollection<Tour> _tours;

        public List<Tour> Tours
        {
            get => _tours.Find(_ => true).ToList();
        }

        public TourCollection(string conStr)
        {
            var client = new MongoClient(conStr);
            var database = client.GetDatabase("TouristHandbook");
            _tours = database.GetCollection<Tour>("Tours");
        }

        public void Add(Tour item)
        {
            _tours.InsertOne(item);
        }

        public void Delete(Tour item)
        {
            _tours.DeleteOne(x => x.Id == item.Id);
        }

        public void Update(Tour item)
        {
            _tours.ReplaceOne(x => x.Id == item.Id, item);
        }

    }
}
