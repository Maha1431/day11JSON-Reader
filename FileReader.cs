using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace DAY11_JSON_READER
{
    public class FileReader
    {
        public List<Inventory> inventories = new List<Inventory>();

        public List<Inventory> GetInventry()
        {
            string text = File.ReadAllText("C:\\Users\\CSC\\source\repos\\DAY11 JSON READER\\DAY11 JSON READER\\Data.json");
            inventories = JsonConvert.DeserializeObject<List<Inventory>>(text);
            return inventories;
        }
    }
}
