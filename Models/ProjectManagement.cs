using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace TerminologyDemo.Models
{
  public class ProjectManagement
  {
      [Key]

      public int ProjectId { get; set; }
    
      [Required(ErrorMessage="Project Name  Required")]
      public string ProjectName { get; set; }
<<<<<<< HEAD
     
     
=======
>>>>>>> 74b5af5cb63ce0e9691d4e2f5d07e652b86827e2

     
        
  }

}