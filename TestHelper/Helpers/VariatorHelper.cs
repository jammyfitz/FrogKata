using System.Collections.Generic;

namespace TestHelper.Helpers
{
    public class VariatorHelper
    {
        public static IEnumerable<IEnumerable<char>> GetVariationsOfThreeCharsFromThreeCharsWithoutRepetition()
        {
            return new List<List<char>>()
            {
                new List<char>() {'a', 'b', 'c'},
                new List<char>() {'a', 'c', 'b'},
                new List<char>() {'b', 'a', 'c'},
                new List<char>() {'c', 'a', 'b'},
                new List<char>() {'b', 'c', 'a'},
                new List<char>() {'c', 'b', 'a'}
            };
        }

        public static IEnumerable<IEnumerable<char>> GetVariationsOfThreeCharsFromThreeCharsWithRepetition()
        {
            return new List<List<char>>()
            {
                new List<char>() {'a', 'a', 'a'},
                new List<char>() {'a', 'a', 'b'},
                new List<char>() {'a', 'a', 'c'},
                new List<char>() {'a', 'b', 'a'},
                new List<char>() {'a', 'b', 'b'},
                new List<char>() {'a', 'b', 'c'},
                new List<char>() {'a', 'c', 'a'},
                new List<char>() {'a', 'c', 'b'},
                new List<char>() {'a', 'c', 'c'},

                new List<char>() {'b', 'a', 'a'},
                new List<char>() {'b', 'a', 'b'},
                new List<char>() {'b', 'a', 'c'},
                new List<char>() {'b', 'b', 'a'},
                new List<char>() {'b', 'b', 'b'},
                new List<char>() {'b', 'b', 'c'},
                new List<char>() {'b', 'c', 'a'},
                new List<char>() {'b', 'c', 'b'},
                new List<char>() {'b', 'c', 'c'},

                new List<char>() {'c', 'a', 'a'},
                new List<char>() {'c', 'a', 'b'},
                new List<char>() {'c', 'a', 'c'},
                new List<char>() {'c', 'b', 'a'},
                new List<char>() {'c', 'b', 'b'},
                new List<char>() {'c', 'b', 'c'},
                new List<char>() {'c', 'c', 'a'},
                new List<char>() {'c', 'c', 'b'},
                new List<char>() {'c', 'c', 'c'}
            };
        }

        public static IEnumerable<IEnumerable<char>> GetVariationsOfThreeCharsFromFourCharsWithoutRepetition()
        {
            return new List<List<char>>()
            {
                new List<char>() {'a', 'b', 'c'},
                new List<char>() {'a', 'b', 'd'},
                new List<char>() {'a', 'c', 'b'},
                new List<char>() {'a', 'd', 'b'},
                new List<char>() {'a', 'c', 'd'},
                new List<char>() {'a', 'd', 'c'},
                new List<char>() {'b', 'a', 'c'},
                new List<char>() {'b', 'a', 'd'},
                new List<char>() {'c', 'a', 'b'},
                new List<char>() {'d', 'a', 'b'},
                new List<char>() {'c', 'a', 'd'},
                new List<char>() {'d', 'a', 'c'},
                new List<char>() {'b', 'c', 'a'},
                new List<char>() {'b', 'd', 'a'},
                new List<char>() {'c', 'b', 'a'},
                new List<char>() {'d', 'b', 'a'},
                new List<char>() {'c', 'd', 'a'},
                new List<char>() {'d', 'c', 'a'},
                new List<char>() {'b', 'c', 'd'},
                new List<char>() {'b', 'd', 'c'},
                new List<char>() {'c', 'b', 'd'},
                new List<char>() {'d', 'b', 'c'},
                new List<char>() {'c', 'd', 'b'},
                new List<char>() {'d', 'c', 'b'}
            };
        }

