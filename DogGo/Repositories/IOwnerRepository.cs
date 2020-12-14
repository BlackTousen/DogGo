using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using DogGo.Models;
using Microsoft.Data.SqlClient;


namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetOwners();
        Owner GetById(int id);
        void AddOwner(Owner owner);
        void DeleteOwner(int id);
        void UpdateOwner(Owner owner);
    }
}