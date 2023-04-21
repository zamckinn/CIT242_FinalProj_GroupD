using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIT242FinalProj.mvc.Data;

namespace CIT242FinalProj.mvc.Models
{
    public record HomeTaskModel
    (
        IList<Tasks> Tasks

    );
}