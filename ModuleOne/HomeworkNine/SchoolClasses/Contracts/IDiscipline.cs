﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Contracts
{
    interface IDiscipline
    {
        string Name { get; set; }
        int NumberOfLectures { get; set; }
        int NumberOfExercises { get; set; }

    }
}
