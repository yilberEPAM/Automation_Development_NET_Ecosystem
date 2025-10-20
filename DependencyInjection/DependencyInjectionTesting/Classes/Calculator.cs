using DependencyInjectionTesting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTesting.Classes
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b) => a + b;
    }
}
