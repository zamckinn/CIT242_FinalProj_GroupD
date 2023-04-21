using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CIT242FinalProj.mvc.Models
{
    public class Tasks
    {
        [Key]
        public int TaskID { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}
        public bool Completed {get; set;}
        public int UserID { get; set; }
        
    }
}