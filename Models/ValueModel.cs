using System;
using Core.MongoDB.Repository;
using Core.MongoDB.Repository.Attributes;

namespace ExRepository.Models
{
    [CollectionName("Values")]
    public class ValueModel : MongoEntity
    {
        public string  Value1 { get; set; }     
        public string Value2 { get; set; }
        public DateTime CreateOn { get; set; } = DateTime.Now;
    }
}