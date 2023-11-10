using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle.Implementation
{
    public class Cat : IAnimal
    {
        public string GetName()
        {
            return "Cat";
        }
        public string MakeSound()
        {
            return "Meow meow!";
        }
    }
}
