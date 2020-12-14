using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        Dog GetById(int id);
        List<Dog> GetDogs();
        List<Dog> GetDogsByOwnerId(int ownerId);
    }
}