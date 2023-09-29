namespace UsingDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<int,string> numbers = new Dictionary<int,string>();

            numbers.Add(4, "Four");
            numbers.Add(7, "Seven");
            numbers.Add(1, "One");
            numbers.Add(9,"Nine");

            Console.WriteLine(numbers[4]);
            //update
            numbers[1] = "Wan";
            Console.WriteLine(numbers[1]);
            numbers[10] = "ten";

            Console.WriteLine(numbers.ElementAt(3));


            if (numbers.TryGetValue(11,out string value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("key is hidden");
            }
            foreach (KeyValuePair<int,string> item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }
    }
}