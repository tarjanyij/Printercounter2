
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Printercounter2.Models
{
    public class Counter
    {
        [Key]
        public int CounterID { get; set; }
        public int PrinterID { get; set; }
        [Display(Name = "Paper Counter" )]
        public int? PaperCounter { get; set; }
        
        [Display(Name = "Toner Level" )] 
        public int? TonerLevel { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date" )]
        public DateTime Date_Counter { get; set; }
        
        [Display(Name = "Daily Paper Consumption" )]
        public int? DailyPaperConsumption { get; set; }
        public Printer Printer { get; set; }

    }
    
}
