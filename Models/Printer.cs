using System;
using System.ComponentModel.DataAnnotations;

namespace Printercounter2.Models
{
    public class Printer
    {
        [Key]
        public int PrinterID { get; set; }

        [Display(Name = "IP address" )]
        public string PrinterIP { get; set; }

        [Display(Name = "Name" )]
        public string PrinterName { get; set; }
        
        [Display(Name = "Model type" )]
        public string PrinterModel { get; set; }
        
        [Display(Name = "Description" )]
        public string PrinterDescription { get; set; }
        
        [Display(Name = "Serial number" )]
        public string PrinterSN { get; set; }
        
        [Display(Name = "Inventory number" )]
        public string PrinterBarcode { get; set; }
        
        [Display(Name = "Location" )]
        public string PrinterLocation { get; set; }
        
        [Display(Name = "Toner name" )]
        public string PrinterTonerName { get; set; }
               
         public bool Active { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of installing" )]
        public DateTime InstallDate { get; set; }

        [Display(Name = "Machine identity number" )]
        public string MachineId { get; set; }

    }
}
