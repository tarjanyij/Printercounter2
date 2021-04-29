using System;
using System.Collections.Generic;
using Printercounter2.ViewModels;
using Printercounter2.Models;

namespace Printercounter2.ViewModels
{
    public class CountersMonthlyReportsViewModel

    {
        public List<Counter> Counters { get; set; }

        public List<Printer> Printers { get; set; }
    }
}
