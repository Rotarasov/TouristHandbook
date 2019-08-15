using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using MongoDB.Driver;

namespace CourseProject.Services
{
    public class AgencyCollection : IAgencyCollection
    {
        private readonly IMongoCollection<TravelAgency> _agencies;

        public List<TravelAgency> TravelAgencies
        {
            get => _agencies.Find(_ => true).ToList();
        }

        public AgencyCollection(string conStr)
        {
            var client = new MongoClient(conStr);
            var database = client.GetDatabase("TouristHandbook");
            _agencies = database.GetCollection<TravelAgency>("TravelAgencies");
        }

        public void Add(TravelAgency item)
        {
            _agencies.InsertOne(item);
        }

        public void Delete(TravelAgency item)
        {
            _agencies.DeleteOne(x => x.Id == item.Id);
        }

        public void Update(TravelAgency item)
        {
            _agencies.ReplaceOne(x => x.Id == item.Id, item);
        }
    }
}
