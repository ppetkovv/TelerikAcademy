using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers.Contracts
{
    interface IWorker:IHuman
    {
        decimal WeekSalary { get; set; }
        decimal WorkHoursPerDay { get; set; }
        decimal MoneyPerHour();
    }
}
