using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CityInfo.Api.Models
{
    public class CityDto
    {
        public ObjectId Id
        {
            get;
            set;
        }

        [BsonElement("CityId")]
        public int CityId
        {
            get;
            set;
        }
        [BsonElement("CityName")]
        public string Name
        {
            get;
            set;
        }
        [BsonElement("Description")]
        public string Description
        {
            get;
            set;
        }
    }
}
