using MyCompany2.RelationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany2.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public ProjectType EProjectType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<UserAndProject> Users { get; set; }
        public ICollection<ProjectsAndSkill> Skills { get; set; }  

    }
}
