using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Services;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CourseProject.Models
{
    public class Tour
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required]
        [MaxLength(70)]
        public string Title { get; set; }

        public List<string> Country { get; set; }

        public List<string> City { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "The Duration can't be less than 0")]
        public int? Duration { get; set; }

        [Required]
        [DateGreaterThanNow(ErrorMessage = "The Start date should be greater than now")]
        [DateGreaterThan("End", "Duration")]
        public DateTime? Start { get; set; }

        [Required]
        [DateGreaterThanNow(ErrorMessage = "The End date should be greater than now")]
        public DateTime? End { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "The Price can't be less than 0")]
        public int? Price { get; set; }

        public List<string> Accomodation { get; set; }

        [Required]
        [MaxLength(30)]
        public string TravelStyle { get; set; }

        public List<string> ExcursionsId {  get; set; }

        public List<string> AgenciesId { get; set; }
    }
}
