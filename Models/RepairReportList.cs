using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Printercounter2.Models
{
  public class RepairReportList
  {
    [Key]
    public int RepairReportListID { get; set; }
    public int PrinterID { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Announcement Date" )]
    public DateTime AnnouncementDate { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Date of Repairing" )]
    public DateTime RepairDate { get; set; }

    [Display(Name = "Reported error" )]
    public string ReportedError { get; set; }

    [Display(Name = "Detected error" )]
    public string DetectedError { get; set; }

    [Display(Name = "Description of work done" )]
    public string WorkDescription { get; set; }

    [Display(Name = "Used materials" )]
    public string UsedMaterials { get; set; }

    [Display(Name = "Administrator" )]
    public string Administrator { get; set; }

     public Printer Printer { get; set; }

  }
}