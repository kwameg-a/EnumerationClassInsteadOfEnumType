using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EnumerationClassInsteadOfEnumType
{
    public abstract class Enumeration : IComparable
    {
        public int Value { get; }
        public string DisplayName { get; }

        protected Enumeration()
        {
        }

        protected Enumeration(int value, string displayName)
        {
            Value = value;
            DisplayName = displayName;
        }

        public override string ToString() => DisplayName;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            FieldInfo[] fieldInfos = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            return fieldInfos.Select(f => f.GetValue(null)).Cast<T>();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Enumeration enumeration)) return false;

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Value.Equals(enumeration.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode() => Value.GetHashCode();

        public static int AbsoluteDifference(Enumeration firstValue, Enumeration secondValue)
        {
            var absoluteDifference = Math.Abs(firstValue.Value - secondValue.Value);
            return absoluteDifference;
        }

        public static T FromValue<T>(int value) where T : Enumeration, new() =>
            Parse<T, int>(value, "value", item => item.Value == value);

        public static T FromDisplayName<T>(string displayName) where T : Enumeration, new() =>
            Parse<T, string>(displayName, "display name", item => item.DisplayName == displayName);

        private static T Parse<T, K>(K value, string description, Func<T, bool> predicate) where T : Enumeration, new()
        {
            var getItem = GetAll<T>().FirstOrDefault(predicate);

            if (getItem != null) return getItem;

            throw new ApplicationException($"'{value}' is not a valid {description} in {typeof(T)}");
        }

        public int CompareTo(object other) => Value.CompareTo(((Enumeration)other).Value);
    }
}
