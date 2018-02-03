using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace codingclub.Models
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description {get; set;}
        public DateTime StartDate {get; set;}
        public DateTime CompletionDate {get; set;}

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}