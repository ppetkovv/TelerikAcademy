using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Contracts
{
    interface ITeacher
    {
        Discipline[] Disciplines { get; set; }
    }
}
