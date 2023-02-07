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

        /// <summary>
        /// This constructor is a variant of the original one, which was designed for working on the app's root folder.
        /// This one will work instead with the path given through string.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="filler"></param>
        public JSONSerializer(string fileName, bool filler)
        {
            path = fileName;
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

        /// <summary>
        /// This method is a variant of the original one, which was designed for deserializing files on the app's root folder.
        /// This one looks for the path set instead. - Requires the object to have been instantiated with the filler version.
        /// </summary>
        /// <param name="filler"></param>
        /// <returns></returns>
        public T DeSerialize(bool filler)
        {
            T obj = new T();
            try
            {
                string jsonFile = File.ReadAllText(path);

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
