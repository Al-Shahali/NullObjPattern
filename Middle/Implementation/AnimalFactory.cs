using Domain.Interface;
using Middle.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle
{
    public class AnimalFactory
    {
        public static IAnimal GetAnimal(string name)
        {
            if (name == "duck")
                return new Duck();
            else if (name == "cat")
                return new Cat();
            else
                return NullAnimal.Instance;
        }
    }
}
