namespace GenericsDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize a dictionary
            // 2 Generics... string & int
            Dictionary<string, int> ages = new Dictionary<string, int>();

            // Add items to the dictionary
            ages.Add("John", 25);
            ages.Add("Emily", 30);
            ages.Add("Michael", 35);

            // Access values using keys
            int johnsAge = ages["John"];
            Console.WriteLine("John's age: " + johnsAge);

            // Check if a key exists
            if (ages.ContainsKey("Emily"))
            {
                Console.WriteLine("Emily's age: " + ages["Emily"]);
            }

            // Modify the value of an existing key
            ages["Michael"] = 40;

            // Remove an item from the dictionary
            ages.Remove("John");

            // Iterate over the dictionary
            foreach (KeyValuePair<string, int> kvp in ages)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
        }
    }
}