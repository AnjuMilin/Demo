using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerminologyDemo.Models
{
  public class ProjectManagementUseraccount
  {

[Key]
 public int ProjectManagementUseraccountId {get; set;}
 [ForeignKey("ProjectManagement")] 
      public int ProjectId { get; set; }
[ForeignKey("UserAccount")]
      public int UserId { get; set; }
       
      
      
       public virtual UserAccount UserAccount { get; set;}
       public virtual ProjectManagement ProjectManagement { get; set;}
  }
}