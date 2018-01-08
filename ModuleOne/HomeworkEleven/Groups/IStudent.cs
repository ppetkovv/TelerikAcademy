using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groups
{
    interface IStudent
    {
        string FirstName { get; }
        string LastName { get; }
        int Age { get; }
        string FacultyNumber { get; }
        IList<decimal> Marks { get; }
        string GetMarksAsString { get; }
        int GroupNumber { get; }
    }
}