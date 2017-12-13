using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Enums;

namespace AnimalHierarchy.Contracts
{
    interface IAnimal : ISound
    {
        string Name { get; set; }
        int Age { get; set; }
        Sex Sex { get; set; }
    }
}
