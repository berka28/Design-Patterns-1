using System;

namespace Repository
{
    public interface IDataRepository
    {
        public string GetAllData();

        public string GetAnimal();

        public string GetCustomer();

        public string GetData();
    }
}