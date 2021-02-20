using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace TerminologyDemo.Models
{
  public class TerminologyAdd
  {
      [Key]

      public int TerminologyId { get; set; }
    
     
      public string TerminologyName { get; set; }
      public string TerminologyDesc { get ; set;}
  }
}
