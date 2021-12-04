using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataRepository : IDataRepository
    {
        public string GetAllData()
        {
            var data = SimulatedDatabase.Load("Dataset A");
            var customer = SimulatedDatabase.Load("From Table Customer Where Name==Steve");
            var animal = SimulatedDatabase.Load("From Table Animal Where Owner==Steve");
            SimulatedDatabase.Save(data);
            SimulatedDatabase.Save(customer);
            SimulatedDatabase.Save(animal);
            return data;
        }

        public string GetAnimal()
        {
            var animal = SimulatedDatabase.Load("From Table Animal Where Owner==Steve");
            SimulatedDatabase.Save(animal);
            return animal;
        }

        public string GetData()
        {
            var data = SimulatedDatabase.Load("Dataset A");
            SimulatedDatabase.Save(data);
            return data;
        }

        public string GetCustomer()
        {
            var customer = SimulatedDatabase.Load("From Table Customer Where Name==Steve");
            SimulatedDatabase.Save(customer);
            return customer;
        }
    }
}
