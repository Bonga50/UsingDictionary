using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDictionary.CamparingDictionaries
{
    internal class CompDictTester
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> areaCodes = new Dictionary<string, string>();
            Dictionary<string, string> userAreaCodes = new Dictionary<string, string>();


            areaCodes.Add("001", "Joburg");
            areaCodes.Add("031", "Durban");
            areaCodes.Add("014", "Rustenburg");
            areaCodes.Add("021", "Cape Town");
            areaCodes.Add("018", "Pochestroom");
            areaCodes.Add("008", "Pretoria");


            userAreaCodes.Add("014", "Rustenburg");
            userAreaCodes.Add("001", "Joburg");
            userAreaCodes.Add("031", "KZN");
            userAreaCodes.Add("021", "Cape Town");
            userAreaCodes.Add("018", "Pochestroom");
            userAreaCodes.Add("005", "Pretoria");

            Random random = new Random();
            areaCodes = areaCodes.OrderBy(x => random.Next()).ToDictionary(codes => codes.Key,codes => codes.Value) ;
            Display(areaCodes);
            int count = 0;
            foreach (KeyValuePair<string,string> codes in areaCodes)
            {
                if (userAreaCodes.TryGetValue(codes.Key,out string area))
                {
                    if (codes.Value.Equals(area))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);


        }

        public static void Display(Dictionary<string,string> codes) {
            foreach (var item in codes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
