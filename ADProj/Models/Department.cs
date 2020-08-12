using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ADProj.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int DepartmentHeadId { get; set; }
        [Required]
        public int DepartmentRepresentativeId { get; set; }
        [Required]
        public string DeptRepId { get;  set;  }
        [Required]
        public string CollectionPointId {get;set;}

        public virtual CollectionPoint CollectionPoint { get;  set; }
        public virtual DepartmentRepresentative DepartmentRepresentative { get; set;  }
        public virtual DepartmentHead DepartmentHead { get; set; }
    }
}
