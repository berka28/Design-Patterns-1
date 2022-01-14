using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SimulatedDatabase : IDataRepository
    {
        public string Load(string v)
        {
            return v;
        }

        public string GetAnimal()
        {
            var animal = Load("From Table Animal Where Owner == Steve");
            return animal;
        }

        public string GetCustomer()
        {
            var customer = Load("From Table Customer Where Name == Steve");
            return customer;
        }

        public string GetData()
        {
            var data = Load("Dataset A");
            return data;
        }

        public void Save(string data)
        {
            Console.WriteLine($"Saving data \"{data}\"");
        }
    }


}
