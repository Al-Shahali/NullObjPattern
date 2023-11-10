using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle.Implementation
{
    public class Duck : IAnimal
    {
        public string GetName()
        {
            return "Duck";
        }
        public string MakeSound()
        {
            return "Quack quack!";
        }
    }
    
}
