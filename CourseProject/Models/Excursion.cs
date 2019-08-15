using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CourseProject.Models
{
    public class Excursion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required]
        [MaxLength(70)]
        public string Title { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "The Price can't be less than 0")]
        public int? Price { get; set; }

        public List<string> ToursId { get; set; }

        public Excursion() { }

        public Excursion(string id, string title, int price)
        {
            Id = id;
            Title = title;
            Price = price;
        }
    }
}
