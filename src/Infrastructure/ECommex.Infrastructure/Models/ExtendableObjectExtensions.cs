using ECommex.Infrastructure.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommex.Infrastructure.Models
{
    public static class ExtendableObjectExtensions
    {
        public static T GetData<T>(this IExtendableObject extendableObject, string name, bool handleType = false)
        {
            CheckNotNull(extendableObject, name);
            if (extendableObject == null)
            {
                throw new ArgumentNullException(nameof(extendableObject));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            return extendableObject.GetData<T>(
                name,
                handleType
                    ? new JsonSerializer { TypeNameHandling = TypeNameHandling.All }
                    : JsonSerializer.CreateDefault()
            );


        }

        public static T GetData<T>(this IExtendableObject extendableObject, string name, JsonSerializer jsonSerializer)
        {
            CheckNotNull(extendableObject, name);
            if (extendableObject.ExtensionData == null)
            {
                return default(T);
            }
            var json = JObject.Parse(extendableObject.ExtensionData);

            var prop = json[name];

            if (prop == null)
            {
                return default(T);
            }

            if (TypeHelper.IsPrimitiveExtendedIncludingNullable(typeof(T)))
            {
                return prop.Value<T>();
            }
            else
            {
                return (T)prop.ToObject(typeof(T), jsonSerializer ?? JsonSerializer.CreateDefault());
            }
        }

        public static void SetData<T>(this IExtendableObject extendableObject, string name, T value, bool handleType = false)
        {
            extendableObject.SetData(
                name,
                value,
                handleType
                    ? new JsonSerializer { TypeNameHandling = TypeNameHandling.All }
                    : JsonSerializer.CreateDefault()
            );
        }

        public static void SetData<T>(this IExtendableObject extendableObject, string name, T value, JsonSerializer jsonSerializer)
        {
            //line72
        }
        
        
        
        private static void CheckNotNull(IExtendableObject extendableObject, string name)
        {
            throw new NotImplementedException();
        }
    }
}
