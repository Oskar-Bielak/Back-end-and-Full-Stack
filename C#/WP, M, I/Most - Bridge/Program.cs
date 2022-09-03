using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Bridge
{
    interface IGenerator<T>
    {
        List<T> Generate(int size);
    }

    class RandomDigitsGenerator : IGenerator<int>
    {
        public List<int> Generate(int size)
        {
            Random rnd = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < size; i++)
            {
                numbers.Add(rnd.Next(0, 10));
            }
            return numbers;
        }
    }

    class DigitsStringGenerator : IGenerator<int>
    {
        private readonly string digits;

        public DigitsStringGenerator(string digits)
        {
            this.digits = digits;
        }

        public List<int> Generate(int size)
        {
            if (digits.Length < size)
            {
                throw new ArgumentException("Generate Argument Exception");
            }

            return digits
                .ToCharArray()
                .Select(c => Convert.ToInt32(char.GetNumericValue(c)))
                .ToList();
        }
    }

    interface IConverter<T, U>
    {
        List<U> ConvertFrom(List<T> elements);
    }

    class DigitsToStringsConverter : IConverter<int, string>
    {
        private static string[] digits =
        {
            "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE"
        };

        public List<string> ConvertFrom(List<int> elements)
        {
            if (elements.Any(element => element < 0 || element > 9))
            {
                throw new ArgumentException("ConvertFrom Argument Exception");
            }
            return elements
                .Select(element => digits[element])
                .ToList();
        }
    }

    class DigitsToBinaryCodeConverter : IConverter<int, string>
    {
        public List<string> ConvertFrom(List<int> elements)
        {
            return elements
                .Select(element => Convert.ToString(element, 2))
                .ToList();
        }
    }

    abstract class DataProcessor<T, U>
    {
        protected IGenerator<T> generator;
        protected IConverter<T, U> converter;

        public abstract List<U> ProceessData(int size);
    }

    class DigitsToStringsProcessor : DataProcessor<int, string>
    {
        public DigitsToStringsProcessor(IGenerator<int> generator, IConverter<int, string> converter)
        {
            this.generator = generator;
            this.converter = converter;
        }

        public override List<string> ProceessData(int size)
        {
            List<int> data = generator.Generate(size);
            return converter.ConvertFrom(data);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------- 1 ----------------------------------");
            var randomDigitsGenerator = new RandomDigitsGenerator();
            var digitsToStringsConverter = new DigitsToStringsConverter();
            DigitsToStringsProcessor digitsToStringsProcessor1
                = new DigitsToStringsProcessor(randomDigitsGenerator, digitsToStringsConverter);
            digitsToStringsProcessor1.ProceessData(10).ForEach(Console.WriteLine);

            Console.WriteLine("----------------------- 2 ----------------------------------");
            var digitsStringGenerator = new DigitsStringGenerator("32891283123123");
            var digitsToBinaryCodeConverter = new DigitsToBinaryCodeConverter();
            DigitsToStringsProcessor digitsToStringsProcessor2
                = new DigitsToStringsProcessor(digitsStringGenerator, digitsToBinaryCodeConverter);
            digitsToStringsProcessor2.ProceessData(10).ForEach(Console.WriteLine);
        }
    }
}
