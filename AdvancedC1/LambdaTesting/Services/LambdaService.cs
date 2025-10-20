using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaTesting.Services
{
    public class LambdaService
    {
        public List<int> Transform(List<int> numbers, Func<int, int> transformer)
        {
            return numbers.Select(transformer).ToList();
        }

        public List<int> Filter(List<int> numbers, Predicate<int> predicate)
        {
            return numbers.Where(x => predicate(x)).ToList();
        }

        public int Aggregate(List<int> numbers, Func<int, int, int> aggregator)
        {
            return numbers.Aggregate(aggregator);
        }

        public void ForEach(List<int> numbers, Action<int> action)
        {
            foreach (var n in numbers)
                action(n);
        }
    }
}
