using System.Collections.Generic;

public static class Extensions
{
    public static T GetByKey<K, T>(this Dictionary<K, T> dict, K k)
    {
        T t;
        if (!dict.TryGetValue(k, out t))
            return default(T);

        return t;
    }
}