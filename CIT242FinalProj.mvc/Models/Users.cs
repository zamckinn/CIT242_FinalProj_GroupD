using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CIT242FinalProj.mvc.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Pass {get; set; }
        public string? UserName {get; set;}
        public string? Email {get; set;}
        public DateTime DoB {get; set;}
        public int Score {get; set;}
}

}