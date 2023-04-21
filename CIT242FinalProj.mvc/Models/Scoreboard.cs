using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIT242FinalProj.mvc.Data;
using System.ComponentModel.DataAnnotations;

namespace CIT242FinalProj.mvc.Models
{
       public class Scoreboard
    {
   [Key]
   public int ScoreID {get; set;}
    public string? User  { get; set; }
    public int Score { get; set; }

    }
    }
