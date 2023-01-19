using Newtonsoft.Json;
using System;
using System.IO;

namespace Model
{
    public class JSONSerializer<T> where T : class, new()
    {
        public string path;

        public JSONSerializer(string fileName)
        {
            path = ".\\" + fileName;
        }

        // - - - - - - - - - -

        public T DeSerialize()
        {
            T obj = new T();
            try
            {
                string jsonFile = File.ReadAllText(path + ".json");

                obj = JsonConvert.DeserializeObject<T>(jsonFile);
            }
            catch (Exception)
            {                
                return null;
            }
            return obj;
        }

        // - - - - - - - - - -

        public void Serialize(T objectName)
        {
            try
            {
                JsonSerializerSettings options = new JsonSerializerSettings();
                options.Formatting = Formatting.Indented;

                string json = JsonConvert.SerializeObject(objectName, options);

                File.WriteAllText(path + ".json", json);                                
            }
            catch (Exception)
            {
                throw new Exception("File inexistent.");
            }            
        }
    }
}
