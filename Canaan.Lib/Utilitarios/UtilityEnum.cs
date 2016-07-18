using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Utilitarios
{
    public class UtilityEnum
    {
        public static IList<T> EnumToList<T>()
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T isn't an enumerated type");

            IList<T> list = new List<T>();
            Type type = typeof(T);

            if (type != null)
            {
                Array enumValues = Enum.GetValues(type);

                foreach (T value in enumValues)
                {
                    list.Add(value);
                }
            }

            return list;
        }

        public static Dictionary<T, string> GetItemsFromEnum<T>(T selectedValue = default(T)) where T : struct
        {
            var result = Enum.GetValues(typeof(T)).Cast<T>().ToDictionary(t => t, t => GetEnumDescription(t.ToString(), typeof(T)));
            return result;
        }


        public static string GetEnumDescription(string value, Type enumType)
        {
            var fi = enumType.GetField(value.ToString());
            var display = fi
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .OfType<DescriptionAttribute>()
                .FirstOrDefault();
            if (display != null)
            {
                return display.Description;
            }

            return value;
        }
    }
}
