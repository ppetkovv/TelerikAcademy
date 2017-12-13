using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndWorkers.Contracts;

namespace StudentsAndWorkers
{
    interface IStudent : IHuman
    {
        double Grade { get; set; }
    }
}
