using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class ListDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List database");

            var product1 = new Product()
            {
                Name = "Macbook Pro",
                Price = 1300
            };

            var product2 = new Product()
            {
                Name = "Dell Inspiron",
                Price = 1250
            };

            return new List<Product>() { product1, product2 };
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List database");
        }
    }
}
