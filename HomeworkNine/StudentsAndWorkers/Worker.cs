using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndWorkers.Contracts;

namespace StudentsAndWorkers
{
    class Worker : Human, IWorker
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Worker(string firstName, string lastName, decimal weekSalary) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
        }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : this(firstName, lastName, weekSalary)
        {
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get => this.weekSalary; set { if (value < 0) { throw new ArgumentOutOfRangeException(); } this.weekSalary = value; } }

        public decimal WorkHoursPerDay { get => this.workHoursPerDay; set { if (value < 0) { throw new ArgumentOutOfRangeException(); } this.workHoursPerDay = value; } }

        public decimal MoneyPerHour() => this.WeekSalary / this.WorkHoursPerDay;

        public override string ToString() => base.ToString() + $" Week salary: {WeekSalary} Work hours per day: {WorkHoursPerDay}";
    }
}