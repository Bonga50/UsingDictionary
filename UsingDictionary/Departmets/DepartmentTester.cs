namespace UsingDictionary.Departmets
{
    internal class DepartmentTester
    {
        static void Main(string[] args)
        {

            List<employees> list = new List<employees>() { };

            Dictionary<string, List<employees>> employees = new Dictionary<string, List<employees>>();

            using (StreamReader reader = new StreamReader("departments.txt.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] lines = line.Split(new char[] { ',' });
                    string dep = lines[0];
                    List<employees> names = new List<employees>();
                    for (int i = 1; i < lines.Length; i++)
                    {
                        names.Add(new employees(i, lines[i]) );
                    }

                    employees.Add(dep, names);

                }


            };








            //(emp number,department)
           //employees.Add("HR", new List<employees>() { new employees(3, "Ben"), new employees(4, "CarL"), new employees(3, "STAN") });
           //employees.Add("IT", new List<employees>() { new employees(5, "GETTY"), new employees(54, "Images"), new employees(33, "Basic") });
           //employees.Add("Finance", new List<employees>() { new employees(34, "Margit"), new employees(45, "Singlton"), new employees(63, "Sean") });

            char c = 'A';

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{c++} {employees.ElementAt(i).Key}");
                for (int j = 0; j < employees.ElementAt(i).Value.Count; j++)
                {
                    Console.WriteLine($"{employees.ElementAt(i).Value[j].empName} - {employees.ElementAt(i).Value[j].empNum}");
                }
                Console.WriteLine("");
            }


        }
    }
}
