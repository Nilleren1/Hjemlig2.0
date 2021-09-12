using Hjemlig2._0.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hjemlig2._0.Helpers
{
    public class JsonFileReader
    {
        public static List<Products> ReadJsonProducts(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonSerializer.Deserialize<List<Products>>(jsonString);
        }
    }
}
