using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _01_Strategy
{
    public enum ConversionType
    {
        JSON, BASE64
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public interface IConverter<T>
    {
        string ConvertFrom(T element);
    }

    public class JsonConverter<T> : IConverter<T>
    {
        public string ConvertFrom(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("JsonConverter ConvertFrom ArgumentException");
            }

            return JsonConvert.SerializeObject(element, Formatting.Indented);
        }
    }

    public class Base64Converter<T> : IConverter<T>
    {
        public string ConvertFrom(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Base64Converter ConvertFrom Argument Exception");
            }

            return element.GetType().GetMembers()
                .Where(memberInfo => memberInfo.MemberType.Equals(MemberTypes.Property))
                .Select(memberInfo =>
                {
                    var value = element.GetType().GetProperty(memberInfo.Name).GetValue(element, null).ToString();
                    var bytes = System.Text.Encoding.UTF8.GetBytes(value);
                    return System.Convert.ToBase64String(bytes);
                }
                )
                .Aggregate((string1, string2) => string1 + "." + string2);
        }
    }

    // ZMIENIAMY STRATEGIE W RUNTIME
    public class DynamicConverter<T>
    {
        private IConverter<T> converter;

        public void SetConversionStrategy(ConversionType conversionType)
        {
            switch (conversionType)
            {
                case ConversionType.JSON:
                    converter = new JsonConverter<T>();
                    break;
                case ConversionType.BASE64:
                    converter = new Base64Converter<T>();
                    break;
            }
        }

        public List<string> ConvertFrom(List<T> elements) =>
            elements.Select(element => converter.ConvertFrom(element)).ToList();

    }

    // USTALAMY STRATEGIE PODCZAS KOMPILACJI
    public class StaticConverter<T, C> where C : IConverter<T>, new()
    {
        private IConverter<T> converter = new C();

        public List<string> Convert(List<T> elements) =>
            elements.Select(element => converter.ConvertFrom(element)).ToList();
    }

    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>()
            {
                new User() {Username = "user", Password = "1234"},
                new User() {Username = "admin", Password = "5678"},
                new User() {Username = "super", Password = "9012"}
            };

            var dynamicConverter = new DynamicConverter<User>();

            dynamicConverter.SetConversionStrategy(ConversionType.JSON);
            Console.WriteLine("\n-----------------------\nJSON DYNAMIC CONVERSION");
            dynamicConverter.ConvertFrom(users).ForEach(Console.WriteLine);

            dynamicConverter.SetConversionStrategy(ConversionType.BASE64);
            Console.WriteLine("\n-----------------------\nBASE64 DYNAMIC CONVERSION");
            dynamicConverter.ConvertFrom(users).ForEach(Console.WriteLine);


            var staticConverter1 = new StaticConverter<User, JsonConverter<User>>();
            Console.WriteLine("\n-----------------------\nJSON STATIC CONVERSION");
            staticConverter1.Convert(users).ForEach(Console.WriteLine);

            var staticConverter2 = new StaticConverter<User, Base64Converter<User>>();
            Console.WriteLine("\n-----------------------\nBASE64 STATIC CONVERSION");
            staticConverter2.Convert(users).ForEach(Console.WriteLine);
        }
    }
}
