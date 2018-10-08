using Core.MongoDB.Repository;
using Core.MongoDB.Repository.Interfaces;
using ExRepository.Models;

namespace ExRepository.Repositorys {
    public class ValueRepository : MongoRepository<ValueModel>, IValueRepository {
        public ValueRepository (IMongoContext mongoContext) : base (mongoContext) {

        }
    }
}