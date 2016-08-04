using System;
using System.Collections.Generic;

namespace TestHelper.Helpers
{
    public static class PermutatorHelper
    {
        public static IEnumerable<IEnumerable<int>> GetPermutationsOfThreeInts()
        {
            return new List<List<int>>()
            {
                new List<int>() {1, 2, 3},
                new List<int>() {1, 3, 2},
                new List<int>() {2, 1, 3},
                new List<int>() {2, 3, 1},
                new List<int>() {3, 1, 2},
                new List<int>() {3, 2, 1}
            };
        }

        public static IEnumerable<IEnumerable<int>> GetPermutationsOfFourIntsFromThreeInts()
        {
            return new List<List<int>>()
            {
                new List<int>() {1, 2, 3},
                new List<int>() {1, 2, 4},
                new List<int>() {1, 3, 2},
                new List<int>() {1, 3, 4},
                new List<int>() {1, 4, 2},
                new List<int>() {1, 4, 3},

                new List<int>() {2, 1, 3},
                new List<int>() {2, 1, 4},
                new List<int>() {2, 3, 1},
                new List<int>() {2, 3, 4},
                new List<int>() {2, 4, 1},
                new List<int>() {2, 4, 3},

                new List<int>() {3, 1, 2},
                new List<int>() {3, 1, 4},
                new List<int>() {3, 2, 1},
                new List<int>() {3, 2, 4},
                new List<int>() {3, 4, 1},
                new List<int>() {3, 4, 2},

                new List<int>() {4, 1, 2},
                new List<int>() {4, 1, 3},
                new List<int>() {4, 2, 1},
                new List<int>() {4, 2, 3},
                new List<int>() {4, 3, 1},
                new List<int>() {4, 3, 2}
            };
        }

        public static IEnumerable<IEnumerable<int>> GetPermutationsOfFourIntsFromFourInts()
        {
            return new List<List<int>>()
            {
                new List<int>() {1, 2, 3, 4},
                new List<int>() {1, 2, 4, 3},
                new List<int>() {1, 3, 2, 4},
                new List<int>() {1, 3, 4, 2},
                new List<int>() {1, 4, 2, 3},
                new List<int>() {1, 4, 3, 2},

                new List<int>() {2, 1, 3, 4},
                new List<int>() {2, 1, 4, 3},
                new List<int>() {2, 3, 1, 4},
                new List<int>() {2, 3, 4, 1},
                new List<int>() {2, 4, 1, 3},
                new List<int>() {2, 4, 3, 1},

                new List<int>() {3, 1, 2, 4},
                new List<int>() {3, 1, 4, 2},
                new List<int>() {3, 2, 1, 4},
                new List<int>() {3, 2, 4, 1},
                new List<int>() {3, 4, 1, 2},
                new List<int>() {3, 4, 2, 1},

                new List<int>() {4, 1, 2, 3},
                new List<int>() {4, 1, 3, 2},
                new List<int>() {4, 2, 1, 3},
                new List<int>() {4, 2, 3, 1},
                new List<int>() {4, 3, 1, 2},
                new List<int>() {4, 3, 2, 1}
            };
        }

        public static IEnumerable<IEnumerable<char>> GetPermutationsOfThreeChars()
        {
            return new List<List<char>>()
            {
                new List<char>() {'a', 'b', 'c'},
                new List<char>() {'a', 'c', 'b'},
                new List<char>() {'b', 'a', 'c'},
                new List<char>() {'b', 'c', 'a'},
                new List<char>() {'c', 'a', 'b'},
                new List<char>() {'c', 'b', 'a'}
            };
        }

        public static IEnumerable<IEnumerable<char>> GetPermutationsWithoutRepetition()
        {
            return new List<List<char>>()
            {
                new List<char>() {'a', 'a', 'c'},
                new List<char>() {'a', 'c', 'a'},
                new List<char>() {'c', 'a', 'a'}
            };
        }

        public static IEnumerable<IEnumerable<char>> GetPermutationsWithRepetition()
        {
            return new List<List<char>>()
            {
                new List<char>() {'a', 'a', 'c'},
                new List<char>() {'a', 'c', 'a'},
                new List<char>() {'a', 'a', 'c'},
                new List<char>() {'a', 'c', 'a'},
                new List<char>() {'c', 'a', 'a'},
                new List<char>() {'c', 'a', 'a'}
            };
        }
    }
}
