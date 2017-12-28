using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStudents
{
    interface IStudent
    {
        string FirstName { get; }
        string LastName { get; }
        int Age { get; }
    }
}
