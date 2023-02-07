using Newtonsoft.Json;
using System;
using System.IO;

namespace Model
{
    public class JSONSerializer<T> where T : class, new()
    {
        public string path;
        int mode;

        public JSONSerializer(string fileName, int mode)
        {
            if(mode == 1)
            {
                path = ".\\" + fileName;
            }
            else
            {
                path = fileName;
            }
            
            this.mode = mode;
        }

        // - - - - - - - - - -

        public T DeSerialize()
        {
            T obj = new T();
            string jsonFile;
            try
            {
                if(mode == 1)
                {
                    jsonFile = File.ReadAllText(path + ".json");
                }
                else
                {
                    jsonFile = File.ReadAllText(path);
                }                

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
