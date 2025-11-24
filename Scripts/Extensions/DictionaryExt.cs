using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace KoganeUnityLib.DictionaryExt
{
    /// <summary>
    ///     Dictionary 型の拡張メソッドを管理するクラス
    /// </summary>
    public static class DictionaryExt
    {
        /// <summary>
        ///     Hashtable に変換します
        /// </summary>
        public static Hashtable ToHashtable<TKey, TValue>(this Dictionary<TKey, TValue> self)
        {
            var result = new Hashtable();
            foreach (KeyValuePair<TKey, TValue> n in self) result[n.Key] = n.Value;
            return result;
        }

        /// <summary>
        ///     ランダムに値を返します
        /// </summary>
        public static TValue ElementAtRandom<TKey, TValue>(this Dictionary<TKey, TValue> self)
        {
            return self.ElementAt(Random.Range(0, self.Count)).Value;
        }
    }
}
