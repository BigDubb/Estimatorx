using System;
using Estimatorx.Core.Security;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Estimatorx.Data.Mongo.Mapping
{
    public class RoleMap : BsonClassMap<Role>
    {
        public RoleMap()
        {
            MapIdProperty(c => c.Id)
                .SetRepresentation(BsonType.String)
                .SetIdGenerator(StringObjectIdGenerator.Instance);

            MapProperty(c => c.Name)
                .SetElementName("nm")
                .SetIgnoreIfNull(true);
        }
    }
}