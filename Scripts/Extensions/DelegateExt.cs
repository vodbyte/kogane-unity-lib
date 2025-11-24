using System;
using System.Reflection;

namespace KoganeUnityLib.DelegateExt
{
    public static class DelegateExt
    {
        public static int GetLength<T>(string name)
        {
            return GetLength(typeof(T), name);
        }

        public static int GetLength(this Type self, string name)
        {
            var attrs = BindingFlags.GetField | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public;
            var field = self.GetField(name, attrs);
            if (field == null)
            {
                throw new ArgumentException($"name is invalid parameter: {name}");
            }
            if (field.GetValue(null) is not Delegate d) return 0;
            Delegate[] list = d.GetInvocationList();
            var length = list.Length;
            return length;
        }
    }
}
