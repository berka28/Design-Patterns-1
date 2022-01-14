using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataRepository : IDataRepository
    {
        public SimulatedDatabase db { get; set; }

        public DataRepository()
        {
            db = new SimulatedDatabase();
        }
        public string GetAnimal()
        {
            return db.GetAnimal();
        }

        public string GetCustomer()
        {
            return db.GetCustomer();
        }

        public string GetData()
        {
            return db.GetData();
        }

        public string Load(string v)
        {
            return db.Load(v);
        }

        public void Save(string data)
        {
            db.Save(data);
        }
    }
}
