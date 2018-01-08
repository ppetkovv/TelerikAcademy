using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Contracts
{
    public interface IStudent : IPerson
    {
        byte UniqueNumber { get; }
    }
}
