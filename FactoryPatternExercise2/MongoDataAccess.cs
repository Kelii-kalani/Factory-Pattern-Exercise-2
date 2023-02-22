using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo database");

            var product1 = new Product()
            {
                Name = "Xbox One",
                Price = 500
            };

            var product2 = new Product()
            {
                Name = "PS5",
                Price = 600
            };

            return new List<Product> { product1, product2 };
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database");
        }
    }
}
