namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Which database would you like to use?");
            Console.WriteLine();
            Console.WriteLine("List, Sql, Mongo");
            string userInput = Console.ReadLine();

            IDataAccess storage = DataAccessFactory.GetDataAccess(userInput);
            
            storage.SaveData();
            var products = storage.LoadData();

            foreach ( var product in products )
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine();
            }
        }
    }
}
