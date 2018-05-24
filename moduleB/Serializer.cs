using System;
using Newtonsoft.Json;

namespace moduleB
{
    public class Serializer
    {
        public string Serialize(int value)
        {
            return JsonConvert.SerializeObject(value);
        }
        
        public int Deserialize(string value)
        {
            return JsonConvert.DeserializeObject<int>(value);
        }
    }
}