using System;
using System.Collections.Generic;
using Printercounter2.ViewModels;
using Printercounter2.Models;

namespace Printercounter2.ViewModels
{
    public class  CountersYearlyReportsViewModel 

    {
       public  List<MonthsValueViewModel> MonthsValue { get; set; }
        public List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> Years { get; set; }
        public List<string> Months { get; set; }
        public List<Printer> Printers { get; set; }
    }

     public class MonthsValueViewModel
     {
         public string Monts { get; set; }
         public string MontsValue { get; set; }
     }

}
