using System;

namespace KoganeUnityLib.StringParseExt
{
    /// <summary>
    ///     StringParse 型の拡張メソッドを管理するクラス
    /// </summary>
    public static class StringParseExt
    {
        /// <summary>
        ///     sbyte型に変換します
        /// </summary>
        public static sbyte ToSByte(this string s)
        {
            return sbyte.Parse(s);
        }

        /// <summary>
        ///     sbyte型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static sbyte? ToSByteOrNull(this string s)
        {
            if (sbyte.TryParse(s, out sbyte result)) return result;
            return null;
        }

        /// <summary>
        ///     sbyte型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static sbyte ToSByteOrDefault(this string s, sbyte defaultValue = 0)
        {
            if (sbyte.TryParse(s, out sbyte result)) return result;
            return defaultValue;
        }

        /// <summary>
        ///     sbyte型に変換可能かを返します
        /// </summary>
        public static bool IsSByte(this string s)
        {
            sbyte result;
            return sbyte.TryParse(s, out result);
        }

        /// <summary>
        ///     byte型に変換します
        /// </summary>
        public static byte ToByte(this string s)
        {
            return byte.Parse(s);
        }

        /// <summary>
        ///     byte型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static byte? ToByteOrNull(this string s)
        {
            if (byte.TryParse(s, out byte result)) return result;
            return null;
        }

        /// <summary>
        ///     byte型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static byte ToByteOrDefault(this string s, byte defaultValue = 0)
        {
            return byte.TryParse(s, out byte result) ? result : defaultValue;
        }

        /// <summary>
        ///     byte型に変換可能かを返します
        /// </summary>
        public static bool IsByte(this string s)
        {
            byte result;
            return byte.TryParse(s, out result);
        }

        /// <summary>
        ///     char型に変換します
        /// </summary>
        public static char ToChar(this string s)
        {
            return char.Parse(s);
        }

        /// <summary>
        ///     char型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static char? ToCharOrNull(this string s)
        {
            if (char.TryParse(s, out char result)) return result;
            return null;
        }

        /// <summary>
        ///     char型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static char ToCharOrDefault(this string s, char defaultValue = '\0')
        {
            return char.TryParse(s, out char result) ? result : defaultValue;
        }

        /// <summary>
        ///     char型に変換可能かを返します
        /// </summary>
        public static bool IsChar(this string s)
        {
            char result;
            return char.TryParse(s, out result);
        }

        /// <summary>
        ///     short型に変換します
        /// </summary>
        public static short ToShort(this string s)
        {
            return short.Parse(s);
        }

        /// <summary>
        ///     short型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static short? ToShortOrNull(this string s)
        {
            if (short.TryParse(s, out short result)) return result;
            return null;
        }

        /// <summary>
        ///     short型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static short ToShortOrDefault(this string s, short defaultValue = 0)
        {
            return short.TryParse(s, out short result) ? result : defaultValue;
        }

        /// <summary>
        ///     short型に変換可能かを返します
        /// </summary>
        public static bool IsShort(this string s)
        {
            short result;
            return short.TryParse(s, out result);
        }

        /// <summary>
        ///     ushort型に変換します
        /// </summary>
        public static ushort ToUShort(this string s)
        {
            return ushort.Parse(s);
        }

        /// <summary>
        ///     ushort型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static ushort? ToUShortOrNull(this string s)
        {
            if (ushort.TryParse(s, out ushort result)) return result;
            return null;
        }

        /// <summary>
        ///     ushort型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static ushort ToUShortOrDefault(this string s, ushort defaultValue = 0)
        {
            return ushort.TryParse(s, out ushort result) ? result : defaultValue;
        }

        /// <summary>
        ///     ushort型に変換可能かを返します
        /// </summary>
        public static bool IsUShort(this string s)
        {
            return ushort.TryParse(s, out ushort _);
        }

        /// <summary>
        ///     int型に変換します
        /// </summary>
        public static int ToInt(this string s)
        {
            return int.Parse(s);
        }

        /// <summary>
        ///     int型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static int? ToIntOrNull(this string s)
        {
            if (int.TryParse(s, out int result)) return result;
            return null;
        }

        /// <summary>
        ///     int型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static int ToIntOrDefault(this string s, int defaultValue = 0)
        {
            return int.TryParse(s, out int result) ? result : defaultValue;
        }

        /// <summary>
        ///     int型に変換可能かを返します
        /// </summary>
        public static bool IsInt(this string s)
        {
            int result;
            return int.TryParse(s, out result);
        }

        /// <summary>
        ///     uint型に変換します
        /// </summary>
        public static uint ToUInt(this string s)
        {
            return uint.Parse(s);
        }

        /// <summary>
        ///     uint型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static uint? ToUIntOrNull(this string s)
        {
            if (uint.TryParse(s, out uint result)) return result;
            return null;
        }

        /// <summary>
        ///     uint型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static uint ToUIntOrDefault(this string s, uint defaultValue = 0)
        {
            return uint.TryParse(s, out uint result) ? result : defaultValue;
        }

        /// <summary>
        ///     uint型に変換可能かを返します
        /// </summary>
        public static bool IsUInt(this string s)
        {
            uint result;
            return uint.TryParse(s, out result);
        }

        /// <summary>
        ///     long型に変換します
        /// </summary>
        public static long ToLong(this string s)
        {
            return long.Parse(s);
        }

        /// <summary>
        ///     long型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static long? ToLongOrNull(this string s)
        {
            if (long.TryParse(s, out long result)) return result;
            return null;
        }

        /// <summary>
        ///     long型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static long ToLongOrDefault(this string s, long defaultValue = 0)
        {
            return long.TryParse(s, out long result) ? result : defaultValue;
        }

