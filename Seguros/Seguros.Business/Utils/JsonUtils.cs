using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Business.Utils
{
    public static class JsonUtils
    {
        public static T DeserealizeJson<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string SerealizeIntoJson<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
