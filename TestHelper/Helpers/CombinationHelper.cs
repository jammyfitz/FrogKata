using System.Collections.Generic;

namespace TestHelper.Helpers
{
    public class CombinationHelper
    {
        public static IEnumerable<IEnumerable<char>> GetCombinationsOfThreeCharsFromThreeCharacterSet()
        {
            return new List<List<char>>()
            {
                new List<char>() {'a', 'b', 'c'}
            };
        }

        public static IEnumerable<IEnumerable<char>> GetCombinationsOfThreeCharsFromThreeCharacterSetWithoutRepetition()
        {
            return new List<List<char>>()
            {
                new List<char>() {'a', 'b', 'c'}
            };
        }

        public static IEnumerable<IEnumerable<char>> GetCombinationsOfThreeCharsFromThreeCharacterSetWithRepetition()
        {
            return new List<List<char>>()
            {
                new List<char>() {'a', 'a', 'a'},
                new List<char>() {'a', 'a', 'b'},
                new List<char>() {'a', 'a', 'c'},
                new List<char>() {'a', 'b', 'b'},
                new List<char>() {'a', 'b', 'c'},
                new List<char>() {'a', 'c', 'c'},
                new List<char>() {'b', 'b', 'b'},
                new List<char>() {'b', 'b', 'c'},
                new List<char>() {'b', 'c', 'c'},
                new List<char>() {'c', 'c', 'c'}
            };
        }

        public static IEnumerable<IEnumerable<char>> GetCombinationsOfFourCharsWithRepetition()
        {
            return new List<List<char>>()
            {
                new List<char>() {'a', 'a', 'a'},
                new List<char>() {'a', 'a', 'b'},
                new List<char>() {'a', 'a', 'c'},
                new List<char>() {'a', 'a', 'd'},
                new List<char>() {'a', 'b', 'b'},
                new List<char>() {'a', 'b', 'c'},
                new List<char>() {'a', 'b', 'd'},
                new List<char>() {'a', 'c', 'c'},
                new List<char>() {'a', 'c', 'd'},
                new List<char>() {'a', 'd', 'd'},
                new List<char>() {'b', 'b', 'b'},
                new List<char>() {'b', 'b', 'c'},
                new List<char>() {'b', 'b', 'd'},
                new List<char>() {'b', 'c', 'c'},
                new List<char>() {'b', 'c', 'd'},
                new List<char>() {'b', 'd', 'd'},
                new List<char>() {'c', 'c', 'c'},
                new List<char>() {'c', 'c', 'd'},
                new List<char>() {'c', 'd', 'd'},
                new List<char>() {'d', 'd', 'd'}
            };
        }

        public static IEnumerable<IEnumerable<char>> GetCombinationsOfFourCharsWithoutRepetition()
        {
            return new List<List<char>>()
            {
                new List<char>() {'a', 'b', 'c'},
                new List<char>() {'a', 'b', 'd'},
                new List<char>() {'a', 'c', 'd'},
                new List<char>() {'b', 'c', 'd'}
            };
        }
    }
}
