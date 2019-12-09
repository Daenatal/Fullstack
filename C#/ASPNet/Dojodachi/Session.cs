using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Dojodachi
{
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            //This helper function serializes the object as JSON and stores it as a string
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        //generic Type T is a stand in we have to specify the type on retrieval
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value= session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}