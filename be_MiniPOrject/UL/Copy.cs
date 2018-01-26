using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UL
{
    public static class Copy
    {
        public static T GetCopy<T>(this T source) where T : new()
        {
            T result = new T();
            foreach (PropertyInfo item in source.GetType().GetProperties())
            {
                try
                {
                    if (item.CanWrite && item.CanRead)
                    {
                        object srcValue = item.GetValue(source, null);
                        item.SetValue(result, srcValue);
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine($" --->> Error copy property {item.Name} from {source.GetType().Name}\n{e.Message}");
                }
            }
            return result;
        }
    }
}