        public static IEnumerable<IEnumerable<char>> GetVariationsOfThreeCharsFromFourCharsWithRepetition()
        {
            return new List<List<char>>()
            {
                new List<char>() {'a', 'a', 'a'},
                new List<char>() {'a', 'a', 'b'},
                new List<char>() {'a', 'a', 'c'},
                new List<char>() {'a', 'a', 'd'},
                new List<char>() {'a', 'b', 'a'},
                new List<char>() {'a', 'b', 'b'},
                new List<char>() {'a', 'b', 'c'},
                new List<char>() {'a', 'b', 'd'},
                new List<char>() {'a', 'c', 'a'},
                new List<char>() {'a', 'c', 'b'},
                new List<char>() {'a', 'c', 'c'},
                new List<char>() {'a', 'c', 'd'},
                new List<char>() {'a', 'd', 'a'},
                new List<char>() {'a', 'd', 'b'},
                new List<char>() {'a', 'd', 'c'},
                new List<char>() {'a', 'd', 'd'},

                new List<char>() {'b', 'a', 'a'},
                new List<char>() {'b', 'a', 'b'},
                new List<char>() {'b', 'a', 'c'},
                new List<char>() {'b', 'a', 'd'},
                new List<char>() {'b', 'b', 'a'},
                new List<char>() {'b', 'b', 'b'},
                new List<char>() {'b', 'b', 'c'},
                new List<char>() {'b', 'b', 'd'},
                new List<char>() {'b', 'c', 'a'},
                new List<char>() {'b', 'c', 'b'},
                new List<char>() {'b', 'c', 'c'},
                new List<char>() {'b', 'c', 'd'},
                new List<char>() {'b', 'd', 'a'},
                new List<char>() {'b', 'd', 'b'},
                new List<char>() {'b', 'd', 'c'},
                new List<char>() {'b', 'd', 'd'},

                new List<char>() {'c', 'a', 'a'},
                new List<char>() {'c', 'a', 'b'},
                new List<char>() {'c', 'a', 'c'},
                new List<char>() {'c', 'a', 'd'},
                new List<char>() {'c', 'b', 'a'},
                new List<char>() {'c', 'b', 'b'},
                new List<char>() {'c', 'b', 'c'},
                new List<char>() {'c', 'b', 'd'},
                new List<char>() {'c', 'c', 'a'},
                new List<char>() {'c', 'c', 'b'},
                new List<char>() {'c', 'c', 'c'},
                new List<char>() {'c', 'c', 'd'},
                new List<char>() {'c', 'd', 'a'},
                new List<char>() {'c', 'd', 'b'},
                new List<char>() {'c', 'd', 'c'},
                new List<char>() {'c', 'd', 'd'},

                new List<char>() {'d', 'a', 'a'},
                new List<char>() {'d', 'a', 'b'},
                new List<char>() {'d', 'a', 'c'},
                new List<char>() {'d', 'a', 'd'},
                new List<char>() {'d', 'b', 'a'},
                new List<char>() {'d', 'b', 'b'},
                new List<char>() {'d', 'b', 'c'},
                new List<char>() {'d', 'b', 'd'},
                new List<char>() {'d', 'c', 'a'},
                new List<char>() {'d', 'c', 'b'},
                new List<char>() {'d', 'c', 'c'},
                new List<char>() {'d', 'c', 'd'},
                new List<char>() {'d', 'd', 'a'},
                new List<char>() {'d', 'd', 'b'},
                new List<char>() {'d', 'd', 'c'},
                new List<char>() {'d', 'd', 'd'}
            };
        }

        public static IEnumerable<IEnumerable<int>> GetVariationsWithRepetitionForTwoNumbers()
        {
            return new List<List<int>>()
            {
                new List<int>() {1, 1},
                new List<int>() {1, 2},
                new List<int>() {2, 1},
                new List<int>() {2, 2}
            };
        }

        public static IEnumerable<IEnumerable<int>> GetVariationsWithRepetitionForThreeNumbers()
        {
            return new List<List<int>>()
            {
                new List<int>() {1, 1, 1},
                new List<int>() {1, 1, 2},
                new List<int>() {1, 1, 3},
                new List<int>() {1, 2, 1},
                new List<int>() {1, 2, 2},
                new List<int>() {1, 2, 3},
                new List<int>() {1, 3, 1},
                new List<int>() {1, 3, 2},
                new List<int>() {1, 3, 3},

                new List<int>() {2, 1, 1},
                new List<int>() {2, 1, 2},
                new List<int>() {2, 1, 3},
                new List<int>() {2, 2, 1},
                new List<int>() {2, 2, 2},
                new List<int>() {2, 2, 3},
                new List<int>() {2, 3, 1},
                new List<int>() {2, 3, 2},
                new List<int>() {2, 3, 3},
                         
                new List<int>() {3, 1, 1},
                new List<int>() {3, 1, 2},
                new List<int>() {3, 1, 3},
                new List<int>() {3, 2, 1},
                new List<int>() {3, 2, 2},
                new List<int>() {3, 2, 3},
                new List<int>() {3, 3, 1},
                new List<int>() {3, 3, 2},
                new List<int>() {3, 3, 3}
            };
        }
    }
}
