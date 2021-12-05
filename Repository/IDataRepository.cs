using System;

namespace Repository
{
    public interface IDataRepository
    {
        public string GetAnimal();

        public string GetCustomer();

        public string GetData();

        public void Save(string data);

        public string Load(string v);
    }
}