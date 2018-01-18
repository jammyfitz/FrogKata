using Facet.Combinatorics;
using System.Collections.Generic;
using System.Linq;

namespace FrogKata.Services
{
    public class FrogService
    {

        public int NumberOfWays(int inches)
        {
            var possibleMovements = new[] { 1, 2 };
            var numberOfWays = new List<IList<int>>();

            for(int i = 0; i < inches; i++)
            {
                var allVariations = new Variations<int>(possibleMovements, i + 1, GenerateOption.WithRepetition).AsEnumerable();
                IEnumerable<IList<int>> variationsToAdd = allVariations.Where(x => x.Sum() == inches);
                numberOfWays.AddRange(variationsToAdd); 
            }

            return numberOfWays.Count();
        }

    }
}