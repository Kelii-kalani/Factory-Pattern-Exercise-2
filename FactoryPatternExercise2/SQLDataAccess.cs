using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL database");

            var product1 = new Product()
            {
                Name = "IPhone",
                Price = 800
            };

            var product2 = new Product()
            {
                Name = "Galaxy Phone",
                Price = 700
            };

            return new List<Product> { product1, product2 };
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }
    }
}