        /// <summary>
        ///     long型に変換可能かを返します
        /// </summary>
        public static bool IsLong(this string s)
        {
            long result;
            return long.TryParse(s, out result);
        }

        /// <summary>
        ///     ulong型に変換します
        /// </summary>
        public static ulong ToULong(this string s)
        {
            return ulong.Parse(s);
        }

        /// <summary>
        ///     ulong型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static ulong? ToULongOrNull(this string s)
        {
            if (ulong.TryParse(s, out ulong result)) return result;
            return null;
        }

        /// <summary>
        ///     ulong型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static ulong ToULongOrDefault(this string s, ulong defaultValue = 0)
        {
            return ulong.TryParse(s, out ulong result) ? result : defaultValue;
        }

        /// <summary>
        ///     ulong型に変換可能かを返します
        /// </summary>
        public static bool IsULong(this string s)
        {
            ulong result;
            return ulong.TryParse(s, out result);
        }

        /// <summary>
        ///     float型に変換します
        /// </summary>
        public static float ToFloat(this string s)
        {
            return float.Parse(s);
        }

        /// <summary>
        ///     float型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static float? ToFloatOrNull(this string s)
        {
            if (float.TryParse(s, out float result)) return result;
            return null;
        }

        /// <summary>
        ///     float型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static float ToFloatOrDefault(this string s, float defaultValue = 0)
        {
            return float.TryParse(s, out float result) ? result : defaultValue;
        }

        /// <summary>
        ///     float型に変換可能かを返します
        /// </summary>
        public static bool IsFloat(this string s)
        {
            return float.TryParse(s, out float _);
        }

        /// <summary>
        ///     double型に変換します
        /// </summary>
        public static double ToDouble(this string s)
        {
            return double.Parse(s);
        }

        /// <summary>
        ///     double型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static double? ToDoubleOrNull(this string s)
        {
            if (double.TryParse(s, out double result)) return result;
            return null;
        }

        /// <summary>
        ///     double型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static double ToDoubleOrDefault(this string s, double defaultValue = 0)
        {
            return double.TryParse(s, out double result) ? result : defaultValue;
        }

        /// <summary>
        ///     double型に変換可能かを返します
        /// </summary>
        public static bool IsDouble(this string s)
        {
            return double.TryParse(s, out double _);
        }

        /// <summary>
        ///     decimal型に変換します
        /// </summary>
        public static decimal ToDecimal(this string s)
        {
            return decimal.Parse(s);
        }

        /// <summary>
        ///     decimal型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static decimal? ToDecimalOrNull(this string s)
        {
            if (decimal.TryParse(s, out decimal result)) return result;
            return null;
        }

        /// <summary>
        ///     decimal型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static decimal ToDecimalOrDefault(this string s, decimal defaultValue = 0)
        {
            return decimal.TryParse(s, out decimal result) ? result : defaultValue;
        }

        /// <summary>
        ///     decimal型に変換可能かを返します
        /// </summary>
        public static bool IsDecimal(this string s)
        {
            return decimal.TryParse(s, out decimal _);
        }

        /// <summary>
        ///     DateTime型に変換します
        /// </summary>
        public static DateTime ToDateTime(this string s)
        {
            return DateTime.Parse(s);
        }

        /// <summary>
        ///     DateTime型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static DateTime? ToDateTimeOrNull(this string s)
        {
            if (DateTime.TryParse(s, out DateTime result)) return result;
            return null;
        }

        /// <summary>
        ///     DateTime型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static DateTime ToDateTimeOrDefault(this string s, DateTime defaultValue = default)
        {
            return DateTime.TryParse(s, out DateTime result) ? result : defaultValue;
        }

        /// <summary>
        ///     DateTime型に変換可能かを返します
        /// </summary>
        public static bool IsDateTime(this string s)
        {
            return DateTime.TryParse(s, out DateTime _);
        }

        /// <summary>
        ///     bool型に変換します
        /// </summary>
        public static bool ToBoolean(this string s)
        {
            return bool.Parse(s);
        }

        /// <summary>
        ///     bool型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static bool? ToBooleanOrNull(this string s)
        {
            if (bool.TryParse(s, out bool result)) return result;
            return null;
        }

        /// <summary>
        ///     bool型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static bool ToBooleanOrDefault(this string s, bool defaultValue = false)
        {
            return bool.TryParse(s, out bool result) ? result : defaultValue;
        }

        /// <summary>
        ///     bool型に変換可能かを返します
        /// </summary>
        public static bool IsBoolean(this string s)
        {
            bool result;
            return bool.TryParse(s, out result);
        }

        /// <summary>
        ///     enum型に変換します
        /// </summary>
        public static T ToEnum<T>(this string s) where T : struct
        {
            return EnumUtils.Parse<T>(s);
        }

        /// <summary>
        ///     enum型に変換します
        ///     変換に失敗した場合は null を返します
        /// </summary>
        public static T? ToEnumOrNull<T>(this string s) where T : struct
        {
            if (EnumUtils.TryParse(s, out T result)) return result;
            return null;
        }

        /// <summary>
        ///     enum型に変換します
        ///     変換に失敗した場合は defaultValue を返します
        /// </summary>
        public static T ToEnumOrDefault<T>(this string s, T defaultValue = default) where T : struct
        {
            return EnumUtils.TryParse(s, out T result) ? result : defaultValue;
        }

        /// <summary>
        ///     enum型に変換可能かを返します
        /// </summary>
        public static bool IsEnum<T>(string value) where T : struct
        {
            T result;
            return EnumUtils.TryParse(value, out result);
        }
    }
}
