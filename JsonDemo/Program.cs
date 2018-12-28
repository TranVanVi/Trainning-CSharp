using JsonDemo.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            //Convert Json to Object
            List<AirLine> list = JsonConvert.DeserializeObject<List<AirLine>>(File.ReadAllText(@"../../Data/Airline.json"));
            //Read Object Convert to Json
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            Console.WriteLine(json);
            foreach (var item in list)
            {
                Console.WriteLine(item.AirLine_Code);
                Console.WriteLine(item.AirLine_Name);
            }
            Console.WriteLine("Client Change Status");
            Console.ReadKey();
        }
    }
}
