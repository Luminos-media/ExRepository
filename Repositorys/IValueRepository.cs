using Core.MongoDB.Repository.Interfaces;
using ExRepository.Models;

namespace ExRepository.Repositorys
{
    public interface IValueRepository:IMongoRepository<ValueModel>
    {
         
    }
}