using Hjemlig2._0.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace Hjemlig2._0.Helpers
{
    public class JsonFileWriter
    {
        public static void WriteToJsonProducts(List<Products> products, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(products, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}
