using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Contracts
{
    interface ISchool
    {
        SchoolClass[] Classes { get; set; }
        SchoolClass this[int index] { get; set; }
        void AddClass(SchoolClass newClass);
        bool RemoveClass(string classIdentifier);
    }
}
