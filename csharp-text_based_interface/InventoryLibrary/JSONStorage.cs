using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        // The dictionary to store objects
        public Dictionary<string, BaseClass> Objects { get; set; }

        // The file path to the JSON file
        private string FilePath { get; set; }

        public JSONStorage()
        {
            Objects = new Dictionary<string, BaseClass>();
            FilePath = Path.Combine("storage", "inventory_manager.json");
        }

        // Method to return the objects dictionary
        public Dictionary<string, BaseClass> All() 
        {
            return Objects;
        }

        // Method to add a new object
        public void New(BaseClass obj) 
        {
            Objects.Add($"{obj.GetType().Name}.{obj.Id}", obj);
        }

        // Method to serialize objects to JSON and save to the file
        public void Save() 
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
            string json = JsonConvert.SerializeObject(Objects);
            File.WriteAllText(FilePath, json);
        }

        // Method to deserialize the JSON file to objects
        public void Load() 
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                Objects = JsonConvert.DeserializeObject<Dictionary<string, BaseClass>>(json);
            }
        }
    }
}